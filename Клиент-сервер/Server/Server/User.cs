using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class User
    {
        private Thread _userThread; // подключение потоков
        private string _userName; // имя юзера
        private bool AuthSuccess = false; // аунтификация для проверки
        public string Username//преобразования имени
        {
            get { return _userName; }
        }
        private Socket _userHandle;
        public User(Socket handle)//потоки
        {
            _userHandle = handle;
            _userThread = new Thread(listner);
            _userThread.IsBackground = true; // работает фоновый поток
            _userThread.Start();
        }
        private void listner()//подключение пользователя
        {
            try//защита от вылета в случае какой-либо проблемы
            {
                while (_userHandle.Connected)//попытка подключения
                {
                    byte[] buffer = new byte[2048];//выделение памяти под пользователя
                    int bytesReceive = _userHandle.Receive(buffer);//выделение места в параметре под код пользователя
                    handleCommand(Encoding.Unicode.GetString(buffer, 0, bytesReceive));//перевод в строковый тип
                }
            }
            catch { Server.EndUser(this); }//выход в cлучае неудачного подключения 
        }
        private bool setName(string Name)//имя 
        {
          
            _userName = Name; // прописываем имя 
            Server.NewUser(this);//сохранение имени
            AuthSuccess = true; // аунтифицируем
            return true;
        }
        private void handleCommand(string cmd)
        {
            try//защита от вылета в случае какой-либо проблемы
            {
                
                string[] commands = cmd.Split('#'); // каманда разделитель 
                int countCommands = commands.Length;
                for (int i = 0; i < countCommands; i++) // проход по списку команд
                {
                    string currentCommand = commands[i];
                    if (string.IsNullOrEmpty(currentCommand))//проверка на пустоту
                        continue;
                    /*Вход (или ввод имени) пользователя*/
                    if (!AuthSuccess)
                    {
                        if (currentCommand.Contains("setname"))//проверка на соответствие (выполнение команды по введнному в чат тексту (или нажатую кнопку с соотвествующим текстом))
                        {
                            if (setName(currentCommand.Split('|')[1]))//вывод удачного/неудачного ввода
                                Send("#setnamesuccess");
                            else
                                Send("#setnamefailed");
                        }
                        continue;
                    }
                    /*Прикрепление файла*/
                    if (currentCommand.Contains("yy"))//проверка на соответствие (выполнение команды по введнному в чат тексту (или нажатую кнопку с соотвествующим текстом))
                    {
                        string id = currentCommand.Split('|')[1];
                        Server.FileD file = Server.GetFileByID(int.Parse(id));//присвоение id файлу
                        if (file.ID == 0)//првоерка на удачное присвоение id
                        {
                            SendMessage("Ошибка при передаче файла...", "1");
                            continue;
                        }
                        Send(file.fileBuffer);//отправка файла в чат
                        Server.Files.Remove(file);
                    }
                    /*Отправка сообщения*/
                    if (currentCommand.Contains("message"))//проверка на соответствие (выполнение команды по введнному в чат тексту (или нажатую кнопку с соотвествующим текстом))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        Server.SendGlobalMessage($"[{_userName}]: {Arguments[1]}","Black");//вывод параметров пользователя при отправке

                        continue;
                    }//sENDfile
                    //...
                    /*Выход из программы*/
                    if (currentCommand.Contains("endsession"))//проверка на соответствие (выполнение команды по введнному в чат тексту (или нажатую кнопку с соотвествующим текстом))
                    {
                        Server.EndUser(this);//выключение программы в случае соответствия 
                        return;
                    }
                    /*Отправка файла конкретному пользователю*/
                    if(currentCommand.Contains("sendfileto"))//проверка на соответствие (выполнение команды по введнному в чат тексту (или нажатую кнопку с соотвествующим текстом))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        string TargetName = Arguments[1];
                        int FileSize = int.Parse(Arguments[2]);
                        string FileName = Arguments[3];
                        byte[] fileBuffer = new byte[FileSize];
                        _userHandle.Receive(fileBuffer);
                        User targetUser = Server.GetUser(TargetName);//присвоение (из системы) имени выбранного пользователя
                        if(targetUser == null)//проверка на выбранного пользователя
                        {
                            SendMessage($"Пользователь {FileName} не найден!","Black");
                            continue;
                        }
                        /*Работа с параметрами для передачи файла*/
                        Server.FileD newFile = new Server.FileD()
                        {
                            ID = Server.Files.Count+1,
                            FileName = FileName,
                            From = Username,
                            fileBuffer = fileBuffer,
                            FileSize = fileBuffer.Length
                        };
                        Server.Files.Add(newFile);//сохранение прикрепленного файла для отправки
                        targetUser.SendFile(newFile,targetUser);//отправка файла выбранному пользователю
                    }
                    /*Выход в приватный чат с конкретным пользователем*/
                    if(currentCommand.Contains("private"))//проверка на соответствие (выполнение команды по введнному в чат тексту (или нажатую кнопку с соотвествующим текстом))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        string TargetName = Arguments[1];
                        string Content = Arguments[2];
                        User targetUser = Server.GetUser(TargetName);//присвоение (из системы) имени выбранного пользователя
                        if (targetUser == null)//проверка на выбранного пользователя
                        {
                            SendMessage($"Пользователь {TargetName} не найден!","Red");
                            continue;
                        }
                        SendMessage($"-[Отправлено][{TargetName}]: {Content}","Black");
                        targetUser.SendMessage($"-[Получено][{Username}]: {Content}","Black");//отправка сообщения выбранному пользователю
                        continue;
                    }

                }

            }
            catch (Exception exp) { Console.WriteLine("Error with handleCommand: " + exp.Message); }//в случае проблемы вывод ошибки и ее текста
        }
        public void SendFile(Server.FileD fd, User To)//отображение файла в чате
        {
            byte[] answerBuffer = new byte[48];//выделение памяти под вывод
            Console.WriteLine($"Sending {fd.FileName} from {fd.From} to {To.Username}");//вывод с данными параметрами
            To.Send($"#gfile|{fd.FileName}|{fd.From}|{fd.fileBuffer.Length}|{fd.ID}");
        }
        public void SendMessage(string content,string clr)//отправка сообщения
        {
            Send($"#msg|{content}|{clr}");//вывод сообщения (с языковыми параметрами)
        }
        public void Send(byte[] buffer)//преобразование сообщения в код
        {
            try//защита от вылета в случае какой-либо проблемы
            {
                _userHandle.Send(buffer);
            }
            catch { }
        }
        public void Send(string Buffer)//проеборазование кода сообщения в текст
        {
            try//защита от вылета в случае какой-либо проблемы
            {
                _userHandle.Send(Encoding.Unicode.GetBytes(Buffer));
            }
            catch { }
        }
        public void End()//закрытие программы
        {
            try//защита от вылета в случае какой-либо проблемы
            {
                _userHandle.Close();
            }
            catch { }

        }
    }
}

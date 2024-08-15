using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;
using System.Net.Mail;
using MySqlX.XDevAPI.Relational;


namespace Client
{
    public partial class ChatForm : Form
    {
       
           
        private delegate void ChatEvent(string content,string clr);
        private Socket _serverSocket; // сокеты
        private Thread listenThread; // поток 
        private string _host = "192.168.0.108"; // IP
        private int _port = 9999; // порт
        
        //  private ChatEvent _addMessage; // добовление сообщений


        public ChatForm()
        {
            InitializeComponent();

   
            userMenu = new ContextMenuStrip();
            ToolStripMenuItem PrivateMessageItem = new ToolStripMenuItem();
            PrivateMessageItem.Text = "Личное сообщение";
            PrivateMessageItem.Click += delegate 
            {
                //if (userList.SelectedItems.Count > 0)
                //{
                //    messageData.Text = $"\"{userList.SelectedItem} ";
                //}
            };
            userMenu.Items.Add(PrivateMessageItem);
            ToolStripMenuItem SendFileItem = new ToolStripMenuItem()
           
            {
                Text = "Отправить файл"
            };
          
            SendFileItem.Click += delegate 
            {
           

                OpenFileDialog ofp = new OpenFileDialog();
                ofp.ShowDialog();
                if (!File.Exists(ofp.FileName))
                {
                    MessageBox.Show($"Файл {ofp.FileName} не найден!");
                    return;
                }
                FileInfo fi = new FileInfo(ofp.FileName);
                
               

                byte[] buffer = File.ReadAllBytes(ofp.FileName);
               // Send($"#sendfileto|{TegList.SelectedItem}|{buffer.Length}|{fi.Name}|{textLabel}");//выбрали имя пользователя размер буфера и имя от кого отправка 
                Send(buffer); // отпрака самого буфера


            };
            userMenu.Items.Add(SendFileItem);
           
        }


     




        ///////////////////////////////////////////
     

        private void ChatForm_Load(object sender, EventArgs e) // подключение пользователя с сервером с помощью потоков 
        {
           

            IPAddress temp = IPAddress.Parse(_host); // находим хост
            _serverSocket = new Socket(temp.AddressFamily,SocketType.Stream,ProtocolType.Tcp); // отправляем хост на сервер
            _serverSocket.Connect(new IPEndPoint(temp, _port));



            if (_serverSocket.Connected) // подключаемся к серверу
            {

                listenThread = new Thread(listner);
                listenThread.IsBackground = true;
                listenThread.Start();
            }




            string LoginUser = DataBank.UserName;



            if (string.IsNullOrEmpty(LoginUser)) // отправили на сервер, что пользователь с именем подключился
                return;
            Send($"#setname|{LoginUser}");



            MySqlDataReader dataReader = null;
            DataBase DB = new DataBase(); // выделяем память для объекта

            MySqlCommand command = null;


            /////////////////////////////////////////// 
            // Заполнили ListView (ListTag) данными из БД 

            DB.openConnection();
            try
            {

                 command = new MySqlCommand("SELECT `name_tag` FROM `tag`", DB.getConnection()); // создаем команду: ищем пользователя в базе данных все теги

                dataReader = command.ExecuteReader();
               
                
                ListViewItem List_Tag_Name = null;


                while (dataReader.Read())
                {
                    List_Tag_Name = new ListViewItem(new string[] { dataReader["name_tag"].ToString() }); // заполнили лист всех тегов данными из бд
                    ListTag.Items.Add(List_Tag_Name);
                    

                    DataBank.List_Tag = ListTag;
                }
                ListTag.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader!= null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }


            DB.closeConnection(); // Закрыли ДБ
            /////////////////////////////////////////// 



            /////////////////////////////////////////// 
            // Заполнили Комбобокс (NameTag) данными из БД 


            DB.openConnection(); // Открыли ДБ

            try
            {
                 command = new MySqlCommand("SELECT name_tag FROM tag", DB.getConnection()); // находим файл в бд по названию тега


                using (MySqlDataReader reader = command.ExecuteReader()) // считываем данные из БД
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("name_tag")))
                        {
                            NameTag.Items.Add(reader["name_tag"].ToString()); // заполняем текстбокс

                            DataBank.CheckTagName = NameTag;
                        }
                    }

                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка SQL при заполнении {NameTag}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при заполнении {NameTag}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ///////////////////////////////////////////




            string Name_User = DataBank.UserName;

            DB.openConnection(); // Открыли ДБ

           

            dataReader = null;

            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();


            /////////////////////////////////////////// 
            // Заполнили ListView (ListTagSub) данными из БД 

            try
            {

                command = new MySqlCommand("SELECT `name_tag` FROM `tag` WHERE `id_tag` IN (SELECT `id_tag` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub)", DB.getConnection()); // ищем все сущуствование теги, на которые подписаны 
                command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    



                adapter1.SelectCommand = command; // выполняем команду выше
                adapter1.Fill(table1); // заполняем вспомогательную таблицу получившимися данными

                if (table1.Rows.Count > 0) // проверяем если ли запись в таблице
                {

                    dataReader = command.ExecuteReader();


                    ListViewItem List_Tag_Name_Sub = null;


                    while (dataReader.Read())
                    {
                        List_Tag_Name_Sub = new ListViewItem(new string[] { dataReader["name_tag"].ToString() }); // заполнили лист всех тегов данными из бд
                        ListTagSub.Items.Add(List_Tag_Name_Sub);

                    }
                    ListTag.Sort();

                    DB.closeConnection(); // Закрыли ДБ
                }


                else
                {
                    DB.closeConnection(); // Закрыли ДБ
                    return;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }


            DB.closeConnection(); // Закрыли ДБ

            /////////////////////////////////////////// 


            /////////////////////////////////////////// 
            // Заполнили Комбобокс (NameTag) данными из БД 


            DB.openConnection(); // Открыли ДБ

            try
            {
                command = new MySqlCommand("SELECT `name_tag` FROM `tag` WHERE `id_tag` IN (SELECT `id_tag` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub)", DB.getConnection()); // находим файл в бд по названию тега
                command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    


                using (MySqlDataReader reader = command.ExecuteReader()) // считываем данные из БД
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("name_tag")))
                        {
                            NameTagSub.Items.Add(reader["name_tag"].ToString()); // заполняем текстбокс
                            DataBank.CheckTagName = NameTag;
                        }
                    }

                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка SQL при заполнении {NameTagSub}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при заполнении {NameTagSub}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ///////////////////////////////////////////



        }

        ///////////////////////////////////////////











        ///////////////////////////////////////////
        private void Sub_Tag_Click(object sender, EventArgs e)
        {

            string Name_User = DataBank.UserName;


            if (string.IsNullOrEmpty(NameTag.Text)) // проверяем поле с путем файла на пустату
            {
                MessageBox.Show("Название тега не выбрано. Напишите или выберете тег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            DataBase DB = new DataBase(); // выделяем память для объекта

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();



            try 
            {

                DB.openConnection(); // Открыли ДБ

                MySqlCommand command = new MySqlCommand("SELECT `id_tag` FROM `tag` WHERE `name_tag` = @name_tag", DB.getConnection()); // ищем id тега в бд по выбранному Комбобокс
                command.Parameters.Add("@name_tag", MySqlDbType.VarChar).Value = NameTag.Text; // заглушка для логина

                adapter.SelectCommand = command; // выполняем команду выше
                adapter.Fill(table); // заполняем вспомогательную таблицу получившимися данными

                if (table.Rows.Count > 0) // проверяем если ли запись в таблице
                {
                    string Id_tag = Convert.ToString(table.Rows[0]["id_tag"]); // присваиваем в переменную найденный id
                    DataBank.ID_Tag = Id_tag;
                }


                DB.closeConnection(); // Закрыли ДБ


                try
                {
                    string Id_tag = DataBank.ID_Tag;

                    DB.openConnection(); // Открыли ДБ

                    command = new MySqlCommand("SELECT `id_tag_sub` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub AND`id_tag` = @id_tag", DB.getConnection()); // проверяем сущуствование такой подписки
                    command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    
                    command.Parameters.Add("@id_tag", MySqlDbType.VarChar).Value = DataBank.ID_Tag; // заглушка для логина

                    adapter1.SelectCommand = command; // выполняем команду выше
                    adapter1.Fill(table1); // заполняем вспомогательную таблицу получившимися данными

                    if (table1.Rows.Count != 0) // проверяем если ли запись в таблице
                    {
                        MessageBox.Show("Вы уже подписаны на данный тег", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
                        return;

                        
                    }
                    else
                    {
                        command = new MySqlCommand("INSERT INTO `tag_sub` (`name_user_sub`, `id_tag`) VALUES (@name_user_sub, @id_tag)", DB.getConnection()); // выполняем команду: добовляем в БД нового пользователя по параметрам
                        command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя           
                        command.Parameters.Add("@id_tag", MySqlDbType.VarChar).Value = Id_tag; // заглушка id на тег

                       

                        DB.closeConnection(); // Закрыли ДБ
                    }



                    DB.openConnection(); // Открыли ДБ

                    if (command.ExecuteNonQuery() != 0)
                    {

                        MySqlDataReader dataReader = null;


                        try
                        {
                            /////////////////////////////////////////// 
                            // Обновили ListTagSub данными из БД 
                            command = new MySqlCommand("SELECT `name_tag` FROM `tag` WHERE `id_tag` IN (SELECT `id_tag` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub)", DB.getConnection()); // ищем все сущуствование теги, на которые подписаны 
                            command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    



                            adapter1.SelectCommand = command; // выполняем команду выше
                            adapter1.Fill(table1); // заполняем вспомогательную таблицу получившимися данными

                            if (table1.Rows.Count > 0) // проверяем если ли запись в таблице
                            {

                                ListTagSub.Clear();

                                dataReader = command.ExecuteReader();


                                ListViewItem List_Tag_Name_Sub = null;


                                while (dataReader.Read())
                                {
                                    List_Tag_Name_Sub = new ListViewItem(new string[] { dataReader["name_tag"].ToString() }); // заполнили лист всех тегов данными из бд
                                    ListTagSub.Items.Add(List_Tag_Name_Sub);

                                }
                                ListTag.Sort();

                                DB.closeConnection(); // Закрыли ДБ
                            }


                            else
                            {
                                DB.closeConnection(); // Закрыли ДБ
                                return;


                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (dataReader != null && !dataReader.IsClosed)
                            {
                                dataReader.Close();
                            }
                        }


                        DB.closeConnection(); // Закрыли ДБ
                       /////////////////////////////////////////// 
                    





                        /////////////////////////////////////////// 
                        // Обновили Комбобокс (NameTagSub) данными из БД 


                        DB.openConnection(); // Открыли ДБ

                        try
                        {
                            command = new MySqlCommand("SELECT `name_tag` FROM `tag` WHERE `id_tag` IN (SELECT `id_tag` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub)", DB.getConnection()); // находим файл в бд по названию тега
                            command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    

                            NameTagSub.Items.Clear();



                            using (MySqlDataReader reader = command.ExecuteReader()) // считываем данные из БД
                            {

                                while (reader.Read())
                                {

                                    if (!reader.IsDBNull(reader.GetOrdinal("name_tag")))
                                    {
                                        NameTagSub.Items.Add(reader["name_tag"].ToString()); // заполняем текстбокс
                                    }
                                }

                            }



                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Ошибка SQL при заполнении {NameTagSub}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при заполнении {NameTagSub}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        ///////////////////////////////////////////




                    }

                }
                catch (SmtpException ex) //уведомление об ошибке
                {
                    MessageBox.Show($"Тег не найден в базе данных ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new ApplicationException
                      ("SmtpException has occured: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw ex;
                }



            }
            catch (SmtpException ex) //уведомление об ошибке
            {
                  throw new ApplicationException
                  ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }















        /////////////////////////////////////////

        private void Unsub_Tag_Click(object sender, EventArgs e)
        {
            string Name_User = DataBank.UserName;


            if (string.IsNullOrEmpty(NameTagSub.Text)) // проверяем поле с путем файла на пустату
            {
                MessageBox.Show("Название тега не выбрано. Напишите или выберете тег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            DataBase DB = new DataBase(); // выделяем память для объекта

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();



            try
            {

                DB.openConnection(); // Открыли ДБ

                MySqlCommand command = new MySqlCommand("SELECT `id_tag` FROM `tag` WHERE `name_tag` = @name_tag", DB.getConnection()); // ищем id тега в бд по выбранному Комбобокс
                command.Parameters.Add("@name_tag", MySqlDbType.VarChar).Value = NameTagSub.Text; // заглушка для логина

                adapter.SelectCommand = command; // выполняем команду выше
                adapter.Fill(table); // заполняем вспомогательную таблицу получившимися данными

                if (table.Rows.Count > 0) // проверяем если ли запись в таблице
                {
                    string Id_tag = Convert.ToString(table.Rows[0]["id_tag"]); // присваиваем в переменную найденный id
                    DataBank.ID_Tag = Id_tag;
                }


                DB.closeConnection(); // Закрыли ДБ



                try
                {
                    string Id_tag = DataBank.ID_Tag;



                    DB.openConnection(); // Открыли ДБ

                    command = new MySqlCommand("SELECT `id_tag_sub` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub AND`id_tag` = @id_tag", DB.getConnection()); // проверяем сущуствование такой подписки
                    command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    
                    command.Parameters.Add("@id_tag", MySqlDbType.VarChar).Value = DataBank.ID_Tag; // заглушка для логина

                    adapter1.SelectCommand = command; // выполняем команду выше
                    adapter1.Fill(table1); // заполняем вспомогательную таблицу получившимися данными

                    if (table1.Rows.Count != 0) // проверяем если ли запись в таблице
                    {
                        command = new MySqlCommand("DELETE FROM `tag_sub` WHERE `id_tag` = @id_tag", DB.getConnection()); // выполняем команду: добовляем в БД нового пользователя по параметрам
                        command.Parameters.Add("@id_tag", MySqlDbType.VarChar).Value = Id_tag; // заглушка id на тег

                        DB.closeConnection(); // Закрыли ДБ

                    }
                    else
                    {
                        MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }



                    DB.openConnection(); // Открыли ДБ

                    if (command.ExecuteNonQuery() != 0)
                    {

                        MySqlDataReader dataReader = null;


                        try
                        {
                            /////////////////////////////////////////// 
                            // Обновили ListView (ListTagSub) данными из БД 


                            command = new MySqlCommand("SELECT `name_tag` FROM `tag` WHERE `id_tag` IN (SELECT `id_tag` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub)", DB.getConnection()); // ищем все сущуствование теги, на которые подписаны 
                            command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    



                            adapter1.SelectCommand = command; // выполняем команду выше
                            adapter1.Fill(table1); // заполняем вспомогательную таблицу получившимися данными

                            if (table1.Rows.Count > 0) // проверяем если ли запись в таблице
                            {

                                dataReader = command.ExecuteReader();


                                ListViewItem List_Tag_Name_Sub = null;
                                ListTagSub.Items.Clear();

                                while (dataReader.Read())
                                {
                                    List_Tag_Name_Sub = new ListViewItem(new string[] { dataReader["name_tag"].ToString() }); // заполнили лист всех тегов данными из бд
                                    ListTagSub.Items.Add(List_Tag_Name_Sub);

                                }
                                ListTag.Sort();

                                DB.closeConnection(); // Закрыли ДБ
                            }


                            else
                            {
                                DB.closeConnection(); // Закрыли ДБ
                                return;


                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (dataReader != null && !dataReader.IsClosed)
                            {
                                dataReader.Close();
                            }
                        }


                        DB.closeConnection(); // Закрыли ДБ





                        /////////////////////////////////////////// 
                        // Обновили Комбобокс (NameTagSub) данными из БД 


                        DB.openConnection(); // Открыли ДБ

                        try
                        {
                            command = new MySqlCommand("SELECT `name_tag` FROM `tag` WHERE `id_tag` IN (SELECT `id_tag` FROM `tag_sub` WHERE `name_user_sub` = @name_user_sub)", DB.getConnection()); // находим файл в бд по названию тега
                            command.Parameters.Add("@name_user_sub", MySqlDbType.VarChar).Value = Name_User; // заглушка для подписавшегося на тег пользователя    

                            NameTagSub.Items.Clear();



                            using (MySqlDataReader reader = command.ExecuteReader()) // считываем данные из БД
                            {

                                while (reader.Read())
                                {

                                    if (!reader.IsDBNull(reader.GetOrdinal("name_tag")))
                                    {
                                        NameTagSub.Items.Add(reader["name_tag"].ToString()); // заполняем текстбокс
                                    }
                                }

                            }



                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Ошибка SQL при заполнении {NameTagSub}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при заполнении {NameTagSub}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        ///////////////////////////////////////////





                    }

                }
                catch (SmtpException ex) //уведомление об ошибке
                {
                    MessageBox.Show($"Файл не найден в базе данных ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new ApplicationException
                      ("SmtpException has occured: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw ex;
                }



            }
            catch (SmtpException ex) //уведомление об ошибке
            {
                throw new ApplicationException
                ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        private Color getColor(string text)
        {

            if (Color.Red.Name.Contains(text))
                return Color.Red;
            return Color.Black;

        }








        public void Send(byte[] buffer) // отправка
        {
            try
            {
                _serverSocket.Send(buffer);
            }
            catch { }
        }




        public void Send(string Buffer)
        {
            try
            {
                _serverSocket.Send(Encoding.Unicode.GetBytes(Buffer));
            }
            catch { }
        }



        public void handleCommand(string cmd)
        {
            
                string[] commands = cmd.Split('#');
                int countCommands = commands.Length;
                for (int i = 0; i < countCommands; i++)
                {
                try
                {
                    string currentCommand = commands[i];
                    if (string.IsNullOrEmpty(currentCommand))
                        continue;
                    if (currentCommand.Contains("setnamesuccess"))
                    {
                        
                        
                      



                        //    messageData.Enabled = true;
                        //    userList.Enabled = true;
                        //    LoginUserAccount.Enabled = false;
                           
                        //});
                        //continue;
                    }
         
                  
                    if(currentCommand.Contains("gfile")) // файлы 
                    {
                        string[] Arguments = currentCommand.Split('|');
                        string fileName = Arguments[1]; // название 
                        string FromName = Arguments[3]; // от кого 
                        string FileSize = Arguments[4]; // размер 
                        string idFile = Arguments[5]; // ID 
                        string textLabel = Arguments[2]; // Label
                       
                        DialogResult Result = MessageBox.Show($"Вы хотите принять файл {fileName} размером {FileSize} от {FromName} c тегом {textLabel}","Файл",MessageBoxButtons.YesNo); // уведоление при отправке файла
                        if (Result == DialogResult.Yes) // если нажали да то нам отправится фаил
                        {
                            
                            Thread.Sleep(1000); // остановка потока 
                            Send("#yy|"+idFile); // отсылка файла 
                            byte[] fileBuffer = new byte[int.Parse(FileSize)]; // буфер
                            _serverSocket.Receive(fileBuffer);
                            File.WriteAllBytes(fileName, fileBuffer);
                            MessageBox.Show($"Файл {fileName} принят."); // принят фаил 
                        }
                        else
                            Send("nn");
                        continue;
                    }

                }
                catch (Exception exp) { Console.WriteLine("Error with handleCommand: " + exp.Message); } // если какой-то из пунктов не сработол, выведет сообщение об ошибке

            }

            
        }



        public void listner() // если отключим сервер , то все юзеры сразу отключатся
        {
            try
            {
                while (_serverSocket.Connected)
                {
                    byte[] buffer = new byte[2048];
                    int bytesReceive = _serverSocket.Receive(buffer);
                    handleCommand(Encoding.Unicode.GetString(buffer, 0, bytesReceive));
                }
            }
            catch
            {
                MessageBox.Show("Связь с сервером прервана");
                Application.Exit();
            }
        }

         

        /////////////////////////////////////////
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show( // создаем диалоговое окно 
            "Вы действительно хотите выйти из программы?", // текст уведомления 
            "Завершение программы",                  // заголовок уведомления
            MessageBoxButtons.YesNo,                 // даем выбрать да / нет
            MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)         // при нажатии "ДА" приложение выключится
            {
               if (_serverSocket.Connected)
                    Send("#endsession");
               Application.Exit();

            }
           
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e) // при наведении на кнопку креста красим ее в красный
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e) // при убирании от кнопки креста красим ее в черный
        {
            CloseButton.ForeColor = Color.Black;
        }
        ///////////////////////////////////////////




        ///////////////////////////////////////////////
      
        // Загрузить файл в БД
        private void UploadFile_Click(object sender, EventArgs e)
        {
            
            UpLoadFileForm UpLoadFile = new UpLoadFileForm(); // выделяем память
            UpLoadFile.Show(); // открываем новую форму авторизации
        }


        // Скачать файл из БД
        private void DownloadFile_Click(object sender, EventArgs e)
        {

            DownLoadFileForm DownLoadFile = new DownLoadFileForm(); // выделяем память
            DownLoadFile.Show(); // открываем новую форму авторизации
        }



        //перемещение формы по экрану
        Point lastPoint; // переменная для ее переноса виндус формы , после нажатого курсора пользователем на виндус форму

        private void ChatForm_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void ChatForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

      
    }
}

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;


namespace Client
{
    public partial class ChatForm : Form
    {
        private delegate void ChatEvent(string content,string clr);
        private ChatEvent _addMessage; // добовление сообщений 
        private Socket _serverSocket; // сокеты
        private Thread listenThread; // поток 
        private string _host = "192.168.0.101"; // IP
        private int _port = 9933; // порт
        public ChatForm()
        {
            InitializeComponent();
            _addMessage = new ChatEvent(AddMessage); // добовление сообщения 
            userMenu = new ContextMenuStrip();
            ToolStripMenuItem PrivateMessageItem = new ToolStripMenuItem();
            PrivateMessageItem.Text = "Личное сообщение";
            PrivateMessageItem.Click += delegate 
            {
                if (userList.SelectedItems.Count > 0)
                {
                    messageData.Text = $"\"{userList.SelectedItem} ";
                }
            };
            userMenu.Items.Add(PrivateMessageItem);
            ToolStripMenuItem SendFileItem = new ToolStripMenuItem()
            {
                Text = "Отправить файл"
            };
            SendFileItem.Click += delegate 
            {
                if (userList.SelectedItems.Count == 0)
                {
                    return;
                }
                OpenFileDialog ofp = new OpenFileDialog();
                ofp.ShowDialog();
                if (!File.Exists(ofp.FileName))
                {
                    MessageBox.Show($"Файл {ofp.FileName} не найден!");
                    return;
                }
                FileInfo fi = new FileInfo(ofp.FileName);
                byte[] buffer = File.ReadAllBytes(ofp.FileName);
                Send($"#sendfileto|{userList.SelectedItem}|{buffer.Length}|{fi.Name}");//выбрали имя пользователя размер буфера и имя от кого отправка 
                Send(buffer); // отпрака самого буфера


            };
            userMenu.Items.Add(SendFileItem);
            userList.ContextMenuStrip = userMenu;

        }

        private void AddMessage(string Content,string Color = "Black") // передача сообщений 
        {
            if(InvokeRequired)
            {
                Invoke(_addMessage,Content,Color); // 
                return;
            }
            chatBox.SelectionStart = chatBox.TextLength;
            chatBox.SelectionLength = Content.Length;
            chatBox.SelectionColor = getColor(Color);
            chatBox.AppendText(Content + Environment.NewLine);
        }

        private Color getColor(string text)
        {
           
            if (Color.Red.Name.Contains(text))
                return Color.Red;
            return Color.Black;

        }

        private void ChatForm_Load(object sender, EventArgs e) // подключение юзера с сервером с помощью потоков 
        {
            IPAddress temp = IPAddress.Parse(_host);
            _serverSocket = new Socket(temp.AddressFamily,SocketType.Stream,ProtocolType.Tcp);
            _serverSocket.Connect(new IPEndPoint(temp, _port));
            if (_serverSocket.Connected)
            {
                connection.Enabled = true;
                nicknameData.Enabled = true;
                AddMessage("Связь с сервером установлена.");
                listenThread = new Thread(listner);
                listenThread.IsBackground = true;
                listenThread.Start();
                
            }
            else
                AddMessage("Связь с сервером не установлена.");
            
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
                        
                        
                        //Из-за того что программа пыталась получить доступ к контролам из другого потока вылетал эксепшен и поля не разблокировались

                        Invoke((MethodInvoker)delegate // переход из одного потока в другой
                        {
                            AddMessage($"Добро пожаловать, {nicknameData.Text}");
                            Text_for_chat.Text = nicknameData.Text;
                            chatBox.Enabled = true;
                            messageData.Enabled = true;
                            userList.Enabled = true;
                            nicknameData.Enabled = false;
                            connection.Enabled = false;
                        });
                        continue;
                    }
                    if(currentCommand.Contains("setnamefailed")) // проверка на неверный ник
                    {
                        AddMessage("Неверный ник!");
                        continue;
                    }
                    if(currentCommand.Contains("msg")) // сообщения
                    {
                        string[] Arguments = currentCommand.Split('|');
                        AddMessage(Arguments[1], Arguments[2]);
                        continue;
                    }

                    if(currentCommand.Contains("userlist")) // список юзеров 
                    {
                        string[] Users = currentCommand.Split('|')[1].Split(','); // запись 
                        int countUsers = Users.Length; // счет 
                        userList.Invoke((MethodInvoker)delegate { userList.Items.Clear(); }); // проход потоков
                        for(int j = 0;j < countUsers;j++)
                        {
                            userList.Invoke((MethodInvoker)delegate { userList.Items.Add(Users[j]) ; });
                        }
                        continue;

                    }
                    if(currentCommand.Contains("gfile")) // файлы 
                    {
                        string[] Arguments = currentCommand.Split('|');
                        string fileName = Arguments[1]; // название 
                        string FromName = Arguments[2]; // от кого 
                        string FileSize = Arguments[3]; // размер 
                        string idFile = Arguments[4]; // ID 
                        DialogResult Result = MessageBox.Show($"Вы хотите принять файл {fileName} размером {FileSize} от {FromName}","Файл",MessageBoxButtons.YesNo); // уведоление при отправке файла
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

        private void enterChat_Click(object sender, EventArgs e) // ввод имени 
        {
            string nickName = nicknameData.Text;
            if (string.IsNullOrEmpty(nickName))
                return;
            Send($"#setname|{nickName}");
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e) // окончание работы 
        {
            if (_serverSocket.Connected)
                Send("#endsession");
        }

        private void messageData_KeyUp(object sender, KeyEventArgs e) // отправка сообщений 
        
        {
            if(e.KeyData == Keys.Enter)
            {
                string msgData = messageData.Text;
                if (string.IsNullOrEmpty(msgData))
                    return;
                if(msgData[0] == '"') // конкретному юзеру 
                {
                    string temp = msgData.Split(' ')[0];
                    string content = msgData.Substring(temp.Length+1);
                    temp = temp.Replace("\"", string.Empty);
                    Send($"#private|{temp}|{content}");
                }
                else
                    Send($"#message|{msgData}"); // всем юзерам 
                messageData.Text = string.Empty;
            }
        }

        private void nameData_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}

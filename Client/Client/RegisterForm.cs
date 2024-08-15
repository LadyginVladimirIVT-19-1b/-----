using Client;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client.Program;

namespace Client
{
    public partial class RegisterForm : Form
    {

        RecoveryLoginPassForm RecoveryLoginPassForm;

        public RegisterForm()
        {
            InitializeComponent();
            // создание подсказкок в строках


            EmailField.Text = "Введите почту";
            EmailField.ForeColor = Color.Gray;


            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;

            
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;


            PassFieldRepeat.Text = "Повторите пароль";
            PassFieldRepeat.ForeColor = Color.Gray;


            

        }

      


        // Работа кнопки "Зарегистрироваться"

        private void Button_Registration_Click(object sender, EventArgs e)
        {


            if (PassField.Text == "Введите электронную почту @mail.ru") // проверка на пустату электронной почты
            {
                MessageBox.Show("Вы не ввели потчу. Введите почту");
                return;
            }


            if (PassField.Text.Contains("@mail.ru") != true) // проверка, что пользователь ввел @mail.ru
            {
                MessageBox.Show("Вы неправильно ввели элетронную почту. Введите почту @mail.ru");
                return;
            }

            if (EmailField.Text == "Введите логин") // проверка на пустату логина
            {
                MessageBox.Show("Вы не ввели логин. Введите логин");
                return;
            }

            if (EmailField.TextLength < 4) // проверка на минимальное число символов логина
            {
                MessageBox.Show("Ваш логин слишком короткий. Логин должен состоять минимум из 4 символов!");
                return;
            }

            if (EmailField.TextLength > 32) // проверка на максимальное число символов пустату логина
            {
                MessageBox.Show("Ваш логин слишком длинный. Логин должен состоять максимум из 32 символов!");
                return;
            }

            if (LoginField.Text == "Введите пароль") // проверка на пустату пароля
            {
                MessageBox.Show("Вы не ввели пароль. Введите пароль");
                return;
            }

            if (LoginField.TextLength < 8) // проверка на минимальное число символов логина
            {
                MessageBox.Show("Ваш пароль слишком простой. Логин должен состоять минимум из 8 символов!");
                return;
            }

            if (LoginField.TextLength > 64) // проверка на максимальное число символов пустату логина
            {
                MessageBox.Show("Ваш пароль слишком длинный. Пароль должен состоять максимум из 64 символов!");
                return;
            }

            if (PassFieldRepeat.Text == "Повторите пароль") // проверка на пустату повторного пороля
            {
                MessageBox.Show("Вы не ввели повторный пароль. Введите повторный пароль");
                return;
            }

            if (LoginField.Text != PassFieldRepeat.Text) // проверяем, что пароль и повторный пороль совпали
            {
                MessageBox.Show("Пароли не совпали! Пороверьте правильность ввода поролей.");
                return;
            }

            if (isUserExists()) // проверка существования зарегистрированного логина 
                return;

            if (isEmailExists()) // проверка существования зарегистрированной электронной почты
                return;



            DataBase DB = new DataBase(); //выделили память под БД
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `email`) VALUES (@Login, @Pass, @Email)", DB.getConnection()); // выполняем команду: добовляем в БД нового пользователя по параметрам

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = EmailField.Text; // заглушка для логина            
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = LoginField.Text; // заглушка для пароля
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = PassField.Text; // заглушка для почты

            DB.openConnection(); // открыли БД




            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан. Теперь Вы можете авторизоваться в системе."); // уведомляем пользователя о создании аккаунта в системе

                try // отправка сообщения на электронную почту
                {

                    SmtpClient mySmtpClient = new SmtpClient("smtp.mail.ru"); // подключаем smtp сервер для майла

                    // устанавливаем smtp-клиент с базовой аутентификацией
                    mySmtpClient.UseDefaultCredentials = true; // подключение заголовков
                    mySmtpClient.EnableSsl = true; // подключение шифрование

                    System.Net.NetworkCredential basicAuthenticationInfo = new
                       System.Net.NetworkCredential("nil.linov@mail.ru", "MPVvTURt4eddfRGvTdpd"); // аунтификация в почте по логину и паролю
                    mySmtpClient.Credentials = basicAuthenticationInfo; // проверка подленности отправителя

                    /* Вместо пароля от почты нужно генерировать пароль в самой почте.
                    Для этого заходим в авторизованную почту , потом заходим в настройки "Пароль и безопасноть" 
                    В настройках "Способы входа" заходим в "Пароли для внешних приложений" создаем название приложения, к которому будем делать привязку автоматического входа электронной почты.
                    После чего генерируется пароль, каторый вставляем в приложение ( в нашем случае нашу программу).
                    */

                    //добавляем откуда и куда в почтовые адреса
                    MailAddress from = new MailAddress("nil.linov@mail.ru", "ООО \"Системнефтеавтоматика\""); // почта отправителя, от кого пишем письмо 
                    MailAddress to = new MailAddress(PassField.Text); // почта получателя, кому пишем письмо
                    MailMessage myMail = new System.Net.Mail.MailMessage(from, to); // передаем конструктор от кого кому письмо


                    // добавляем Ответить
                    MailAddress replyTo = new MailAddress("nil.linov@mail.ru"); // при нажатии кнопки "Ответить", письмо отправиться на эту почту
                    myMail.ReplyToList.Add(replyTo); // список адресов для возрата ответного письма


                    // устанавливаем тему и кодировку
                    myMail.Subject = "Регистрация в системе"; // тема письма
                    myMail.SubjectEncoding = System.Text.Encoding.UTF8; // настраиваем кодировку текста


                    // устанавливаем тело-сообщение и кодировку                                        
                    myMail.Body = "Вы зарегистрировались в системе ООО \"Системнефтеавтоматика\" \n\n" + "У Нас есть свой сайт: https://snaperm.ru/ \n\n"; // текст письма
                                                                                                                                                           // myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>."; // текст письма в виде HTML запросов

                    myMail.BodyEncoding = System.Text.Encoding.UTF8; // настраиваем кодировку текста

                    myMail.IsBodyHtml = false; // False - если письмо ввиде текста / True если текст будет скриптом HTML

                    mySmtpClient.Send(myMail); // отправляем письмо на имеил
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


                this.Hide(); // закрываем текущюю форму
                LoginForm LoginForm = new LoginForm(); // выделяем память
                LoginForm.Show(); // открываем новую форму авторизации

            }

            else
            {
                MessageBox.Show("Аккаунт НЕ был создан! Проверьте введенные данные.");
                return;
            }

            DB.closeConnection(); // Закрыли ДБ

        }


        ////////////////////////////////
        // проверяем наличия существования уже зарегистрированного пользователя
        public Boolean isUserExists()
        {
            DataBase DB = new DataBase(); // выделяем память для объектов
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Login", DB.getConnection()); // создаем команду: ищем пользователя в базе данных по логину введенным пользователем
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = EmailField.Text; // заглушка для логина

            adapter.SelectCommand = command; // выполняем команду выше
            adapter.Fill(table); // заполняем вспомогательную таблицу получившимися данными

            if (table.Rows.Count > 0) // проверяем если ли запись в таблице БД
            {
                MessageBox.Show("Данный логин уже существует! Введите другой логин."); // информируем сообщением
                return true;
            }
            else
                return false;


        }
        ////////////////////////////////


        ////////////////////////////////
        // проверяем наличия существования уже зарегистрированной электронной почты
        public Boolean isEmailExists()
        {
            DataBase DB = new DataBase(); // выделяем память для объектов
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @Email", DB.getConnection()); // создаем команду: ищем пользователя в базе данных по логину введенным пользователем
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = PassField.Text; // заглушка для почты

            adapter.SelectCommand = command; // выполняем команду выше
            adapter.Fill(table); // заполняем вспомогательную таблицу получившимися данными

            if (table.Rows.Count > 0) // проверяем если ли запись в таблице БД
            {
                MessageBox.Show("Вы не можете использовать эту почту! Введите другую почту."); // информируем сообщением
                return true;
            }
            else
                return false;


        }
        ////////////////////////////////



        ///////////////////////////////////////
        //действия с объектом "X"
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show( // создаем диалоговое окно 
           "Вы действительно хотите выйти из программы?", // текст уведомления 
           "Завершение программы",                  // заголовок уведомления
           MessageBoxButtons.YesNo,                 // даем выбрать да / нет
           MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)         // при нажатии "ДА" приложение выключится
            {
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
        /////////////////////////////



        ///////////////////////////////////////
        //действия с объектом "Авторизоваться?"      
        private void AuthorizationLabel_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationLabel.ForeColor = Color.Red;
        }

        private void AuthorizationLabel_MouseLeave(object sender, EventArgs e)
        {
            AuthorizationLabel.ForeColor = Color.Black;
        }
        /////////////////////////////////



        //перемещение формы по экрану
        Point lastPoint; // переменная для ее переноса виндус формы , после нажатого курсора пользователем на виндус форму

        private void MainPanel_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на нижнее полотно 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e) // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void TitlePanel_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на нижнее полотно
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e) // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EmailPicture_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на картинку электронной почты
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void EmailPicture_MouseDown(object sender, MouseEventArgs e)  // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UserPicture_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на картинку пользователя
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UserPicture_MouseDown(object sender, MouseEventArgs e)  // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }
                
        private void PassPicture_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на картинку замка
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PassPicture_MouseDown(object sender, MouseEventArgs e)  // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }
             
        private void PassPictureRepeat_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на картинку замка
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PassPictureRepeat_MouseDown(object sender, MouseEventArgs e)  // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /////////////////////////////////

    
       



      

        private void AuthorizationLabel_Click(object sender, EventArgs e) // переход на форму авторизации
        {
            this.Hide(); // закрываем текущюю форму
            LoginForm loginForm = new LoginForm(); // выделяем память
            loginForm.Show(); // открываем форму регистрации
        }



        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Введите почту")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "Введите почту";
                EmailField.ForeColor = Color.Gray;

            }
        }

        ////////////////////////////////
        // подсказка для ввода логина
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;

            }
        }
        ////////////////////////////////


        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;

            }
        }

        private void PassFieldRepeat_Enter(object sender, EventArgs e)
        {
            if (PassFieldRepeat.Text == "Повторите пароль")
            {
                PassFieldRepeat.Text = "";
                PassFieldRepeat.ForeColor = Color.Black;
            }
        }

        private void PassFieldRepeat_Leave(object sender, EventArgs e)
        {
            if (PassFieldRepeat.Text == "")
            {
                PassFieldRepeat.Text = "Повторите пароль";
                PassFieldRepeat.ForeColor = Color.Gray;

            }
        }
    }
}











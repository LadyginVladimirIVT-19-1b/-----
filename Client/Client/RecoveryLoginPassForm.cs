using Client;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Client
{
    public partial class RecoveryLoginPassForm : Form
    {
        


        public RecoveryLoginPassForm()
        {
            InitializeComponent();

            // создание подсказкок в строках
            EmailField.Text = "Введите почту";
            EmailField.ForeColor = Color.Gray;



        }



        ///////////////////////////////////////
        //действия с объектом "X"
        private void CloseButton_Click(object sender, EventArgs e) // закрытие проекта при нажатии кнопки "X"
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
        ////////////////////////////                



        ////////////////////////////////
        // подсказка для ввода электронной почты
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


        private void AuthorizationLabel_Click(object sender, EventArgs e)
        {
            this.Hide(); // закрываем текущюю форму
            LoginForm loginForm = new LoginForm(); // выделяем память
            loginForm.Show(); // открываем форму регистрации
        }

        private void AuthorizationLabel_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationLabel.ForeColor = Color.Red;
        }

        private void AuthorizationLabel_MouseLeave(object sender, EventArgs e)
        {
            AuthorizationLabel.ForeColor = Color.Black;
        }

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

        private void EmailPicture_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на картинку элетронной почты
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }



        private void EmailPicture_MouseDown(object sender, MouseEventArgs e) // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }
        ///////////////////////////////


        private void Button_RecoveryLoginPass_Click(object sender, EventArgs e)
        {

            if (EmailField.Text == "Введите почту") // проверка на пустату электронной почты
            {
                MessageBox.Show("Вы не ввели потчу. Введите почту");
                return;
            }


            if (EmailField.Text.Contains("@mail.ru") != true) // проверка, что пользователь ввел @mail.ru
            {
                MessageBox.Show("Вы неправильно ввели элетронную почту. Введите почту @mail.ru");
                return;
            }



            try
            {
                String EmailUser = EmailField.Text; // запишем в переменной текст из поля логина 
                DataBank.Email = EmailUser;

                DataBase DB = new DataBase(); // выделяем память для объекта
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @Email", DB.getConnection()); // создаем команду: ищем пользователя в базе данных по логину и паролю введенным пользователем
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailUser; // заглушка для почты

                adapter.SelectCommand = command; // выполняем команду выше
                adapter.Fill(table); // заполняем вспомогательную таблицу получившимися данными

                
                DB.closeConnection(); // Закрыли ДБ

               


                // генерируем код для восстановления пароля
                Random RandNumber = new Random(); // для генерации цифры
                Random RandLetter = new Random(); // для генерации буквы
                string KodPassEmail = null;

                for (int i = 0; i < 15; i++)
                {
                    int rand_num = RandNumber.Next (0,2);
                    
                    if (rand_num == 0)
                    {
                        int rand_number = RandNumber.Next(0, 9);
                        KodPassEmail += rand_number;
                        continue;
                    }

                    else
                    {
                        char rand_let = (char) RandLetter.Next(33, 125);
                        if (rand_let == '/' || rand_let == '\\')
                        {
                            rand_let = (char)RandLetter.Next(33, 91);
                        }

                        KodPassEmail += rand_let;
                        continue;

                    }
  
                }

                DataBank.EmailKod = KodPassEmail; // сохранаяем код в классе , чтобы перенести данные на другую форму
              


                if (table.Rows.Count == 1) // проверяем если ли запись в таблице
                    {

                        
                       
                                                                                        // 
                        SmtpClient mySmtpClient = new SmtpClient("smtp.mail.ru"); // подключаем smtp сервер для майла

                        // set smtp-client with basicAuthentication
                        mySmtpClient.UseDefaultCredentials = true; // подключение заголовков
                        mySmtpClient.EnableSsl = true; // подключение шифрование

                        System.Net.NetworkCredential basicAuthenticationInfo = new
                           System.Net.NetworkCredential("nil.linov@mail.ru", "MPVvTURt4eddfRGvTdpd"); // аунтификация в почте по логину и паролю
                        mySmtpClient.Credentials = basicAuthenticationInfo; // проверка подленности отправителя


                        // add from,to mailaddresses
                        MailAddress from = new MailAddress("nil.linov@mail.ru", "Наша Система"); // почта отправителя и от кого пишем письмо 
                        MailAddress to = new MailAddress(EmailField.Text); // почта получателя и его кому пишем письмо
                        MailMessage myMail = new System.Net.Mail.MailMessage(from, to); // передаем конструктор от кого кому письмо


                        // add ReplyTo
                        MailAddress replyTo = new MailAddress("nil.linov@mail.ru"); // при нажатии кнопки "Ответить", письмо отправиться на эту почту
                        myMail.ReplyToList.Add(replyTo); // список адресов для возрата ответного письма


                        // set subject and encoding
                        myMail.Subject = "Восстановление пароля"; // тема письма
                        myMail.SubjectEncoding = System.Text.Encoding.UTF8; // настраиваем кодировку текста


                        // set body-message and encoding

                        myMail.Body = "Код для восстановления пароля: " + KodPassEmail; // текст письма
                        myMail.BodyEncoding = System.Text.Encoding.UTF8; // настраиваем кодировку текста
                                                                         // text or html
                        myMail.IsBodyHtml = false; // False - если письмо ввиде текста / True если текст будет скриптом HTML

                        mySmtpClient.Send(myMail); // отправляем письмо на имеил


                        MessageBox.Show("На Вашу почту отправлен код для восстановления пароля"); // информируем сообщением

                        // переход на форму главную
                        this.Hide(); // закрываем текущюю форму
                        PasswordRecoveryCodeForm PasswordRecoveryCode = new PasswordRecoveryCodeForm(); // выделяем память
                        PasswordRecoveryCode.Show(); // открываем новую форму авторизации


                }
                    else
                        MessageBox.Show("Такого пользователя не существует. Проверьте правильность электронной почты.");
                
            }

            catch (SmtpException ex)
            {
               throw new ApplicationException
               ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
               throw ex;
            }



        }






    }
} 
        


             



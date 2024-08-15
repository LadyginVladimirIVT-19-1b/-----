using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
      //  ChatForm LoginUserAccount;


        public LoginForm()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;            // используется для убирания со строки пароля автонастройку размера
            this.PassField.Size = new Size(this.LoginField.Size.Width, this.LoginField.Size.Height); // приравниваем размер строки пароля к строке логина

            // создание подсказкок в строках
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;

            PassField.UseSystemPasswordChar = false;
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;

        }

        //////////////////////////////////////
        // авторизация пользователя в системе
        private void Button_Authorization_Click(object sender, EventArgs e)
        {




            if (LoginField.Text == "Введите логин") // проверка на пустату логина
            {
                MessageBox.Show("Вы не ввели логин. Введите логин");
                return;
            }

            if (PassField.Text == "Введите пароль") // проверка на пустату пароля
            {
                MessageBox.Show("Вы не ввели пароль. Введите пароль");
                return;
            }


            String loginUser = LoginField.Text; // запишем в переменной текст из поля логина 
            String passUser = PassField.Text; // запишем в переменной текст из поля пароля


            DataBase DB = new DataBase(); // выделяем память для объекта
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @Login AND `pass` = @Pass", DB.getConnection()); // создаем команду: ищем пользователя в базе данных по логину и паролю введенным пользователем
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = loginUser; // заглушка для логина
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = passUser; // заглушка для пароля

            adapter.SelectCommand = command; // выполняем команду выше
            adapter.Fill(table); // заполняем вспомогательную таблицу получившимися данными




            if (table.Rows.Count > 0) // проверяем если ли запись в таблице
            {
                MessageBox.Show("Пользователь авторизован"); // информируем сообщением
                               
                DataBank.UserName = LoginField.Text; // Переносим Логин авторизованного пользователя в чат форму
                
               
                // переход на форму главную
                this.Hide(); // закрываем текущюю форму
                ChatForm ChatForm = new ChatForm(); // выделяем память
                ChatForm.Show(); // открываем новую форму авторизации
               
            }
            else
                MessageBox.Show("Пользователь НЕ авторизован! Проверьте правильность логина и пароля.");

            DB.closeConnection(); // Закрыли ДБ
        }
        /////////////////////////////////////



        private void Open_eye_Picture_Click(object sender, EventArgs e) // нажатие на картинку открытого глаза
        {

            PassField.UseSystemPasswordChar = true; // делаем пароль не видимым
            Close_eye_Picture.Visible = true; // показываем картинку закрытого глаза
            Open_eye_Picture.Visible = false; // прячем картинку открытого глаза
           
        }


        private void Close_eye_Picture_Click(object sender, EventArgs e) // нажатие на картинку закртытого глаза
        {

            PassField.UseSystemPasswordChar = false; // делаем пароль видимым
            Close_eye_Picture.Visible = false; // прячем картинку закрытого глаза
            Open_eye_Picture.Visible = true; // показываем картинку открытого глаза

        }




        ///////////////////////////////////////
        //действия по изменениям объекта "X"

        private void CloseButton_Click(object sender, EventArgs e)  // закрытие проекта при нажатии кнопки "X" с использованием всплывающего уведомления
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
        /////////////////////////////////



        ///////////////////////////////////////
        //изменения цвета на объекте "Зарегистрироваться?"
        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.Red;

        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.Black;
        }
        //////////////////////////////////////



        ///////////////////////////////////////
        //изменения цвета на объекте "Восстановление логина и пароля"
        private void Recovery_login_passLabel_MouseEnter(object sender, EventArgs e)
        {
            Recovery_login_passLabel.ForeColor = Color.Red;
        }

        private void Recovery_login_passLabel_MouseLeave(object sender, EventArgs e)
        {
            Recovery_login_passLabel.ForeColor = Color.Black;
        }
        ///////////////////////////////////////
        


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

        private void UserPicture_MouseMove(object sender, MouseEventArgs e) // задает кардинаты X и Y, после нажатия курсора на картинку пользователя
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UserPicture_MouseDown(object sender, MouseEventArgs e) // обновляет по кардинатам курсора новое место для виндус формы
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
        private void PassPicture_MouseDown(object sender, MouseEventArgs e) // обновляет по кардинатам курсора новое место для виндус формы
        {
            lastPoint = new Point(e.X, e.Y);
        }

        ///////////////////////////////



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



        ////////////////////////////////
        // подсказка для ввода пароля
        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.UseSystemPasswordChar = true;
                PassField.Text = "";
                PassField.ForeColor = Color.Black;

            }

            
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.UseSystemPasswordChar = false;
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;

            }
            

        }
        ////////////////////////////////


        private void RegisterLabel_Click(object sender, EventArgs e) // переход на форму регистрации
        {
            this.Hide(); // закрываем текущюю форму
            RegisterForm registerForm = new RegisterForm(); // выделяем память
            registerForm.Show(); // открываем форму регистрации
        }

        private void Recovery_login_passLabel_Click(object sender, EventArgs e) // переход на форму восстановления логина и пароля
        {
            this.Hide(); // закрываем текущюю форму
            RecoveryLoginPassForm RecoveryLoginPassForm = new RecoveryLoginPassForm(); // выделяем память
            RecoveryLoginPassForm.Show(); // открываем форму восстановление пароля
        }


      

        
    }
}

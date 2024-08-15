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
    public partial class ChangePasswordForm : Form
    {
        

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

      
        //перемещение формы по экрану

        Point lastPoint; // переменная для ее переноса виндус формы , после нажатого курсора пользователем на виндус форму

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

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void UserPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UserPicture_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }    

        private void UserPicture1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UserPicture1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PassLable_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PassLable_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PassAgeinLable_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PassAgeinLable_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        //////////////////////////////


        ///////////////////////////////////////
        //действия по изменениям объекта "X"

        private void CloseButton_Click(object sender, EventArgs e)  // закрытие проекта при нажатии кнопки "X" с использованием всплывающего уведомления
        {
            DialogResult dialog = MessageBox.Show( // создаем диалоговое окно 
            "Вы действительно хотите вернуться в окно авторизации? Если вы выйдете, то данные об изменении пароля не сохранятся!!!", // текст уведомления 
            "Вернуться в окно авторизации",          // заголовок уведомления
            MessageBoxButtons.YesNo,                 // даем выбрать да / нет
            MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)         // при нажатии "ДА" приложение выключится
            {
                // переход на форму главную
                this.Hide(); // закрываем текущюю форму
                LoginForm LoginForm= new LoginForm(); // выделяем память
                LoginForm.Show(); // открываем новую форму авторизации
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
       


        private void Button_ChangePass_Click(object sender, EventArgs e)
        {
            string EmailUser = DataBank.Email;


            String PassUser = PassField.Text; // запишем в переменной текст из поля пароля 
            String PassAgainUser = PassAgainField.Text; // запишем в переменной текст из поля пароля

            // проверка для создания пароля
            
            if (PassField.Text == "Введите пароль") // проверка на пустату пароля
            {
                MessageBox.Show("Вы не ввели пароль. Введите пароль");
                return;
            }

            if (PassField.TextLength < 8) // проверка на минимальное число символов логина
            {
                MessageBox.Show("Ваш пароль слишком простой. Логин должен состоять минимум из 8 символов!");
                return;
            }

            if (PassField.TextLength > 64) // проверка на максимальное число символов пустату логина
            {
                MessageBox.Show("Ваш пароль слишком длинный. Пароль должен состоять максимум из 64 символов!");
                return;
            }

            if (PassAgainField.Text == "Повторите пароль") // проверка на пустату повторного пороля
            {
                MessageBox.Show("Вы не ввели повторный пароль. Введите повторный пароль");
                return;
            }

            if (PassField.Text != PassAgainField.Text) // проверяем, что пароль и повторный пороль совпали
            {
                MessageBox.Show("Пароли не совпали! Пороверьте правильность ввода поролей.");
                return;
            }


            try

            {
                DataBase DB = new DataBase(); // выделяем память для объекта

                DB.openConnection(); // Открыли ДБ

                MySqlDataAdapter adapter1 = new MySqlDataAdapter();

                MySqlCommand command1 = new MySqlCommand($"UPDATE users SET pass = '" + PassUser + "' WHERE email = '" + EmailUser + "' ", DB.getConnection()); // выполняем команду: добовляем в БД нового пользователя по параметрам
                //command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PassUser; // заглушка для пароля
                //command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailUser; // заглушка для логина
               
                adapter1.UpdateCommand = command1; 
                command1.ExecuteNonQuery(); // выполняем команду выше

                DB.closeConnection(); // Закрыли ДБ

                MessageBox.Show("Пароль изменен"); // информируем сообщением
            }
            catch
            {
                MessageBox.Show("Пароль НЕ изменен!"); // информируем сообщением
            }




           

            // переход на форму главную
            this.Hide(); // закрываем текущюю форму
            LoginForm LoginForm = new LoginForm(); // выделяем память
            LoginForm.Show(); // открываем новую форму авторизации

           








        }

      
    }
}

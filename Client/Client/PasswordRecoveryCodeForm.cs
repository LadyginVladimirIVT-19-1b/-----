using MySqlX.XDevAPI.Relational;
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
    public partial class PasswordRecoveryCodeForm : Form
    {
        string CodeEmail = DataBank.EmailKod;

        public PasswordRecoveryCodeForm()
        {
            InitializeComponent();

            // создание подсказкок в строках
            CodeField.Text = "Введите код";
            CodeField.ForeColor = Color.Gray;

            
           
        }



        private void CodeField_Enter(object sender, EventArgs e)
        {
            if (CodeField.Text == "Введите код")
            {
                CodeField.Text = "";
                CodeField.ForeColor = Color.Black;
            }
        }

        private void CodeField_Leave(object sender, EventArgs e)
        {
            if (CodeField.Text == "")
            {
                CodeField.Text = "Введите код";
                CodeField.ForeColor = Color.Gray;

            }
        }


        public void Button_RecoveryPass_Click(object sender, EventArgs e)
        {

            if (CodeField.Text == CodeEmail) // проверяем если ли запись в таблице
            {
                              
                // переход на форму главную
                this.Hide(); // закрываем текущюю форму
                ChangePasswordForm ChangePassword = new ChangePasswordForm(); // выделяем память
                ChangePassword.Show(); // открываем новую форму авторизации

            }
            else
                MessageBox.Show("Неверный код, проверьте правильность ввода кода");

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

        //////////////////////////////


        ///////////////////////////////////////
        //действия по изменениям объекта "X"

        private void CloseButton_Click(object sender, EventArgs e)  // закрытие проекта при нажатии кнопки "X" с использованием всплывающего уведомления
        {
            DialogResult dialog = MessageBox.Show( // создаем диалоговое окно 
           "Вы действительно хотите вернуться в окно авторизации? Если вы выйдете, то восстановления пароля придется начинать с начало", // текст уведомления 
           "Вернуться в окно авторизации",          // заголовок уведомления
           MessageBoxButtons.YesNo,                 // даем выбрать да / нет
           MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)         // при нажатии "ДА" приложение выключится
            {
                // переход на форму главную
                this.Hide(); // закрываем текущюю форму
                LoginForm LoginForm = new LoginForm(); // выделяем память
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






    }
}

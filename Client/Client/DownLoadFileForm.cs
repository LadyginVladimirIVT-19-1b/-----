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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace Client
{
    public partial class DownLoadFileForm : Form
    {
      


        public DownLoadFileForm()
        {
            InitializeComponent();


        }




        //////////////////////////////////////////

        // Действия над объектом Х
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // закрываем текущюю форму
        }


        private void CloseButton_MouseEnter(object sender, EventArgs e) // при наведении на кнопку креста красим ее в красный
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e) // при убирании от кнопки креста красим ее в черный
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void ViewFile_Click(object sender, EventArgs e) // скачать файл в папку
        {
            if (string.IsNullOrEmpty(NameTagFile.Text)) // проверяем поле с путем файла на пустату
            {
                MessageBox.Show("Название файла не выбрано. Напишите название файла", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (NameTagFile.Text != null)
            {
                Hint_User.Text = "Фаил выбран";
                

            }

            try
            {
                DataBase DB = new DataBase(); // выделяем память для объекта

                DB.openConnection(); // Открыли ДБ


                MySqlCommand command = new MySqlCommand("SELECT file FROM tag WHERE name_tag = @name_tag", DB.getConnection()); // находим файл в бд по названию тега
                command.Parameters.AddWithValue("@name_tag", NameTagFile.Text);

                MySqlDataReader reader = command.ExecuteReader(); // выполняем команду считавания

                if (reader.Read())
                {
                    byte[] fileData = (byte[])reader["file"];

                    SaveFileDialog saveFileDialog = new SaveFileDialog();  // диалоговое окно для сохранения файла в конкретную папку из бд
                   
                    //saveFileDialog.Filter = "All Files (*.*)|*.*" + "|Text File (*.txt)|*.txt" + "|Docx File(*.docx)|*.docx" + // Создаем фильтрацию в папке по типам файлам
                    //                 "|Doc File (*.doc)|*.doc" + "|Exsel File (*.xlsx)|*.xlsx"; ; 

                    saveFileDialog.FilterIndex = 1;

                    saveFileDialog.FileName = NameTagFile.Text;


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, fileData); // создает файл записывает туда массив байтов и закрывает
                        MessageBox.Show("Файл успешно скачен из БД", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Файл не найден в базе данных ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DB.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при скачиванииз данных в базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }



        ////////////////////////////////////////// 
        private void DownLoadFileForm_Load(object sender, EventArgs e) // заполняет текстбокс названиями тегов
        {
            DataBase DB = new DataBase(); // выделяем память для объекта

            DB.openConnection(); // Открыли ДБ

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT name_tag FROM tag", DB.getConnection()); // находим файл в бд по названию тега


                using (MySqlDataReader reader = command.ExecuteReader()) // считываем данные из БД
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("name_tag")))
                        {
                            NameTagFile.Items.Add(reader["name_tag"].ToString()); // заполняем текстбокс
                        }
                    }

                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка SQL при заполнении {NameTagFile}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при заполнении {NameTagFile}:\r\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        //////////////////////////////////////////


        Point lastPoint; // переменная для ее переноса виндус формы , после нажатого курсора пользователем на виндус форму

        private void DownLoadFileForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DownLoadFileForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }












    }
}
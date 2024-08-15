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
using System.Data.SqlClient;


namespace Client
{
    public partial class UpLoadFileForm : Form
    {
        private string selectedFilePath; // путь к файлу

        private string NameFile; // название файла

        public UpLoadFileForm()
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

        //////////////////////////////////////////



        private void UpLoadFileForm_Load(object sender, EventArgs e)
        {
            Path_File.Text = "        \"" + "Пусто" + "\"";
            
            
            string LoginUser = DataBank.UserName;

            DataBase DB = new DataBase(); // выделяем память для объекта
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT id_user FROM `users` WHERE `login` = @Login", DB.getConnection()); // создаем команду: ищем пользователя в базе данных по логину и паролю введенным пользователем
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginUser; // заглушка для логина

            adapter.SelectCommand = command; // выполняем команду выше
            adapter.Fill(table); // заполняем вспомогательную таблицу получившимися данными

            if (table.Rows.Count > 0) // проверяем если ли запись в таблице
            {
                string id_User = Convert.ToString(table.Rows[0]["id_user"]);
                DataBank.ID_User = id_User;
            }


            DB.closeConnection(); // Закрыли ДБ
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open_File_Dialog = new OpenFileDialog(); // открываем проводник для выбора файла

            Open_File_Dialog.Filter = "All Files (*.*)|*.*" + "|Text File (*.txt)|*.txt" + "|Docx File(*.docx)|*.docx" + // Создаем фильтрацию по типам файлам
                                     "|Doc File (*.doc)|*.doc" + "|Exsel File (*.xlsx)|*.xlsx";

            
            if (Open_File_Dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = Open_File_Dialog.FileName; // задаем путь к файлу

                NameFile = Open_File_Dialog.SafeFileName;

                Hint_User.Text = $"Выбран файл:";

                Path_File.Text = "\"" + NameFile + "\"";

            }
        }

        private void UpLoadFile_Click(object sender, EventArgs e)
        {
            string LoginUser = DataBank.UserName;
            string id_User = DataBank.ID_User;
            

            if (string.IsNullOrEmpty(selectedFilePath)) // проверяем поле с путем файла на пустату
            {
                MessageBox.Show("Текстовый файл не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataBase DB = new DataBase(); // выделяем память для объекта

            try
            {
                

                DB.openConnection(); // Открыли ДБ


                
                MySqlCommand command = new MySqlCommand("INSERT INTO `tag` (`name_tag`, `author_tag`, `id_user`, `file`) VALUES (@name_tag, @author_tag, @id_user,@file)", DB.getConnection()); // выполняем команду: добовляем в БД нового пользователя по параметрам

                command.Parameters.Add("@name_tag", MySqlDbType.VarChar).Value = NameFile; // заглушка для логина            
                command.Parameters.Add("@author_tag", MySqlDbType.VarChar).Value = LoginUser; // заглушка для пароля
                command.Parameters.Add("@id_user", MySqlDbType.VarChar).Value = id_User; // заглушка для почты
                command.Parameters.Add("@file", MySqlDbType.LongBlob).Value = File.ReadAllBytes(selectedFilePath);

                DB.openConnection(); // открыли БД

                

                command.ExecuteNonQuery();

                MessageBox.Show("Данные успешно добавлены в БД", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DB.closeConnection(); // Закрыли ДБ
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении данных в базу данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ListView TagList = DataBank.List_Tag;


            MySqlDataReader dataReader = null;
           

            DB.openConnection();
            try
            {
                TagList.Clear();
                MySqlCommand command = new MySqlCommand("SELECT `name_tag` FROM `tag`", DB.getConnection()); // создаем команду: ищем пользователя в базе данных все теги

                dataReader = command.ExecuteReader(); // считываем теги из БД
                ListViewItem ItemList = null;

                while (dataReader.Read()) // Заполняем названием тега ТекстБох
                {
                    ItemList = new ListViewItem(new string[] { dataReader["name_tag"].ToString() }); 

                    TagList.Items.Add(ItemList);

                   
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
            // Заполнили Комбобокс (NameTag) данными из БД 


            DB.openConnection(); // Открыли ДБ
            ComboBox NameTag = DataBank.CheckTagName;
            NameTag.Items.Clear();

            try
            {
              


                MySqlCommand command = new MySqlCommand("SELECT name_tag FROM tag", DB.getConnection()); // находим файл в бд по названию тега


                using (MySqlDataReader reader = command.ExecuteReader()) // считываем данные из БД
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("name_tag")))
                        {
                            NameTag.Items.Add(reader["name_tag"].ToString()); // заполняем текстбокс

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







        }


        Point lastPoint; // переменная для ее переноса виндус формы , после нажатого курсора пользователем на виндус форму
        private void UpLoadFileForm_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UpLoadFileForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

   

        




    }
}

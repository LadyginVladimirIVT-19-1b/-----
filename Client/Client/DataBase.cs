using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=mqtt"); // подключение к БД по параметрам
       

        public void openConnection() // подключение соединение к бд
        {
            if (connection.State == System.Data.ConnectionState.Closed) // если нету подключения к бд, то подключаемся
                connection.Open();
        }

        public void closeConnection() // отключить соединение от бд
        {
            if (connection.State == System.Data.ConnectionState.Open) // если бд подключена, то отключаем 
                connection.Close();
        }


        public MySqlConnection getConnection() // возвращает соединение с бд
        {
            return connection; // говорит с какой базой работаем
        }

    }
}

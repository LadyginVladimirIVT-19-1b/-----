using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static internal class DataBank
    {
        public static string UserName; // используется для уведомления на сервер о подключенном пользователе

        public static string EmailKod; // используется для отправки кода восстановления пароля на почту

        public static string Email; // 


        public static string ID_User; // используется для сохранения id пользователя в таблице бд users

        public static string ID_Tag; // используется для сохранения id тега в таблице бд tag

        public static ListView List_Tag;

       

        public static ComboBox CheckTagName; // используется для обновления названий тегов
    }
}

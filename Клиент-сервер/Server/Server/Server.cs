using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Server
{
    public static class Server
    {
        public static List<FileD> Files = new List<FileD>();
        public struct FileD
        {
            public int ID; // ID
            public string FileName; // имя файла
            public string From; // откуда придет фаил
            public int FileSize; // размер файла
            public byte[] fileBuffer; // буфер для файла
        }
        public static int CountUsers = 0; //сколько юзеров
        public delegate void UserEvent(string Name); 
        
        public static event UserEvent UserConnected = (Username) =>//подключене юзера
        {
            Console.WriteLine($"User {Username} connected."); // оповещение о подключении юзера на сервер
            CountUsers++; // после добовления юзира в счетчик добовляем +1
            SendGlobalMessage($"Пользователь {Username} подключился к чату.", "Black"); // отправляет всем юзерам находящимся в чате, что подключился новый юзер
            SendUserList(); //выдение списка появившихся юзров
                           
        };
        
        public static event UserEvent UserDisconnected = (Username) =>//отключение юзера из чата, работает точно также
        {
            Console.WriteLine($"User {Username} disconnected."); // отключился юзе 
            CountUsers--; // уменьшился счетчик
            SendGlobalMessage($"Пользователь {Username} отключился от чата.","Black"); // прошло оповещение
            SendUserList(); // вывелся список оставщихся юзеров
        };
      
        public static List<User> UserList = new List<User>(); // список юзеров
        public static Socket ServerSocket; // сервер сокетов
        public const string Host = "192.168.0.101"; //прописываем ip-шник
        public const int Port = 9933;//прописываем порт
        public static bool Work = true; // логическая функция отчечающая за работу сервера которая идет в ваил 

        public static FileD GetFileByID(int ID)//прикрепление файла по ID
        {
            int countFiles = Files.Count; // счетчик файлов
            for(int i = 0;i < countFiles;i++)
            {
                if (Files[i].ID == ID) // проверяем ID
                    return Files[i]; // отправка файла
            }
            return new FileD() { ID = 0};
        }
        public static void NewUser(User usr)//конектим юзера
        {
            if (UserList.Contains(usr))//если появился новый юзер
                return;
            UserList.Add(usr);//добавляем в список юзеров
            UserConnected(usr.Username);//добавляем к законекченым юзирам
        }
        public static void EndUser(User usr)//дисконектим юзера
        {
            if (!UserList.Contains(usr))//если исчез юзер
                return;
            UserList.Remove(usr);//убираем его из списка юзеров
            usr.End(); // заканчиваем работу исчезнувшего юзира
            UserDisconnected(usr.Username); // и отключаем его от сервера

        }

        public static User GetUser(string Name)//поиск пользователя под конкретным именем
        {
            for(int i = 0;i < CountUsers;i++)//если влезает наш список
            {
                if (UserList[i].Username == Name)
                    return UserList[i]; // берем его имя
            }
            return null;
        }
        public static void SendUserList()//юзера в список добавим
        {
            string userList = "#userlist|";

            for(int i = 0;i < CountUsers;i++) 
            {
                userList += UserList[i].Username + ",";
            }

            SendAllUsers(userList);//покажем его всем юзерам
        }
        public static void SendGlobalMessage(string content,string clr)//сохранение в список текста сообщения пользователя (с языковыми параметрами)
        {
            for(int i = 0;i < CountUsers;i++)
            {
                UserList[i].SendMessage(content, clr);
            }
        }
        public static void SendAllUsers(byte[] data)//сохранение в список кода пользователя
        {
            for(int i = 0;i < CountUsers;i++)
            {
                UserList[i].Send(data);
            }
        }
        public static void SendAllUsers(string data)//сохранение в список параметр пользователя
        {
            for (int i = 0; i < CountUsers; i++)
            {
                UserList[i].Send(data);
            }
        }


    }
}

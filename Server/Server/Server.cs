using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Server
{
    public static class Server
    {
        public static List<FileD> Files = new List<FileD>();
        public static List<PodpiskiUser> Podpiski = new List<PodpiskiUser>(); // доп клас для тегов и подписок 
        public struct PodpiskiUser // создать отдельные классы через которые отображать в интерефейсе данные о подписках
        {
            public string name; // Имя пользователя
            public List<string> TagList; //список подписок теги
            public List<string> UserList; //список подписок пользователи
        }
        public struct FileD
        {
            public int ID; // ID файла
            public string FileName; // имя файла
            public string From; // откуда придет фаил
            public int FileSize; // размер файла
            public byte[] fileBuffer; // буфер для файла
            public string Tag; // для работы с тегами
        }
        public static int CountClient = 0; //количество клиентов
        public delegate void ClientEvent(string Name); 
        
        public static event ClientEvent UserConnected = (Username) =>//подключение клиента
        {
            Console.WriteLine($"User {Username} connected."); // оповещение о подключении юзера на сервер
            CountClient++; // после добовления юзира в счетчик добовляем +1
            SendGlobalMessage($"Пользователь {Username} подключился к чату.", "Black"); // отправляет всем юзерам находящимся в чате, что подключился новый юзер
            SendClientList(); //выдение списка появившихся юзров
                           
        };
        
        public static event ClientEvent UserDisconnected = (Username) =>//отключение клиента из чата, работает точно также
        {
            Console.WriteLine($"User {Username} disconnected."); // отключился юзе 
            CountClient--; // уменьшился счетчик
            SendGlobalMessage($"Пользователь {Username} отключился от чата.","Black"); // прошло оповещение
            SendClientList(); // вывелся список оставщихся юзеров
        };
      
        public static List<WorkSocket> ClientList = new List<WorkSocket>(); //список клиентов
        public static Socket ServerSocket; // сервер сокетов
        public const string Host = "192.168.0.108"; //прописываем ip-шник
        public const int Port = 9999;//прописываем порт
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
       

        public static void NewClient(WorkSocket usr)//подключение клиента
        {
            if (ClientList.Contains(usr))//если появился новый юзер
                return;
            ClientList.Add(usr);//добавляем в список юзеров
            UserConnected(usr.Username);//добавляем к законекченым юзирам
        }


        public static void EndClient(WorkSocket usr)//отеключение клиента
        {
            if (!ClientList.Contains(usr))//если исчез юзер
                return;
            ClientList.Remove(usr);//убираем его из списка юзеров
            usr.End(); // заканчиваем работу исчезнувшего юзира
            UserDisconnected(usr.Username); // и отключаем его от сервера

        }

        public static WorkSocket GetClient(string Name)//поиск клиента под конкретным именем
        {
            for(int i = 0;i < CountClient;i++)//если влезает наш список
            {
                if (ClientList[i].Username == Name)
                    return ClientList[i]; // берем его имя
            }
            return null;
        }


        public static void SendClientList()//добавление клиента в список
        {
            string userList = "#userlist|";

            for(int i = 0;i < CountClient;i++) 
            {
                userList += ClientList[i].Username + ",";
            }

            SendAllClients(userList);//покажем его всем юзерам
        }


        public static void SendGlobalMessage(string content,string clr)//сохранение в список текста сообщения пользователя (с языковыми параметрами)
        {
            for(int i = 0;i < CountClient;i++)
            {
                ClientList[i].SendMessage(content, clr);
            }
        }


        public static void SendAllClients(byte[] data)//сохранение в список кода пользователя
        {
            for(int i = 0;i < CountClient;i++)
            {
                ClientList[i].Send(data);
            }
        }


        public static void SendAllClients(string data)//сохранение в список параметр пользователя
        {
            for (int i = 0; i < CountClient; i++)
            {
                ClientList[i].Send(data);
            }
        }


        public static void SetLabel(int ID, string labelName) // устанавливаем файлу Ярлык. Макс 1 ярлык на файл
        {
            FileD tmpFile = Files[ID];
            tmpFile.Tag = "labelName";
            Files[ID] = tmpFile;
        }

        public static void RemoveLabel(int ID, string labelName) //удаляем с файла Ярлык
        {
            FileD tmpFile = Files[ID];
            tmpFile.Tag = "noTag";
            Files[ID] = tmpFile;
        }
    }
}

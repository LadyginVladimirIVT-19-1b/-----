using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress address = IPAddress.Parse(Server.Host);//преобразуем строку ip-адрес в экземляр класса
            Server.ServerSocket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);// создание объекта сокета 
            Server.ServerSocket.Bind(new IPEndPoint(address, Server.Port));//связываем сокет с локальной конечной точкой
            Server.ServerSocket.Listen(100);//прослушиваем скоеты для принятие юзеров
            Console.WriteLine($"Server has been started on {Server.Host}:{Server.Port}");// вывод о работе сервера по его Ip и порту
            Console.WriteLine("Waiting connections...");//вывод о подключениях
            while(Server.Work)//пока сервер работает выполняем действия по булевой функции
            {
                Socket handle = Server.ServerSocket.Accept();//ожидание подключение клиета
                Console.WriteLine($"New connection: {handle.RemoteEndPoint.ToString()}"); //законектился юзер
                new User(handle); // добовляем в список юзеров

            }
            Console.WriteLine("Server closeing...");//отключение сервера

        }
    }
}

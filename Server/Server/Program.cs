using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress address = IPAddress.Parse(Server.Host);//преобразуем строку ip-адрес в экземляр класса
            Server.ServerSocket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);// создание объекта сокета 
            Server.ServerSocket.Bind(new IPEndPoint(address, Server.Port));//связываем сокет с локальной конечной точкой
            Server.ServerSocket.Listen(100);//прослушиваем скоеты для принятие клиента
            Console.WriteLine($"Server has been started on {Server.Host}:{Server.Port}");// вывод о работе сервера по его Ip и порту
            Console.WriteLine("Waiting connections...");//вывод о подключениях
            while(Server.Work)//пока сервер работает выполняем действия по булевой функции
            {
                Socket handle = Server.ServerSocket.Accept();//ожидание подключение клиента
                Console.WriteLine($"New connection: {handle.RemoteEndPoint.ToString()}"); //подключился клиент
                new WorkSocket(handle); //добовляем в список клиентов

            }
            Console.WriteLine("Server closeing...");//отключение сервера
        }
    }
}

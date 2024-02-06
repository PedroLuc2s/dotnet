// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void PreStart()
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1500);
            Console.WriteLine("Set...");
            Thread.Sleep(1500);
            Console.WriteLine("Go...");
            Thread.Sleep(500);
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite o tempo em segundos ou digite 'exit' para sair: ");
            #pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            var data = Console.ReadLine().ToLower();
            #pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
            if (data == "exit")
                System.Environment.Exit(0);
            else
            {
                int time = int.Parse(data);
                PreStart();
                Start(time);
            }
        }
        static void Start(int time)
        {
            int currenTitme = 0;

            while (currenTitme != time)
            {
                Console.Clear();
                currenTitme++;
                Console.WriteLine($"{currenTitme}s");
                Thread.Sleep(1000);            
            }
            Console.Clear();
            Console.WriteLine("O StopWatch terminou... Pressione 'Enter' para prosseguir.");
            Thread.Sleep(2000);
            Console.ReadKey();
            Menu();            
        }
    }
}



// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;
using System.Buffers;
using System.Threading;
using System.IO;

namespace Editor
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oquê você deseja fazer?");
            Thread.Sleep(1000);
            Console.WriteLine("1 - Abrir arquivo");
            Thread.Sleep(1000);
            Console.WriteLine("2 - Criar arquivo");
            Thread.Sleep(1000);
            Console.WriteLine("0 - Sair do editor");


            string? option = Console.ReadLine();

            Console.WriteLine("");

            switch (option)
            {
                case "0": Environment.Exit(0); break;
                case "1": Abrir(); break;
                case "2": Criar(); break;
                default: Menu(); break;
            }
        }
        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)!");
            Console.WriteLine("");

            string input = "";

            do
            {
                input += Console.ReadLine();
                input += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            
            Thread.Sleep(2000);

            Console.WriteLine("Quer salvar seu texto?");
            Thread.Sleep(1000);
            Console.WriteLine("S - Sim ou N - Não");

            Thread.Sleep(1000);
            var data = Console.ReadLine();

            if (data == "N" || data == "n")
                input = "";
            else
            {   
                Thread.Sleep(1000);
                Console.WriteLine("Para onde eu posso enviar o endereço do arquivo?");
                var endereco = Console.ReadLine();
                #pragma warning disable CS8604 // Possível argumento de referência nula.
                using (var file = new StreamWriter(endereco))
                {
                    file.Write(input);
                }
                #pragma warning restore CS8604 // Possível argumento de referência nula.
                Thread.Sleep(1000);
                Console.WriteLine("Seu texto foi salvo!");            
            }
            Menu();
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o endereço do arquivo?");
            var path = Console.ReadLine();

            Console.WriteLine("");

            #pragma warning disable CS8604 // Possível argumento de referência nula.
            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            #pragma warning restore CS8604 // Possível argumento de referência nula.

            Console.WriteLine("");
            
            Thread.Sleep(2000);
            Console.WriteLine("Pressione 'Enter' para sair");
            Console.ReadLine();
            Menu();
        }
    }
}
using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static float Multiply(float a, float b) { return a * b; }

        static float Divide(float a, float b) { return a / b; }

        static float Subtract(float a, float b) { return a - b; }

        static float Add(float a, float b) { return a + b; }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            var primeiraVariavel = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            var segundaVariavel = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação: (+, -, *, /)");
            char operation = char.Parse(Console.ReadLine());

            Console.WriteLine("");

            switch (operation)
            {
                case '+': Console.WriteLine($"O resultado da operação é: {Add(primeiraVariavel, segundaVariavel)}"); break;
                case '-': Console.WriteLine($"O resultado da operação é: {Subtract(primeiraVariavel, segundaVariavel)}"); break;
                case '*': Console.WriteLine($"O resultado da operação é: {Multiply(primeiraVariavel, segundaVariavel)}"); break;
                case '/': Console.WriteLine($"O resultado da operação é: {Divide(primeiraVariavel, segundaVariavel)}"); break;
                default: Console.WriteLine("Operação inválida!!"); break;
            }
            
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Para voltar ao menu digite 'c'");
            Thread.Sleep(2000);
            Console.WriteLine("Caso queira sair Digite a tecla 's'");
            Console.WriteLine("");
            Thread.Sleep(1000);
            string tecla = Console.ReadLine().ToLower();

            if (tecla == "c")
                Menu();

            if (tecla == "s")
                Environment.Exit(0);
        }

        static void Main()
        {
            Menu();
        }
    }
}

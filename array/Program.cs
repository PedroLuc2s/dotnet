using System;
using System.Threading;

namespace ContaBancaria
{
    class Banco
    {
        private static string Name = "Pedro";
        private static decimal Saldo = 0;

        public static void ConsultarSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Este é o seu saldo R${Saldo:F2}.");
            MostrarMenu();
        }

        public static void Depositar()
        {
            Console.Clear();
            Console.WriteLine($"{Name}, Quanto deseja depositar?");
            if (decimal.TryParse(Console.ReadLine(), out decimal deposito) && deposito > 0)
            {
                Saldo += deposito;
                Console.WriteLine("Depósito feito com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor inválido!!");
            }
            MostrarMenu();
        }

        public static void Sacar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"{Name}, Quanto deseja sacar?");
                if (decimal.TryParse(Console.ReadLine(), out decimal saque) && saque > 0)
                {
                    if (saque <= Saldo)
                    {
                        Saldo -= saque;
                        Console.WriteLine("Saque concluído com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para o saque.");
                    }
                }
                else
                {
                    Console.WriteLine("Saque inválido!!!\nTente um valor maior que zero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ocorreu um erro ao processar o saque. Certifique-se de inserir um valor válido.");
            }
            MostrarMenu();
        }

        public static void MostrarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Olá {Name}, Bem-vindo ao nosso banco, é um prazer servi-lo(a).");
                Thread.Sleep(1000);
                Console.WriteLine("Como podemos ajudar?");
                Thread.Sleep(1000);
                Console.WriteLine("------------------------");
                Thread.Sleep(1000);
                Console.WriteLine("1 - Consultar meu saldo");
                Thread.Sleep(1000);
                Console.WriteLine("2 - Depositar");
                Thread.Sleep(1000);
                Console.WriteLine("3 - Sacar");
                Thread.Sleep(1000);
                Console.WriteLine("0 - Sair");
                Thread.Sleep(1000);
                Console.WriteLine("------------------------");

                char escolha = char.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case '1': ConsultarSaldo(); break;
                    case '2': Depositar(); break;
                    case '3': Sacar(); break;
                    case '0': Environment.Exit(0); break;
                    default: Console.WriteLine("Escolha inválida. Tente novamente."); break;
                }
            }
        }

        public static void Main()
        {
            MostrarMenu();
        }
    }
}

using System;
using System.Diagnostics;
using System;

namespace Editor
{
    public static class Html
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Draw();
            Options();

            var choose = Console.ReadLine();
        }

        static void Draw()
        {
            Console.WriteLine("+");
            for (int i = 0; i<=30; i++)
                Console.WriteLine("-");
            
            Console.WriteLine("+");
            Console.WriteLine("\n");

            for (int lines = 0; lines<=10; lines++)
            {
                Console.WriteLine("|");
                for (int i = 0; i<=30 ;i++)
                    Console.WriteLine(" ");
                
                Console.WriteLine("|");
                Console.WriteLine("\n");
            }
            Console.WriteLine("+");
            for (int i = 0; i<=30 ; i++)
                Console.WriteLine("-");
            
            Console.WriteLine("+");
            Console.WriteLine("\n");
        }
        static void Options()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("\n");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Agendar consulta");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("0 - Sair");
        }
        public static void Choose(int choose)
        {
            switch (choose)
            {
                case 1: Agendar(); break;
                case 0: Environment.Exit(0); break;
                default: Show(); break;
            }
        }
        public static void Agendar(){
            Console.Clear();
            Draw();

            Console.WriteLine("A cliníca têm esses dias para o atendimento: seg ás 17h e sex ás 13h.");
            Console.WriteLine("Qual sua escolha opção 1(seg) ou opção 2(sex)?");
  
            var option = Console.ReadLine();

            if (option == "1")
                Console.WriteLine("Sua consulta ésta marcada para segunda!");
            else
                Console.WriteLine("Sua consulta ésta marcada para sexta!");
            Show();
        }
    }
}
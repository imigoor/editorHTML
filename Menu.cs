using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
            WriteOptions();
            HandleMenuOption();
        }

        public static void Columns()
        {
            Console.Write("+");
            int i = 0;
            do
            {
                Console.Write("-");
                i++;
            }while(i <= 60);
            Console.Write("+");
            Console.Write("\n");
        }

        public static void Lines()
        {
          int lines = 0;
            while(lines <= 20)
            {
                Console.Write("|");
                for(int i = 0; i <= 60; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
                lines++;
            }  
        }

        public static void DrawScreen()
        {
            Columns();
            Lines();
            Columns();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("******************");
            Console.SetCursorPosition(2, 2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("******************");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("3 - Sair");
            Console.SetCursorPosition(2, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption()
        {
            var option = short.Parse(Console.ReadLine());
            switch(option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("Vizualizar"); break;
                case 3: 
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}
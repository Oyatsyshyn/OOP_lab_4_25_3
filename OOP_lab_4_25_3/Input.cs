using System;
using System.IO;

namespace OOP_lab_4_25_3
{
    class Input
    {
        public static void Read()
        {
            Work.Initialisation(ReadBase());
            Key();
        }

        public static void Key()
        {
            Console.WriteLine("Додавання записiв: +");
            Console.WriteLine("Редагування записiв: E");
            Console.WriteLine("Знищення записiв: -");
            Console.WriteLine("Виведення записiв: Enter");
            Console.WriteLine("Пошук записiв: F");
            Console.WriteLine("Сортуванн записiв: S");
            Console.WriteLine("Вихiд: Esc");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.OemPlus:
                    Console.WriteLine();
                    Work.Add();
                    break;

                case ConsoleKey.E:
                    Console.WriteLine();
                    Work.Edit();
                    break;

                case ConsoleKey.OemMinus:
                    Console.WriteLine();
                    Work.Remove();
                    break;

                case ConsoleKey.Enter:
                    Console.WriteLine();
                    Output.Write();
                    Key();
                    break;

                case ConsoleKey.F:
                    Console.WriteLine();
                    Work.Find();
                    break;

                case ConsoleKey.S:
                    Console.WriteLine();
                    Work.Sort();
                    break;

                case ConsoleKey.Escape:
                    return;
            }
        }
        public static string ReadBase()
        {
            StreamReader file = new StreamReader("base.txt");

            string tempStr = file.ReadToEnd();

            file.Close();

            return tempStr;
        }
    }
}

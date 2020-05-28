using System;
using System.IO;
using System.Linq;

namespace OOP_lab_4_25_3
{
    class Work
    {
        public static void Add()
        {
            StreamWriter file = new StreamWriter("base.txt", true);

            Console.WriteLine("\nВведiть новi данi");

        Retry:
            Console.Write("Номер договору : ");

            try
            {
                file.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Номер договору має бути вказаний лише числом!");

                goto Retry;
            }

            Console.Write("Прiзище: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Iм'я: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Адреса: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Номер телефону: ");

            file.WriteLine(Console.ReadLine());

            file.Close();

            Console.WriteLine();

            Input.Read();
        }

        public static void Remove()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для видалення: ");

            bool[] remove = new bool[Program.abonents.Length];

            for (int i = 0; i < remove.Length; ++i)
            {
                remove[i] = false;
            }

            try
            {
                remove[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                Input.Read();
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                if (!remove[i])
                {
                    file.WriteLine(Program.abonents[i].Number);
                    file.WriteLine(Program.abonents[i].Surename);
                    file.WriteLine(Program.abonents[i].Number);
                    file.WriteLine(Program.abonents[i].Adress);
                    file.WriteLine(Program.abonents[i].Telephone);
                }
            }

            Console.Write("Видалено.\n");

            file.Close();

            Console.WriteLine();

            Input.Read();
        }

        public static void Edit()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для редагування: ");

            bool[] edit = new bool[Program.abonents.Length];

            for (int i = 0; i < edit.Length; ++i)
            {
                edit[i] = false;
            }

            try
            {
                edit[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                Input.Read();
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                if (edit[i])
                {
                    Console.WriteLine("\nВведiть новi данi");

                Retry:
                    Console.Write("Номер договору : ");

                    try
                    {
                        file.WriteLine(int.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Номер договору має бути вказаний лише числом!");

                        goto Retry;
                    }

                    Console.Write("Прiзище: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Iм'я: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Адреса: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Номер телефону: ");

                    file.WriteLine(Console.ReadLine());
                }
                else
                {
                    file.WriteLine(Program.abonents[i].Number);
                    file.WriteLine(Program.abonents[i].Surename);
                    file.WriteLine(Program.abonents[i].Number);
                    file.WriteLine(Program.abonents[i].Adress);
                    file.WriteLine(Program.abonents[i].Telephone);
                }
            }

            Console.Write("Змiни внесено.\n");

            file.Close();

            Console.WriteLine();

            Input.Read();
        }

        public static void Find()
        {
            Console.Write("Прiзвище: ");

            string surename = Console.ReadLine();

            Console.WriteLine(Output.Format, "Номер договору", "Прiзвище", "Iм'я", "Адреса", "Номер телефону");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                if (surename == Program.abonents[i].Surename)
                {
                    Console.WriteLine(Output.Format, Program.abonents[i].Number, Program.abonents[i].Surename, Program.abonents[i].Name, Program.abonents[i].Adress, Program.abonents[i].Telephone);
                }
            }

            Console.WriteLine();

            Input.Read();
        }

        public static void Sort()
        {
            Program.abonents = Program.abonents.OrderBy(x => x.Number).ToArray();

            Output.Write();

            Console.WriteLine();

            Input.Read();
        }

        public static void Initialisation(string allBase)
        {
            string[] elements = allBase.Split("\r\n",StringSplitOptions.RemoveEmptyEntries);

            Program.abonents = new Abonent[elements.Length / 5];

            for (int i = 0; i < elements.Length; i += 5)
            {
                Program.abonents[i / 5] = new Abonent(int.Parse(elements[i]), elements[i + 1], elements[i + 2], elements[i + 3], elements[i + 4]);
            }
        }
    }
}

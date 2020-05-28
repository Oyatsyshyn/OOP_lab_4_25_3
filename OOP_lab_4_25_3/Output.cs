using System;

namespace OOP_lab_4_25_3
{
    class Output
    {
        public const string Format = "{0, -20} {1, -20} {2, -20} {3, -30} {4, -15}";

        public static void Write()
        {
            Console.WriteLine(Format, "Номер договору", "Прiзвище", "Iм'я", "Адреса", "Номер телефону");

            for (int i = 0; i < Program.abonents.Length; ++i)
            {
                Console.WriteLine(Format, Program.abonents[i].Number, Program.abonents[i].Surename, Program.abonents[i].Name, Program.abonents[i].Adress, Program.abonents[i].Telephone);
            }
        }
    }
}

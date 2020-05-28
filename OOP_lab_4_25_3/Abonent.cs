using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_25_3
{
    class Abonent
    {
        private int _number;
        private string _surename;
        private string _name;
        private string _adress;
        private string _telephone;

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public string Surename
        {
            get => _surename;
            set => _surename = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Adress
        {
            get => _adress;
            set => _adress = value;
        }

        public string Telephone
        {
            get => _telephone;
            set => _telephone = value;
        }

        private static string UkrainianI(string str)
        {
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; ++i)
            {
                if (ch[i] == '?')
                {
                    ch[i] = 'i';
                }
            }

            return new string(ch);
        }

        public Abonent()
        {
            _number = 0;
            _surename = "Не вказано";
            _name = "Не вказано";
            _adress = "Не вказано";
            _telephone = "Не вказано";
        }

        public Abonent(int number, string surename, string name, string adress, string telephone)
        {
            _number = number;
            _surename = surename;
            _name = name;
            _adress = adress;
            _telephone = telephone;
        }
    }
}

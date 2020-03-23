using System;
using System.Collections.Generic;
using System.Text;

namespace PluginReader
{
    public class PersonInfo : IInfoReader
    {
        private int _age = 0;
        public string Name { get; set; }
        public string SecondName { get; set; }
        private int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (BirthDate > DateTime.Now)
                {
                    _age = BirthDate.Year - DateTime.Now.Year;
                }
                else
                {
                    Console.WriteLine("Error. Unccorent age. Default age - 18 y.o.");
                    _age = 18;

                    throw new Exception();
                }
            }
        }
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
        public string Profession { get; set; }

        public PersonInfo(string name, string secondName, DateTime birthDate, string phoneNumber, string profession)
        {
            Name = name;
            SecondName = secondName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            Profession = profession;
        }

        public void GetBiogrphy()
        {
            Console.WriteLine(
                $"Name - {Name},\n" +
                $"Second name - {SecondName},\n" +
                $"Age - {Age},\n" +
                $"Profession - {Profession},\n" +
                $"Phone number - {PhoneNumber}.\n");
        }

        public void ShowMes()
        {
            string s = "";
        }
    }
}

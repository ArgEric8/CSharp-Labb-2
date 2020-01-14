using System;

namespace Labb2
{
    class Person
    {
        protected string yourName = "Namnlös";
        protected int yourAge = 99;
        protected string yourGender = "kön ej angivet";

        public Person() {}
        public Person(string fullName, int age)
        {
            yourName = fullName;
            yourAge = age;
            setGender();
        }

        public void setPersonDetails()
        {
            Console.WriteLine("Skriv in namn");
            string fullName = Console.ReadLine();
            Console.WriteLine("Skriv in ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            yourName = fullName;
            yourAge = age;
            setGender();
        }

        public void getPersonDetails()
        {
            Console.WriteLine("{0} är {1} år ({2}).", yourName, yourAge, yourGender);
        }
        public void setFullName(string fullName)
        {
            yourName = fullName;
        }

        public void setAge(int age)
        {
            yourAge = age;
        }

        public void setGender()
        {
            int genderChoice = 0;
            while (genderChoice > 3 || genderChoice == 0)
            {
                Console.WriteLine("\nVälj kön");
                Console.WriteLine("1. Man");
                Console.WriteLine("2. Kvinna");
                Console.WriteLine("3. Vill inte ange");
                bool isNumber = int.TryParse(Console.ReadLine(), out genderChoice);

                if (isNumber == false)
                {
                    Console.WriteLine("Endast siffror tas emot");
                    continue;
                }
                else if (genderChoice == 1)
                {
                    yourGender = "man";
                }
                else if (genderChoice == 2)
                {
                    yourGender = "kvinna";
                }
                else if (genderChoice == 3)
                {
                    yourGender = "kön ej angivet";
                }
                else 
                {
                    Console.WriteLine("Ditt val existerar inte.");
                    continue;
                }
            }
            Console.WriteLine("");
        }

        public void hairFeatures()
        {
            Console.WriteLine("Hårlängd?");
            int hairLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hårfärg?");
            string hairColor = Console.ReadLine();
        }
    }
}
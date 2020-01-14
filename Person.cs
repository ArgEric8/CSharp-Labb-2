using System;
using System.Globalization;

namespace Labb2
{
    struct hairDetails
        {
            public string color;
            public int length;
        }
    class Person
    {
        private string yourName;
        protected int yourAge;
        protected string yourGender;
        protected string yourEyeColor;
        protected hairDetails yourHair;
        DateTime yourBirthday = new DateTime();

        public Person() {Console.WriteLine("\nPerson skapad");}

        public void setPersonDetails()
        {
            setName();
            setAge();
            setHair();
            setGender(); 
            setBirthday();  
            setEyeColor();
        }

        public void getPersonDetails()
        {
            Console.WriteLine("{0} är {1} år ({2}), född {3}.", yourName, yourAge, yourGender, yourBirthday.ToString("yy-MMM-dd"));
            Console.WriteLine("{0} hårfärg och {1} cm långt med {2} ögon.", yourHair.color, yourHair.length, yourEyeColor);
        }

        public void setBirthday() {
            Console.WriteLine("Ange födelsedag yy-mm-dd");
            string birthdayInput = Console.ReadLine();
            yourBirthday = DateTime.ParseExact(birthdayInput, "yyMMdd", CultureInfo.InvariantCulture);
        }
        public void setHair() {
            Console.WriteLine("Ange hårfärg");
            yourHair.color = Console.ReadLine();
            Console.WriteLine("Ange hårlängd i cm");
            yourHair.length = int.Parse(Console.ReadLine());
        }
        // public string Yourname { get => yourName; set => yourName = value; }
        public void setName()
        {
            Console.WriteLine("Skriv in namn");
            string name = Console.ReadLine();
            yourName = name;
        }

        public void setAge()
        {
            Console.WriteLine("Skriv in ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            yourAge = age;
        }

        public void setEyeColor()
        {
            Console.WriteLine("Ange ögonfärg");
            string eyeColor = Console.ReadLine();
            yourEyeColor = eyeColor;
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
    }
}
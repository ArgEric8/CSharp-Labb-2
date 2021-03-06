﻿using System;
using System.Collections.Generic;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            while (userInput != 5)
            {
            Console.WriteLine("\n1. Visa gångertabell");
            Console.WriteLine("2. Räkna ut summan och medelvärdet av tal");
            Console.WriteLine("3. Tio slumpmässiga tal");            
            Console.WriteLine("4. Lägg till personer");
            Console.WriteLine("5. Avsluta");
            Console.WriteLine("\nVälj ett alternativ!");

            bool letter = int.TryParse(Console.ReadLine(), out userInput);
            if (letter == true)
            {
                // Första valet
                if (userInput == 1)
                {
                    firstChoice();
                }

                // Andra valet
                if (userInput == 2)
                {
                    secondChoice();
                }

                // Tredje valet
                if (userInput == 3)
                {
                    thirdChoice();
                }

                // Fjärde valet
                if (userInput == 4)
                {
                    fourthChoice();
                }

                // Femte valet
                if (userInput == 5)
                {
                    Console.WriteLine("\nAvslutar...");
                    break;
                }
            }
            else
                {
                    Console.WriteLine("Inga bokstäver tillåts");
                }
            }
        }

        // Metoder
        static void firstChoice ()
        {
            Console.WriteLine("\nGångertabellen:");
            for (int y = 1; y < 11; y++)
            {
                Console.WriteLine("\n");
                for (int x = 1; x < 11; x++)
                {
                    Console.Write("{0,5}", x * y);
                }
            }
        
        }

        static void secondChoice ()
        {
            Console.WriteLine("\nAnge fem tal");
                double[] femTal = new double[5];
                double sum = 0;

                for (int i = 0; i < femTal.Length; i++)
                {
                    if (double.TryParse(Console.ReadLine(), out femTal[i]))
                        {
                            sum += femTal[i];
                        }
                    else
                    {
                        i--;
                        Console.WriteLine("Inga bokstäver, tack.");
                    }
                }

                double högstVärde = femTal[0];
                double lägstVärde = femTal[0];
                for (int j = 0; j < femTal.Length; j++)
                    {
                        if (högstVärde < femTal[j])
                        {
                            högstVärde = femTal[j];
                        }

                        if (lägstVärde > femTal[j])
                        {
                            lägstVärde = femTal[j];
                        }
                    }

                double medelVärde = sum / femTal.Length;
                Console.WriteLine("\nSumman är {0:0.#}.", sum);
                Console.WriteLine("Medelvärdet är {0:0.##}.", medelVärde);
                Console.WriteLine("Högsta värdet är {0} och lägsta värdet är {1}.", högstVärde, lägstVärde);
        }

        static void thirdChoice ()
        {
            int[] randomTal = new int[10];
                    Random randomSiffra = new Random();

                    Console.WriteLine("Dina tio slumpmässiga tal är följande");
                    for (int i = 0; i < randomTal.Length; i++)
                    {
                        randomTal[i] = randomSiffra.Next(10, 51);
                    }

                    for (int i = 0; i < randomTal.Length; i++)
                    {
                        Array.Sort(randomTal);
                        Array.Reverse(randomTal);
                        Console.WriteLine("{0}", randomTal[i]);
                    }
        }

        static void fourthChoice ()
        {
            List<Person> people = new List<Person>();
            int anotherPerson = 1;
            while (anotherPerson == 1)
            {
                Person person1 = new Person();
                person1.setPersonDetails();

                if (anotherPerson == 1)
                {
                    Console.WriteLine("Vill du lägga till fler?");
                    Console.WriteLine("1. Ja");
                    Console.WriteLine("2. Nej");
                    anotherPerson = Convert.ToInt32(Console.ReadLine());
                    people.Add(person1); 
                }
            }

            // Console.WriteLine("1. Visa lista på alla personer");
            // Console.WriteLine("2. Gå vidare");
            // int showlist = int.Parse(Console.ReadLine());
            // if (showlist == 1) {
                for (int i = 0; i < people.Count; i++)
                    {
                        people[i].getPersonDetails();
                }
            // }
        }
    }
}
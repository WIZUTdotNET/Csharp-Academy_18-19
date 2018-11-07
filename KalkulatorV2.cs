
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV1
{
    class Program
    {

        static void Main(string[] args)
        {
            int ile;
            int a;
            int b;
            int co;
            int i;
            int silnia_jeden;
            int silnia_dwa;
            int silnia = 1;

            Console.WriteLine("Ile liczb chcesz podać?");

            ile = Int32.Parse(Console.ReadLine());
            if (ile == 0)
            {
                Console.WriteLine("Do widzenia");
            }
            else if (ile == 1)
            {
                Console.WriteLine("Podaj jedną liczbę a obliczę jej silnię");
                a = Int32.Parse(Console.ReadLine());
                silnia_jeden = a;
                for (i = 1; i <= silnia_jeden; i++)
                {
                    silnia = silnia * i;
                }
                Console.WriteLine($"Silnia z {a} = {silnia}");
            }
            else if (ile == 2)
            {
                Console.WriteLine("Podaj dwie liczby");
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());

                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Modulo");
                Console.WriteLine("6. Silnia");

                co = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (co)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez 0!");
                        }
                        else
                        {
                            Console.WriteLine($"{a} / {b} = {a / b}");
                        }
                        break;
                    case 5:
                        if (b == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez 0!");
                        }
                        else
                        {
                            Console.WriteLine($"{a} modulo {b} = {a % b}");
                        }
                        break;
                    case 6: //silnia
                        //pierwsza
                        silnia_jeden = a;
                        for (i = 1; i <= silnia_jeden; i++)
                        {
                            silnia = silnia * i;
                        }
                        Console.WriteLine($"Silnia z  {a} = {silnia}");

                        //druga
                        silnia_dwa = b;
                        silnia = 1;
                        for (i = 1; i <= silnia_dwa; i++)
                        {
                            silnia = silnia * i;
                        }
                        Console.WriteLine($"Silnia z  {b} = {silnia}");
                        break;

                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                }

            }
            else // gdy użytkownik poda coś innego niż 0, 1 i 2
            {
                Console.WriteLine("Mogę tego nie ogarnąć");
            }
            System.Console.ReadKey();
        }
    }
}


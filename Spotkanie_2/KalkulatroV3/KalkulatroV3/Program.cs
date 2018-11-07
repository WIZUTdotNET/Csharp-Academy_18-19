using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV1
{
    class Program
    {

        static void elo()
        {
            Console.WriteLine("Do widzenia");
        }

        static void sumnik(int a, int b)
        {
            int oddaj;
            oddaj = a + b;
            Console.WriteLine(oddaj);
        }

        static void odejmnik(int a, int b)
        {
            int oddaj;
            oddaj = a - b;
            Console.WriteLine(oddaj);
        }

        static void mnoznik(int a, int b)
        {
            
            int oddaj;
            oddaj = a * b;
            Console.WriteLine(oddaj);
        }

        static void dzielnik(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0!");
            }
            else
            {
                int oddaj;
                oddaj = a / b;
                Console.WriteLine(oddaj);
            }
        }

        static void modulnik(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0!");
            }
            else
            {
                int oddaj;
                oddaj = a % b;
                Console.WriteLine(oddaj);
            }
        }

        static void silnikjeden(int a, int i, int silnia_jeden)
        {
            int silnia = 1;

            silnia_jeden = a;
            for (i = 1; i <= silnia_jeden; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine($"Silnia z {a} = {silnia}");
        }

        static void silnikdwa(int a, int b, int i, int silnia_jeden, int silnia_dwa)
        {
            //pierwsza
            int silnia = 1;
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
        }
       static void nie_ma()
        {
            Console.WriteLine("Nie ma takiej opcji");
        }

        static void nie_ogarniam()
        {
        Console.WriteLine("Mogę tego nie ogarnąć");
        }

        static void Main(string[] args)
        {
            int ile;
            int a;
            int b;
            int co;
            int i=1;
            int silnia_jeden=0;
            int silnia_dwa=0;
            

            Console.WriteLine("Ile liczb chcesz podać?");

            ile = Int32.Parse(Console.ReadLine());
            if (ile == 0)
            {
                elo();
            }
            else if (ile == 1)
            {
                Console.WriteLine("Podaj jedną liczbę a obliczę jej silnię");
                a = Int32.Parse(Console.ReadLine());

                silnikjeden(a, i, silnia_jeden);
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
                        sumnik(a, b);
                        break;
                    case 2:
                        odejmnik(a, b);
                        break;
                    case 3:
                        mnoznik(a, b);
                        break;
                    case 4:
                        dzielnik(a, b);
                        break;
                    case 5:
                        modulnik(a, b);
                        break;
                    case 6: //silnia
                        silnikdwa(a, b, i, silnia_jeden, silnia_dwa);
                        break;

                    default:
                        nie_ma();
                        break;
                }

            }
            else // gdy użytkownik poda coś innego niż 0, 1 i 2
            {
                nie_ogarniam();
            }
            System.Console.ReadKey();
        }
    }
}



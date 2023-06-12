using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "[2] zajęcia - Norman Menes, 27058";

            Console.Write("Podaj numer zadania: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    {
                        Console.Write("Podaj liczbę do wyznaczenia przybliżenia liczby pi: ");
                        int iter = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pi = " + zadanie1(iter));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Podaj liczbę: ");
                        ulong liczba = ulong.Parse(Console.ReadLine());
                        zadanie2(liczba);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Podaj liczbę: ");
                        ulong liczba = ulong.Parse(Console.ReadLine());
                        Console.Write("Podaj kierunek przesunięcia (L / R): ");
                        char znak = char.Parse(Console.ReadLine());
                        zadanie2(liczba);
                        zadanie2(zadanie3(liczba, znak));
                        break;
                    }
                case 4:
                    {
                        Console.Write("Podaj liczbę: ");
                        ulong liczba = ulong.Parse(Console.ReadLine());
                        Console.Write("Podaj n: ");
                        int n = int.Parse(Console.ReadLine());
                        zadanie2(liczba);
                        zadanie2(zadanie4(liczba, n));
                        break;
                    }
                case 5:
                    {
                        zadanie5();
                        break;
                    }
                default:
                    Console.WriteLine("Podano zły numer zadania!");
                    break;
            }
        }

        static double zadanie1(int iter)
        {
            double pi = 0;
            for (int i = 0; i <= iter; ++i)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            pi *= 4;
            return pi;
        }

        static void zadanie2(ulong liczba)
        {
            const int liczbaBitowWZmiennej = 64;
            // zadanie zrobiłem dla liczby 8 bajtowej, a nie 8 bitowej
            //string binary = Convert.ToString(liczba, 2);  // można dla int
            ulong mask = 0x8000000000000000;
            for (int i = 0; i < liczbaBitowWZmiennej; ++i)
            {
                if ((liczba & mask) != 0) Console.Write("1");
                else Console.Write("0");
                mask >>= 1;
            }
            Console.Write("\n");
        }

        static ulong zadanie3(ulong liczba, char znak)
        {
            if (znak == 'L') return liczba << 1;
            else if (znak == 'R') return liczba >> 1;
            else
            {
                Console.WriteLine("Podano błędny kierunek!");
                Environment.Exit(1);
                return 0;
            }
        }

        static ulong zadanie4(ulong liczba, int n)
        {
            return (liczba << n) | (liczba >> (64 - n));
        }

        enum kodyKrajow
        {
            Polska = 48,
            Niemcy = 49,
            Slowacja = 421,
            Czechy = 420
        }
        static void zadanie5()
        {
            Console.WriteLine($"{(int)kodyKrajow.Polska}\t{kodyKrajow.Polska}");
            Console.WriteLine($"{(int)kodyKrajow.Niemcy}\t{kodyKrajow.Niemcy}");
            Console.WriteLine($"{(int)kodyKrajow.Slowacja}\t{kodyKrajow.Slowacja}");
            Console.WriteLine($"{(int)kodyKrajow.Czechy}\t{kodyKrajow.Czechy}");
        }
    }
}
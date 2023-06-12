using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "[1] zajęcia - Norman Menes, 27058";

            Console.Write("Podaj numer zadania: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    zadanie1();
                    break;
                case 2:
                    zadanie2();
                    break;
                case 3:
                    zadanie3();
                    break;
                case 4:
                    zadanie4();
                    break;
                case 5:
                    zadanie5();
                    break;
                default:
                    Console.WriteLine("Podano zły numer zadania!");
                    break;
            }
        }

        static void zadanie1()
        {
            Console.Write("Podaj imię: ");
            string x = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string y = Console.ReadLine();
            Console.Write("Podaj wiek: ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Użytkownik " + x + " " + y + " ma " + z + " lat");
        }

        static void zadanie2()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.WriteLine("A B | Y");
            Console.WriteLine("–––––––");
            Console.WriteLine("0 0 | 0");
            Console.WriteLine("0 1 | 0");
            Console.WriteLine("1 0 | 0");
            Console.WriteLine("1 1 | 1");
        }

        static void zadanie3()
        {
            Console.Write("Podaj wysokość choinki: ");
            int wysokosc = int.Parse(Console.ReadLine());
            const int k_MiejsceKursora = 70;
            int miejsceKursora = k_MiejsceKursora;
            Console.CursorLeft = miejsceKursora;
            for (int i = 1; i <= wysokosc; i++)
            {
                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                miejsceKursora--;
                Console.CursorLeft = miejsceKursora;
            }
            Console.CursorLeft = k_MiejsceKursora;
            Console.WriteLine("#");
        }

        static void zadanie4()
        {
            Console.Write("Podaj zakres od: ");
            int zakresOd = int.Parse(Console.ReadLine());
            Console.Write("Podaj zakres do: ");
            int zakresDo = int.Parse(Console.ReadLine());
            int wielkoscTabeli = zakresDo - zakresOd + 2;
            int[,] tab = new int[wielkoscTabeli, wielkoscTabeli];

            // stworzenie pierwszej kolumny
            int pom = zakresOd;
            for (int i = 0; i < wielkoscTabeli; i++)
            {
                if (i == 0) tab[i, 0] = 0;
                else
                {
                    tab[i, 0] = pom;
                    pom++;
                }
            }

            // stworzenie górnego wiersza
            pom = zakresOd;
            for (int j = 0; j < wielkoscTabeli; j++)
            {
                if (j == 0) tab[0, j] = 0;
                else
                {
                    tab[0, j] = pom;
                    pom++;
                }
            }

            // obliczanie
            for (int i = 1; i < wielkoscTabeli; i++)
            {
                for (int j = 1; j < wielkoscTabeli; j++)
                {
                    tab[i, j] = tab[i, 0] * tab[0, j];
                }
            }

            // wyświetlanie
            const int k_MiejsceKursora = 0;
            for (int i = 0; i < wielkoscTabeli; i++)
            {
                int miejsceKursora = k_MiejsceKursora;
                for (int j = 0; j < wielkoscTabeli; j++)
                {
                    Console.CursorLeft = miejsceKursora;
                    Console.Write(tab[i, j]);
                    miejsceKursora += 7;
                }
                Console.Write("\n");
            }
        }

        static void zadanie5()
        {
            int suma = 0;
            int [] tab = new int[10];

            Console.WriteLine("Wprowadź wartości tablicy:");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
                suma = suma + tab[i];
            }

            Console.Clear();
            Console.WriteLine("Tablica:");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
                if (i == tab.Length - 1) Console.Write("\n");
            }
            Console.WriteLine("Min = " + tab.Min());
            Console.WriteLine("Max = " + tab.Max());
            Console.WriteLine("Suma = " + tab.Sum());
            Console.WriteLine("Średnia = " + tab.Average());
            Console.WriteLine("Średnia = " + (double)suma/10);      // z konwersją na typ double
        }
    }
}
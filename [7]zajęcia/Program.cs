using System;

namespace _7_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "[7] zajęcia - Norman Menes, 27058";

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
                default:
                    Console.WriteLine("Podano zły numer zadania!");
                    break;
            }
        }

        static void zadanie1()
        {
            Console.Write("Podaj numer podzadania: ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    wyjatki1 wyjatek1 = new wyjatki1();
                    break;
                case 2:
                    wyjatki2 wyjatek2 = new wyjatki2();
                    break;
                case 3:
                    try
                    {
                        Divide1 wyjatek3 = new Divide1(-1);
                        Console.WriteLine(wyjatek3.Result());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    try
                    {
                        Divide2 wyjatek4 = new Divide2(-1);
                        Console.WriteLine(wyjatek4.Result());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Podano zły numer zadania!");
                    break;
            }
        }

        static void zadanie2()
        {
            password password1 = new password();
        }
    }
}

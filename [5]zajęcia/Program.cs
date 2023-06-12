using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "[5] zajęcia - Norman Menes, 27058";

            Console.Write("Podaj numer zadania: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    // LIFO
                    zadanie1();
                    break;
                case 2:
                    // FIFO
                    zadanie2();
                    break;
                default:
                    Console.WriteLine("Podano zły numer zadania!");
                    break;
            }
        }

        static void zadanie1() /*LIFO*/
        {
            Stack<Person> EmployerList = new Stack<Person>(10);

            EmployerList.Push(new Person("Jan", "Kowalski", 1234));
            EmployerList.Push(new Person("Anna", "Nowak", 5678));
            EmployerList.Push(new Person("Jan", "Zet", 9101));

            Console.WriteLine("PRZED SORTOWANIEM\r\n");
            Console.WriteLine(EmployerList.Pop());
            Console.WriteLine(EmployerList.Pop());
            Console.WriteLine(EmployerList.Pop());

            EmployerList.Push(new Person("Jan", "Kowalski", 1234));
            EmployerList.Push(new Person("Anna", "Nowak", 5678));
            EmployerList.Push(new Person("Jan", "Zet", 9101));

            EmployerList.Sort();

            Console.WriteLine("PO SORTOWANIU\r\n");
            Console.WriteLine(EmployerList.Pop());
            Console.WriteLine(EmployerList.Pop());
            Console.WriteLine(EmployerList.Pop());
        }

        static void zadanie2()  /*FIFO*/
        // bufor wydruku
        {
            const uint maxSizePrintBuffer = 5;
            PrintBuffer<PrintFile> PrintBuffer = new PrintBuffer<PrintFile>(maxSizePrintBuffer);

            // WYSYŁANIE PLIKÓW DO DRUKU
            Console.WriteLine("\nWYSYŁANIE PLIKÓW DO DRUKU");
            Console.WriteLine("========================================================");
            PrintBuffer.Enqueue(new PrintFile("plikA.txt", 1, "Norman Menes", "07.12.2022 20:01:05"));
            PrintBuffer.Enqueue(new PrintFile("plikB.txt", 1, "Adam Woźny", "07.12.2022 20:02:05"));
            PrintBuffer.Enqueue(new PrintFile("plikC.txt", 1, "Agnieszka Nowak", "07.12.2022 18:50:05"));
            PrintBuffer.Enqueue(new PrintFile("plikD.txt", 1, "Michalina Woźniak", "07.12.2022 20:04:05"));
            PrintBuffer.Enqueue(new PrintFile("plikE.txt", 1, "Ewa Mały", "07.12.2022 20:05:05"));
            PrintBuffer.Enqueue(new PrintFile("plikF.txt", 1, "Norman Menes", "07.12.2022 15:30:05"));  // przepełnienie bufora
            PrintBuffer.Enqueue(new PrintFile("plikG.txt", 1, "Robert Woźny", "07.12.2022 20:15:05"));  // przepełnienie bufora

            // WYŚWIETLENIE PIERWSZEGO PLIKU W KOLEJCE
            Console.WriteLine("\nPIERWSZY PLIK W KOLEJCE");
            Console.WriteLine("========================================================");
            Console.WriteLine(PrintBuffer.Peak());
            Console.WriteLine(PrintBuffer.Peak());  // ten sam wynik co powyżej

            // SORTOWANIE
            // zmiana kolejności wydruku. W pierwszej kolejności mają wydrukować się pliki z najpóźniejszą datą wysłania
            PrintBuffer.Sort();

            // DRUK
            Console.WriteLine("\nDRUK");
            Console.WriteLine("========================================================");
            PrintBuffer.Print();
            PrintBuffer.Print();
            PrintBuffer.Print();
            PrintBuffer.Print();
            PrintBuffer.Print();
            PrintBuffer.Print();    // pusty bufor
            PrintBuffer.Print();    // pusty bufor
        }
    }
}

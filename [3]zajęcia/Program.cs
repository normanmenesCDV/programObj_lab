using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "[3] zajęcia - Norman Menes, 27058";

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
            Complex cmp1 = new Complex(4, -5);
            Complex cmp2 = new Complex(1, -1);
            Complex cmp3 = cmp1 * cmp2;

            cmp3.print();
            Console.WriteLine("Wynik mnożenia dwóch liczb zespolonych to: " + cmp1 * cmp2);
            // Wynik mnożenia dwóch liczb zespolonych to: _3_zajęcia.Complex --> taki pojawi się wynik przy braku funkcji 'public override string ToString()'
            Console.WriteLine(cmp2.mod());
            Console.WriteLine(cmp1+cmp2);
        }

        static void zadanie2()
        {
            //Matrix x = new Matrix(/*path*/)
            Matrix A = new Matrix("matrixA.txt");
            Matrix B = new Matrix("matrixB.txt");
            A.show("A");
            B.show("B");

            Matrix T = A.transposition();
            T.show("A_T");

            Matrix Add = A + B;
            if (Add != null) Add.show("Add");

            Matrix Multi = A * B;
            if (Multi != null) Multi.show("Multi");
        }

    }
}
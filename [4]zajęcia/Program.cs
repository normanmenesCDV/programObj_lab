using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "[4] zajęcia - Norman Menes, 27058";

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
            Sphere[] spheres = new Sphere[3];
            spheres[0] = new Conic(5, 2);
            spheres[1] = new Cuboid(10, 10, 10);
            spheres[2] = new Cuboid(2, 3, 4);

            foreach (Sphere element in spheres)
            {
                Console.WriteLine(element.Volume());
            }
        }

        static void zadanie2()
        {
            Employer[] employers = new Employer[3];
            employers[0] = new Manager("Norman", "Menes", "2022-09-01", 8530.00, 3);
            employers[1] = new Accountant("Agnieszka", "Rachmistrz", "2018-10-02", 3200.00, 1);
            employers[2] = new Engineer("Adam", "Zaradny", "2020-03-01", 4100.08, 28);

            // podwyżka 2022-12-06
            {
                Console.WriteLine("PODWYŻKA 2022-12-06");
                Console.WriteLine(employers[1].Name + " " + employers[1].Surname + "\n" + "Obecne zarobki: " + employers[1].Salary);
                employers[1].Salary = 3540.93;
                Console.WriteLine("Nowe zarobki: " + employers[1].Salary);
                Console.WriteLine("---");
                Console.WriteLine(employers[0].Name + " " + employers[0].Surname + "\n" + "Obecne zarobki: " + employers[0].Salary);
                employers[0].rise(1.5);
                Console.WriteLine("Nowe zarobki: " + employers[0].Salary);
                Console.WriteLine();
            }

            Console.WriteLine("LISTA PRACOWNIKÓW");
            foreach (Employer element in employers)
            {
                element.display();
            }
        }
    }
}

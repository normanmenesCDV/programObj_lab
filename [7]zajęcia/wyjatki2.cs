using System;
using System.Collections.Generic;
using System.Text;

namespace _7_zajęcia
{
    class wyjatki2
    {
        public wyjatki2()
        {
            try
            {
                int[] tab = new int[] { 1, 2, 3, 4 };

                for (int i = 0; i <= 4; i++)
                {
                    Console.Write("Podaj liczbę: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(
                        "tab[" + i + "] / " + x + " = \n" +
                        tab[i] + " / " + x + " = " +
                        + (double)tab[i] / x
                    );
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program się zakończył!");
            }
            Console.ReadKey();
        }
    }
}

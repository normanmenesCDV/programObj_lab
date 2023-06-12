using System;
using System.Collections.Generic;
using System.Text;

namespace _7_zajęcia
{
    class wyjatki1
    {
        public wyjatki1()
        {
            try
            {
                int[] tab = new int[] { 1, 2, 3, 4 };

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(tab[i]);

                }
            }
            // wersja 1
            //catch (Exception)
            //{
             //   Console.WriteLine("Element poza obszarem tablicy");
            //}

            // wersja 2
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            // wersja 3
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

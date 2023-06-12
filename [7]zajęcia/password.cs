using System;
using System.Collections.Generic;
using System.Text;

namespace _7_zajęcia
{
    public class ZaKrotkieHaslo : Exception
    {
        public ZaKrotkieHaslo (string message) : base (message) { }
    }

    public class BladDuzychLiter : Exception
    {
        public BladDuzychLiter(string message) : base(message) { }
    }
    
    public class BladZnakowNumerycznych : Exception
    {
        public BladZnakowNumerycznych(string message) : base(message) { }
    }

    public class BladZnakowSpecjalnych : Exception
    {
        public BladZnakowSpecjalnych(string message) : base(message) { }
    }

    public class BledneHaslo : Exception
    {
        public BledneHaslo(string message) : base(message) { }
    }

    class password
    {
        private string pass;
        private const uint
            minLiczbaZnakow = 8,
            minLiczbaDuzychLiter = 1,
            minLiczbaMalychLiter = 0,
            minLiczbaZnakowNumerycznych = 1,
            minLiczbaZnakowSpecjalnych = 1,
            maxLiczbaProbWprowadzeniaHasla = 3;
        private char[] znakiSpecjalne = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '`', '~', '[', '{', ']', '}', '\\', '|', ';', ':', '\'', '\"', ',', '<', '.', '>', '/', '?', ' '};

        public password()
        {
            Console.WriteLine("Hasło powinno składać się z przynajmniej 8 znaków i zawierać:\n* mininum jedną dużą literę,\n* jeden znak specjalny,\n* jedną liczbę");
            Console.Write("Podaj hasło: ");
            pass = Console.ReadLine();
            testNowegoHasla();

            wprowadzHaslo();
            Console.Clear();
            Console.WriteLine("Logowanie przebiegło pomyślnie!");
        }
        private void testNowegoHasla()
        {
            try
            {
                testNowegoHasla_DlugoscHasla();
                testNowegoHasla_DuzeLitery();
                testNowegoHasla_ZnakiNumeryczne();
                testNowegoHasla_ZnakiSpecjalne();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
        }

        private void testNowegoHasla_DlugoscHasla()
        {
            if (pass.Length < minLiczbaZnakow) throw new ZaKrotkieHaslo("Podane hasło jest zbyt krótkie");
        }

        private void testNowegoHasla_DuzeLitery()
        {
            uint licznik = 0;
            foreach(var value in pass)
            {
                if (value >= 'A' && value <= 'Z') licznik++;
            }
            if (licznik < minLiczbaDuzychLiter) throw new BladDuzychLiter("Nie podano wystarczającej liczby dużych liter");
        }

        private void testNowegoHasla_ZnakiNumeryczne()
        {
            uint licznik = 0;
            foreach (var value in pass)
            {
                if (value >= '0' && value <= '9') licznik++;
            }
            if (licznik < minLiczbaZnakowNumerycznych) throw new BladZnakowNumerycznych("Nie podano wystarczającej liczby znaków numerycznych");
        }

        private void testNowegoHasla_ZnakiSpecjalne()
        {
            uint licznik = 0;
            foreach (var value in pass)
            {
                foreach(var znakSpecjalny in znakiSpecjalne)
                {
                    if (value == znakSpecjalny)
                    {
                        licznik++;
                        break;
                    }
                }
            }
            if (licznik < minLiczbaZnakowSpecjalnych) throw new BladZnakowSpecjalnych("Nie podano wystarczającej liczby znaków specjalnych");
        }

        private void wprowadzHaslo()
        {
            Console.Clear();
            string passEntered;
            for (uint licznikProb = 1; licznikProb != 0; licznikProb++)
            {
                Console.Write("Podaj hasło: ");
                passEntered = Console.ReadLine();
                try
                {
                    wprowadzHaslo_sprawdzHaslo(passEntered, licznikProb);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void wprowadzHaslo_sprawdzHaslo(string passEntered, uint licznikProb)
        {
            if (licznikProb > maxLiczbaProbWprowadzeniaHasla)
            {
                Console.WriteLine("Podałeś " + maxLiczbaProbWprowadzeniaHasla + " razy nieprawidłowe hasło");
                Environment.Exit(2);
            }
            else if (passEntered != pass)
            {
                throw new BledneHaslo("Podano nieprawidłowe hasło");
            }
        }
    }
}

// poprawiona wersja

using System;
using System.Collections.Generic;
using System.Text;

namespace _4_zajęcia
{
    class Employer
    {
        protected string name, surname;             // zastosowanie 'protected' umożliwia klasom dziedziczonym dostęp do tego obiektu
        protected double salary;
        protected string employment_date;

        public string Name
        {
            get { return name; }
        }
        public string Surname
        {
            get { return surname; }
        }
        public double Salary {
            get { return salary; }
            set { salary = value; }
        }
        public string Employment_date
        {
            get { return employment_date; }
        }

        public Employer(string _name = "", string _surname = "", string _employment_date = "", double _salary = 0)
        {
            name = _name;
            surname = _surname;
            salary = _salary;
            employment_date = _employment_date;
        }

        public virtual void rise(double fragment)
        { salary *= fragment; }

        public virtual void display()
        {
            Console.WriteLine("Pracownik");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Data zatrudnienia = " + employment_date);
            Console.WriteLine("Wynagrodzenie = " + salary);
            Console.WriteLine();
        }
    }

    class Manager:Employer
    {
        private int numberManager;
        public Manager(string _name = "", string _surname = "", string _employment_date = "", double _salary = 0, int _numberManager = 0)
        {
            name = _name;
            surname = _surname;
            salary = _salary;
            employment_date = _employment_date;
            numberManager = _numberManager;
        }

        public override void display()
        {
            Console.WriteLine("DYREKTOR");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Data zatrudnienia = " + employment_date);
            Console.WriteLine("Wynagrodzenie = " + salary);
            Console.WriteLine("Numer dyrektorski = " + numberManager);
            Console.WriteLine();
        }
    }

    class Accountant:Employer
    {
        private int numberAccountant;
        public Accountant(string _name = "", string _surname = "", string _employment_date = "", double _salary = 0, int _numberAccountant = 0)
        {
            name = _name;
            surname = _surname;
            salary = _salary;
            employment_date = _employment_date;
            numberAccountant = _numberAccountant;
        }

        public override void display()
        {
            Console.WriteLine("KSIĘGOWY");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Data zatrudnienia = " + employment_date);
            Console.WriteLine("Wynagrodzenie = " + salary);
            Console.WriteLine("Numer księgowy = " + numberAccountant);
            Console.WriteLine();
        }
    }

    class Engineer:Employer
    {
        private int numberEngineer;

        public Engineer(string _name = "", string _surname = "", string _employment_date = "", double _salary = 0, int _numberEngineer = 0)
        {
            name = _name;
            surname = _surname;
            salary = _salary;
            employment_date = _employment_date;
            numberEngineer = _numberEngineer;
        }

        public override void display()
        {
            Console.WriteLine("TECHNIK");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Data zatrudnienia = " + employment_date);
            Console.WriteLine("Wynagrodzenie = " + salary);
            Console.WriteLine("Numer inżynierski = " + numberEngineer);
            Console.WriteLine();
        }
    }
}

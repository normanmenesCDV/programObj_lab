// pierwotne wykonanie - z obiektami name, surname, salary, employment_date typu 'private'

using System;
using System.Collections.Generic;
using System.Text;

namespace _4_zajęcia_STARE
{
    class Employer
    {
        private string name, surname;
        private double salary;
        private string employment_date;

        public virtual string Name
        {
            get { return name; }
        }
        public virtual string Surname
        {
            get { return surname; }
        }
        public virtual double Salary {
            get { return salary; }
            set { salary = value; }
        }
        public virtual string Employment_date
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
        private string name, surname;
        private double salary;
        private string employment_date;

        public override string Name
        {
            get { return name; }
        }
        public override string Surname
        {
            get { return surname; }
        }
        public override double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public override string Employment_date
        {
            get { return employment_date; }
        }

        public Manager(string _name = "", string _surname = "", string _employment_date = "", double _salary = 0)
        {
            name = _name;
            surname = _surname;
            salary = _salary;
            employment_date = _employment_date;
        }

        public override void rise(double fragment)
        { salary *= fragment; }

        public override void display()
        {
            Console.WriteLine("DYREKTOR");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Data zatrudnienia = " + employment_date);
            Console.WriteLine("Wynagrodzenie = " + salary);
            Console.WriteLine();
        }
    }

    class Accountant:Employer
    {
        private string name, surname;
        private double salary;
        private string employment_date;

        public override string Name
        {
            get { return name; }
        }
        public override string Surname
        {
            get { return surname; }
        }
        public override double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public override string Employment_date
        {
            get { return employment_date; }
        }

        public Accountant(string _name = "", string _surname = "", string _employment_date = "", double _salary = 0)
        {
            name = _name;
            surname = _surname;
            salary = _salary;
            employment_date = _employment_date;
        }

        public override void rise(double fragment)
        { salary *= fragment; }

        public override void display()
        {
            Console.WriteLine("KSIĘGOWY");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Data zatrudnienia = " + employment_date);
            Console.WriteLine("Wynagrodzenie = " + salary);
            Console.WriteLine();
        }
    }

    class Engineer:Employer
    {
        private string name, surname;
        private double salary;
        private string employment_date;

        public override string Name
        {
            get { return name; }
        }
        public override string Surname
        {
            get { return surname; }
        }
        public override double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public override string Employment_date
        {
            get { return employment_date; }
        }

        public Engineer(string _name = "", string _surname = "", string _employment_date = "", double _salary = 0)
        {
            name = _name;
            surname = _surname;
            salary = _salary;
            employment_date = _employment_date;
        }

        public override void rise(double fragment)
        { salary *= fragment; }

        public override void display()
        {
            Console.WriteLine("TECHNIK");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Data zatrudnienia = " + employment_date);
            Console.WriteLine("Wynagrodzenie = " + salary);
            Console.WriteLine();
        }
    }
}
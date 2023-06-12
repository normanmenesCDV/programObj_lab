using System;
using System.Collections.Generic;
using System.Text;

namespace _5_zajęcia
{
    class Person:IComparable
    {
        private string name, lastname;
        long PESEL;

        public Person(string name, string lastname, long PESEL)
        {
            this.name = name;
            this.lastname = lastname;
            this.PESEL = PESEL;
        }

        public override string ToString()           // bez tej przeciążonej metody nie wyświetli się prawidłowo lista pracowników
        {
            return ("name: " + this.name + "\r\n" +
                "lastname: " + this.lastname + "\r\n" +
                "PESEL: " + this.PESEL + "\r\n");
        }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;

            if (p != null)
            {
                if(p.lastname.CompareTo(this.lastname) == 0)
                {
                    return p.name.CompareTo(this.name);
                }
                return p.lastname.CompareTo(this.lastname);
            }
            return 0;
        }
    }
}

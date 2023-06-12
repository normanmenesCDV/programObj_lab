using System;
using System.Collections.Generic;
using System.Text;

namespace _5_zajęcia
{
    class PrintFile : IComparable, ICloneable
    {
        private string nameOfFile;
        private uint status;
        private string owner;
        private string dateOfSent, dateOfPrint;

        public uint set_status { set { status = value; } }

        public string set_dateOfPrint { set { dateOfPrint = value; } }

        public PrintFile(string nameOfFile, uint status, string owner, string dateOfSent, string dateOfPrint = "-")
        {
            this.nameOfFile = nameOfFile;
            this.status = status;
            this.owner = owner;
            this.dateOfSent = dateOfSent;
            this.dateOfPrint = dateOfPrint;
        }

        //Queue<PrintFile> q = obj as Queue<PrintFile>;

        public override string ToString()           // bez tej przeciążonej metody nie wyświetli się prawidłowo lista buforu wydruku
        {
            return ("Nazwa pliku: " + this.nameOfFile + "\r\n" +
                "Status: " + this.status + "\r\n" +
                "Właściciel: " + this.owner + "\r\n" +
                "Data przesłania: " + this.dateOfSent + "\r\n" +
                "Data wydruku: " + this.dateOfPrint + "\r\n");
        }
        
        public int CompareTo(object obj)
        {
            PrintFile p = obj as PrintFile;
            if (p != null)
            {
                return p.dateOfSent.CompareTo(this.dateOfSent);
            }
            return 0;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }


}

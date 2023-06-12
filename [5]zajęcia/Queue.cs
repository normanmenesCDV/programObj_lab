// Kolejka [FIFO]

using System;
using System.Collections.Generic;
using System.Text;

namespace _5_zajęcia
{
    class Queue<T>
    {
        protected T[] QueueTemplate = null;
        protected uint _NumOfElements = 0;
        public uint NumOfElements { get { return _NumOfElements; } }

        /*protected Queue(uint size)
        {
            QueueTemplate = new T[size];
        }*/

        protected Queue()
        {
            
        }

        protected bool isEmpty()
        {
            if (_NumOfElements == 0) return true;
            else return false;
        }

        protected bool isFull()
        {
            if (_NumOfElements >= QueueTemplate.Length) return true;
            else return false;
        }

        public void Enqueue(T element)
        {
            if (isFull() == false)
            {
                QueueTemplate[NumOfElements] = element;
                _NumOfElements++;
            }
            else Console.WriteLine("Przepełniona kolejka\n");
        }

        public void Dequeue()
        {
            if (isEmpty() == false)
            {
                Console.WriteLine(returnFirstObj());

                QueueTemplate[0] = default(T);
                for (int i = 0, j = i + 1; i < _NumOfElements - 1; i++, j++) {
                    QueueTemplate[i] = QueueTemplate[j];
                }
                _NumOfElements--;
            }
            else Console.WriteLine("Pusta kolejka");
        }

        protected T returnFirstObj()
        {
            return QueueTemplate[0];
        }

        public T Peak()
        {
            if (isEmpty() == false) return QueueTemplate[0];
            else return default(T);
        }

        public void Sort()
        {
            Array.Sort(QueueTemplate);
        }
    }

    class PrintBuffer<T>:Queue<T> where T:PrintFile, IComparable, ICloneable
    {
        public PrintBuffer(uint size)
        {
            QueueTemplate = new T[size];
        }

        public void Print()
        {
            object file = QueueTemplate[0];
            PrintFile p = file as PrintFile;
            if(isEmpty() == false)
            {
                p.set_status = (int)statusy.Wydrukowano;
                p.set_dateOfPrint = DateTime.Now.ToString();
                Dequeue();
            }
            else Console.WriteLine("Pusta kolejka");
        }

        enum statusy
        {
            Przeslano = 1,
            Blad = 2,
            Wydrukowano = 3
        }
    }
}

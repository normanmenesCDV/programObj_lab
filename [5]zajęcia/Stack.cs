// Stos [LIFO]

using System;
using System.Collections.Generic;
using System.Text;

namespace _5_zajęcia
{
    class Stack<T> where T:IComparable
    {
        T[] StackTemplate = null;
        int i = 0;

        public Stack(int size)
        {
            StackTemplate = new T[size];
        }

        private bool isEmpty()
        {
            if (i == 0) return true;
            else return false;
        }

        private bool isFull()
        {
            if (i >= StackTemplate.Length) return true;
            else return false;
        }

        public void Push(T element)
        {
            if(isFull() == false)
            {
                StackTemplate[i] = element;
                i++;
            }
        }

        public T Pop()
        {
            if (isEmpty() == false)
            {
                i--;
                return StackTemplate[i];
            }
            else return default(T);
        }

        public T Peak()
        {
            if (isEmpty() == false) return StackTemplate[i];
            else return default(T);
        }

        public void Sort()
        {
            Array.Sort(StackTemplate, 0, i);
        }
    }
}

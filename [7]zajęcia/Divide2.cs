using System;
using System.Collections.Generic;
using System.Text;

namespace _7_zajęcia
{
    public class NumberLessThanZero : Exception
    {
        public NumberLessThanZero(string message) : base(message) { }
    }
    class Divide2
    {
        private int x = 5;

        public Divide2(int y)
        {
            if (y < 0) throw new NumberLessThanZero("Numer is less than zero");
            x /= y;
        }

        public int Result()
        {
            return x;
        }
    }
}

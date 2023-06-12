using System;
using System.Collections.Generic;
using System.Text;

namespace _7_zajęcia
{
    class Divide1
    {
        private int x = 5;

        public Divide1(int y)
        {
            if (y < 0) throw new ArgumentException();
            x /= y;
        }

        public int Result()
        {
            return x;
        }
    }
}

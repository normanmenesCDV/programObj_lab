using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zajęcia
{
    class Complex
    {
        private double _real, _img;

        public Complex(double real, double img)
        {
            _real = real;
            _img = img;
        }
        
        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex(c1._real + c2._real, c1._img + c2._img);
        }

        public static Complex operator * (Complex c1, Complex c2)
        {
            return new Complex(c1._real * c2._real + (-1*c1._img*c2._img), c1._real*c2._img + c1._img*c2._real);
        }

        public double mod()
        {
            return Math.Sqrt(Math.Pow(_real, 2) + Math.Pow(_img, 2));
        }

        public override string ToString()
        {
            if (_img < 0) return (_real + "" + _img + "i");
            else return (_real + "+" + _img + "i");
        }

        public void print()
        {
            if (_img < 0) Console.WriteLine(_real + "" + _img + "i");
            else Console.WriteLine(_real + "+" + _img + "i");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _4_zajęcia
{
    class Sphere
    {
        private float x, y, z;          // środek ciężkości
        public Sphere(float _x = 0, float _y = 0, float _z = 0)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public virtual float Volume()               // Metoda WIRTUALNA w klasie bazowej - dowiązywana dynamicznie w klasach potomnych
        {
            return 0;
        }
    }

    class Cuboid:Sphere
    {
        private float a, b, c;

        public Cuboid(float _a = 0, float _b = 0, float _c = 0)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public override float Volume()          // Wariant metody wirtualnej w klasie potomnej. Ta metoda dla klasy dziedziczonej Cuboid ma pierszeństwo przed metodą Volume w klasie Sphere
        {
            return a * b * c;
        }
    }

    class Conic:Sphere
    {
        private float r, h;

        public Conic(float _r = 0, float _h = 0)
        {
            r = _r;
            h = _h;
        }

        public override float Volume()
        {
            return ((float)Math.PI*r*r*h )/ 3;
        }
    }
}

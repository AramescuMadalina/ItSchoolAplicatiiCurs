using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application20
{
    class Square : Shape
    {
        float Latura;
        public Square(float latura)
        {
            Latura = latura;
        }
        public override float GetArea()
        {
            return Latura * Latura;
        }
        public override float GetPerimeter()
        {
            return 4 * Latura;
        }
    }

    class Rectangle : Shape
    {
        float Lungime;
        float Latime;

        public Rectangle(float lungime, float latime)
        {
            Lungime = lungime;
            Latime = latime;
        }
        public override float GetArea()
        {
            return Lungime * Latime;
        }
        public override float GetPerimeter()
        {
            return 2 * (Latime + Lungime);
        }
    }

    class Circle : Shape
    {
        float Raza;

        public Circle(float raza)
        {
            Raza = raza;
        }
        public override float GetArea()
        {
            return (float)(2 * Raza * Raza * Math.PI);
        }
        public override float GetPerimeter()
        {
            return (float)(2 * Raza * Math.PI);
        }
    }
}

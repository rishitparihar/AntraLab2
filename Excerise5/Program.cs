using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerise5
{
    class Box
    {
        double length, breadth, height;

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            b1.setBreadth(5.0);
            b1.setHeight(5.0);
            b1.setLength(5.0);

            Console.WriteLine($"Volume of Box1 {b1.getVolume()}");

            Box b2 = new Box();
            b2.setBreadth(5.0);
            b2.setHeight(2.0);
            b2.setLength(44.0);

            Console.WriteLine($"Volume of Box2 {b2.getVolume()}");


            Box b3 = new Box();
            b3.setBreadth(5.0);
            b3.setHeight(5.0);
            b3.setLength(5.0);

            Console.WriteLine($"Volume of Box3 {b3.getVolume()}");


        }
    }
}

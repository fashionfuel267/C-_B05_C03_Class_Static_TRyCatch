using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03Class
{
    internal class Circle
    {
        int radius;
    public static int count;
        public Circle()
        {
            this.radius = 5;
            count++;
        }
        public Circle(int r)//constructor
        {
            this.radius = r;
            count++;
        }
        public void Area()
        {
            double a= Math.PI*radius*radius;
            Console.WriteLine($"Area of {radius} is {a}");
        }


    }
}

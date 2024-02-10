using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            c.Area();//object/instance level
            Circle c1 = new Circle(30);
            c1.Area();
            Console.WriteLine($"Circle's object created {Circle.count} times");
            Console.ReadKey();
        }
    }


}

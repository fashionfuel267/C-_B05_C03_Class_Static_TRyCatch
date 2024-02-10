using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_EException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Div(9, 0);
            Console.ReadKey();

        }
        public static  void  Div(int x, int y)
        {
            try
            {
                Console.WriteLine(x / y);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

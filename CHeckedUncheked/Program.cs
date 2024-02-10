using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHeckedUncheked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            Console.WriteLine(x);
            try
            {
                int result = x / 0;
                checked
                {
                    int y = x++;

                }
               
            }
            catch (DivideByZeroException oex)
            {
                Console.WriteLine(oex.Message);
            }
            catch (OverflowException oex)
            {
                Console.WriteLine(oex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
}

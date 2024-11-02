using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarsTMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 24, b = 36, c=72, d=96;

            int ab = ekub(a, b);
            int cd= ekub(d, c);
            int natija = ekub(ab, cd);
            
            Console.WriteLine("ekub = "+ natija);
            Console.ReadKey();  

        }
        public static int ekub(int a,int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;

        }



    }
}

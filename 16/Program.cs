using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static bool Espositivo(int n)
        {
            bool resultado = false;
            if (n > 0)
            {
                Console.WriteLine($"{n} es positivo");
                resultado = true;
            }
            else
            {
                Console.WriteLine($"{n} es negatido");
                resultado = false;
            }

        }
        static void Main(string[] args)
        {
        }
    }
}

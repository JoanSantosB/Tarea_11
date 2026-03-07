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
                Console.WriteLine($"{n} es negativo");
                resultado = false;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int number=int.Parse(Console.ReadLine());
            Espositivo(number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int factorial = 1; ;
            for (int i = 1; i <= n; i++)
            {
                factorial*= i;
            }
            Console.WriteLine($"El factorial de {n} es: {factorial}");
            return factorial;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Factorial(number);
            }
            else
            {
                Console.WriteLine("No se puede de calcular el factorial de un número negativo");
            }
        }
    }
}

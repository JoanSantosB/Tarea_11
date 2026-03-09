using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Program
    {
        static bool EsPrimo(int n)
        {
            bool primo = true;
            if (n <= 1)
            {
                primo = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        primo = false; break;
                    }
                }
            }
            if( primo)
            {
                Console.WriteLine($"El número {n} es un número primo");
            }
            else
            {
                Console.WriteLine($"El número {n} no es un número primo");
            }
            return primo;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                EsPrimo(number);
            }
            else
            {
                Console.WriteLine("El número debe ser un número positivo");
            }
        }
    }
}

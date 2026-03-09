using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    internal class Program
    {
        static int SumarDel1AlN(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma es: {suma}");
            return suma;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int number=int.Parse(Console.ReadLine());
            if (number > 0)
            {
                SumarDel1AlN(number);
            }
            else
            {
                Console.WriteLine("Error, deben ser números positivos");
            }
        }
    }
}

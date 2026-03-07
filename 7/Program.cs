using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void MostrarDoble(int n)
        {
            int resultado = n * 2;
            Console.WriteLine($"El doble es: {resultado}");
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int number=int.Parse(Console.ReadLine());
            MostrarDoble(number);
        }
    }
}

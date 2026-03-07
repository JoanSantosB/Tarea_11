using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void MostrarCuadrado(int n)
        {
            int resultado = n*n;
            Console.WriteLine($"El cuadrado del número es: {resultado}");
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int number=int.Parse(Console.ReadLine());
            MostrarCuadrado(number);
        }
    }
}

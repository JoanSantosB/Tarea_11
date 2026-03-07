using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static int Sumar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"El resultado es: {resultado}");
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primero número: ");
            int number1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int number2=int.Parse(Console.ReadLine());
            Sumar(number1, number2);
        }
    }
}

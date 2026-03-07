using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static double Dividir(double a, double b)
        {
            double resultado = a / b;
            Console.WriteLine($"El resultado es: {resultado}");
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            double number1=double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double number2=double.Parse(Console.ReadLine());
            if (number2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                Dividir(number1, number2);
            }
        }
    }
}

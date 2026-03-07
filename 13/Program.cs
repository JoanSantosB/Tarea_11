using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"El resultado es: {resultado}");
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primero número: ");
            int number1 = int.Parse(Console.ReadLine());
            if( number1 == 0)
            {
                Console.WriteLine("No se puede multiplicar por 0");
            }
            else
            {
                Console.Write("Ingrese el segundo número: ");
                int number2 = int.Parse(Console.ReadLine());
                if( number2 == 0)
                {
                    Console.WriteLine("No se puede multiplicar por 0");
                }
                else
                {
                    Multiplicar(number1, number2);
                }
            }
        }
    }
}

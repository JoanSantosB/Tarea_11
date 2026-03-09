using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static int MenorDeTres(int a, int b, int c)
        {
            int menor = 0;
            if (a <= b && a <= c)
            {
                menor = a;
                Console.WriteLine($"El número menor es: {menor}");
            }
            else if (b < a && b < c)
            {
                menor = b;
                Console.WriteLine($"El número menor es: {menor}");
            }
            else if(c <= a&&c <= b) 
            {
                menor = c;
                Console.WriteLine($"El número menor es: {menor}");
            }
            return menor;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            int number3 = int.Parse(Console.ReadLine());
            if (number1 == number2 && number1 == number3)
            {
                Console.WriteLine("Los tres números tienen el mismo valor");
            }
            else
            {
                MenorDeTres(number1, number2, number3);
            }
        }
    }
}

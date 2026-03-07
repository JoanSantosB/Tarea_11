using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static int Mayor(int a, int b)
        {
            int mayor = 0;
            if (a > b)
            {
                mayor = a;
            }
            else
            {
                mayor = b;
            }
            Console.WriteLine($"El número mayor es: {mayor}");
            return mayor;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int number1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int number2=int.Parse(Console.ReadLine());
            if(number1 == number2)
            {
                Console.WriteLine("Los dos números tienen el mismo valor");
            }
            else
            {
                Mayor(number1, number2);
            }
        }
    }
}

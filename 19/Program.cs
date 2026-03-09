using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static bool EsMultiplo(int n, int m)
        {
            bool multiplo=false;
            if(n %m==0)
            {
                Console.WriteLine($"{n} es multiplo de {m}");
                multiplo = true;
            }
            else
            {
                Console.WriteLine($"{n} no es multiplo de {m}");
                multiplo = false;
            }
            return multiplo;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int number1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese un número para verificar si es multiplo: ");
            int number2=int.Parse(Console.ReadLine());
            if (number2 != 0)
            {
                EsMultiplo(number1 , number2);
            }
            else
            {
                Console.WriteLine("Error debe ingresar un número que no sea 0");
            }
        }
    }
}

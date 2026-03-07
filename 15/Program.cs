using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static bool EsPar(int a)
        {
            bool resultado=false;
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} es un número par");
                resultado = true;
            }
            else
            {
                Console.WriteLine($"{a} es un número impar");
                resultado = false;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int number=int.Parse(Console.ReadLine());
            EsPar(number);
        }
    }
}

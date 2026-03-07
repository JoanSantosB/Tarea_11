using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void SumarMostrar(int a,int b)
        {
            int resultado = a+b;
            Console.WriteLine($"La suma es: {resultado}");
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int number1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int number2=int.Parse(Console.ReadLine());
            SumarMostrar(number1,number2);
        }
    }
}

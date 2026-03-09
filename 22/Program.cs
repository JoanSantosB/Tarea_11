using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Program
    {
        static string Repetir(string texto,int veces)
        {
            for(int i = 1; i <= veces; i++)
            {
                Console.WriteLine($"{i}-{texto}");
            }
            return texto;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string word = Console.ReadLine().ToLower();
            Console.Write("Ingrese la cantidad de veces que desea repetir: ");
            int cantidad=int.Parse(Console.ReadLine());
            if (cantidad > 0)
            {
                Repetir(word, cantidad);
            }
            else 
            {
                Console.WriteLine("La cantidad debe se mayor que 0");
            }
        }
    }
}

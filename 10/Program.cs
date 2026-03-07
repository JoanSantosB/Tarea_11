using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void ImprimirTexto(string texto,int veces)
        {
            for(int i = 0; i < veces; i++)
            {
                Console.WriteLine($"{i+1}-{texto}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el texto: ");
            string sentence = Console.ReadLine();
            Console.Write("Ingrese las veces que se imprima el texto: ");
            int cantidad = int.Parse(Console.ReadLine());
            ImprimirTexto(sentence,cantidad);
        }
    }
}

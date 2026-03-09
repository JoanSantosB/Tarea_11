using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static int ContarLetras(string palabra)
        {
            int contador = 0;
            foreach (char c in palabra)
            {
                contador++; 
            }
            Console.WriteLine($"Total de letras: {contador}");
            return contador;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string word = Console.ReadLine();
            ContarLetras(word);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static int ContarVocales(string texto)
        {
            int contador = 0;
            foreach (char c in texto)
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        contador++;
                        break;
                }
            }
            Console.WriteLine($"Total de vocales: {contador}");
            return contador;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string word=Console.ReadLine().ToLower();
            ContarVocales(word);
        }
    }
}

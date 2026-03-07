using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola "+nombre);
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese un nombre: ");
            string name=Console.ReadLine();
            Saludar(name);
        }
    }
}

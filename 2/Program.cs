using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void MostrarNombre()
        {
            Console.Write("Ingrese un nombre: ");
            string name=Console.ReadLine();
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            MostrarNombre();
        }
    }
}

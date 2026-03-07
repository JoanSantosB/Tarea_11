using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion=int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.Write("Ingrese un número: ");
                        int a=int.Parse(Console.ReadLine());
                        Console.Write("Ingrese un número: ");
                        int b=int.Parse(Console.ReadLine());
                        Console.WriteLine($"El resultado de la suma es: {a+b}");
                        break;
                    case 2:
                        Console.Write("Ingrese un número: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese un número: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"El resultado de la resta es: {a - b}");
                        break;
                    case 3:
                        Console.WriteLine("Gracias por utilizar el programa");
                        break;
                    default:
                        Console.WriteLine("Esta opción no existe");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 3);
        }
        static void Main(string[] args)
        {
            MostrarMenu();
        }
    }
}

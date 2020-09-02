using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la edad de la persona: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad <= 10)
            {
                Console.Write("Es un niño/a.");
            }
            else if (edad >= 11 && edad <= 17)
            {
                Console.Write("Es un adolecente.");
            }
            else if (edad >= 18 && edad <= 38)
            {
                Console.Write("Es un adulto joven.");
            }
            else if (edad >= 39 && edad <= 59)
            {
                Console.Write("Es de mediana edad.");
            }
            else if (edad >= 60 && edad <= 99)
            {
                Console.Write("Es un adulto mayor.");
            }

            Console.ReadKey();
        }
    }
}

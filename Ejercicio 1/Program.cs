using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es Par.");
            }
            else
            {
                Console.WriteLine("El numero es impar.");
            }
            Console.ReadKey();
        }
    }
}

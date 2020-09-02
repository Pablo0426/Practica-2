using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite otro numero: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.Write("El numero " + n1 + " es mayor que el numero " + n2);
            }
            else
            {
                Console.Write("El numero " + n2 + " es mayor que el numero " + n1);
            }

            Console.ReadKey();
        }
    }
}

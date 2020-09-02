using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pulse [1] para sumar o Pulse [2] para restar: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Digite un numero");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite otro numero");
                    int n2 = int.Parse(Console.ReadLine());
                    int total = n1 + n2;
                    Console.WriteLine("La sumatoria es: " + total);
                    break;
                case 2:
                    Console.WriteLine("Digite un numero");
                    int n3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite otro numero");
                    int n4 = int.Parse(Console.ReadLine());
                    int Total = n3 - n4;
                    Console.WriteLine("La resta es: " + Total);
                    break;
                default:
                    Console.WriteLine("Esa opcion no existe.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

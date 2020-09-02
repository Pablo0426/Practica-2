using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ahorro = 18765.43;
            Console.WriteLine("Su cuenta de ahorro tiene disponible RD$18,765.43 \nDigite el monto a retirar: ");
            double retiro = double.Parse(Console.ReadLine());

            if (retiro > ahorro)
            {
                Console.WriteLine("Usted no cuenta con dicho valance en su cuanta de ahorros.\nIntente con otra cantidad");
            }
            else
            {
                ahorro = ahorro - retiro;
                Console.WriteLine("\nSu valance actual es de " + ahorro);
            }
            Console.ReadKey();
        }
    }
}

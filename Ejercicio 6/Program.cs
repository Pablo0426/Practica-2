using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double interes = 0.15;
            Console.Write("Digite el valor de la cuota: ");
            double cuota = double.Parse(Console.ReadLine());

            interes = interes / 12;
            Console.Write("interes mensual: " + interes);
            cuota = cuota * interes + cuota;

            Console.Write("\nLa cuota mensual es de: " + cuota);
            Console.ReadKey();
        }
    }
}

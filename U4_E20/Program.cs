using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVentas;
            int totalVentas = 0;

            Console.WriteLine("Introduzca el número de ventas: ");
            numVentas = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=numVentas; i++) {
                Console.WriteLine("Introduzca la venta número {0}", i);
                int venta = Convert.ToInt32(Console.ReadLine());

                totalVentas += venta;
            }

            Console.WriteLine("El total de sus ventas es: {0}", totalVentas);

            Console.ReadKey();
        }
    }
}

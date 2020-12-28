using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E6
{
    class Program
    {
        static void Main(string[] args)
        {
            string numTarjeta;

            Console.WriteLine("Introduzca el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca la forma de pago: ");
            string formaPago = Console.ReadLine();

            if (formaPago == "tarjeta") {
                Console.WriteLine("Introduzca el número de tarjeta: ");
                numTarjeta = Console.ReadLine();
            }

            Console.WriteLine("Vas a pagar {0} euros con {1}.", precio, formaPago);

            Console.ReadKey();
        }
    }
}

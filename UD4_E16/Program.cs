using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD4_E16
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;

            Console.WriteLine("Introduzca el precio del producto: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El precio de su producto con IVA es de {0} euros.", price * 1.21);

            Console.ReadKey();
        }
    }
}

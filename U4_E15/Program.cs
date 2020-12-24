using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("El número es divisible por dos.");
            } else {
                Console.WriteLine("El número no es divisible por dos.");
            }                

            Console.ReadKey();
        }
    }
}

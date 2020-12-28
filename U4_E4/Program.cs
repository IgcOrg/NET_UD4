using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introduce otro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2) {
                Console.WriteLine("El número mayor es {0}.", num1);
            } else if (num1 == num2) {
                Console.WriteLine("Los números son iguales");
            } else {
                Console.WriteLine("El número mayor es {0}.", num2);
            }

            Console.ReadKey();
        }
    }
}

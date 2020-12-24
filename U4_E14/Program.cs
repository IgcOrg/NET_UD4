using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E14
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;

            Console.WriteLine("Introduce el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La superfície de tu círculo mide {0}", Math.Round(Math.PI * Math.Pow(radio, 2), 2));

            Console.ReadKey();
        }
    }
}

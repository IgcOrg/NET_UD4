using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E13
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Introduce tu nombre");
            nombre = Console.ReadLine();


            Console.Write("Bienvenido {0}.", nombre);

            Console.ReadKey();
        }
    }
}

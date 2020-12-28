using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre de una ciudad: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Introduzca el nombre de una persona: ");
            string persona = Console.ReadLine();

            Console.WriteLine("Hola {0}, bienvenido a {1}.", persona, ciudad);

            Console.ReadKey();
        }
    }
}

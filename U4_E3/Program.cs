using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cómo te llamas?");
            string nombre = Console.ReadLine();

            Console.WriteLine("¿Cuántos años tienes?");
            string edad = Console.ReadLine();

            Console.WriteLine("Te llamas {0} y tienes {1} años.", nombre, edad);
            Console.ReadKey();
        }
    }
}

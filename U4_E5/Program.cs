using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] finDeSemana = { "sabado", "Sabado", "domingo", "Domingo" };

            Console.WriteLine("Introduce el día de la semana");
            string dia = Console.ReadLine();

            if (finDeSemana.Contains(dia)) {
                Console.WriteLine("Es fin de semana");
            } else {
                Console.WriteLine("No es fin de semana");
            }

            Console.ReadKey();
        }
    }
}

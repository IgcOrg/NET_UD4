using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E21 {
    class Program {
        static void Main(string[] args) {
            string dia = string.Empty;
            
            Console.WriteLine("Introduzca un día de la semana para saber si es laborable o no: ");
            dia = Console.ReadLine();

            switch (dia) {
                case "Lunes":
                    Console.WriteLine("Laborable");
                break;

                case "Martes":
                    Console.WriteLine("Laborable");
                break;

                case "Miercoles":
                    Console.WriteLine("Laborable");
                break;

                case "Jueves":
                    Console.WriteLine("Laborable");
                break;

                case "Viernes":
                    Console.WriteLine("Laborable");
                break;

                case "Sabado":
                    Console.WriteLine("No laborable");
                break;

                case "Domingo":
                    Console.WriteLine("No laborable");
                break;
            }

            Console.ReadKey();
        }
    }
}

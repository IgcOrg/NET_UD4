using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E23 {
    class Program {
        static void Main(string[] args) {
            int operando1 = 0;
            int operando2 = 0;

            string signo = string.Empty;

            Console.WriteLine("Bienvenido a CalculadoraInversa: ");
            
            Console.WriteLine("Introduzca el primer operando: ");
            operando1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo operando: ");
            operando2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ahora introduzca el signo de la operación: ");
            signo = Console.ReadLine();

            switch (signo) {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", operando1, operando2, operando1 + operando2);
                    break;

                case "-":
                    Console.WriteLine("{0} - {1} = {2}", operando1, operando2, operando1 - operando2);
                    break;

                case "*":
                    Console.WriteLine("{0} * {1} = {2}", operando1, operando2, operando1 * operando2);
                    break;

                case "/":
                    Console.WriteLine("{0} / {1} = {2}", operando1, operando2, operando1 / operando2);
                    break;

                case "^":
                    Console.WriteLine("{0} ^ {1} = {2}", operando1, operando2, Math.Pow(operando1, operando2));
                    break;

                case "%":
                    Console.WriteLine("{0} % {1} = {2}", operando1, operando2, operando1 % operando2);
                    break;

                default:
                    Console.WriteLine("El símbolo introducido no es válido. Se cerrará la aplicación.");
                    break;
            }

            Console.ReadKey();
        }
    }
}

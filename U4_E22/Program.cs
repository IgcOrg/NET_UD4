using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_E22 {
    class Program {
        static void Main(string[] args) {
            string password = "123";
            string userPassword = string.Empty;

            int intentos = 3;

            Console.WriteLine("Bienvenido, a continuación dispondrá de tres intentos para adivinar la contraseña: ");

            for (int i=1; (i<=intentos && userPassword != password); i++) {
                Console.WriteLine("Intento {0}: ", i);
                userPassword = Console.ReadLine();

                if (userPassword != password) {
                    Console.WriteLine("Contraseña errónea.");
                }
            }

            if (userPassword == password) {
                Console.WriteLine("Enhorabuena, has acertado.");
            } else {
                Console.WriteLine("Has agotado todos los intentos, vuelve a probar..");
            }

            Console.ReadKey();
        }
    }
}

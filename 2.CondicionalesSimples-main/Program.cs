using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1. crear un algritmo que permita... 

            string nombre = "";
            float sueldo = 0;

            Console.WriteLine(" Ingrese el nombre del usuario: ");
            nombre = Console.ReadLine(); //Todo lo que el usuario ingresa dese la consola llega como una cadena de caracteres (string)
            Console.WriteLine(" Ingrese el sueldo del usuario: ");
            sueldo = Convert.ToSingle(Console.ReadLine()); // Para convertir la cadena de caracteres a un numero decimal (float)
             
            if (sueldo >= 3000)
            {
                Console.WriteLine($"el usuario {nombre}, debe pagar impuestos");    // opción b) Console.WriteLine(" El usuario " + nombre + " tiene un sueldo alto");
            }
            if (sueldo < 3000)
            {
                Console.WriteLine($"el usuario {nombre}, NO debe pagar impuestos");
            }
            */

            // 2.Crear un algoritmo que lea la edad del usuario, si el usuario es mayor a 18 años, se debe mostrar el mensaje: "bienvenido al sitio web "
            float edad = 0;
            Console.WriteLine("Ingrese la edad del usuario: ");
            edad = Convert.ToSingle(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al sitio web >;D ");
            }
            if (edad < 18)
            {
                Console.WriteLine("Lo siento, no puedes ingresar al sitio web :c, vuelve cuando seas mayor de edad");
            }
            Console.WriteLine("hasta luego");
        }
    }
}

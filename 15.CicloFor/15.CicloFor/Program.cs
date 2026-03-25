using System;

namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int acumulador = 0;

            for (int contador = 0;  contador <=5;  contador++)
            {
                acumulador += contador;
            }

            Console.WriteLine($"La suma de los cinco primeros enteros es:{acumulador}");
           */

            /*
              1. Realizar un programa que permita obtener la factorial de un numero entero ingresado por el teclado


            int factorial = 1;
            int numero;

            Console.WriteLine("por favor ingrese un número para calcular su factorial");

            numero=int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= numero ; contador++)
            {
               factorial *= contador;
            }
            Console.WriteLine($"Factorial de {numero} es: {factorial}");
            */
            /*
              2. Realizar un programa que permita imprimir por pantalla los números múltiplos de 5,
                 el usuario debe ingresar por el teclado el rango de números a evaluar.
            */
             int numeroInicial = 1; //inicioRango
             int numeroFinal = 1;  //finalRango

            Console.WriteLine(" A continucaión el programa va a determinar los numeros multiplos de 5 del rango que usted elija entre dos números, Ingrese el primer número ");
            numeroInicial=int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el segundo número ");
            numeroFinal=int.Parse(Console.ReadLine());               
            Console.WriteLine($"Los Numeros del rango que son multiplos de 5 son:  ");

            for (int i = numeroInicial; i <= numeroFinal; i++)
            {
                if (i%5 == 0)  //Función MOD #%# = residuo
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

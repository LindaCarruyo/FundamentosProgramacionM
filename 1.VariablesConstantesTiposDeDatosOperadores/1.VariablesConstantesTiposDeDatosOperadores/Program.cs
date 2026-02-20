using System;

namespace _1.VariablesConstantesTiposDeDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES NUMERICOS
            //Cambio de signo:
            int dato1 = 4;
            int dato2 = -dato1;
            Console.Write(dato1 + " // " + dato2);

            //Aritmeticos:
            int dato3 = 4 + 6;
            int dato4 = 150 - 120;
            int dato5 = 12 * 56;
            float dato6 = (float)5 / 3; //otras formas de dividir con decimales: [5/3f;] [5f/3;] [(float) 5/3;] [5f/3f;] )) se utilizó float para que muestre los decimales  
            Console.Write(" \n Suma: {0}\n resta: {1}\n Multiplicación: {2}\n Divición: {3}\n", dato3, dato4, dato5, dato6);

            //Incremento - Decremento}
            dato3++; //dato3 = dato3+1;  solo 1
            Console.WriteLine("Incremento: {0}", dato3);
            dato4--; //dato4 = dato4-1;  solo 1
            Console.WriteLine("Decremento: {0}", dato4);
            dato5 += 4; // dato5 = dato5+4; //[para sumar ]
            dato3 -= 5; // dato3 = dato3-5; //[para restar ]
            dato5 *= dato3; // dato5 = dato5*4; //[para Multiplicar ]
            dato6 /= dato3; // dato3 = dato3/5; //[para Dividir ]

            //Orden de evaluación Operadores Numericos
            float dato7 = 4 * 3 / 2;
            Console.WriteLine(dato7);
            float dato8 = 4.0f * (3.0f / 5.0f);
            Console.WriteLine(dato8); 



        }
    }
}

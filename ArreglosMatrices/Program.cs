using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        { /* 
            ANOTACIONES:
                - Las matrices son estructuras de datos que permiten almacenar datos en una tabla de filas y columnas.
                - Se pueden declarar e inicializar de diferentes formas, ya sea asignando valores directamente o utilizando bucles para llenarlas.
                - Para acceder a los elementos de una matriz, se utilizan índices que indican la posición del elemento en la fila y columna correspondiente.
                - Es importante tener en cuenta las dimensiones de la matriz al realizar operaciones como la suma, resta o multiplicación, ya que deben ser compatibles para llevar a cabo dichas operaciones.
                - En el ejemplo se muestra cómo llenar una matriz utilizando un bucle anidado, solicitando al usuario que ingrese los valores para cada posición de la matriz.
                - Finalmente, se recorre la matriz para mostrar los valores ingresados por el usuario en formato de tabla.

           ejemplo1:
            int[,] Numeros = new int[2, 3]; // [filas, columnas]

            Numeros[0 , 0] = 15;Numeros[0 , 1] = 15;Numeros[0 , 2] = 23;   
            Numeros[1 , 0] = 36; Numeros[1 , 1] = 22;Numeros[1, 2] = 100;
         
            //Numeros[0, 0] = 15;     //normalmente se ven en listado en los demás códigos, 
            //Numeros[0, 1] = 15;     //pero para visualizar la tabla mas facilmente lo hice de la manera anterior
            //Numeros[0, 2] = 23;    
            //Numeros[1, 0] = 36;
            //Numeros[1, 1] = 22;
            //Numeros[1, 2] = 100;
        

           ejemplo2: 
            string[,] Nombres =    // Ejemplo para llenar Matriz
            {
                {"Juan" ,"Maria"},
                {"Ana"  ,"Luis" },
                {"Sofia","Pedro"}
            };

           ejemplo3:
            Char[,] simbolos = new Char[2, 5]; 
            for (int i =0; i < 2; i++) //recorre las fillas
            {
                for (int j = 0; j < 5; j++)//recorre las columnas de cada fila
                {
                    Console.WriteLine($"Ingrese un simbolo para la P {i},{j}");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();        // Limpia la consola para mostrar solo la matriz de simbolos

            //Recorrer la matriz para recuperar los datos
            for (int i = 0; i < simbolos.GetLength(0); i++) // GetLeight(0) Obtiene el numero de filas 
            { 
                for(int j = 0; j < simbolos.GetLength(1); j++) // GetLeight(1) Obtiene el numero de columnas
                {
                    Console.Write(simbolos[i, j] + " | ");
                }
                Console.WriteLine();
            }
           ------------------------------------------------------------------------------------------------- */
            /*
              1. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
                 Requisitos del programa:
                 * Solicita al usuario que ingrese los elementos de la primera matriz (2 filas y 3 columnas)
                 * Solicita al usuario que ingrese los elementos de la segunda matriz (2 filas y 3 columnas)
                 * Calcula la matriz suma, resultado de sumar los elementos correspondientes de las dos matrices
                 * Muestra la matriz resultante de la sum en formato de tabla (matriz de 2 filas y 3 columnas).
            */
            

        }
    }
}

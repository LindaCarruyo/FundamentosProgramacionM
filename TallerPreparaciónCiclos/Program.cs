using System;

namespace TallerPreparaciónCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------------------------------------------------------------------------------------
               1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
                  le permitirá al usuario, introducir tantas calificaciones como así desee,
                  en el momento en que seleccione que no desea continuar capturando
                  calificaciones, el algoritmo debe presentar el promedio de las
                  calificaciones capturadas previamente. 
            

            double nota;
            int cantidad = 0;
            double suma = 0;

            Console.WriteLine("Introduzca calificaciones (con decimales si lo desea). Para terminar escriba 'p'.");

            while (true)
            {
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada)) //saber si tiene espacios en blanco o es vacía
                {
                    Console.WriteLine("Entrada vacía. Ingrese una calificación o 'p' para terminar.");
                    continue;
                }

                string texto = entrada.Trim().ToLower(); //eliminar espacios en blanco y convertir a minúsculas para que el usuario no se confunda

                if (texto == "p")
                {
                    if (cantidad > 0)
                    {
                        double promedio = suma / cantidad;
                        Console.WriteLine($"Su promedio final es: {promedio:F2}");
                    }
                    else
                    {
                        Console.WriteLine("No se ingresaron calificaciones.");
                    }
                    break;
                }

                if (double.TryParse(texto, out nota))
                {
                    if (nota < 0.0 || nota > 100.0)
                    {
                        Console.WriteLine("Calificación fuera de rango (0-100). Intente de nuevo.");
                        continue;
                    }
                    suma += nota;
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número (por ejemplo 78.5) o 'p' para terminar.");
                }
            }

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
            
           ------------------------------------------------------------------------------------------------------- */
            /*
             2. Se requiere un algoritmo para mostrar por pantalla los divisores de un
                número ingresado por teclado.
                Tener en cuenta que dados dos números enteros a y b, se dice que b es
                divisor de a si se cumple que al efectuar una división entera a/b el
                residuo es 0, en C# utilizar el operador Mod para obtener el residuo de
                una división de dos números.
                Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3,
                2, 1 que son los divisores del número 6.
           
            // Programa para mostrar los divisores de un número entero
            //  - Valida la entrada con while hasta obtener un entero
            //  - Maneja el caso 0 (infinitos divisores)
            //  - Muestra divisores positivos en orden descendente (ej: 6, 3, 2, 1)

            Console.WriteLine("Mostrar divisores de un número entero");
            Console.Write("Ingrese un número entero: ");

            int numero;
            string entrada = Console.ReadLine();

            // Validación: repetir mientras la conversión falle
            while (!int.TryParse(entrada?.Trim(), out numero))
            {
                Console.WriteLine("Entrada no válida. Ingrese un número entero:");
                entrada = Console.ReadLine();
            }

            // Caso especial: 0
            if (numero == 0)
            {
                Console.WriteLine("0 tiene infinitos divisores (todos los enteros).");
            }
            else
            {
                int valor = Math.Abs(numero); // trabajamos con el valor absoluto para divisores positivos
                Console.Write($"Los divisores de {numero} son: ");

                int i = valor;
                bool primero = true;

                // Recorremos desde valor hasta 1 para imprimir en orden descendente
                while (i >= 1)
                {
                    if (valor % i == 0) // si el residuo es 0, i es divisor
                    {
                        if (!primero) Console.Write(", ");
                        Console.Write(i);
                        primero = false;
                    }
                    i--;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();

            ------------------------------------------------------------------------------------------------------- */
            /*
             3. Dados dos números enteros ingresados por teclado: b que es la base y
                e que es el exponente, se requiere calcular el resultado de la
                potenciación.
                Ejemplo: b=2, e=5  25=2*2*2*2*2= 32
                Mostrar por pantalla el resultado de la potenciación.
                Seguir pidiendo por teclado la base y el exponente y realizar la
                potenciación correspondiente, hasta que el usuario ingrese por teclado
                el carácter de escape ‘n’
            
            Console.WriteLine("Potenciación. Escriba 'n' en cualquier entrada para salir.");

            while (true)
            {
                Console.Write("Ingrese la base: ");
                string baseInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(baseInput))
                {
                    Console.WriteLine("Entrada vacía. Intente de nuevo.");
                    continue;
                }

                if (baseInput.Trim().ToLower() == "n")
                    break;

                if (!int.TryParse(baseInput.Trim(), out int b))
                {
                    Console.WriteLine("Base inválida. Ingrese un número entero.");
                    continue;
                }

                Console.Write("Ingrese el exponente: ");
                string expInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(expInput))
                {
                    Console.WriteLine("Entrada vacía. Intente de nuevo.");
                    continue;
                }

                if (expInput.Trim().ToLower() == "n")
                    break;

                if (!int.TryParse(expInput.Trim(), out int e))
                {
                    Console.WriteLine("Exponente inválido. Ingrese un número entero.");
                    continue;
                }

                double resultado = Math.Pow(b, e);
                double resultadoRedondeado = Math.Round(resultado);
                string resultadoTexto = Math.Abs(resultado - resultadoRedondeado) < 1e-12
                    ? resultadoRedondeado.ToString("F0")
                    : resultado.ToString();

                Console.WriteLine($"{b}^{e} = {resultadoTexto}");
                Console.WriteLine();
            }

            Console.WriteLine("Proceso terminado. Presione una tecla para salir...");
            Console.ReadKey();

            ---------------------------------------------------------------------------------------*/
            /*
             4. Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
                kilómetros durante 10 días, para determinar si es apto para la prueba de
                5 kilómetros. Para considerarlo apto debe cumplir las siguientes
                condiciones:
                     Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
                     Que al menos en una de las pruebas realice un tiempo menor de 15
                        minutos.
                     Que su promedio sea menor o igual a 18 minutos.
                Diseñar un algoritmo para registrar los datos y decidir si es apto para la
                competencia.
             
             */

            //contador para cada uno de los 10 dias, que pida ingrtesar numeros de cada dia
            // si alguno de los dias es mayor a 20min, se detiene el conteo y automaticamente dice "no es apto" sin importar que no cumpla los 10 dias.
            //promediar los tiempos que haya cumplido y dar el resultado.
            // si el promedio es menor a 18 minutos y se cumplieron los 10 dias "es apto para el maratón"

            Console.WriteLine("Programa para ver si es apto para la maratón");

             
            



           
          
            
        }
    }
}

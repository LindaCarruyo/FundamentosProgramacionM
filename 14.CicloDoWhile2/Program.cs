using System;
using System.Diagnostics.Eventing.Reader;

namespace _14.CicloDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             14. Crear un algoritmo que permita calcular y mostrar por pantalla los números
                 primos hasta el numero 100.
             
            int contadorNumeros = 1;
            int contador = 1;
            int divisores = 0;
           
            do
            {
                do
                {
                    if (contadorNumeros % contador == 0)
                    {
                        divisores++;
                    }
                    contador++;
                }
                while (contador <= contadorNumeros);
                contador = 1;
                if (divisores == 2)
                {
                    Console.WriteLine(contadorNumeros);
                }
                divisores = 0;
                contadorNumeros++;
            }  */

            /*
             15. Escribe un algoritmo que actúe como una calculadora básica. El algoritmo debe permitir al usuario elegir
                 una operación (suma, resta, multiplicación, división), y luego ingresar dos números. El ciclo debe 
                 repetirse hasta que el usuario decida salir.
             

            int num1 = 0;
            int num2 = 0;
            char operacion = ' ';

            Console.WriteLine("Calculadora; seleccione el tipo de operacion que desea realizar entre dos numeros; s = suma, r = resta, m = multiplicacion, d = division; para salir presione q ");
            operacion = char.Parse(Console.ReadLine());
            
            do             {
                Console.WriteLine("Ingrese el primer numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                num2 = int.Parse(Console.ReadLine());
                switch (operacion)
                {
                    case 's':
                        Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                        break;
                    case 'r':
                        Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
                        break;
                    case 'm':
                        Console.WriteLine($"El resultado de la multiplicacion es: {num1 * num2}");
                        break;
                    case 'd':
                        if (num2 != 0)
                        {
                            Console.WriteLine($"El resultado de la division es: {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operacion no valida.");
                        break;
                }
                Console.WriteLine("Seleccione otra operacion s = suma r = resta m = multiplicación d = división o presione q para salir ");
                operacion = char.Parse(Console.ReadLine());
            } while (operacion != 'q');
            */

            /*
             16. crear un algoritmo que permita ingresar números: hasta que el  usuario lo indique, y luego mostrar:
                 a. Calcular cuantos son pares y cuantos impares.
                 b. Calcular el promedio de los números pares y el promedio de los números impares y el de todos los números ingresados.
                 c. Terminar cuando el usuario lo indique.
            */


            /* int Numero;
            char Decision = ' ';

            Console.WriteLine(" Ingrese uno a uno una secuencia de Numeros; Cuando termine de ingresar los numeros presione F para mostrar los numeros pares e impares y su promedio, o la Q para salir del programa ");
            Numero = Convert.ToInt32(Console.ReadLine());
            
            if (Numero = ) 
            {
                if (Decision == 'f' && Decision == 'F')
                {
                    int contadorPares = 0;
                    int contadorImpares = 0;
                    int sumaPares = 0;
                    int sumaImpares = 0;
                    int contadorTotal = 0;
                    int sumaTotal = 0;
                    do
                    {
                        if (Numero % 2 == 0)
                        {
                            contadorPares++;
                            sumaPares += Numero;
                        }
                        else
                        {
                            contadorImpares++;
                            sumaImpares += Numero;
                        }
                        contadorTotal++;
                        sumaTotal += Numero;
                        Console.WriteLine("Ingrese otro numero o presione F para mostrar los resultados o Q para salir");
                        Numero = Convert.ToInt32(Console.ReadLine());
                        Decision = char.Parse(Console.ReadLine());
                    } while (Decision != 'F' && Decision != 'Q');

                    if (contadorPares > 0)
                    {
                        Console.WriteLine($"Cantidad de numeros pares: {contadorPares}, Promedio de numeros pares: {(double)sumaPares / contadorPares}");
                    }
                    else
                    {
                        Console.WriteLine("No se ingresaron numeros pares.");
                    }
                    if (contadorImpares > 0)
                    {
                        Console.WriteLine($"Cantidad de numeros impares: {contadorImpares}, Promedio de numeros impares: {(double)sumaImpares / contadorImpares}");
                    }
                    else
                    {
                        Console.WriteLine("No se ingresaron numeros impares.");
                    }
                    if (contadorTotal > 0)
                    {
                        Console.WriteLine($"Promedio de todos los numeros ingresados: {(double)sumaTotal / contadorTotal}");
                    }

                }
            }
            while (Decision != 'Q' && Decision != 'F') 
            {
                Console.WriteLine("Operacion no valida INGRESE UN NUMERO o ingrese F para mostrar los resultados o Q para salir");
                Decision = char.Parse(Console.ReadLine());
            }*/



        }
    }
}

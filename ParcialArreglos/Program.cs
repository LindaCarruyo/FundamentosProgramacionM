using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ENUNCIADO:
            Registro y análisis de calificaciones de estudiantes
            Implemente un programa que gestione la información académica de 5 estudiantes, almacenando sus datos en una matriz estructurada y realizando cálculos sobre sus calificaciones.
            Requisitos del programa:

            1.Creación de la matriz:
            Utilice una matriz de 6 columnas por 6 filas (1 fila para encabezados y 5 filas para datos de estudiantes).
            La primera fila debe contener los encabezados de las columnas, en el siguiente orden:
            | Nombre del Estudiante | Grado | Nota Parcial 1 | Nota Parcial 2 | Examen Final | Nota Final |

            2.Ingreso de datos:
            Para cada uno de los 5 estudiantes, el programa debe solicitar por teclado:
             *Nombre completo del estudiante.
             *Grado (solo se permiten los grados: 6°, 7°, 8°, 9°). Validar la entrada.
             *Nota del Parcial 1 (valor decimal entre 0.0 y 5.0). Validar la entrada.
             *Nota del Parcial 2 (valor decimal entre 0.0 y 5.0). Validar la entrada.
             *Nota del Examen Final (valor decimal entre 0.0 y 5.0). Validar la entrada.
             *Calcular la Nota Final como el promedio de las tres notas (Parcial 1, Parcial 2 y Examen Final) .
             
            3.Visualización de la matriz:
            Una vez ingresados todos los datos, mostrar en pantalla la matriz completa con los encabezados y los datos de cada estudiante.

            4.Análisis de calificaciones:
             *Determinar y mostrar en pantalla:
             *El nombre del estudiante con la mayor nota final.
             *
            5.Consideraciones adicionales:
             La matriz será una mezcla de texto y números, por lo tanto, se recomienda tratar los datos de la matriz, como tipo string y convertir las notas a tipos numéricos para realizar     los     cálculos.
            Use validación de entrada para garantizar que los datos del usuario cumplan con los requisitos establecidos.
            */


            decimal mejorNotaFinal = -1m;
            string nombreMejorEstudiante = string.Empty;
            string NombreEstudiante;
            decimal NotaParcial1, NotaParcial2, ExamenFinal, NotaFinal;
            char Grado;
            string[,] MatrizNotas = new string[6, 6];

            Console.WriteLine("Registro y análisis de calificaciones de estudiantes, por favor asegurese de ingresar las notas, en caso de tener decimales usar ");

            for (int fila = 1; fila <= 5; fila++)
            {
                // Nombre
                do
                {
                    Console.WriteLine("Ingrese el nombre del estudiante:");
                    NombreEstudiante = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(NombreEstudiante))
                    {
                        Console.WriteLine("El nombre del estudiante no puede estar vacío. Por favor, ingrese un nombre válido.");
                    }
                    else if (NombreEstudiante.Any(char.IsDigit)) // por si tiene numeros 
                    {
                        Console.WriteLine("El nombre del estudiante no puede contener números. Por favor, ingrese un nombre válido."); // igual lo registra y no lo pude corregir :((
                    }
                    
                } while (string.IsNullOrWhiteSpace(NombreEstudiante));
                MatrizNotas[fila, 0] = NombreEstudiante;

                // Grado
                string gradoInput;
                bool gradoValido = false;
                do
                {
                    Console.WriteLine("Ingrese el grado del estudiante (6°, 7°, 8°, 9°):");
                    gradoInput = Console.ReadLine()?.Trim();
                    if (!string.IsNullOrEmpty(gradoInput))
                    {
                        // aceptar '6', '6°', '6º', etc.
                        char primera = gradoInput[0];
                        if (primera == '6' || primera == '7' || primera == '8' || primera == '9')
                        {
                            Grado = primera;
                            MatrizNotas[fila, 1] = gradoInput;
                            gradoValido = true;
                        }
                    }
                    if (!gradoValido)
                    {
                        Console.WriteLine("Grado inválido. Por favor, ingrese un grado válido (6°, 7°, 8°, 9°).");
                    }
                } while (!gradoValido);

                // Nota Parcial 1
                do
                {
                    Console.WriteLine("Ingrese la nota del Parcial 1:");
                    string input = Console.ReadLine();
                    if (!decimal.TryParse(input, out NotaParcial1) || NotaParcial1 < 0.0m || NotaParcial1 > 5.0m)
                    {
                        Console.WriteLine("Nota del Parcial 1 inválida. Por favor, ingrese un valor decimal entre 0,0 y 5,0.");
                    }
                    else
                    {
                        MatrizNotas[fila, 2] = NotaParcial1.ToString("0.00");
                        break;
                    }
                } while (true);

                // Nota Parcial 2
                do
                {
                    Console.WriteLine("Ingrese la nota del Parcial 2:");
                    string input = Console.ReadLine();
                    if (!decimal.TryParse(input, out NotaParcial2) || NotaParcial2 < 0.0m || NotaParcial2 > 5.0m)
                    {
                        Console.WriteLine("Nota del Parcial 2 inválida. Por favor, ingrese un valor decimal entre 0,0 y 5,0.");
                    }
                    else
                    {
                        MatrizNotas[fila, 3] = NotaParcial2.ToString("0.00");
                        break;
                    }
                } while (true);

                // Examen Final
                do
                {
                    Console.WriteLine("Ingrese la nota del Examen Final:");
                    string input = Console.ReadLine();
                    if (!decimal.TryParse(input, out ExamenFinal) || ExamenFinal < 0.0m || ExamenFinal > 5.0m)
                    {
                        Console.WriteLine("Nota del Examen Final inválida. Por favor, ingrese un valor decimal entre 0,0 y 5,0.");
                    }
                    else
                    {
                        MatrizNotas[fila, 4] = ExamenFinal.ToString("0.00");
                        break;
                    }
                } while (true);

                // Cálculo Nota Final
                NotaFinal = Math.Round((NotaParcial1 + NotaParcial2 + ExamenFinal) / 3m, 2);
                MatrizNotas[fila, 5] = NotaFinal.ToString("0.00");
                Console.WriteLine("La nota final del estudiante es: " + NotaFinal.ToString("0.00"));

                // Seguimiento mejor estudiante
                if (NotaFinal > mejorNotaFinal)
                {
                    mejorNotaFinal = NotaFinal;
                    nombreMejorEstudiante = NombreEstudiante;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz de notas:");
            for (int i = 0; i < MatrizNotas.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizNotas.GetLength(1); j++)
                {
                    Console.Write(MatrizNotas[i, j] + "\t");
                }
                Console.WriteLine();

            }

            if (!string.IsNullOrEmpty(nombreMejorEstudiante))
            {
                Console.WriteLine();
                Console.WriteLine("El estudiante con la mayor nota final es: " + nombreMejorEstudiante + " con " + mejorNotaFinal.ToString("0.00"));
            }

            //cerrar programa o repetir proceso
            Console.WriteLine("Presione Q para cerrar el programa  o R para repetir el proceso");
            Console.ReadKey();
            if (char.ToUpper(Console.ReadKey().KeyChar) == 'q')
            {
                Environment.Exit(0);
            }
            else if (char.ToUpper(Console.ReadKey().KeyChar) == 'r')
            {
                Console.Clear();
                Main(args);
            }
        }
    }
}

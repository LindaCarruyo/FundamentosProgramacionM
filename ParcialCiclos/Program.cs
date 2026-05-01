using System;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             En el programa de Ingeniería Eléctrica, que cuenta con 18 estudiantes, se desea procesar información sobre la ocupación y el género de los alumnos.
               El programa debe realizar las siguientes acciones:
               Ingresar por teclado la ocupación de cada estudiante (trabaja o estudia) y su género (hombre o mujer).
               Calcular y mostrar el porcentaje de estudiantes que trabajan y el porcentaje de los que estudian respecto al total del grupo.
               Calcular y mostrar el número de mujeres que trabajan.
               Calcular y mostrar el número de hombres que estudian.

             PASOS:
            1. definir variables para contar estudiantes que trabajan, estudian, mujeres que trabajan y hombres que estudian.
            2. usar un ciclo para ingresar la ocupación y el género de cada estudiante, actualizando las variables de conteo según corresponda.
            3. después del ciclo, calcular los porcentajes y mostrar los resultados.
            4. mostrar el número de mujeres que trabajan y hombres que estudian.
            5. finalizar el programa.

            */

            int totalEstudiantes = 18;
            int estudiantesQueTrabajan = 0;
            int estudiantesQueEstudian = 0;
            int mujeresQueTrabajan = 0;
            int hombresQueEstudian = 0;


            for (int i = 1; i <= totalEstudiantes; i++)
            {
                string ocupacion;
                while (true)
                {
                    Console.Write($"Estudiante {i} - Ingrese ocupación (Trabaja: T / Estudia: E): ");
                    ocupacion = (Console.ReadLine() ?? "").Trim().ToLower(); // Convertir a minúsculas para facilitar la comparación
                    if (ocupacion == "t" || ocupacion == "e" || ocupacion == "trabaja" || ocupacion == "estudia")
                        break;
                    Console.WriteLine("Entrada no válida. Use 'T' para trabaja o 'E' para estudia.");
                }

                string genero;
                while (true)
                {
                    Console.Write($"Estudiante {i} Ingrese genero: (Masculino: M / Femenino: F): ");
                    genero = (Console.ReadLine() ?? "").Trim().ToLower(); //c0onvertir en minusculas
                    if (genero == "m" || genero == "f" || genero == "masculino" || genero == "femenino")
                        break;
                    Console.WriteLine("Entrada no válida. Use 'M' para masculino o 'F' para femenino.");
                }

                bool trabaja = ocupacion.StartsWith("t");
                bool estudia = ocupacion.StartsWith("e");
                bool masculino = genero.StartsWith("m");
                bool femenino = genero.StartsWith("f");

                if (trabaja) estudiantesQueTrabajan++;
                if (estudia) estudiantesQueEstudian++;

                if (trabaja && femenino) mujeresQueTrabajan++;
                if (estudia && masculino) hombresQueEstudian++;
            }

            double porcentajeTrabaja = (double)estudiantesQueTrabajan / totalEstudiantes * 100.0;
            double porcentajeEstudia = (double)estudiantesQueEstudian / totalEstudiantes * 100.0;

            Console.WriteLine();
            Console.WriteLine($"Porcentaje que trabaja: {porcentajeTrabaja:F2}%");
            Console.WriteLine($"Porcentaje que estudia: {porcentajeEstudia:F2}%");
            Console.WriteLine($"Número de mujeres que trabajan: {mujeresQueTrabajan}");
            Console.WriteLine($"Número de hombres que estudian: {hombresQueEstudian}");


        }
    }
}

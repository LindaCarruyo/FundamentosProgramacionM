using System;

namespace DondeDamianTiendita_ProyectoGrupal
{
    internal class Program
    {
        // --- Datos de Usuarios---
        static string[] cedulasUsuarios = new string[20];
        static string[] nombresUsuarios = new string[20];
        static string[] apellidosUsuarios = new string[20];
        static string[] telefonosUsuarios = new string[20];
        static string[] emailsUsuarios = new string[20];
        static int totalUsuarios = 0;

        // --- Datos de Artículos---
        static int[] idsArticulos = new int[20];
        static string[] nombresArticulos = new string[20];
        static double[] preciosArticulos = new double[20];
        static int[] stocksArticulos = new int[20];
        static int totalArticulos = 0;

        //--- Datos de Ventas ---
        static int CeleccionUsuarioVenta; // Índice del usuario seleccionado para la venta

        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        static void ShowMainMenu()
        {
            bool enMenuPrincipal = true;
            while (enMenuPrincipal)
            {
                Console.Clear();
                Console.WriteLine("----------- MENÚ PRINCIPAL -----------");
                Console.WriteLine("1) Gestión de Usuarios");
                Console.WriteLine("2) Gestión de Productos");
                Console.WriteLine("3) Gestión de Ventas");
                Console.WriteLine("4) Salir");
                Console.WriteLine("--------------------------------------");
                int opcion = ReadInt("Seleccione una opción: ", 1, 4);

                switch (opcion)
                {
                    case 1:
                        GestionUsuarios();
                        break;
                    case 2:
                        GestionArticulos();
                        break;
                    case 3:
                        GestionVentas();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        enMenuPrincipal = false;
                        break;
                }
            }
        }

        // ----------------- GESTIÓN DE USUARIOS -----------------
        static void GestionUsuarios()
        {
            bool enMenuUsuarios = true;
            while (enMenuUsuarios)
            {
                Console.Clear();
                Console.WriteLine("---- GESTIÓN DE USUARIOS ----");
                Console.WriteLine("1) Ver Lista de Usuarios");
                Console.WriteLine("2) Ingresar un Nuevo Usuario");
                Console.WriteLine("3) Editar Información de Usuario");
                Console.WriteLine("4) Volver al Menú Principal");
                int opcion = ReadInt("Seleccione una opción: ", 1, 4);

                switch (opcion)
                {
                    case 1:
                        VerListaUsuarios();
                        break;
                    case 2:
                        IngresarNuevoUsuario();
                        break;
                    case 3:
                        EditarUsuario();
                        break;
                    case 4:
                        enMenuUsuarios = false;
                        break;
                }
            }
        }

        static void VerListaUsuarios()
        {
            Console.Clear();
            if (totalUsuarios == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
                Console.WriteLine();
                Console.WriteLine("¿Desea registrar un nuevo usuario?");
                Console.WriteLine("1) Sí");
                Console.WriteLine("2) No");
                int opcion = ReadInt("Seleccione una opción: ", 1, 2);
                if (opcion == 1)
                {
                    IngresarNuevoUsuario();
                }
                else
                {
                    Pause();
                }
            }
            else
            {
                Console.WriteLine("------- Lista de Usuarios -------");
                for (int i = 0; i < totalUsuarios; i++)
                {
                    Console.WriteLine("Usuario " + (i + 1) + ":");
                    Console.WriteLine("  C.C.:     " + cedulasUsuarios[i]);
                    Console.WriteLine("  Nombre:   " + nombresUsuarios[i]);
                    Console.WriteLine("  Apellido: " + apellidosUsuarios[i]);
                    Console.WriteLine("  Teléfono: " + telefonosUsuarios[i]);
                    Console.WriteLine("  Email:    " + emailsUsuarios[i]);
                    Console.WriteLine("---------------------------------");
                }
                Console.WriteLine("Total de usuarios: " + totalUsuarios);
                Pause();
            }
        }

        static void IngresarNuevoUsuario()
        {
            Console.Clear();
            if (totalUsuarios >= cedulasUsuarios.Length)
            {
                Console.WriteLine("No se pueden registrar más usuarios (límite alcanzado).");
                Pause();
                return;
            }

            string cedula = ReadString("Ingrese la cédula: ");
            for (int i = 0; i < totalUsuarios; i++)
            {
                if (cedulasUsuarios[i] == cedula)
                {
                    Console.WriteLine("Ya existe un usuario con esa cédula.");
                    Pause();
                    return;
                }
            }

            string nombre = ReadString("Ingrese el nombre: ");
            string apellido = ReadString("Ingrese el apellido: ");
            string telefono = ReadString("Ingrese el teléfono: ");
            string email = ReadString("Ingrese el email: ");

            cedulasUsuarios[totalUsuarios] = cedula;
            nombresUsuarios[totalUsuarios] = nombre;
            apellidosUsuarios[totalUsuarios] = apellido;
            telefonosUsuarios[totalUsuarios] = telefono;
            emailsUsuarios[totalUsuarios] = email;
            totalUsuarios++;

            Console.WriteLine("Usuario registrado exitosamente.");
            Pause();
        }

        static void EditarUsuario()
        {
            Console.Clear();
            if (totalUsuarios == 0)
            {
                Console.WriteLine("No hay usuarios registrados. presione cualquier tecla para regresar.");
                Console.ReadKey();
                Pause();
                return;
            }

            string cedula = ReadString("Ingrese la cédula del usuario a editar: ");
            int posicion = -1;
            for (int i = 0; i < totalUsuarios; i++)
            {
                if (cedulasUsuarios[i] == cedula)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
            {
                Console.WriteLine("No se encontró un usuario con esa cédula.");
                Pause();
                return;
            }

            Console.WriteLine("Usuario encontrado: " + nombresUsuarios[posicion] + " " + apellidosUsuarios[posicion]);
            Console.WriteLine("(Presione ENTER para dejar el campo sin cambios)");

            string nuevoNombre = ReadStringAllowEmpty("Nuevo nombre [" + nombresUsuarios[posicion] + "]: ");
            if (!string.IsNullOrEmpty(nuevoNombre)) nombresUsuarios[posicion] = nuevoNombre;

            string nuevoApellido = ReadStringAllowEmpty("Nuevo apellido [" + apellidosUsuarios[posicion] + "]: ");
            if (!string.IsNullOrEmpty(nuevoApellido)) apellidosUsuarios[posicion] = nuevoApellido;

            string nuevoTelefono = ReadStringAllowEmpty("Nuevo teléfono [" + telefonosUsuarios[posicion] + "]: ");
            if (!string.IsNullOrEmpty(nuevoTelefono)) telefonosUsuarios[posicion] = nuevoTelefono;

            string nuevoEmail = ReadStringAllowEmpty("Nuevo email [" + emailsUsuarios[posicion] + "]: ");
            if (!string.IsNullOrEmpty(nuevoEmail)) emailsUsuarios[posicion] = nuevoEmail;

            Console.WriteLine("Usuario actualizado correctamente.");
            Pause();
        }

        // ----------------- GESTIÓN DE ARTÍCULOS -----------------
        static void GestionArticulos()
        {
            bool enMenuArticulos = true;
            while (enMenuArticulos)
            {
                Console.Clear();
                Console.WriteLine("---- GESTIÓN DE ARTÍCULOS ----");
                Console.WriteLine("1) Ver Lista de Artículos");
                Console.WriteLine("2) Ingresar un Nuevo Artículo");
                Console.WriteLine("3) Editar Información de Artículo");
                Console.WriteLine("4) Volver al Menú Principal");
                int opcion = ReadInt("Seleccione una opción: ", 1, 4);

                switch (opcion)
                {
                    case 1:
                        VerListaArticulos();
                        break;
                    case 2:
                        IngresarNuevoArticulo();
                        break;
                    case 3:
                        EditarArticulo();
                        break;
                    case 4:
                        enMenuArticulos = false;
                        break;
                }
            }
        }

        static void VerListaArticulos()
        {
            Console.Clear();
            if (totalArticulos == 0)
            {
                Console.WriteLine("No hay artículos registrados.");
            }
            else
            {
                Console.WriteLine("------- Lista de Artículos -------");
                for (int i = 0; i < totalArticulos; i++)
                {
                    Console.WriteLine("Artículo " + (i + 1) + ":");
                    Console.WriteLine("  ID:     " + idsArticulos[i]);
                    Console.WriteLine("  Nombre: " + nombresArticulos[i]);
                    Console.WriteLine("  Precio: $" + preciosArticulos[i].ToString("0.00"));
                    Console.WriteLine("  Stock:  " + stocksArticulos[i]);
                    Console.WriteLine("----------------------------------");
                }
                Console.WriteLine("Total de artículos: " + totalArticulos);
            }
            Pause();
        }

        static void IngresarNuevoArticulo()
        {
            Console.Clear();
            if (totalArticulos >= idsArticulos.Length)
            {
                Console.WriteLine("No se pueden registrar más artículos (límite alcanzado).");
                Pause();
                return;
            }

            int id = ReadInt("Ingrese el ID del artículo: ");
            for (int i = 0; i < totalArticulos; i++)
            {
                if (idsArticulos[i] == id)
                {
                    Console.WriteLine("Ya existe un artículo con ese ID.");
                    Pause();
                    return;
                }
            }

            string nombre = ReadString("Ingrese el nombre del artículo: ");
            double precio = ReadDouble("Ingrese el precio: ");
            int stock = ReadInt("Ingrese el stock: ", 0, int.MaxValue);

            idsArticulos[totalArticulos] = id;
            nombresArticulos[totalArticulos] = nombre;
            preciosArticulos[totalArticulos] = precio;
            stocksArticulos[totalArticulos] = stock;
            totalArticulos++;

            Console.WriteLine("Artículo registrado exitosamente.");
            Pause();
        }

        static void EditarArticulo()
        {
            Console.Clear();
            if (totalArticulos == 0)
            {
                Console.WriteLine("No hay artículos registrados.");
                Pause();
                return;
            }

            int id = ReadInt("Ingrese el ID del artículo a editar: ");
            int posicion = -1;
            for (int i = 0; i < totalArticulos; i++)
            {
                if (idsArticulos[i] == id)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
            {
                Console.WriteLine("No se encontró un artículo con ese ID.");
                Pause();
                return;
            }

            Console.WriteLine("Artículo encontrado: " + nombresArticulos[posicion]);
            Console.WriteLine("(Presione ENTER para dejar el campo sin cambios)");

            string nuevoNombre = ReadStringAllowEmpty("Nuevo nombre [" + nombresArticulos[posicion] + "]: ");
            if (!string.IsNullOrEmpty(nuevoNombre)) nombresArticulos[posicion] = nuevoNombre;

            string nuevoPrecioTexto = ReadStringAllowEmpty("Nuevo precio [" + preciosArticulos[posicion] + "]: ");
            double np;
            if (!string.IsNullOrEmpty(nuevoPrecioTexto) && double.TryParse(nuevoPrecioTexto, out np)) preciosArticulos[posicion] = np;

            string nuevoStockTexto = ReadStringAllowEmpty("Nuevo stock [" + stocksArticulos[posicion] + "]: ");
            int ns;
            if (!string.IsNullOrEmpty(nuevoStockTexto) && int.TryParse(nuevoStockTexto, out ns)) stocksArticulos[posicion] = ns;

            Console.WriteLine("Artículo actualizado correctamente.");
            Pause();
        }

        // ----------------- GESTIÓN DE VENTAS (SIMPLE, SIN LISTAS) -----------------
        static void GestionVentas()
        {
            Console.Clear();
            Console.WriteLine("---- GESTIÓN DE VENTAS ----");

            bool hayUsuarios = totalUsuarios > 0;
            bool hayArticulosEnStock = false;
            for (int i = 0; i < totalArticulos; i++)
            {
                if (stocksArticulos[i] > 0)
                {
                    hayArticulosEnStock = true;
                    break;
                }
            }

            if (!hayUsuarios || !hayArticulosEnStock)
            {
                Console.WriteLine("No hay suficientes datos para realizar ventas.");
                if (!hayUsuarios) Console.WriteLine("- No hay usuarios registrados.");
                if (!hayArticulosEnStock) Console.WriteLine("- No hay artículos con stock disponible.");

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1) Registrar usuario");
                Console.WriteLine("2) Registrar artículo");
                Console.WriteLine("3) Volver al Menú Principal");

                int opcion = ReadInt("Seleccione una opción: ", 1, 3);
                if (opcion == 1)
                {
                    IngresarNuevoUsuario();
                }
                else if (opcion == 2)
                {
                    IngresarNuevoArticulo();
                }
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---- GESTIÓN DE VENTAS ----");
                Console.WriteLine("Seleccione usuario:");

                for (int i = 0; i < totalUsuarios; i++)
                {
                    Console.WriteLine((i + 1) + ") " + nombresUsuarios[i] + " " + apellidosUsuarios[i] + " - C.C.: " + cedulasUsuarios[i]);
                }
                int seleccionUsuario = ReadInt("Seleccione un usuario por número: ", 1, totalUsuarios);
                CeleccionUsuarioVenta = seleccionUsuario - 1;

                Console.Clear();
                Console.WriteLine("Usuario seleccionado: " + nombresUsuarios[CeleccionUsuarioVenta] + " " + apellidosUsuarios[CeleccionUsuarioVenta] + " - C.C.: " + cedulasUsuarios[CeleccionUsuarioVenta]);

                int[] indicesSeleccionados = new int[20];
                int[] cantidadesSeleccionadas = new int[20];
                int totalSeleccionados = 0;
                const int maxItemsPorVenta = 20;

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Seleccione artículos para la venta (límite 20 artículos distintos):");

                    int[] disponibles = new int[20];
                    int disponiblesCount = 0;
                    for (int i = 0; i < totalArticulos; i++)
                    {
                        if (stocksArticulos[i] > 0)
                        {
                            disponibles[disponiblesCount] = i;
                            disponiblesCount++;
                        }
                    }

                    if (disponiblesCount == 0)
                    {
                        Console.WriteLine("No hay artículos con stock disponible.");
                        break;
                    }

                    Console.WriteLine("0) Generar factura / Finalizar selección");
                    for (int i = 0; i < disponiblesCount; i++)
                    {
                        int idx = disponibles[i];
                        Console.WriteLine((i + 1) + ") " + nombresArticulos[idx] + " - Precio: $" + preciosArticulos[idx].ToString("0.00") + " - Stock: " + stocksArticulos[idx]);
                    }

                    int opcionArticulo = ReadInt("Seleccione un artículo por número (o 0 para terminar): ", 0, disponiblesCount);
                    if (opcionArticulo == 0)
                    {
                        if (totalSeleccionados == 0)
                        {
                            Console.WriteLine("No se seleccionaron artículos. Venta cancelada.");
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("---- RESUMEN DE LA VENTA ----");
                        Console.WriteLine("Cliente: " + nombresUsuarios[CeleccionUsuarioVenta] + " " + apellidosUsuarios[CeleccionUsuarioVenta] + " - C.C.: " + cedulasUsuarios[CeleccionUsuarioVenta]);
                        Console.WriteLine();
                        double totalVenta = 0.0;
                        Console.WriteLine("ARTÍCULOS:");
                        for (int k = 0; k < totalSeleccionados; k++)
                        {
                            int artIdx = indicesSeleccionados[k];
                            int cant = cantidadesSeleccionadas[k];
                            double precioUnit = preciosArticulos[artIdx];
                            double subtotal = precioUnit * cant;
                            totalVenta += subtotal;
                            Console.WriteLine((k + 1) + ") " + nombresArticulos[artIdx] + " - Cantidad: " + cant + " - Precio unitario: $" + precioUnit.ToString("0.00") + " - Subtotal: $" + subtotal.ToString("0.00"));
                        }
                        Console.WriteLine();
                        Console.WriteLine("TOTAL A PAGAR: $" + totalVenta.ToString("0.00"));
                        Console.WriteLine();
                        Console.WriteLine("1) Confirmar compra");
                        Console.WriteLine("2) Cancelar compra");

                        int confirmar = ReadInt("Seleccione una opción: ", 1, 2);
                        if (confirmar == 1)
                        {
                            for (int k = 0; k < totalSeleccionados; k++)
                            {
                                int idx = indicesSeleccionados[k];
                                stocksArticulos[idx] = stocksArticulos[idx] - cantidadesSeleccionadas[k];
                                if (stocksArticulos[idx] < 0) stocksArticulos[idx] = 0;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Compra aprobada. Gracias por su compra, muestre el ticket a la salida.");
                        }
                        else
                        {
                            Console.WriteLine("Compra cancelada.");
                        }

                        Console.WriteLine();
                        Console.WriteLine("¿Desea realizar otra venta?");
                        Console.WriteLine("1) Sí");
                        Console.WriteLine("2) Volver al Menú Principal");
                        int otra = ReadInt("Seleccione una opción: ", 1, 2);
                        if (otra == 1)
                        {
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        int artSeleccionadoIdx = disponibles[opcionArticulo - 1];
                        int stockDisponible = stocksArticulos[artSeleccionadoIdx];
                        int maxVendible = stockDisponible;

                        int existenteIndex = -1;
                        for (int i = 0; i < totalSeleccionados; i++)
                        {
                            if (indicesSeleccionados[i] == artSeleccionadoIdx)
                            {
                                existenteIndex = i;
                                break;
                            }
                        }

                        if (existenteIndex >= 0)
                        {
                            maxVendible = stockDisponible - cantidadesSeleccionadas[existenteIndex];
                            if (maxVendible <= 0)
                            {
                                Console.WriteLine("Ya seleccionó la máxima cantidad disponible de este artículo.");
                                continue;
                            }
                        }

                        int cantidad = ReadInt("Ingrese la cantidad a vender (1 - " + maxVendible + "): ", 1, maxVendible);

                        if (existenteIndex >= 0)
                        {
                            cantidadesSeleccionadas[existenteIndex] = cantidadesSeleccionadas[existenteIndex] + cantidad;
                        }
                        else
                        {
                            if (totalSeleccionados >= maxItemsPorVenta)
                            {
                                Console.WriteLine("Ha alcanzado el límite de " + maxItemsPorVenta + " artículos distintos por venta.");
                                continue;
                            }
                            indicesSeleccionados[totalSeleccionados] = artSeleccionadoIdx;
                            cantidadesSeleccionadas[totalSeleccionados] = cantidad;
                            totalSeleccionados++;
                        }

                        Console.WriteLine("Artículo agregado: " + nombresArticulos[artSeleccionadoIdx] + " x" + cantidad);

                        if (totalSeleccionados >= maxItemsPorVenta)
                        {
                            Console.WriteLine("Se alcanzó el límite de 20 artículos distintos. Procediendo a generar la factura...");
                            Console.WriteLine("Presione ENTER para continuar.");
                            Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("---- RESUMEN DE LA VENTA ----");
                            Console.WriteLine("Cliente: " + nombresUsuarios[CeleccionUsuarioVenta] + " " + apellidosUsuarios[CeleccionUsuarioVenta] + " - C.C.: " + cedulasUsuarios[CeleccionUsuarioVenta]);
                            Console.WriteLine();
                            double totalVenta = 0.0;
                            Console.WriteLine("ARTÍCULOS:");
                            for (int k = 0; k < totalSeleccionados; k++)
                            {
                                int idx = indicesSeleccionados[k];
                                int cant = cantidadesSeleccionadas[k];
                                double precioUnit = preciosArticulos[idx];
                                double subtotal = precioUnit * cant;
                                totalVenta += subtotal;
                                Console.WriteLine((k + 1) + ") " + nombresArticulos[idx] + " - Cantidad: " + cant + " - Precio unitario: $" + precioUnit.ToString("0.00") + " - Subtotal: $" + subtotal.ToString("0.00"));
                            }
                            Console.WriteLine();
                            Console.WriteLine("TOTAL A PAGAR: $" + totalVenta.ToString("0.00"));
                            Console.WriteLine();
                            Console.WriteLine("1) Confirmar compra");
                            Console.WriteLine("2) Cancelar compra");

                            int confirmar2 = ReadInt("Seleccione una opción: ", 1, 2);
                            if (confirmar2 == 1)
                            {
                                for (int k = 0; k < totalSeleccionados; k++)
                                {
                                    int idx = indicesSeleccionados[k];
                                    stocksArticulos[idx] = stocksArticulos[idx] - cantidadesSeleccionadas[k];
                                    if (stocksArticulos[idx] < 0) stocksArticulos[idx] = 0;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Compra aprobada. Gracias por su compra, muestre el ticket a la salida.");
                            }
                            else
                            {
                                Console.WriteLine("Compra cancelada.");
                            }

                            Console.WriteLine();
                            Console.WriteLine("¿Desea realizar otra venta?");
                            Console.WriteLine("1) Sí");
                            Console.WriteLine("2) Volver al Menú Principal");
                            int otra2 = ReadInt("Seleccione una opción: ", 1, 2);
                            if (otra2 == 1)
                            {
                                break;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
                Pause();
            }
        }

        // ----------------- MÉTODOS AUXILIARES -----------------
        static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                int val;
                if (int.TryParse(input, out val) && val >= min && val <= max)
                    return val;
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                double val;
                if (double.TryParse(input, out val))
                    return val;
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        static string ReadString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                    return input.Trim();
                Console.WriteLine("El valor no puede estar vacío.");
            }
        }

        static string ReadStringAllowEmpty(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (input == null) return string.Empty;
            return input.Trim();
        }

        static void Pause()
        {
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}


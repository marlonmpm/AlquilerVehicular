using System;
using System.Collections.Generic;
using SistemaAlquilerVehiculos.enums;

namespace SistemaAlquilerVehiculos.@class
{
    class Program
    {
        static SistemaAlquiler sistema = new SistemaAlquiler();

        static void Main(string[] args)
        {
            SistemaAlquiler sistema = new SistemaAlquiler();

            while (true)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Agregar vehículo");
                Console.WriteLine("2. Mostrar flota");
                Console.WriteLine("3. Reservar vehículo");
                Console.WriteLine("4. Devolver vehículo");
                Console.WriteLine("5. Salir");
                Console.WriteLine(" ");
                Console.Write("Seleccione una opción: ");
                Console.WriteLine(" ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Marca: ");
                        string marca = Console.ReadLine();
                        Console.Write("Modelo: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Año: ");
                        int anio = int.Parse(Console.ReadLine());
                        Console.Write("Precio Alquiler: ");
                        decimal precio = decimal.Parse(Console.ReadLine());

                        Vehiculo automovil = new Automovil(marca, modelo, anio, precio);
                        sistema.AgregarVehiculo(automovil);
                        break;

                    case "2":
                        sistema.MostrarFlota();
                        break;

                    case "3":
                        Console.Write("Marca del vehículo a reservar: ");
                        string marcaReserva = Console.ReadLine();
                        Console.Write("Modelo del vehículo a reservar: ");
                        string modeloReserva = Console.ReadLine();
                        Console.Write("Nombre del cliente: ");
                        string cliente = Console.ReadLine();
                        DateTime fechaInicio = DateTime.Now;
                        DateTime fechaFin = fechaInicio.AddDays(7);

                        sistema.ReservarVehiculo(marcaReserva, modeloReserva, cliente, fechaInicio, fechaFin);
                        break;

                    case "4":
                        Console.Write("Marca del vehículo a devolver: ");
                        string marcaDevolver = Console.ReadLine();
                        Console.Write("Modelo del vehículo a devolver: ");
                        string modeloDevolver = Console.ReadLine();

                        sistema.DevolverVehiculo(marcaDevolver, modeloDevolver);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}




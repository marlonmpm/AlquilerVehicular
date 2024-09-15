using SistemaAlquilerVehiculos.enums;
using SistemaAlquilerVehiculos.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculos.@class
{

    // Clase que representa el sistema de alquiler de vehículos.
    public class SistemaAlquiler
    {

        // Lista de vehículos disponibles en la flota y clientes registrados

        private List<Vehiculo> flota = new List<Vehiculo>();
        private List<Cliente> clientes = new List<Cliente>();


        // metodo para Agregar un nuevo vehículo
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            flota.Add(vehiculo);
            Console.WriteLine($"Vehículo {vehiculo.Marca} {vehiculo.Modelo} agregado a la flota.");
        }

        

        // metodo para mostrar un lista vehículo
        public void MostrarFlota()
        {
            Console.WriteLine("Vehículos en la flota:");
            foreach (var vehiculo in flota)
            {
                Console.WriteLine($"{vehiculo.Tipo}: {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Anio}) - Estado: {vehiculo.Estado}");
            }
        }

        public void ReservarVehiculo(string marca, string modelo, string cliente, DateTime fechaInicio, DateTime fechaFin)
        {
            var vehiculo = flota.FirstOrDefault(v => v.Marca == marca && v.Modelo == modelo && v.Estado == EstadoVehiculo.DISPONIBLE);
            if (vehiculo != null)
            {
                var reserva = new Reserva(vehiculo, cliente, fechaInicio, fechaFin);
                reservas.Add(reserva);
                ((IReserva)vehiculo).Reservar();
            }
            else
            {
                Console.WriteLine("No se encontró un vehículo disponible con esas características.");
            }
        }

        public void DevolverVehiculo(string marca, string modelo)
        {
            var vehiculo = flota.FirstOrDefault(v => v.Marca == marca && v.Modelo == modelo && v.Estado == EstadoVehiculo.ALQUILADO);
            if (vehiculo != null)
            {
                ((IDevuelve)vehiculo).Devolver();
            }
            else
            {
                Console.WriteLine("El vehículo no está alquilado.");
            }
        }

    }
}

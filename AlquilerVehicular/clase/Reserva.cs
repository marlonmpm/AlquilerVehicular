using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculos.@class
{

    // Representa una reserva de un vehículo por un cliente.
    public class Reserva
    {

        public String Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }


        // Constructor de la clase Reserva.
        public Reserva(String cliente, Vehiculo vehiculo, DateTime fechaInicio, DateTime fechaFin)
        {
            Cliente = cliente;
            Vehiculo = vehiculo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public MostrarReseva(Vehiculo vehiculo, string cliente, DateTime fechaInicio)
        {
            Console.WriteLine($"Cliente: {Cliente}, Vehículo: {Vehiculo.Marca} {Vehiculo.Modelo}, Desde: {FechaInicio}, Hasta: {FechaFin}");
        }
    }
    
}

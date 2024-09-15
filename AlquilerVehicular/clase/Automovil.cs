using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlquilerVehiculos.enums;
using SistemaAlquilerVehiculos.interfaces;

namespace SistemaAlquilerVehiculos.@class
{

    public class Automovil : Vehiculo, IDevuelve, IReserva
    {
        public Automovil(string marca, string modelo, int anio, decimal precioAlquiler)
              : base(marca, modelo, anio, precioAlquiler) { }

        public void Devolver()
        {
            if (Estado == EstadoVehiculo.ALQUILADO)
            {
                Console.WriteLine($"El automóvil {Marca}, {Modelo} ha sido devuelto.");
            }
        }

        public void Reservar(Cliente cliente, DateTime fechaInicio, DateTime fechaFin)
        {
            if (Estado == EstadoVehiculo.DISPONIBLE)
            {
                CambiarEstado(EstadoVehiculo.ALQUILADO);
                Console.WriteLine($"El automóvil {Marca}, {Modelo} ha sido reservado.");
            }
            else
            {
                Console.WriteLine("Este automóvil no está disponible.");
            }
        }

        public void Reservar()
        {
            throw new NotImplementedException();
        }
    }
}


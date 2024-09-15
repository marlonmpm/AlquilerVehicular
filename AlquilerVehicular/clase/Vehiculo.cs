using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlquilerVehiculos.@class;
using SistemaAlquilerVehiculos.enums;
using SistemaAlquilerVehiculos.interfaces;

namespace SistemaAlquilerVehiculos.@class
{

    // Clase abstracta que representa un vehículo genérico.
    public abstract class Vehiculo 
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public EstadoVehiculo Estado { get; set; }
        public decimal PrecioAlquiler { get; private set; }
        public abstract TipoVehiculo Tipo { get; set; }


        public Vehiculo(string marca, string modelo, int anio, decimal precioAlquiler, TipoVehiculo tipo )
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Tipo = tipo;
            PrecioAlquiler = precioAlquiler;
            Estado = EstadoVehiculo.DISPONIBLE;
        }



        public void CambiarEstado(EstadoVehiculo nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Precio Alquiler: {PrecioAlquiler}, Estado: {Estado}");
        }


      
    }
}

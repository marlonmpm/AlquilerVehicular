using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlquilerVehiculos.@class
{

    //  cliente del sistema de alquiler de vehículos.
    public class Cliente
    {

        public string Nombre { get; set; }
        public string DNI { get; set; }


        // Constructor de la clase Cliente.
        public Cliente(string nombre, string dni)
        {
            Nombre = nombre;
            DNI = dni;
        }
    }
}

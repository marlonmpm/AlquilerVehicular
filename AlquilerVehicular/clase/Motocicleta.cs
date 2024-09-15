using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlquilerVehiculos.enums;

namespace SistemaAlquilerVehiculos.@class
{
    internal class Motocicleta : Vehiculo
    {

        public override TipoVehiculo Tipo => TipoVehiculo.MOTOCICLETA;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlquilerVehiculos.enums;

namespace SistemaAlquilerVehiculos.@class
{
    public class Camion : Vehiculo
    {

        public override TipoVehiculo Tipo => TipoVehiculo.CAMION;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Edvi.Models.Model;

namespace Edvi.Interfaces.Validador
{
    public interface Ivalidador
    {
        void ValidarCliente(Cliente cliente);
        void ValidarGuia(GuiaRemision guia);
        void ValidarRuta(Ruta ruta);
        void ValidarVehiculo(Vehiculo vehiculo);
    }
}

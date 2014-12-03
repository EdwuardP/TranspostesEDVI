using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.Models.Model;
namespace Edvi.Interfaces.Service
{
    public interface IVehiculoService
    {
        //Vehiculo GetFromVehiculoById(Int32 id);
        void AddVehiculo(Vehiculo vehiculo);
        IList<Vehiculo> AllVehiculo();
   
    }
}

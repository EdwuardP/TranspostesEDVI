using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.DB.DB;
using Edvi.Interfaces.Service;
namespace Edvi.Services.Service
{
    public class VehiculoService:IVehiculoService
    {
       private readonly Databases database;

       public VehiculoService(Databases database)
        {
            this.database = database;
        }
        public void AddVehiculo(Models.Model.Vehiculo vehiculo)
        {
            database.Vehiculos.Add(vehiculo);
            database.SaveChanges();
        }


        public IList<Models.Model.Vehiculo> AllVehiculo()
        {
            return database.Vehiculos.ToList();
        }
    }
}

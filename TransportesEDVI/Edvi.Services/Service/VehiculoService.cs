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
       private readonly Database database;

       public VehiculoService(Database database)
        {
            this.database = database;
        }
        public void AddVehiculo(Models.Model.Vehiculo vehiculo)
        {
            database.Vehiculos.Add(vehiculo);
            database.SaveChanges();
        }
    }
}

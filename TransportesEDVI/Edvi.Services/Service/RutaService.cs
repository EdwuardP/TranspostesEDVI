using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.DB.DB;
using Edvi.Interfaces.Service;
namespace Edvi.Services.Service
{
    public class RutaService:IRutaService
    {
       private readonly Database database;

       public RutaService(Database database)
        {
            this.database = database;
        }
        public void AddRuta(Models.Model.Ruta ruta)
        {
            database.Rutas.Add(ruta);
            database.SaveChanges();
        }
    }
}

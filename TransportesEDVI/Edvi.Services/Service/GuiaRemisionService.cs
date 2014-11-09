using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.DB.DB;
using Edvi.Interfaces.Service;
namespace Edvi.Services.Service
{
    public class GuiaRemisionService:IGuiaRemisionService
    {
        private readonly Databases database;

        public GuiaRemisionService(Databases database)
        {
            this.database = database;
        }
        public void AddGuiaRemision(Models.Model.GuiaRemision guiaRemision)
        {
            database.GuiaRemisions.Add(guiaRemision);
            database.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.DB.DB;
using Edvi.Interfaces.Service;

namespace Edvi.Services.Service
{
    public class ClienteService:IClienteService
    {
        private readonly Databases database;

        public ClienteService(Databases database)
        {
            this.database = database;
        }

        public void AddCliente(Models.Model.Cliente cliente)
        {
            database.Clientes.Add(cliente);
            database.SaveChanges();
        }
    }
}

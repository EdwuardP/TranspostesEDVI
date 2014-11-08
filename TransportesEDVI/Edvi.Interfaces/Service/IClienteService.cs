using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.Models.Model;

namespace Edvi.Interfaces.Service
{
    public interface IClienteService
    {
        //Cliente getFromClienteById(Int32 id);
        void AddCliente(Cliente cliente);
    }
}

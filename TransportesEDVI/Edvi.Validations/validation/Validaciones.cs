using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.Interfaces.Validador;

namespace Edvi.Validations.validation
{
    public class Validaciones:Ivalidador
    {

        public void ValidarCliente(Models.Model.Cliente cliente)
        {
          //  throw new NotImplementedException();
             if(cliente.Ruc.Length!=11)
             {
              
                // ModelState.AddModelError("Ruc", "Ruta debe de ser 11 digitos");
             }
        }

        public void ValidarGuia(Models.Model.GuiaRemision guia)
        {
            throw new NotImplementedException();
        }

        public void ValidarRuta(Models.Model.Ruta ruta)
        {
            throw new NotImplementedException();
        }

        public void ValidarVehiculo(Models.Model.Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }


        public void ValidateCreateCliente(Models.Model.Cliente cliente,  System.Web.Mvc.ModelStateDictionary modelState )
        {
            var ruc = cliente.Ruc;
            if (ruc.Length!=11)
            {
                modelState.AddModelError("Ruc", "El ruc tiene que ser 11 digitos");    
            }
            
        }
    }
}

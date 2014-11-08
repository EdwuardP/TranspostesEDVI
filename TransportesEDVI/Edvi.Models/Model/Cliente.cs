using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvi.Models.Model
{
    public class Cliente
    {
        //public Cliente()
        //{
        //this.Contratoes = new List<Contrato>();
        //}
        public Int32 Id { get; set; }
        public String Ruc { get; set; }
        public String RazSocial { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        
        //public List<Contrato> Contratoes { get; set; }

    }
}

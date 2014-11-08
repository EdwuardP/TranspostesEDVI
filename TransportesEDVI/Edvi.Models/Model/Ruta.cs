using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvi.Models.Model
{
    public class Ruta
    {
        //public Ruta()
        //{
        //this.DetalleContratoes = new List<DetalleContrato>();
        //}
        public Int32 Id { get; set; }
        public String Origen { get; set; }
        public String Destino { get; set; }
        public String Descripcion { get; set; }
        public String Distancia { get; set; }
        //public List<DetalleContrato> DetalleContratoes { get; set; }

    }
}

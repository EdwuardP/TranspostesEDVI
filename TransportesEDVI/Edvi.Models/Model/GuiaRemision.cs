using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvi.Models.Model
{
    public class GuiaRemision
    {
        //public GuiaRemision()
        //{
        //    this.DetalleGuiaRemisions = new List<DetalleGuiaRemision>();
        //}

        public Int32 Id { get; set; }
        public String Nro { get; set; }
        public Decimal PesoTotal { get; set; }
        public String Estado { get; set; }
        //public List<DetalleGuiaRemision> DetalleGuiaRemisions { get; set; }

    }
}

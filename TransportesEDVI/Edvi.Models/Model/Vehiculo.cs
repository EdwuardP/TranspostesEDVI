using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvi.Models.Model
{
    public class Vehiculo
    {
        //public Vehiculo()
        //{
        //    this.DetalleGastMants = new List<DetalleGastMant>();
        //}
        public Int32 Id { get; set; }
        public String PlacaVehiculo { get; set; }
        public String Marca { get; set; }
        public String PlacaCarreta { get; set; }
        public String Modelo { get; set; }
        public String CertInscripcion { get; set; }
        public String ConfVehicular { get; set; }
        public DateTime FecVenSoat { get; set; }
        public DateTime FecUltRevTecnica { get; set; }
        public Decimal CargaBruta { get; set; }
        public String Estado { get; set; }
        //public List<DetalleGastMant> DetalleGastMants { get; set; }
    }
}

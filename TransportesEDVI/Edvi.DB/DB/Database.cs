using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.DB.Map;
using Edvi.Models.Model;

namespace Edvi.DB.DB
{
    public  class Database : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<GuiaRemision> GuiaRemisions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Configurations.Add(new ClienteMap());
        modelBuilder.Configurations.Add(new RutaMap());
        modelBuilder.Configurations.Add(new VehiculoMap());
        modelBuilder.Configurations.Add(new GuiaRemisionMap());
        //modelBuilder.Configurations.Add<Cliente>(new ClienteMap());
        }
    }
}

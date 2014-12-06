using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.DB.Map;
using Edvi.Models.Model;

namespace Edvi.DB.DB
{
    public  class Databases : DbContext
    {
        //public Databases()
        //{
        //    Database.SetInitializer<Databases>(null);
        //    Database.SetInitializer<Databases>(new CreateDatabaseIfNotExists<Databases>());
        //}
        //public DbSet

        public virtual IDbSet<Cliente> Clientes { get; set; }
        public virtual IDbSet<Ruta> Rutas { get; set; }
        public virtual IDbSet<Vehiculo> Vehiculos { get; set; }
        public virtual IDbSet<GuiaRemision> GuiaRemisions { get; set; }

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

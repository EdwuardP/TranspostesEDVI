using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using Edvi.Models.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvi.DB.Map
{
    public class VehiculoMap : EntityTypeConfiguration<Vehiculo>
    {
        public VehiculoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.PlacaVehiculo)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Marca)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PlacaCarreta)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Modelo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CertInscripcion)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ConfVehicular)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Estado)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Vehiculos");

            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlacaVehiculo).HasColumnName("PlacaVehiculo");
            this.Property(t => t.Marca).HasColumnName("Marca");
            this.Property(t => t.PlacaCarreta).HasColumnName("PlacaCarreta");
            this.Property(t => t.Modelo).HasColumnName("Modelo");
            this.Property(t => t.CertInscripcion).HasColumnName("CestidicadoIncripcion");
            this.Property(t => t.ConfVehicular).HasColumnName("ConfiguracionVehicular");
            this.Property(t => t.FecVenSoat).HasColumnName("Soat");
            this.Property(t => t.FecUltRevTecnica).HasColumnName("RevicionTecnica");
            this.Property(t => t.CargaBruta).HasColumnName("CargaBruta");
            this.Property(t => t.Estado).HasColumnName("Estado");
        }
    }
}
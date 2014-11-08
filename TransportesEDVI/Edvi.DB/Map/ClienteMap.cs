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
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties

            this.Property(t => t.Ruc)
                .IsRequired().HasMaxLength(11);

            this.Property(t => t.RazSocial)
                .IsRequired().HasMaxLength(100);

            this.Property(t => t.Direccion)
                .IsRequired().HasMaxLength(150);

            this.Property(t => t.Telefono).HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Cliente");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Ruc).HasColumnName("Ruc");
            this.Property(t => t.RazSocial).HasColumnName("RazSocial");
            this.Property(t => t.Telefono).HasColumnName("Telefono");
            this.Property(t => t.Direccion).HasColumnName("Direccion");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Mappings
{
    class RehberMapping : EntityTypeConfiguration<Rehber>
    {
        public RehberMapping()
        {
            HasKey(a => new { a.RehberID });
            Property(a => a.Ad).IsRequired().HasMaxLength(30).HasColumnType("nvarchar");
            Property(a => a.Soyad).IsRequired().HasMaxLength(30).HasColumnType("nvarchar");
            HasMany(a => a.Faturalar)
               .WithRequired(a => a.Rehber)
               .HasForeignKey(a => a.RehberID)
               .WillCascadeOnDelete();
        }
    }
}

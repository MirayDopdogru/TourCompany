using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Mappings
{
    class OdemeTipiMapping : EntityTypeConfiguration<OdemeTipi>
    {
        public OdemeTipiMapping()
        {
            HasKey(a => new { a.TipID });
            Property(a => a.Tip).IsRequired().HasMaxLength(15).HasColumnType("nvarchar");
            HasMany(a => a.Faturalar)
               .WithRequired(a => a.OdemeTipi)
               .HasForeignKey(a => a.TipID)
               .WillCascadeOnDelete();
        }
    }
}

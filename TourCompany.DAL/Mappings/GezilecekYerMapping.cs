using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Mappings
{
    class GezilecekYerMapping : EntityTypeConfiguration<GezilecekYer>
    {
        public GezilecekYerMapping()
        {
            HasKey(a => new { a.YerID });
            Property(a => a.YerAdi).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            HasMany(a => a.Faturalar)
               .WithRequired(a => a.GezilecekYer)
               .HasForeignKey(a => a.YerID)
               .WillCascadeOnDelete();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DAL.Mappings;
using TourCompany.Model;

namespace TourCompany.DAL
{
    class TourCompanyDbContext : DbContext
    {
        public TourCompanyDbContext()
            :base(@"Server=DESKTOP-DL9ESCO\MIRAYDOPDOGRU;Database=NewDb;Trusted_Connection=True")
        {

        }

        public DbSet<Dil> Diller { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<GezilecekYer> GezilecekYerler { get; set; }
        public DbSet<OdemeTipi> OdemeTipleri { get; set; }
        public DbSet<Rehber> Rehberler { get; set; }
        public DbSet<Turist> Turistler { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DilMapping());
            modelBuilder.Configurations.Add(new FaturaMapping());
            modelBuilder.Configurations.Add(new GezilecekYerMapping());
            modelBuilder.Configurations.Add(new OdemeTipiMapping());
            modelBuilder.Configurations.Add(new RehberMapping());
            modelBuilder.Configurations.Add(new TuristMapping());

            modelBuilder.Entity<Dil>()
                .HasMany(a => a.Rehberler)
                .WithMany(a => a.Diller)
                .Map(a =>
                {
                    a.MapLeftKey("DilID");
                    a.MapRightKey("RehberID");
                    a.ToTable("DilRehber");
                });

            modelBuilder.Entity<Fatura>()
                .HasMany(a => a.Turistler)
                .WithMany(a => a.Faturalar)
                .Map(a =>
                {
                    a.MapLeftKey("FaturaID");
                    a.MapRightKey("TuristID");
                    a.ToTable("FaturaTurist");
                });


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

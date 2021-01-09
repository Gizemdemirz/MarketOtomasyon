using MarketOtamasyon.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtamasyon.Contexts
{
    class OtomasyonContext : DbContext
    {
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Urun> Uruns { get; set; }
      
        public DbSet<Satis> Satis { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}

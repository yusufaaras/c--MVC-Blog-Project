using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCegitimi.Models
{
    public partial class UrunDbContext : DbContext
    {
        
        public UrunDbContext()
            : base("name=UrunDbContext")
        {
        }

        public virtual DbSet<Kategories> Kategories { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategories>()
                .Property(e => e.KategoriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.UrunAdi)
                .IsUnicode(false);
        }
    }
}

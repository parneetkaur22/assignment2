namespace parneetkaur.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnections")
        {
        }

        public virtual DbSet<Dovebathproduct> Dovebathproducts { get; set; }
        public virtual DbSet<Dovestylingproduct> Dovestylingproducts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dovebathproduct>()
                .Property(e => e.DoveSoap)
                .IsUnicode(false);

            modelBuilder.Entity<Dovebathproduct>()
                .Property(e => e.DoveShampoo)
                .IsUnicode(false);

            modelBuilder.Entity<Dovebathproduct>()
                .Property(e => e.DoveConditioner)
                .IsUnicode(false);

            modelBuilder.Entity<Dovestylingproduct>()
                .Property(e => e.Dovehairspray)
                .IsUnicode(false);

            modelBuilder.Entity<Dovestylingproduct>()
                .Property(e => e.Dovehairgel)
                .IsUnicode(false);

            modelBuilder.Entity<Dovestylingproduct>()
                .Property(e => e.Doveheatprotector)
                .IsUnicode(false);
        }
    }
}

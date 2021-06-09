namespace Sistema_de_Venta_Facturacion.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BaseEntities : DbContext
    {
        public BaseEntities()
            : base("name=BaseEntities")
        {
        }

        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturaLinea> FacturaLinea { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>()
                .Property(e => e.Precio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Factura)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<FacturaLinea>()
                .Property(e => e.Precio)
                .HasPrecision(10, 2);
        }
    }
}

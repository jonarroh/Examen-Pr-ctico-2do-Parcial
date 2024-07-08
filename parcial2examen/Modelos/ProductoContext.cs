using Microsoft.EntityFrameworkCore;

namespace parcial2examen.Modelos
{
    public class ProductoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public ProductoContext(DbContextOptions<ProductoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración Fluent API
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Image).IsRequired();
                entity.Property(e => e.Cantidad).IsRequired();
                entity.Property(e => e.Categoria).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Precio).IsRequired().HasColumnType("decimal(18,2)");
            });

            // Agregar datos iniciales
            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1,Descripcion= "Clancy el nuevo album de Twenty one pilots", Nombre = "Clancy", Image = "https://m.media-amazon.com/images/I/81moh0ogZCL._UF1000,1000_QL80_.jpg", Cantidad = 52, Categoria = "Usa", Precio = 685 },
                new Producto { Id = 2, Descripcion = "Keep Me Fed es el nuevo album de The Warning", Nombre = "Keep Me Feed", Image = "https://shop.republicrecords.com/cdn/shop/files/SPOTIFY-THEWARNING_LP_MOCKUP_58_88_1.png?v=1711996978", Cantidad = 52, Categoria = "MXN", Precio = 485 },
                new Producto { Id = 3, Descripcion = "“Music of the Spheres” es una colección de 12 canciones con oleadas de sintetizadores y melodías etéreas", Nombre = "Music Of The Sphere", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQLkZTSGluevAlHw1F4BXwLzKo4skJnFxluWA&s", Cantidad = 52, Categoria = "MXN", Precio = 485 }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;


namespace FL_FARMACIAS.Dominio
{
    internal class DBConnect : DbContext
    {
        public DBConnect() : base("name=DefaultConnection") // La cadena de conexión en app.config
        {
        }

        // Mapear las entidades a las tablas de la base de datos
        public DbSet<ClienteDominio> Cliente { get; set; }
        public DbSet<DescuentoDominio> Descuento { get; set; }

        // Configuración adicional para personalizar el mapeo
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClienteDominio>().ToTable("Clientes");
            modelBuilder.Entity<DescuentoDominio>().ToTable("Descuentos");

            // Configuración de relaciones y llaves foráneas
            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.id)
            .HasColumnName("id_cliente")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.nombre)
            .HasColumnName("nombre");
           
            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.apellido)
            .HasColumnName("apellido");

            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.dni)
            .HasColumnName("dni");

            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.telefono)
            .HasColumnName("telefono");


            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.idDescuento)
            .HasColumnName("id_descuento");

            modelBuilder.Entity<ClienteDominio>()
             .HasOptional(c => c.desc)          // Relación opcional con DescuentoDominio
             .WithMany()                        // Un Descuento puede estar relacionado con muchos Clientes
             .HasForeignKey(c => c.idDescuento);

            modelBuilder.Entity<DescuentoDominio>()
                .Property(c => c.id)
                .HasColumnName("id_descuento")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);


            modelBuilder.Entity<DescuentoDominio>()
                .Property(c => c.descripcion)
                .HasColumnName("descripcion");

            modelBuilder.Entity<DescuentoDominio>()
                .Property(c => c.porcentajeDescuento)
                .HasColumnName("porcentajeDescuento");


            modelBuilder.Entity<DescuentoDominio>()
                .Property(c => c.estado)
                .HasColumnName("activo");
        }


    }
}

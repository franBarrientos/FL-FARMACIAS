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

        public DbSet<ProductoDominio> Producto { get; set; }

        public DbSet<LaboratorioDominio> Laboratorio { get; set; }

        public DbSet<MarcaDominio> Marca { get; set; }
        public DbSet<CategoriaDominio> Categoria { get; set; }
        
        public DbSet<ProveedorDominio> Proveedor { get; set; }


        // Configuración adicional para personalizar el mapeo
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //CLIENTE
            modelBuilder.Entity<ClienteDominio>().ToTable("Clientes");
            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.id)
            .HasColumnName("id_cliente")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ClienteDominio>()
            .Property(c => c.idDescuento)
            .HasColumnName("id_descuento");

            modelBuilder.Entity<ClienteDominio>()
             .HasOptional(c => c.desc)          // Relación opcional con DescuentoDominio
             .WithMany()                        // Un Descuento puede estar relacionado con muchos Clientes
             .HasForeignKey(c => c.idDescuento);

            modelBuilder.Entity<ClienteDominio>()
                .Property(c => c.dni)
                .HasMaxLength(8);

            modelBuilder.Entity<ClienteDominio>()
                .HasIndex(c => c.dni).IsUnique();


            //DESCUENTO
            modelBuilder.Entity<DescuentoDominio>().ToTable("Descuentos");
            modelBuilder.Entity<DescuentoDominio>()
                .Property(c => c.id)
                .HasColumnName("id_descuento")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<DescuentoDominio>()
                .Property(c => c.estado)
                .HasColumnName("activo");




            //CATEGORIA
            modelBuilder.Entity<CategoriaDominio>().ToTable("Categorias");
            modelBuilder.Entity<CategoriaDominio>()
            .Property(c => c.id)
            .HasColumnName("id_categoria")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);


            //PRODUCTO
            modelBuilder.Entity<ProductoDominio>().ToTable("Productos");
            modelBuilder.Entity<ProductoDominio>()
            .Property(c => c.id)
            .HasColumnName("id_producto")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);


            modelBuilder.Entity<ProductoDominio>()
            .Property(c => c.idCategoria)
            .IsRequired()
            .HasColumnName("id_categoria");


            modelBuilder.Entity<ProductoDominio>()
             .HasRequired(c => c.categoria)          // Relación opcional con CategoriaDominio
             .WithMany()                        // Un Categoria puede estar relacionado con muchos Productos
             .HasForeignKey(c => c.idCategoria);

            modelBuilder.Entity<ProductoDominio>()
                .Property(c => c.idLaboratorio)
                .IsOptional()
                .HasColumnName("id_laboratorio");


            modelBuilder.Entity<ProductoDominio>()
             .HasOptional(c => c.laboratorio)          // Relación opcional con LaboratorioDominio
             .WithMany()                        // Un Laboratorio puede estar relacionado con muchos Productos
             .HasForeignKey(c => c.idLaboratorio);

            modelBuilder.Entity<ProductoDominio>()
                .Property(c => c.idMarca)
                .IsOptional()
                .HasColumnName("id_marca");


            modelBuilder.Entity<ProductoDominio>()
             .HasOptional(c => c.marca)          // Relación opcional con MarcaDominio
             .WithMany()                        // Un Marca puede estar relacionado con muchos Productos
             .HasForeignKey(c => c.idMarca);


            //MARCA
            modelBuilder.Entity<MarcaDominio>().ToTable("Marcas");
            modelBuilder.Entity<MarcaDominio>()
            .Property(c => c.id)
            .HasColumnName("id_marca")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            //LABORATORIO
            modelBuilder.Entity<LaboratorioDominio>().ToTable("Laboratorios");
            modelBuilder.Entity<LaboratorioDominio>()
            .Property(c => c.id)
            .HasColumnName("id_laboratorio")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            //PROVEEDOR
            modelBuilder.Entity<ProveedorDominio>().ToTable("Proveedores");
            modelBuilder.Entity<ProveedorDominio>()
            .Property(c => c.id)
            .HasColumnName("id_proveedor")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ProveedorDominio>()
                .Property(c => c.cuit)
                .IsRequired();

            modelBuilder.Entity<ProveedorDominio>()
                .Property(c => c.cuit)
                .HasMaxLength(11);

            modelBuilder.Entity<ProveedorDominio>()
                .HasIndex(c => c.cuit)
                .IsUnique();

    
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using FL_FARMACIAS.Aplicacion;


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

        public DbSet<Rol> Rol { get; set; }

        public DbSet<UsuarioDominio> Usuario { get; set; }

        public DbSet<Empleadodominio> Empleado { get; set; }

        public DbSet<CargoDominio> Cargo { get; set; }

        public DbSet<MetodoPagoDominio> MetodoPago { get; set; }
        public DbSet<VentaDominioDominio> Ventas { get; set; }
        public DbSet<VentaDetalleDominio> VentasDetalles { get; set; }
        public DbSet<pedidoDominio> Pedidos { get; set; }

        public DbSet<PedidosDetalleDominio> PedidoDetalle { get; set; }
        // Configuración adicional para personalizar el mapeo
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            //ROL
            modelBuilder.Entity<Rol>().ToTable("Roles");
            modelBuilder.Entity<Rol>()
            .Property(c => c.id)
            .HasColumnName("id_rol")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            //USUARIOS
            modelBuilder.Entity<UsuarioDominio>().ToTable("Usuarios");
            modelBuilder.Entity<UsuarioDominio>()
            .Property(c => c.id)
            .HasColumnName("id_usuario")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<UsuarioDominio>()
           .Property(c => c.rolId)
           .HasColumnName("id_rol");

            modelBuilder.Entity<UsuarioDominio>()
                .Ignore(u => u.empleado);

            modelBuilder.Entity<UsuarioDominio>()
             .HasRequired(c => c.rol)          // Relación opcional con 
             .WithMany()                        // Un Descuento puede estar relacionado con muchos Clientes
             .HasForeignKey(c => c.rolId);



            //CARGOS
            modelBuilder.Entity<CargoDominio>().ToTable("Cargos");
            modelBuilder.Entity<CargoDominio>()
            .Property(e => e.id)
            .HasColumnName("id_cargo")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);


            //EMPLEADO
            modelBuilder.Entity<Empleadodominio>().ToTable("Empleados");
            modelBuilder.Entity<Empleadodominio>()
            .Property(e => e.id)
            .HasColumnName("id_empleado")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Empleadodominio>()
              .Property(e => e.idUsuario)
              .HasColumnName("id_usuario");

            modelBuilder.Entity<Empleadodominio>()
            .HasOptional(e => e.usuario)          // Relación opcional con 
            .WithMany()                        // Un Descuento puede estar relacionado con muchos Clientes
            .HasForeignKey(e => e.idUsuario);


            modelBuilder.Entity<Empleadodominio>()
            .Property(e => e.idCargo)
            .HasColumnName("id_cargo");

            modelBuilder.Entity<Empleadodominio>()
            .HasRequired(e => e.cargo)          // Relación opcional con 
            .WithMany()                        // Un Descuento puede estar relacionado con muchos Clientes
            .HasForeignKey(e => e.idCargo);

            //empleados restricciones

            modelBuilder.Entity<Empleadodominio>()
                .HasIndex(e => e.dni).IsUnique();

            modelBuilder.Entity<Empleadodominio>()
                .Property(e => e.dni)
                .HasMaxLength(8);

            modelBuilder.Entity<Empleadodominio>()
                .HasIndex(e => e.cuil).IsUnique();

            modelBuilder.Entity<Empleadodominio>()
                .Property(e => e.cuil)
                .HasMaxLength(11);

            modelBuilder.Entity<Empleadodominio>()
                .Property(e => e.telefono)
                .HasMaxLength(10);

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

            //Metodo de pago
            modelBuilder.Entity<MetodoPagoDominio>().ToTable("Metodos_Pago");
            modelBuilder.Entity<MetodoPagoDominio>()
            .Property(c => c.id)
            .HasColumnName("id_metodo_pago")
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            //VENTAS

            modelBuilder.Entity<VentaDominioDominio>().ToTable("Ventas");
            modelBuilder.Entity<VentaDominioDominio>()
              .HasKey(v => v.id_venta); // Clave primaria para Ventas

            modelBuilder.Entity<VentaDetalleDominio>().ToTable("Ventas_Detalle");
            
            modelBuilder.Entity<VentaDetalleDominio>()
                .HasKey(vd => new { vd.id_venta, vd.id_producto }); // Clave primaria compuesta para Ventas_Detalle


            // Configuración de relaciones
            modelBuilder.Entity<VentaDominioDominio>()
                .HasOptional(v => v.descuento) // Con HasOptional, indicas que la relacion es opcional
                .WithMany() // Aquí no necesitas especificar con qué entidad se relaciona si no tienes una propiedad en DescuentoDominio
                .HasForeignKey(v => v.id_descuento);

            modelBuilder.Entity<VentaDominioDominio>()
                .HasMany(v => v.detalles)
                .WithRequired(vd => vd.venta) // Con WithRequired, indicas que la relación es obligatoria
                .HasForeignKey(vd => vd.id_venta);

            modelBuilder.Entity<VentaDetalleDominio>()
                .HasRequired(vd => vd.producto) // Asumiendo que un producto es requerido en el detalle de la venta
                .WithMany() // Aquí no necesitas especificar con qué entidad se relaciona si no tienes una propiedad en ProductoDominio
                .HasForeignKey(vd => vd.id_producto);

            // Configuración de relaciones para Cliente y Método de Pago
            modelBuilder.Entity<VentaDominioDominio>()
                .HasRequired(v => v.cliente) // La venta requiere un cliente
                .WithMany() // Asumiendo que un cliente puede tener múltiples ventas
                .HasForeignKey(v => v.id_cliente);

            modelBuilder.Entity<VentaDominioDominio>()
                .HasRequired(v => v.metodoPago) // La venta requiere un método de pago
                .WithMany() // Asumiendo que un método de pago puede estar en múltiples ventas
                .HasForeignKey(v => v.id_metodo_pago);

            modelBuilder.Entity<VentaDominioDominio>()
                .HasRequired(v => v.empleado) // La venta requiere un empleado
                .WithMany() // Asumiendo que un empleado puede tener múltiples ventas
                .HasForeignKey(v => v.id_empleado);

            //PEDIDOS


            modelBuilder.Entity<pedidoDominio>().ToTable("Pedidos");

            modelBuilder.Entity<pedidoDominio>()

              .HasKey(p => p.Idpedido); // Clave primaria



            modelBuilder.Entity<PedidosDetalleDominio>().ToTable("DetallePedido");



            modelBuilder.Entity<PedidosDetalleDominio>()

                .HasKey(pd => new { pd.Idpedido, pd.Idproducto }); // Clave primaria compuesta para detalle pedido





            // Configuración de relaciones

            modelBuilder.Entity<pedidoDominio>()

                .HasRequired(v => v.proveedor) // Con hasRequired seria el objeto, indicas que la relacion es opcional

                .WithMany() // Aquí no necesitas especificar con qué entidad se relaciona si no tienes una propiedad en DescuentoDominio

                .HasForeignKey(v => v.idproveedor);

            modelBuilder.Entity<pedidoDominio>()

                .HasRequired(v => v.farmaceutico) // Con hasRequired seria el objeto, indicas que la relacion es opcional

                .WithMany() // Aquí no necesitas especificar con qué entidad se relaciona si no tienes una propiedad en DescuentoDominio

                .HasForeignKey(v => v.idfarmaceutico);

            modelBuilder.Entity<pedidoDominio>()

                            .HasOptional(v => v.administrador) // Con hasRequired seria el objeto, indicas que la relacion es opcional

                            .WithMany()

                            .HasForeignKey(v => v.idadmin);





            modelBuilder.Entity<pedidoDominio>()

                .HasMany(v => v.detalle)

                .WithRequired(vd => vd.Pedido) // ESTO SERIA DESDE DETALLE A PEDIDO

                .HasForeignKey(vd => vd.Idpedido);



            modelBuilder.Entity<PedidosDetalleDominio>()

                .HasRequired(vd => vd.producto) // Asumiendo que un producto es requerido en el detalle de la venta

                .WithMany() // Aquí no necesitas especificar con qué entidad se relaciona si no tienes una propiedad en ProductoDominio

                .HasForeignKey(vd => vd.Idproducto);
        }


    }
}

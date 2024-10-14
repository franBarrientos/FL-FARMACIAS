namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargos",
                c => new
                    {
                        id_cargo = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id_cargo);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        id_categoria = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_categoria);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id_cliente = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        dni = c.String(maxLength: 8),
                        telefono = c.String(),
                        activo = c.Boolean(nullable: false),
                        id_descuento = c.Int(),
                    })
                .PrimaryKey(t => t.id_cliente)
                .ForeignKey("dbo.Descuentos", t => t.id_descuento)
                .Index(t => t.dni, unique: true)
                .Index(t => t.id_descuento);
            
            CreateTable(
                "dbo.Descuentos",
                c => new
                    {
                        id_descuento = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        porcentajeDescuento = c.Double(nullable: false),
                        activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_descuento);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        id_empleado = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        sexo = c.Boolean(nullable: false),
                        dni = c.String(maxLength: 8),
                        cuil = c.String(maxLength: 11),
                        telefono = c.String(maxLength: 10),
                        id_cargo = c.Int(nullable: false),
                        salario = c.Single(nullable: false),
                        fechaingreso = c.DateTime(nullable: false),
                        foto = c.Binary(),
                        id_usuario = c.Int(),
                        estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_empleado)
                .ForeignKey("dbo.Cargos", t => t.id_cargo, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.id_usuario)
                .Index(t => t.dni, unique: true)
                .Index(t => t.cuil, unique: true)
                .Index(t => t.id_cargo)
                .Index(t => t.id_usuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        id_usuario = c.Int(nullable: false, identity: true),
                        usuario = c.String(),
                        clave = c.String(),
                        activo = c.Boolean(nullable: false),
                        id_rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_usuario)
                .ForeignKey("dbo.Roles", t => t.id_rol, cascadeDelete: true)
                .Index(t => t.id_rol);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id_rol = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id_rol);
            
            CreateTable(
                "dbo.Laboratorios",
                c => new
                    {
                        id_laboratorio = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.id_laboratorio);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        id_marca = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.id_marca);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        id_producto = c.Int(nullable: false, identity: true),
                        codProducto = c.String(),
                        nombre = c.String(),
                        precio = c.Double(nullable: false),
                        stock = c.Int(nullable: false),
                        id_categoria = c.Int(nullable: false),
                        id_marca = c.Int(),
                        id_laboratorio = c.Int(),
                        estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_producto)
                .ForeignKey("dbo.Categorias", t => t.id_categoria, cascadeDelete: true)
                .ForeignKey("dbo.Laboratorios", t => t.id_laboratorio)
                .ForeignKey("dbo.Marcas", t => t.id_marca)
                .Index(t => t.id_categoria)
                .Index(t => t.id_marca)
                .Index(t => t.id_laboratorio);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        id_proveedor = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        cuit = c.String(nullable: false, maxLength: 11),
                        provincia = c.String(),
                        localidad = c.String(),
                        direccion = c.String(),
                        correo = c.String(),
                        telefono = c.String(),
                        activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_proveedor)
                .Index(t => t.cuit, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "id_marca", "dbo.Marcas");
            DropForeignKey("dbo.Productos", "id_laboratorio", "dbo.Laboratorios");
            DropForeignKey("dbo.Productos", "id_categoria", "dbo.Categorias");
            DropForeignKey("dbo.Empleados", "id_usuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "id_rol", "dbo.Roles");
            DropForeignKey("dbo.Empleados", "id_cargo", "dbo.Cargos");
            DropForeignKey("dbo.Clientes", "id_descuento", "dbo.Descuentos");
            DropIndex("dbo.Proveedores", new[] { "cuit" });
            DropIndex("dbo.Productos", new[] { "id_laboratorio" });
            DropIndex("dbo.Productos", new[] { "id_marca" });
            DropIndex("dbo.Productos", new[] { "id_categoria" });
            DropIndex("dbo.Usuarios", new[] { "id_rol" });
            DropIndex("dbo.Empleados", new[] { "id_usuario" });
            DropIndex("dbo.Empleados", new[] { "id_cargo" });
            DropIndex("dbo.Empleados", new[] { "cuil" });
            DropIndex("dbo.Empleados", new[] { "dni" });
            DropIndex("dbo.Clientes", new[] { "id_descuento" });
            DropIndex("dbo.Clientes", new[] { "dni" });
            DropTable("dbo.Proveedores");
            DropTable("dbo.Productos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Laboratorios");
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Empleados");
            DropTable("dbo.Descuentos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
            DropTable("dbo.Cargos");
        }
    }
}

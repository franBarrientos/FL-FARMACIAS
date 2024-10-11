namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
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
                        dni = c.String(),
                        telefono = c.String(),
                        activo = c.Boolean(nullable: false),
                        id_descuento = c.Int(),
                    })
                .PrimaryKey(t => t.id_cliente)
                .ForeignKey("dbo.Descuentos", t => t.id_descuento)
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "id_marca", "dbo.Marcas");
            DropForeignKey("dbo.Productos", "id_laboratorio", "dbo.Laboratorios");
            DropForeignKey("dbo.Productos", "id_categoria", "dbo.Categorias");
            DropForeignKey("dbo.Clientes", "id_descuento", "dbo.Descuentos");
            DropIndex("dbo.Productos", new[] { "id_laboratorio" });
            DropIndex("dbo.Productos", new[] { "id_marca" });
            DropIndex("dbo.Productos", new[] { "id_categoria" });
            DropIndex("dbo.Clientes", new[] { "id_descuento" });
            DropTable("dbo.Productos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Laboratorios");
            DropTable("dbo.Descuentos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}

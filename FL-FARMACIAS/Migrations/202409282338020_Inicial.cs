namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "id_descuento", "dbo.Descuentos");
            DropIndex("dbo.Clientes", new[] { "id_descuento" });
            DropTable("dbo.Descuentos");
            DropTable("dbo.Clientes");
        }
    }
}

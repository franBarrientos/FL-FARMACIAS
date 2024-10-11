namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_provedor : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.id_proveedor)
                .Index(t => t.cuit, unique: true);
            
            AlterColumn("dbo.Clientes", "dni", c => c.String(maxLength: 8));
            CreateIndex("dbo.Clientes", "dni", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Proveedores", new[] { "cuit" });
            DropIndex("dbo.Clientes", new[] { "dni" });
            AlterColumn("dbo.Clientes", "dni", c => c.String());
            DropTable("dbo.Proveedores");
        }
    }
}

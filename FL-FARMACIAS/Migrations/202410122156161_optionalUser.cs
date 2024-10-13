namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optionalUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Empleados", "id_usuario", "dbo.Usuarios");
            DropIndex("dbo.Empleados", new[] { "id_usuario" });
            CreateTable(
                "dbo.CargoDominios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Empleados", "idCargo", c => c.Int(nullable: false));
            AddColumn("dbo.Empleados", "cargo_id", c => c.Int());
            AlterColumn("dbo.Empleados", "id_usuario", c => c.Int());
            CreateIndex("dbo.Empleados", "id_usuario");
            CreateIndex("dbo.Empleados", "cargo_id");
            AddForeignKey("dbo.Empleados", "cargo_id", "dbo.CargoDominios", "id");
            AddForeignKey("dbo.Empleados", "id_usuario", "dbo.Usuarios", "id_usuario");
            DropColumn("dbo.Empleados", "cargo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleados", "cargo", c => c.String());
            DropForeignKey("dbo.Empleados", "id_usuario", "dbo.Usuarios");
            DropForeignKey("dbo.Empleados", "cargo_id", "dbo.CargoDominios");
            DropIndex("dbo.Empleados", new[] { "cargo_id" });
            DropIndex("dbo.Empleados", new[] { "id_usuario" });
            AlterColumn("dbo.Empleados", "id_usuario", c => c.Int(nullable: false));
            DropColumn("dbo.Empleados", "cargo_id");
            DropColumn("dbo.Empleados", "idCargo");
            DropTable("dbo.CargoDominios");
            CreateIndex("dbo.Empleados", "id_usuario");
            AddForeignKey("dbo.Empleados", "id_usuario", "dbo.Usuarios", "id_usuario", cascadeDelete: true);
        }
    }
}

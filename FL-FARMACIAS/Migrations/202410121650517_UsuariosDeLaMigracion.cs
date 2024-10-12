namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuariosDeLaMigracion : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "id_rol", "dbo.Roles");
            DropIndex("dbo.Usuarios", new[] { "id_rol" });
            DropTable("dbo.Usuarios");
        }
    }
}

namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolesDeLaMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id_rol = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id_rol);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Roles");
        }
    }
}

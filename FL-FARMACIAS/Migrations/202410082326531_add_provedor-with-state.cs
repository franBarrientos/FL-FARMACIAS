namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_provedorwithstate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proveedores", "activo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proveedores", "activo");
        }
    }
}

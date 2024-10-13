namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optionalUserv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleados", "foto", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleados", "foto");
        }
    }
}

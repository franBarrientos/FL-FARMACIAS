namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEstadoEmpleado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleados", "estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleados", "estado");
        }
    }
}

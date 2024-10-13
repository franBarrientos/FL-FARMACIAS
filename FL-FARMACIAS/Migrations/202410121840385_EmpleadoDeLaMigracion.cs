namespace FL_FARMACIAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpleadoDeLaMigracion : DbMigration
    {
        public override void Up()
        {
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
                        cargo = c.String(),
                        salario = c.Single(nullable: false),
                        fechaingreso = c.DateTime(nullable: false),
                        id_usuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_empleado)
                .ForeignKey("dbo.Usuarios", t => t.id_usuario, cascadeDelete: true)
                .Index(t => t.dni, unique: true)
                .Index(t => t.cuil, unique: true)
                .Index(t => t.id_usuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleados", "id_usuario", "dbo.Usuarios");
            DropIndex("dbo.Empleados", new[] { "id_usuario" });
            DropIndex("dbo.Empleados", new[] { "cuil" });
            DropIndex("dbo.Empleados", new[] { "dni" });
            DropTable("dbo.Empleados");
        }
    }
}

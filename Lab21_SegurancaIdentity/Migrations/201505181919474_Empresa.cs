namespace ReclamaPoaS2B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Empresa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Empresa");
        }
    }
}

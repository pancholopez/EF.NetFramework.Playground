namespace Playground.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCaseName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Case", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Case", "Name");
        }
    }
}

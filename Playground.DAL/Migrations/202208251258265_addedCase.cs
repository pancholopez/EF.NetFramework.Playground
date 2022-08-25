namespace Playground.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cases");
        }
    }
}

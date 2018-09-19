namespace VartasAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        Edited = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}

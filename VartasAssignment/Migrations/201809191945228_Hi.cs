namespace VartasAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Category", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Description", c => c.String());
            AlterColumn("dbo.Games", "Name", c => c.String());
            AlterColumn("dbo.Games", "Category", c => c.String());
        }
    }
}

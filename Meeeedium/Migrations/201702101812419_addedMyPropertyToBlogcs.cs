namespace Meeeedium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMyPropertyToBlogcs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "MyProperty", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "MyProperty");
        }
    }
}
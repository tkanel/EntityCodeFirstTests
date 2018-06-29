namespace EntityCodeFirstTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToNewsletter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.customers", "IsSubscribedToNewletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.customers", "IsSubscribedToNewletter");
        }
    }
}

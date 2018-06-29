namespace EntityCodeFirstTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.customers", "Name", c => c.String(nullable: false));
        }
    }
}

namespace EntityCodeFirstTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToCustomerUpdateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.customers", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.customers", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}

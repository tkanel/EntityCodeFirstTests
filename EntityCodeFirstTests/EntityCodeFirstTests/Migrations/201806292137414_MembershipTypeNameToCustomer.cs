namespace EntityCodeFirstTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeNameToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.customers", "MembershipTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.customers", "MembershipTypeName");
        }
    }
}

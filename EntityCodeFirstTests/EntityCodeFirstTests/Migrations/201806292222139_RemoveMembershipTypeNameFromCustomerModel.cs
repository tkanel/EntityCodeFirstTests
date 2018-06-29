namespace EntityCodeFirstTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMembershipTypeNameFromCustomerModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.customers", "MembershipTypeName_Id", "dbo.MembershipTypes");
            DropIndex("dbo.customers", new[] { "MembershipTypeName_Id" });
            DropColumn("dbo.customers", "MembershipTypeName_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.customers", "MembershipTypeName_Id", c => c.Byte());
            CreateIndex("dbo.customers", "MembershipTypeName_Id");
            AddForeignKey("dbo.customers", "MembershipTypeName_Id", "dbo.MembershipTypes", "Id");
        }
    }
}

namespace EntityCodeFirstTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpfee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.customers", "MembershipTypeId");
            AddForeignKey("dbo.customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.customers", new[] { "MembershipTypeId" });
            DropColumn("dbo.customers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}

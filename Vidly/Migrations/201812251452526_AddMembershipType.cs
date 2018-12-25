namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberschipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MemberschipType_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MemberschipType_Id");
            AddForeignKey("dbo.Customers", "MemberschipType_Id", "dbo.MemberschipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberschipType_Id", "dbo.MemberschipTypes");
            DropIndex("dbo.Customers", new[] { "MemberschipType_Id" });
            DropColumn("dbo.Customers", "MemberschipType_Id");
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MemberschipTypes");
        }
    }
}

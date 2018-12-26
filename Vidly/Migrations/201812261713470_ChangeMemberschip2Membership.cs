namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMemberschip2Membership : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MemberschipTypes", newName: "MembershipTypes");
            DropForeignKey("dbo.Customers", "MemberschipType_Id", "dbo.MemberschipTypes");
            DropIndex("dbo.Customers", new[] { "MemberschipType_Id" });
            DropColumn("dbo.Customers", "MembershipTypeId");
            RenameColumn(table: "dbo.Customers", name: "MemberschipType_Id", newName: "MembershipTypeId");
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeId", newName: "MemberschipType_Id");
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MemberschipType_Id");
            AddForeignKey("dbo.Customers", "MemberschipType_Id", "dbo.MemberschipTypes", "Id");
            RenameTable(name: "dbo.MembershipTypes", newName: "MemberschipTypes");
        }
    }
}

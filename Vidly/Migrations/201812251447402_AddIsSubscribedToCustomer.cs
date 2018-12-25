namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.Customers", new[] { "Customer_ID" });
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "Customer_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Customer_ID", c => c.Int());
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
            CreateIndex("dbo.Customers", "Customer_ID");
            AddForeignKey("dbo.Customers", "Customer_ID", "dbo.Customers", "ID");
        }
    }
}

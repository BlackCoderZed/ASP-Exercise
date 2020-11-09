namespace ASP_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeAndCustomerDOB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
            AddColumn("dbo.MembershipTypes", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Type");
            DropColumn("dbo.Customers", "DOB");
        }
    }
}

namespace ASP_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeAndCustomerDOB1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Type", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Type", c => c.String());
        }
    }
}

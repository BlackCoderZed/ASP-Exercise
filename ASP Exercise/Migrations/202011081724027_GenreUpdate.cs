namespace ASP_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GenreTypes", "Genre", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GenreTypes", "Genre", c => c.Short(nullable: false));
        }
    }
}

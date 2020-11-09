namespace ASP_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreUpdate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            DropPrimaryKey("dbo.GenreTypes");
            AddColumn("dbo.Movies", "GenreType_Id", c => c.Int());
            AlterColumn("dbo.GenreTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.GenreTypes", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GenreType_Id");
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }
    }
}

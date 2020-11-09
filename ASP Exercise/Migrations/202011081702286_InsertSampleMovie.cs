namespace ASP_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertSampleMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 1','2010-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 2','2011-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 3','2012-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 4','2013-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 5','2014-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 6','2015-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 7','2016-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 8','2017-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 9','2018-07-01')");
            Sql("INSERT INTO Movies (Name,ReleasedDate) values ('Supernatural Season 10','2019-07-01')");
        }
        
        public override void Down()
        {
        }
    }
}

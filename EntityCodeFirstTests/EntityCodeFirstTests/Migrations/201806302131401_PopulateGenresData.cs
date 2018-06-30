namespace EntityCodeFirstTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (GenreName) VALUES ('COMEDY')");
            Sql("INSERT INTO GENRES (GenreName) VALUES ('DRAMA')");
            Sql("INSERT INTO GENRES (GenreName) VALUES ('VIOGRAPHY')");
            Sql("INSERT INTO GENRES (GenreName) VALUES ('ACTION')");
            Sql("INSERT INTO GENRES (GenreName) VALUES ('SCIFY')");
            Sql("INSERT INTO GENRES (GenreName) VALUES ('TERROR')");
        }
        
        public override void Down()
        {
        }
    }
}

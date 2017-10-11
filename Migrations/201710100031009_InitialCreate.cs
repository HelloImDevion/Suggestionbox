namespace week9suggestionbox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suggestionmodels",
                c => new
                    {
                        RecordNum = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                        Suggestion = c.String(),
                    })
                .PrimaryKey(t => t.RecordNum);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suggestionmodels");
        }
    }
}
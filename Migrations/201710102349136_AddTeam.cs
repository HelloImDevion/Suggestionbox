namespace week9suggestionbox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suggestionmodels", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suggestionmodels", "Name");
        }
    }
}

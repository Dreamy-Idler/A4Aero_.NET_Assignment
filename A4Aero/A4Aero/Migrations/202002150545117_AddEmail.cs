namespace A4Aero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentLists", "EMAIL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgentLists", "EMAIL");
        }
    }
}

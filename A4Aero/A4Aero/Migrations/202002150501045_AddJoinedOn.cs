namespace A4Aero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJoinedOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentLists", "JOINED_ON", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgentLists", "JOINED_ON");
        }
    }
}

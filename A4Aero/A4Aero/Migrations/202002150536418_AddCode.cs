namespace A4Aero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentLists", "CODE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgentLists", "CODE");
        }
    }
}

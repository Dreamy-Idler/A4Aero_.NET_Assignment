namespace A4Aero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMarkupPlan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentLists", "MARKUP_PLAN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgentLists", "MARKUP_PLAN");
        }
    }
}

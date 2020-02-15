namespace A4Aero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMobile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentLists", "MOBILE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgentLists", "MOBILE");
        }
    }
}

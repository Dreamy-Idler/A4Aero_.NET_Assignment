namespace A4Aero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBalance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentLists", "BALANCE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgentLists", "BALANCE");
        }
    }
}

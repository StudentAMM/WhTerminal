namespace WhTerminal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckHangar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hangar", "maxContainers", c => c.Int(nullable: false));
            AddColumn("dbo.Hangar", "countContainers", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hangar", "countContainers");
            DropColumn("dbo.Hangar", "maxContainers");
        }
    }
}

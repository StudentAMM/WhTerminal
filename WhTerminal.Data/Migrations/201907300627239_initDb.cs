namespace WhTerminal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOnUtc = c.DateTime(nullable: false),
                        Warehouse_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Warehouse", t => t.Warehouse_Id)
                .Index(t => t.Warehouse_Id);
            
            CreateTable(
                "dbo.Hangar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOnUtc = c.DateTime(nullable: false),
                        Area_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Area", t => t.Area_Id)
                .Index(t => t.Area_Id);
            
            CreateTable(
                "dbo.Container",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOnUtc = c.DateTime(nullable: false),
                        Hangar_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hangar", t => t.Hangar_Id)
                .Index(t => t.Hangar_Id);
            
            CreateTable(
                "dbo.Warehouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOnUtc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Area", "Warehouse_Id", "dbo.Warehouse");
            DropForeignKey("dbo.Container", "Hangar_Id", "dbo.Hangar");
            DropForeignKey("dbo.Hangar", "Area_Id", "dbo.Area");
            DropIndex("dbo.Container", new[] { "Hangar_Id" });
            DropIndex("dbo.Hangar", new[] { "Area_Id" });
            DropIndex("dbo.Area", new[] { "Warehouse_Id" });
            DropTable("dbo.Warehouse");
            DropTable("dbo.Container");
            DropTable("dbo.Hangar");
            DropTable("dbo.Area");
        }
    }
}

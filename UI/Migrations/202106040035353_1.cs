namespace UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RI",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                        Gn = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.Work",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RI", t => t.Cid, cascadeDelete: true)
                .Index(t => t.Cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Work", "Cid", "dbo.RI");
            DropIndex("dbo.Work", new[] { "Cid" });
            DropTable("dbo.Work");
            DropTable("dbo.RI");
        }
    }
}

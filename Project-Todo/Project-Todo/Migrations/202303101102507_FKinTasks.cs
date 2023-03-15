namespace Project_Todo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKinTasks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Tasks", "Id");
            AddForeignKey("dbo.Tasks", "Id", "dbo.Projects", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Id", "dbo.Projects");
            DropIndex("dbo.Tasks", new[] { "Id" });
            DropColumn("dbo.Tasks", "Id");
        }
    }
}

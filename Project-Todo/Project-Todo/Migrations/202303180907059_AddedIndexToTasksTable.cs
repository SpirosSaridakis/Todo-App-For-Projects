namespace Project_Todo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIndexToTasksTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "ProjectTaskIndex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "ProjectTaskIndex");
        }
    }
}

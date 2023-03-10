namespace Project_Todo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedStudentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Progress = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TaskId);
            
            AddColumn("dbo.Projects", "CurrentTask", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "CurrentTask");
            DropTable("dbo.Tasks");
        }
    }
}

namespace _7_CodeFirstDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameClasseCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255, unicode: false));
            Sql("UPDATE COURSES SET Name=Title2");
            DropColumn("dbo.Courses", "Title2");
            //RenameColumn("dbo.Courses", "Title2", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title2", c => c.String(nullable: false, maxLength: 255, unicode: false));
            Sql("UPDATE COURSES SET Title2=Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}

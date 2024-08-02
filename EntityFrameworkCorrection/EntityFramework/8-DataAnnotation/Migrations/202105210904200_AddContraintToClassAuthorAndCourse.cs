namespace _8_DataAnnotation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContraintToClassAuthorAndCourse : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Authors", newName: "t_author");
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "AuthorId");
            AlterColumn("dbo.t_author", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "AuthorId");
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.t_author", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.t_author");
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int());
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
            AlterColumn("dbo.t_author", "Name", c => c.String());
            RenameColumn(table: "dbo.Courses", name: "AuthorId", newName: "Author_Id");
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
            RenameTable(name: "dbo.t_author", newName: "Authors");
        }
    }
}

namespace _4_MySqlDbFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameClassContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Nom", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Nom");
        }
    }
}

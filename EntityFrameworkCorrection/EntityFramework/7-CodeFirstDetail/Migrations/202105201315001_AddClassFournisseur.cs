namespace _7_CodeFirstDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassFournisseur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fournisseurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            //Insérer des données de test
            Sql("INSERT INTO Fournisseurs(Nom) VALUES ('Dawan')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Fournisseurs");
        }
    }
}

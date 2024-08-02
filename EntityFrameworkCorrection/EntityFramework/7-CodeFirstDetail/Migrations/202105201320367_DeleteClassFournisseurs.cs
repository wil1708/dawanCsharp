namespace _7_CodeFirstDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteClassFournisseurs : DbMigration
    {
        public override void Up()
        {
            //Créer une table temporaire qui contiendra les données de la table à supprimer
            CreateTable(
               "dbo._Fournisseurs",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Nom = c.String(),
               })
               .PrimaryKey(t => t.Id);
            Sql("INSERT INTO _Fournisseurs(Nom) SELECT Nom FROM Fournisseurs ");

            DropTable("dbo.Fournisseurs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Fournisseurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Fournisseurs(Nom) SELECT Nom FROM _Fournisseurs");
            DropTable("dbo._Fournisseurs");
        }
    }
}

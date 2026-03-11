namespace AppSenAgriculture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiseAJour : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Personnes", newSchema: "public");
            MoveTable(name: "dbo.Produits", newSchema: "public");
            MoveTable(name: "dbo.Categories", newSchema: "public");
            MoveTable(name: "dbo.UniteMesures", newSchema: "public");
            MoveTable(name: "dbo.Champs", newSchema: "public");
            MoveTable(name: "dbo.Communes", newSchema: "public");
            MoveTable(name: "dbo.Departements", newSchema: "public");
            MoveTable(name: "dbo.Regions", newSchema: "public");
            AddColumn("public.Personnes", "Login", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AddColumn("public.Personnes", "MotDePasse", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("public.Personnes", "AdresseClient", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("public.Personnes", "ProfessionClient", c => c.String(maxLength: 100, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("public.Personnes", "ProfessionClient");
            DropColumn("public.Personnes", "AdresseClient");
            DropColumn("public.Personnes", "MotDePasse");
            DropColumn("public.Personnes", "Login");
            MoveTable(name: "public.Regions", newSchema: "dbo");
            MoveTable(name: "public.Departements", newSchema: "dbo");
            MoveTable(name: "public.Communes", newSchema: "dbo");
            MoveTable(name: "public.Champs", newSchema: "dbo");
            MoveTable(name: "public.UniteMesures", newSchema: "dbo");
            MoveTable(name: "public.Categories", newSchema: "dbo");
            MoveTable(name: "public.Produits", newSchema: "dbo");
            MoveTable(name: "public.Personnes", newSchema: "dbo");
        }
    }
}

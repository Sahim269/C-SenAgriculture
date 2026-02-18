namespace AppSenAgriculture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        IdPersonne = c.Int(nullable: false, identity: true),
                        NomPersonne = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        PrenomPersonne = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        EmailPersonne = c.String(unicode: false),
                        TelephonePersonne = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        ExploitationAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        LocalisationAgriculteur = c.String(maxLength: 200, storeType: "nvarchar"),
                        SuperficieAgriculteur = c.Double(),
                        TypeCultureAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        RegionAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        DepartementAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        CommuneAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        VilleVillageAgriculteur = c.String(maxLength: 80, storeType: "nvarchar"),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdPersonne);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        IdProduit = c.Int(nullable: false, identity: true),
                        LibelleProduit = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        DescriptionProduit = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        PrixUnitaireMin = c.Double(nullable: false),
                        PrixUnitaireMax = c.Double(nullable: false),
                        CategorieId = c.Int(nullable: false),
                        IdUniteMesure = c.Int(nullable: false),
                        Agriculteur_IdPersonne = c.Int(),
                    })
                .PrimaryKey(t => t.IdProduit)
                .ForeignKey("dbo.Categories", t => t.CategorieId, cascadeDelete: true)
                .ForeignKey("dbo.UniteMesures", t => t.IdUniteMesure, cascadeDelete: true)
                .ForeignKey("dbo.Personnes", t => t.Agriculteur_IdPersonne)
                .Index(t => t.CategorieId)
                .Index(t => t.IdUniteMesure)
                .Index(t => t.Agriculteur_IdPersonne);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdCategorie = c.Int(nullable: false, identity: true),
                        LibelleCategorie = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        DescriptionCategorie = c.String(maxLength: 250, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdCategorie);
            
            CreateTable(
                "dbo.UniteMesures",
                c => new
                    {
                        idUnite = c.Int(nullable: false, identity: true),
                        CodeUnite = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        NameUnite = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idUnite);
            
            CreateTable(
                "dbo.Champs",
                c => new
                    {
                        idChamp = c.Int(nullable: false, identity: true),
                        nomChamp = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        descriptionChamp = c.String(maxLength: 150, storeType: "nvarchar"),
                        superficie = c.Double(nullable: false),
                        latitude = c.Double(nullable: false),
                        longitude = c.Double(nullable: false),
                        communeId = c.Int(nullable: false),
                        agriculteurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idChamp)
                .ForeignKey("dbo.Personnes", t => t.agriculteurId, cascadeDelete: true)
                .ForeignKey("dbo.Communes", t => t.communeId, cascadeDelete: true)
                .Index(t => t.communeId)
                .Index(t => t.agriculteurId);
            
            CreateTable(
                "dbo.Communes",
                c => new
                    {
                        idCommune = c.Int(nullable: false, identity: true),
                        nomCommune = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        departementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idCommune)
                .ForeignKey("dbo.Departements", t => t.departementId, cascadeDelete: true)
                .Index(t => t.departementId);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        idDepartement = c.Int(nullable: false, identity: true),
                        nomDepartement = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        regionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDepartement)
                .ForeignKey("dbo.Regions", t => t.regionId, cascadeDelete: true)
                .Index(t => t.regionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        idRegion = c.Int(nullable: false, identity: true),
                        nomRegion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idRegion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departements", "regionId", "dbo.Regions");
            DropForeignKey("dbo.Communes", "departementId", "dbo.Departements");
            DropForeignKey("dbo.Champs", "communeId", "dbo.Communes");
            DropForeignKey("dbo.Champs", "agriculteurId", "dbo.Personnes");
            DropForeignKey("dbo.Produits", "Agriculteur_IdPersonne", "dbo.Personnes");
            DropForeignKey("dbo.Produits", "IdUniteMesure", "dbo.UniteMesures");
            DropForeignKey("dbo.Produits", "CategorieId", "dbo.Categories");
            DropIndex("dbo.Departements", new[] { "regionId" });
            DropIndex("dbo.Communes", new[] { "departementId" });
            DropIndex("dbo.Champs", new[] { "agriculteurId" });
            DropIndex("dbo.Champs", new[] { "communeId" });
            DropIndex("dbo.Produits", new[] { "Agriculteur_IdPersonne" });
            DropIndex("dbo.Produits", new[] { "IdUniteMesure" });
            DropIndex("dbo.Produits", new[] { "CategorieId" });
            DropTable("dbo.Regions");
            DropTable("dbo.Departements");
            DropTable("dbo.Communes");
            DropTable("dbo.Champs");
            DropTable("dbo.UniteMesures");
            DropTable("dbo.Categories");
            DropTable("dbo.Produits");
            DropTable("dbo.Personnes");
        }
    }
}

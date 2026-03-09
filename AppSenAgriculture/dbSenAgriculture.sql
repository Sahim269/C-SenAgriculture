USE dbSenAgriculture;

CREATE TABLE IF NOT EXISTS UniteMesures (
    idUnite INT AUTO_INCREMENT PRIMARY KEY,
    CodeUnite VARCHAR(50) NOT NULL,
    NameUnite VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS Categories (
    IdCategorie INT AUTO_INCREMENT PRIMARY KEY,
    LibelleCategorie VARCHAR(100) NOT NULL,
    DescriptionCategorie VARCHAR(250)
);

CREATE TABLE IF NOT EXISTS Regions (
    idRegion INT AUTO_INCREMENT PRIMARY KEY,
    nomRegion VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS Departements (
    idDepartement INT AUTO_INCREMENT PRIMARY KEY,
    nomDepartement VARCHAR(100) NOT NULL,
    regionId INT NOT NULL,
    FOREIGN KEY (regionId) REFERENCES Regions(idRegion)
);

CREATE TABLE IF NOT EXISTS Communes (
    idCommune INT AUTO_INCREMENT PRIMARY KEY,
    nomCommune VARCHAR(100) NOT NULL,
    departementId INT NOT NULL,
    FOREIGN KEY (departementId) REFERENCES Departements(idDepartement)
);

CREATE TABLE IF NOT EXISTS Personnes (
    IdPersonne INT AUTO_INCREMENT PRIMARY KEY,
    NomPersonne VARCHAR(80) NOT NULL,
    PrenomPersonne VARCHAR(100) NOT NULL,
    EmailPersonne VARCHAR(255),
    TelephonePersonne VARCHAR(20) NOT NULL,
    Discriminator VARCHAR(50) NOT NULL DEFAULT 'Personne',
    ExploitationAgriculteur VARCHAR(80),
    LocalisationAgriculteur VARCHAR(200),
    SuperficieAgriculteur DOUBLE,
    TypeCultureAgriculteur VARCHAR(80),
    RegionAgriculteur VARCHAR(80),
    DepartementAgriculteur VARCHAR(80),
    CommuneAgriculteur VARCHAR(80),
    VilleVillageAgriculteur VARCHAR(80)
);

CREATE TABLE IF NOT EXISTS Produits (
    IdProduit INT AUTO_INCREMENT PRIMARY KEY,
    LibelleProduit VARCHAR(100) NOT NULL,
    DescriptionProduit VARCHAR(500) NOT NULL,
    PrixUnitaireMin DOUBLE NOT NULL DEFAULT 0,
    PrixUnitaireMax DOUBLE NOT NULL DEFAULT 0,
    CategorieId INT NOT NULL,
    IdUniteMesure INT NOT NULL,
    FOREIGN KEY (CategorieId) REFERENCES Categories(IdCategorie),
    FOREIGN KEY (IdUniteMesure) REFERENCES UniteMesures(idUnite)
);

CREATE TABLE IF NOT EXISTS Champs (
    idChamp INT AUTO_INCREMENT PRIMARY KEY,
    nomChamp VARCHAR(50) NOT NULL,
    descriptionChamp VARCHAR(150),
    superficie DOUBLE NOT NULL,
    latitude DOUBLE NOT NULL,
    longitude DOUBLE NOT NULL,
    communeId INT NOT NULL,
    agriculteurId INT NOT NULL,
    FOREIGN KEY (communeId) REFERENCES Communes(idCommune),
    FOREIGN KEY (agriculteurId) REFERENCES Personnes(IdPersonne)
);

CREATE TABLE IF NOT EXISTS AgriculteurProduits (
    AgriculteurId INT NOT NULL,
    ProduitId INT NOT NULL,
    PRIMARY KEY (AgriculteurId, ProduitId),
    FOREIGN KEY (AgriculteurId) REFERENCES Personnes(IdPersonne),
    FOREIGN KEY (ProduitId) REFERENCES Produits(IdProduit)
);

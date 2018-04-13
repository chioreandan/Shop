



USE [ShopV2]
GO

CREATE TABLE Users(
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    NumePrenume VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Telefon VARCHAR(10) NOT NULL,
    Adresa VARCHAR(255) NOT NULL,
    Parola VARCHAR(255) NOT NULL,
    Nickname VARCHAR(255)
);

CREATE TABLE Vanzatori(
    VanzatorId INT IDENTITY(1,1) PRIMARY KEY,
    UserId_FK INT FOREIGN KEY REFERENCES Users(UserId),
    NumeCompanie VARCHAR(255) NOT NULL,
    Cont VARCHAR(255) NOT NULL,
    CUI VARCHAR(255) NOT NULL

);

CREATE TABLE Admins(
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    UserId_FK INT FOREIGN KEY REFERENCES Users(UserId),
    VanzatorId_FK INT FOREIGN KEY REFERENCES Vanzatori(VanzatorId)




);



CREATE TABLE Branduri(
    BrandId INT IDENTITY(1,1) PRIMARY KEY,
    NumeBrand VARCHAR NOT NULL
    --nu stiu

);
CREATE TABLE CategoriiProduse(
    CategorieId int IDENTITY(1,1) PRIMARY KEY,
    --ProdusId INT FOREIGN KEY REFERENCES Produse(ProduseId)
    NumeCategorie VARCHAR(255) NOT NULL
);

CREATE TABLE Produse(
    ProdusId INT IDENTITY(1,1) PRIMARY KEY,
    VanzatorId_FK INT FOREIGN KEY REFERENCES Vanzatori(VanzatorId),
    BrandId_FK INT FOREIGN KEY REFERENCES Branduri(BrandId),
    CategorieId INT FOREIGN KEY REFERENCES CategoriiProduse(CategorieId),
    NumeProdus VARCHAR(255) NOT NULL,
    Pret DECIMAL NOT NULL,
    Stoc INT NOT NULL,
    Caracteristici TEXT NOT NULL,
    Imagine IMAGE NULL


);



CREATE TABLE Comenzi(
    ComandaID INT IDENTITY(1,1) PRIMARY KEY,
    UserId_FK INT FOREIGN KEY REFERENCES Users(UserId),
    ProdusId_FK INT FOREIGN KEY REFERENCES Produse(ProdusId),
    VanzatorId_FK INT FOREIGN KEY REFERENCES Vanzatori(VanzatorId),
    DataComanda DATE Not NULL

)



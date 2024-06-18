use [master];
go
drop database [db_lab18];
go
create database [db_lab18];
go
USE [db_lab18]
GO

-- tables
-- Table: Autor
CREATE TABLE Autor (
    AutorId int  NOT NULL IDENTITY(1, 1),
    NombreCompleto varchar(100)  NOT NULL,
    Seudonimo varchar(50)  NOT NULL,
    AniosExperiencia int  NOT NULL,
    Eliminado bit  NOT NULL,
    CONSTRAINT Autor_PK PRIMARY KEY  (AutorId)
);

-- Table: Editorial
CREATE TABLE Editorial (
    EditorialId int  NOT NULL IDENTITY(1, 1),
    Nombre varchar(100)  NOT NULL,
    FechaFundacion date  NOT NULL,
    Eliminado bit  NOT NULL,
    CONSTRAINT Editorial_PK PRIMARY KEY  (EditorialId)
);

-- Table: Libro
CREATE TABLE Libro (
    LibroId int  NOT NULL IDENTITY(1, 1),
    AutorId int  NOT NULL,
    EditorialId int  NOT NULL,
    Titulo varchar(100)  NOT NULL,
    Genero varchar(50)  NOT NULL,
    NroPaginas int  NOT NULL,
    Eliminado bit  NOT NULL,
    CONSTRAINT Libro_PK PRIMARY KEY  (LibroId)
);

-- foreign keys
-- Reference: Libro_Autor (table: Libro)
ALTER TABLE Libro ADD CONSTRAINT Libro_Autor
    FOREIGN KEY (AutorId)
    REFERENCES Autor (AutorId);

-- Reference: Libro_Editorial (table: Libro)
ALTER TABLE Libro ADD CONSTRAINT Libro_Editorial
    FOREIGN KEY (EditorialId)
    REFERENCES Editorial (EditorialId);

INSERT INTO "Autor" ("NombreCompleto", "Seudonimo", "AniosExperiencia", "Eliminado")
VALUES ('Julia Paredes', 'J.P.', 10, 0)
go
INSERT INTO "Autor" ("NombreCompleto", "Seudonimo", "AniosExperiencia", "Eliminado")
VALUES ('Andrew Kwai', 'Kwai', 3, 0)
go
INSERT INTO "Autor" ("NombreCompleto", "Seudonimo", "AniosExperiencia", "Eliminado")
VALUES ('Andrea Torres', 'A. Towers', 5, 1)
go

INSERT INTO "Editorial" ("Nombre", "FechaFundacion", "Eliminado")
VALUES ('Wattpad Inc.', '2010-08-06', 0)
go
INSERT INTO "Editorial" ("Nombre", "FechaFundacion", "Eliminado")
VALUES ('Random Books', '2000-12-01', 0)
go
INSERT INTO "Editorial" ("Nombre", "FechaFundacion", "Eliminado")
VALUES ('Libro Ladrillo', '2011-05-29', 1)
go
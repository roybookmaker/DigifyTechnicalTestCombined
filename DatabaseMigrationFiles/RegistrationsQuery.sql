CREATE DATABASE localdb;
GO

USE localdb;
GO

CREATE TABLE Registrations (
    Id INT PRIMARY KEY IDENTITY,
    CompanyName NVARCHAR(255) NOT NULL,
    NPWP NVARCHAR(50) NOT NULL,
    DirectorName NVARCHAR(255) NOT NULL,
    PICName NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    PhoneNumber NVARCHAR(50) NOT NULL,
    NPWPFilePath NVARCHAR(255),
    PowerOfAttorneyFilePath NVARCHAR(255)
);
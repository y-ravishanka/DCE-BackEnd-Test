
CREATE DATABASE dceBackEndTest

USE dceBackEndTest

CREATE TABLE Customer
(
	UserId INT IDENTITY(1,1),
	Username VARCHAR(30),
	Email VARCHAR(20),
	FirstName VARCHAR(20),
	LastName VARCHAR(20),
	CreatedOn DATETIME,
	IsActive BIT DEFAULT(1),
	PRIMARY KEY (UserId)
);

SELECT * FROM Customer
DELETE Customer
DROP TABLE Customer

create table Supplier
(
	SupplierId int identity(1,1),
	SupplierName VARCHAR(50) NOT NULL,
	CreatedOn DATETIME NOT NULL,
	IsActive BIT DEFAULT(1)
)

SELECT * FROM Supplier
DELETE Supplier
DROP TABLE Supplier



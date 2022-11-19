
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

/* Order table sql script */
CREATE TABLE [Order]
(
	OrderId UNIQUEIDENTIFIER DEFAULT NEWID(),
	ProductId UNIQUEIDENTIFIER NOT NULL,
	OrderStatus INT(1) NOT NULL,
	OrderType INT(1) NOT NULL,
	OrderBy UNIQUEIDENTIFIER NOT NULL,
	OrderedOn DATETIME NOT NULL,
	ShippedOn DATETIME NOT NULL,
	IsActive BIT DEFAULT(1),
	PRIMARY KEY (OrderId)
)

/* basic Order table function queries */
SELECT * FROM [Order]
DELETE [Order]
DROP TABLE [Order]

CREATE TABLE Supplier
(
	SupplierId int identity(1,1),
	SupplierName VARCHAR(50) NOT NULL,
	CreatedOn DATETIME NOT NULL,
	IsActive BIT DEFAULT(1)
)

SELECT * FROM Supplier
DELETE Supplier
DROP TABLE Supplier



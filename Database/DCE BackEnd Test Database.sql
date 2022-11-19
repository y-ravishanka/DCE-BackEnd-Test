
CREATE DATABASE dceBackEndTest

USE dceBackEndTest

/* Customer table sql script */
CREATE TABLE Customer
(
	UserId UNIQUEIDENTIFIER DEFAULT NEWID(),
	Username VARCHAR(30),
	Email VARCHAR(20),
	FirstName VARCHAR(20),
	LastName VARCHAR(20),
	CreatedOn DATETIME,
	IsActive BIT DEFAULT(1),
	PRIMARY KEY (UserId)
);

/* basic Customer table function queries */
SELECT * FROM Customer;
DELETE Customer;
DROP TABLE Customer;

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
);

/* basic Order table function queries */
SELECT * FROM [Order];
DELETE [Order];
DROP TABLE [Order];

/* Product table sql script */
CREATE TABLE Product
(
	ProductId UNIQUEIDENTIFIER DEFAULT NEWID(),
	ProductName VARCHAR(50) NOT NULL,
	UnitPrice DECIMAL NOT NULL,
	SupplierId UNIQUEIDENTIFIER NOT NULL,
	CreatedOn DATETIME NOT NULL,
	IsActive BIT DEFAULT(1),
	PRIMARY KEY (ProductId)
)

/* basic Product table function queries */
SELECT * FROM Product
DELETE Product
DROP TABLE Product

/* Supplier table sql script */
CREATE TABLE Supplier
(
	SupplierId UNIQUEIDENTIFIER DEFAULT NEWID(),
	SupplierName VARCHAR(50) NOT NULL,
	CreatedOn DATETIME NOT NULL,
	IsActive BIT DEFAULT(1)
);

/* basic Supplier table function queries */
SELECT * FROM Supplier;
DELETE Supplier;
DROP TABLE Supplier;



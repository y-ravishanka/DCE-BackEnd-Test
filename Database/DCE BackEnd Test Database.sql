
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
	OrderStatus INT NOT NULL,
	OrderType INT NOT NULL,
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
);

/* basic Product table function queries */
SELECT * FROM Product;
DELETE Product;
DROP TABLE Product;

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


/*
stored procedure for getting all the active Orders by Customer
product details and supplier details are included
*/

CREATE PROCEDURE GetActiveOrders
@UserId VARCHAR(100)
AS
select o.OrderId,o.OrderStatus,o.OrderType,o.OrderedOn,o.ShippedOn,p.ProductId,p.ProductName,p.UnitPrice,p.CreatedOn,p.IsActive,s.SupplierId,s.SupplierName,s.CreatedOn,s.IsActive 
from [Order] as o,[Product] as p, [Supplier] as s 
where o.OrderBy = @UserId and o.ProductId = p.ProductId and p.SupplierId = s.SupplierId and o.IsActive = 1;

------------------------------------------------------------

-- test procedure
exec GetActiveOrders @UserId = '3D9DFA9D-88A1-42C8-BB3F-C00CCC94DDEB';

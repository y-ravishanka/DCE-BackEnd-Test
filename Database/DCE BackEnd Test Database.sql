
create database dceBackEndTest

use dceBackEndTest

create table Customer
(
	UserId int identity(1,1),
	Username varchar(30),
	Email varchar(20),
	FirstName varchar(20),
	LastName varchar(20),
	CreatedOn datetime,
	IsActive bit default(1),	primary key (UserId));select * from Customerdelete Customerdrop table Customer
--Task_1

USE HumanResources
GO

CREATE TABLE Employee
(
	EmployeeID Int IDENTITY PRIMARY KEY NOT NULL,
	[Name] Varchar(Max) NOT NULL,
	Salary Money NOT NULL DEFAULT 0,
	StartWorking Date NOT NULL,
	PostID Int NOT NULL FOREIGN KEY REFERENCES Post(PostID),
	DepartmentID Int NOT NULL FOREIGN KEY REFERENCES Department(DepartmentID),
)

CREATE TABLE Department
(
	DepartmentID Int IDENTITY PRIMARY KEY NOT NULL,
	DepartmentName Varchar(Max) NOT NULL,
)

CREATE TABLE Post
(
	PostID Int IDENTITY PRIMARY KEY NOT NULL,
	PostName Varchar(Max) NOT NULL,
)

--Task_2

CREATE DATABASE NewDB  
ON							  
(
	NAME = 'NewDB',				
	FILENAME = 'D:\NewDB.mdf',
	SIZE = 30MB,              
	MAXSIZE = 100MB,			
	FILEGROWTH = 10MB			
)
LOG ON						  
( 
	NAME = 'LogNewDB',			
	FILENAME = 'E:\NewDB.ldf',
	SIZE = 5MB,               
	MAXSIZE = 50MB,                    
	FILEGROWTH = 5MB                  
)               
COLLATE Cyrillic_General_CI_AS

--Task_3

USE StorageDB
GO

CREATE TABLE Personal
(
	EmployeeID Int IDENTITY PRIMARY KEY NOT NULL,
	[Name] Varchar(Max) NOT NULL,
	Salary Money NOT NULL DEFAULT 0,
	StartWorking Date NOT NULL,
	OrderID Int NOT NULL FOREIGN KEY REFERENCES [Order](OrderID),
)

CREATE TABLE [Provider]
(
	ProviderID Int IDENTITY PRIMARY KEY NOT NULL,
	ProviderName Varchar(Max) NOT NULL,
)

CREATE TABLE RegularBuyer
(
	BuyerID Int IDENTITY PRIMARY KEY NOT NULL,
	BuyerName Varchar(Max) NOT NULL,
)

CREATE TABLE [Order]
(
	OrderID Int IDENTITY PRIMARY KEY NOT NULL,
	OrderName Varchar(Max) NOT NULL,
	ProviderID Int NOT NULL FOREIGN KEY REFERENCES [Provider](ProviderID),
	BuyerID Int NOT NULL FOREIGN KEY REFERENCES RegularBuyer(BuyerID),
)
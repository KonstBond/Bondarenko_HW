--TASK_1

USE HumanResources

CREATE TABLE ALLINFO
(
	EmployeeID Int IDENTITY PRIMARY KEY NOT NULL,
	[Name] Varchar(Max) NOT NULL,
	Salary Money NOT NULL DEFAULT 0,
	StartWorking Date NOT NULL,
	PostID Int NOT NULL,
	DepartmentID Int NOT NULL,
	DepartmentName Varchar(Max) NOT NULL,
	[CountEmployee] Int NOT NULL,
)

--Нормализация

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
	[CountEmployee] Int NOT NULL,
)

CREATE TABLE Post
(
	PostID Int IDENTITY PRIMARY KEY NOT NULL,
	PostName Varchar(Max) NOT NULL,
)

--TASK_2

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

--TASK_3

USE ShootingDB

CREATE TABLE Shooter
(
	ShooterID Int IDENTITY PRIMARY KEY NOT NULL,
	[Name] Varchar(Max) NOT NULL,
	[Rank] Varchar(Max) NULL,
	Squad Int NOT NULL,
)


CREATE TABLE Gun
(
	GunID Int IDENTITY PRIMARY KEY NOT NULL,
	[Name] Varchar(Max) NOT NULL,
)

CREATE TABLE Warden
(
	WardenID Int IDENTITY PRIMARY KEY NOT NULL,
	[Name] Varchar(Max) NOT NULL,
	[Rank] Varchar(Max) NOT NULL,
)

CREATE TABLE Give
(
	GiveID Int IDENTITY PRIMARY KEY NOT NULL,
	WardenID Int FOREIGN KEY REFERENCES Warden(WardenID) NOT NULL,
	ShooterID Int FOREIGN KEY REFERENCES Shooter(ShooterID) NOT NULL,
	GunID Int FOREIGN KEY REFERENCES Gun(GunID) NOT NULL,
)

INSERT INTO Gun
([Name])
VALUES
('AK-47'),
('Глок20'),
('AK-74')

INSERT INTO Warden
([Name], [Rank])
VALUES
('Буров О.С.','Майор'),
('Рыбаков Н.Г.','Майор '),
('Деребанов В.Я.', 'Подполковник')

INSERT INTO Shooter
([Name], [Rank], Squad)
VALUES
('Петров В.А.','оф.205', 222 ),
('Лодарев П.С.','оф.221', 232),
('Леонтьев К.В.', 'оф.201', 212),
('Духов Р.М.', NULL, 200) 

INSERT INTO Give
(ShooterID, GunID, WardenID)
VALUES
(1,1,1),
(1,2,2),
(2,3,3),
(2,2,2),
(3,1,1),
(3,2,2),
(4,1,1)

SELECT * FROM Give
SELECT * FROM Shooter
SELECT * FROM Warden
SELECT * FROM Gun

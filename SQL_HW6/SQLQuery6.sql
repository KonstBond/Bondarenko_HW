--TASK_1

USE AdventureWorks2012

--Он работает, но ничего не возвращает :)
SELECT * FROM Person.BusinessEntity as BE
	WHERE BE.rowguid = 
		(SELECT rowguid FROM Person.BusinessEntityAddress as BEA
			WHERE BEA.rowguid IN
			 (SELECT rowguid FROM Person.BusinessEntityContact as BEC
				WHERE BEC.ContactTypeID IN
				(SELECT ContactTypeID FROM Person.ContactType as CT
					WHERE CT.ContactTypeID > 1)
			 )
		)
--TASK_2

CREATE DATABASE MyJoinsDB  
ON							  
(
	NAME = 'MyJoinsDB',				
	FILENAME = 'D:\NewDB.mdf',
	SIZE = 10MB,              
	MAXSIZE = 100MB,			
	FILEGROWTH = 10MB			
)
LOG ON						  
( 
	NAME = 'LogMyJoinsDB',			
	FILENAME = 'E:\NewDB.ldf',
	SIZE = 5MB,               
	MAXSIZE = 50MB,                    
	FILEGROWTH = 5MB                  
)               
COLLATE Cyrillic_General_CI_AS

--TASK_3

USE MyJoinsDB

CREATE TABLE Employee
(
	EmployeeID INT IDENTITY PRIMARY KEY NOT NULL,
	[Name] Varchar(MAX) NOT NULL,
	Phone NChar(10) NOT NULL,
	PostID INT NOT NULL FOREIGN KEY REFERENCES Post(PostID),
)

CREATE TABLE Post
(
	PostID INT IDENTITY PRIMARY KEY NOT NULL,
	PostName Varchar(MAX) NOT NULL,
	Salary Money NOT NULL,
)

CREATE TABLE EmployeeInfo
(
	EmployeeID INT NOT NULL UNIQUE FOREIGN KEY REFERENCES Employee(EmployeeID),
	Maried Bit NOT NULL,
	Birthday Date NOT NULL,
	Home Varchar(MAX) NOT NULL,
)

INSERT Post
(PostName, Salary)
VALUES
('Главный директор', 10000.00),
('Менеджер', 2400.00),
('Рабочий', 1800.00)

INSERT Employee
([Name], Phone, PostID)
VALUES
('Бондаренко К.О.', 0665645643, 1),
('Филипенко С.В.', 0665630362, 2),
('Денисов А.В.', 0663232364, 3),
('Джанер Г.Ф.', 0665456234, 3),
('Хватов Л.Л.', 0665675353, 3),
('Бойко П.В.', 0664563453, 2),
('Бессонов Н.С.', 0664235268, 3)

INSERT EmployeeInfo
(EmployeeID,Maried, Birthday, Home)
VALUES
(1,1, '15/02/1998', 'Шампанский 12'),
(2,0, '06/06/1988', 'Кутузова 35'),
(3,1, '01/12/1999', 'Советская 103'),
(4,0, '27/10/1979', 'Мясоедова 7/9'),
(5,0, '24/05/2001', 'Шевченко 2'),
(6,1, '21/02/1999', 'Старицкого 12'),
(7,0, '16/08/1989', 'Трубодуров 57')

--TASK_4
SELECT Phone, (SELECT Home FROM EmployeeInfo WHERE Employee.EmployeeID = EmployeeInfo.EmployeeID) FROM Employee

SELECT Birthday, (SELECT Phone FROM Employee WHERE Employee.EmployeeID = EmployeeInfo.EmployeeID) as Phone FROM EmployeeInfo
	WHERE Maried = 0

SELECT Phone, (SELECT Birthday FROM EmployeeInfo WHERE Employee.EmployeeID = EmployeeInfo.EmployeeID) as Phone FROM Employee
	WHERE PostID IN (SELECT PostID FROM Post 
		WHERE PostName = 'Менеджер')
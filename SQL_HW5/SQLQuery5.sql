--TASK_1

USE AdventureWorks2012

SELECT Production.Product.ProductID, Production.Product.[Name]  FROM Production.Product
	JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
	JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
	JOIN Production.UnitMeasure ON Production.Product.SizeUnitMeasureCode = Production.UnitMeasure.UnitMeasureCode
	WHERE Production.Product.[Name] LIKE 'HL%'
	ORDER BY Production.Product.ProductID

--TASK_2
SELECT * FROM Production.ProductModel


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

SELECT Employee.[Name], Employee.Phone, EmployeeInfo.Home FROM Employee
	JOIN EmployeeInfo ON Employee.EmployeeID = EmployeeInfo.EmployeeID

SELECT Employee.[Name], Employee.Phone, EmployeeInfo.Birthday FROM Employee
	JOIN EmployeeInfo ON Employee.EmployeeID = EmployeeInfo.EmployeeID
	WHERE Maried = 0

SELECT Employee.[Name], Employee.Phone, EmployeeInfo.Birthday FROM Employee
	JOIN EmployeeInfo ON Employee.EmployeeID = EmployeeInfo.EmployeeID
	JOIN Post ON Post.PostID = Employee.PostID
	WHERE Post.PostName = 'Менеджер' 

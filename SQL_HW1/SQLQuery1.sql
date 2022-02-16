CREATE DATABASE MyDB  
ON							  
(
	NAME = 'MyDB',			
	FILENAME = 'D:\SQL\SQL_HW1\MyDB.mdf',		
	SIZE = 10MB,                    
	MAXSIZE = 100MB,				
	FILEGROWTH = 10MB		
)
LOG ON						  
( 
	NAME = 'LogMyDB',				  
	FILENAME = 'D:\SQL\SQL_HW1\MyDB.ldf',        
	SIZE = 5MB,                        
	MAXSIZE = 50MB,                    
	FILEGROWTH = 5MB                   
)               
COLLATE Cyrillic_General_CI_AS 

CREATE TABLE EmployeeNames
(
	[Name] NVarchar(MAX) NOT NULL,
	phone Nchar(10) NOT NULL,
)

CREATE TABLE EmployeePost
(
	Salary money NOT NULL,
	Post NVarchar(MAX) NOT NULL,
)

CREATE TABLE EmployeeInfo
(
	Maried NVarchar(MAX) NOT NULL,
	Birthday date NOT NULL,
	Home NVarchar(MAX) NOT NULL,
)


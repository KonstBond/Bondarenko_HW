--Task_1

USE AdventureWorks2012

--StandartCost в обоих случаях = 0, поэтому выборка пустая :)
SELECT * FROM Production.Product
WHERE StandardCost > 100 AND NAME LIKE 'ML%' AND ProductNumber LIKE 'RM%'
GO

--Task_2

USE HomeWork

CREATE TABLE Product
(
	ProductID Int IDENTITY NOT NULL,
	[Name] NVarchar(MAX) NOT NULL,
	ProductNumber NVarchar(MAX) NOT NULL,
	Cost Money NOT NULL, 
	[Count] Int,
	SellStartDate Date NOT NULL
)

INSERT INTO Product
([name], ProductNumber, Cost, [Count], SellStartDate)
VALUES
('Корона', 'AK-53818', '5', '50', '15/08/2011'),
('Милка', 'AM-51122','6.1', '50', '15/07/2011'),
('Аленка', 'AA-52211', '2.5', '20', '15/06/2011'),
('Snickers', 'BS-32118', '2.8', '50', '15/08/2011'),
('Snickers', 'BSL-3818', '5', '100', '20/08/2011'),
('Bounty', 'BB-38218', '3', '100', '01/08/2011'),
('Nuts', 'BN-37818', '3', '100', '21/08/2011'),
('Mars', 'BM-3618', '2.5', '50', '24/08/2011'),
('Свиточ', 'AS-54181', '5', '100', '12/08/2011'),
('Свиточ', 'AS-54182', '5', '100', '12/08/2011')
GO

--Task_3

SELECT * FROM Product
WHERE [Count] > 59 
GO

SELECT * FROM Product
WHERE cost > 3 AND SellStartDate > '20/08/2011'
GO

--Task_4

UPDATE Product
SET Cost += 0.25
WHERE [Name] = 'Свиточ'
GO
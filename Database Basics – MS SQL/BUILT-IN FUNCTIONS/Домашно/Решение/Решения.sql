USE SoftUni
go
--Problelm 1
Select FirstName,LastName
From Employees
WHERE FirstName LIKE 'SA%'
go
--Problem 2
Select FirstName,LastName
From Employees
WHERE LastName LIKE '%ei%'
go
--Problem 3
SELECT FirstName
FROM Employees
WHERE DepartmentID IN (3,10) AND HireDate BETWEEN '1995-01-01' AND '2005-12-31'
go
--Problme 4
SELECT FirstName,LastName
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'
go
--Problem 5
SELECT [Name]
FROM Towns
WHERE LEN([NAME])=5 OR LEN([NAME])=6
ORDER BY [NAME] ASC
go
--Problem 6
SELECT *
FROM Towns
WHERE [Name] LIKE '[MKBE]%'
ORDER BY [Name]ASC
go
--Problem 7
SELECT *
FROM Towns
WHERE [Name] NOT LIKE '[RBD]%'
ORDER BY [Name]ASC
go
--Problem 8

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT*
FROM Employees
WHERE HireDate BETWEEN '2000-01-01' AND GETDATE()
go
--Problem 9
SELECT FirstName,LastName
FROM Employees
WHERE LEN(LastName)=5
go
USE Geography
--Problem 10
SELECT CountryName,IsoCode
FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode
--Problem 11
SELECT * FROM Peaks
SELECT * FROM Rivers

SELECT PeakName, RiverName, 
LOWER(PeakName + SUBSTRING(RiverName, 2, LEN(RiverName) - 1)) AS [Mix] FROM Peaks, Rivers
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER By [Mix]
go
--Problem 13
USE Diablo
SELECT Username,
 Right (Email,LEN(Email)-CHARINDEX('@',Email)) AS [Email Provider]
From [Users]
ORDER BY [Email Provider],Username
--Problem 14
SELECT Username, IpAddress AS [IP Address] FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username
--Problem 15
SELECT * FROM Games

SELECT [Name] AS [Game],
CASE
	WHEN DATEPART(HOUR, Start) BETWEEN 0 AND 11 THEN 'Morning'
	WHEN DATEPART(HOUR, Start) BETWEEN 12 AND 17 THEN 'Afternoon'
	WHEN DATEPART(HOUR, Start) BETWEEN 18 AND 24 THEN 'Evening'
END AS [Part of the Day],
CASE
	WHEN Duration <= 3 THEN 'Extra Short'
	WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
	WHEN Duration > 6 THEN 'Long'
	WHEN Duration IS NULL THEN 'Extra Long'
END AS [Duration]
FROM Games
ORDER BY Game, Duration, [Part of the Day]
--Problem 16
SELECT * FROM INFORMATION_SCHEMA.TABLES

SELECT * FROM Orders

SELECT ProductName, OrderDate,
DATEADD(DAY, 3, OrderDate) AS [Pay Due],
DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
FROM Orders

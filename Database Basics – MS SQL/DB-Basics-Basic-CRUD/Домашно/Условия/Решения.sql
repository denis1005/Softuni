
SELECT *
FROM Departments
go
--Problem 3
SELECT Name 
FROM Departments
go
--Problem 4
SELECT FirstName,LastName,Salary
FROM Employees
go
--Problem 5
SELECT FirstName,MiddleName,LastName
FROM Employees
--Problem 6
Select FirstName + '.' + LastName +'@softuni.bg' AS [Full Email Address]
FROM Employees
go
--Problem 7
SELECT  DISTINCT Salary
FROM Employees
go
--Problem 8
SELECT *
FROM Employees
WHERE JobTitle='Sales Representative'
go
--Problem 9
SELECT FirstName,LastName,JobTitle
FROM Employees
WHERE Salary>=20000 AND Salary<=30000
go
--Problem 10
SELECT FirstName+' '+ MiddleName+' '+ LastName AS [Full NaMe]
FROM Employees
Where Salary IN (25000,14000,12500,23600)
go
--Problem 11
SELECT FirstName,LastName
FROM Employees
Where ManagerID IS NULL
go
--Prbolem 12
SELECT FirstName,LastName,Salary
FROM Employees
Where Salary >50000
ORDER BY Salary DESC
go
--Ptoblem 13
SELECT TOP (5)FirstName,LastName
FROM Employees
Where Salary >50000
ORDER BY Salary DESC
go
--Problem 14
SELECT FirstName,LastName
FROM Employees
Where NOT (DepartmentID=4)
go
--Problem 15
SELECT *
FROM Employees
ORDER BY Salary DESC,FirstName ASC,LastName  DESC,MiddleName ASC
go
--Problem 16
CREATE VIEW V_EmployeesSalaries AS
SELECT FirstName,LastName,Salary
FROM Employees
go
--Problem 17

CREATE VIEW v_EmployeeNameJobTitle AS
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle AS [Job Title] FROM Employees
GO
--Problem 18
SELECT DISTINCT JobTitle
FROM Employees

--Problem 19
SELECT TOP (10)* 
FROM Projects
ORDER BY  StartDate ,[Name]
--Problem 20
SELECT  TOP (5) FirstName,LastName,HireDate
FROM Employees
ORDER BY HireDate DESC
--Problem 21
UPDATE Employees
SET Salary *= 1.12
WHERE DepartmentID = 1 OR DepartmentID = 2 OR DepartmentID = 4 OR DepartmentID = 11

SELECT Salary FROM Employees
GO

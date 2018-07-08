--Problem 1
USE Gringotts
SELECT COUNT(*)
FROM WizzardDeposits
--Problem 2
SELECT MAX(MagicWandSize) AS LongestMegicWand
FROM WizzardDeposits
--Problem 3
SELECT DepositGroup,
 MAX(MagicWandSize) AS LongestMegicWand
FROM WizzardDeposits
GROUP BY DepositGroup
--Problem 4
SELECT TOP (2)DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)
--Problem 5
SELECT DepositGroup,
SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup
--Problem 6
SELECT DepositGroup,
SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup,MagicWandCreator
HAVING MagicWandCreator='Ollivander family'
go
--Problem 7
SELECT DepositGroup,
SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup,MagicWandCreator
HAVING MagicWandCreator='Ollivander family' AND SUM(DepositAmount)<150000
ORDER BY TotalSum DESC
go
--Problem 8 
SELECT DepositGroup,
MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup,MagicWandCreator
ORDER BY MagicWandCreator,DepositGroup
--Problem 9
SELECT
 CASE
  WHEN Age < 10 THEN '[0-10]'
  WHEN Age < 21 THEN '[11-20]'
  WHEN Age < 31 THEN '[21-30]'
  WHEN Age < 41 THEN '[31-40]'
  WHEN Age < 51 THEN '[41-50]'
  WHEN Age < 61 THEN '[51-60]'
 ELSE '[61+]'
END AS [AgeGroup],
COUNT(*) AS WizardCount
FROM WizzardDeposits
GROUP BY
 CASE
  WHEN Age < 10 THEN '[0-10]'
  WHEN Age < 21 THEN '[11-20]'
  WHEN Age < 31 THEN '[21-30]'
  WHEN Age < 41 THEN '[31-40]'
  WHEN Age < 51 THEN '[41-50]'
  WHEN Age < 61 THEN '[51-60]'
 ELSE '[61+]'
END
go
--Problem 10
SELECT LEFT (FirstName,1)
FROM WizzardDeposits
GROUP BY LEFT (FirstName,1),DepositGroup
HAVING DepositGroup='Troll Chest'
ORDER BY LEFT (FirstName,1) ASC
--Problem 11
SELECT DepositGroup,
 IsDepositExpired,
 AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits
WHERE DATEPART(YEAR, DepositStartDate) > 1984
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired
go
--Problem 12
SELECT SUM(DepositAmount - NextDeposit) AS [SumDifference]
  FROM (SELECT DepositAmount , 
	  LEAD (DepositAmount) OVER (ORDER BY Id) AS [NextDeposit]
	  FROM WizzardDeposits) AS WizzartDeposits 
 go
--Problem 13
USE Softuni
SELECT DepartmentID,
SUM(Salary) AS [TotalSalary]
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID ASC
go
--Problem 14
SELECT DepartmentID,
MIN(Salary) AS [MinSalary]
FROM Employees
WHERE DATEPART(YEAR, HireDate) > 1999
GROUP BY DepartmentID
HAVING DepartmentID IN (2,5,7)
ORDER BY DepartmentID ASC
go
--Problem 15
SELECT * INTO TempTable FROM Employees
WHERE Salary > 30000

DELETE FROM TempTable
WHERE ManagerID = 42

UPDATE TempTable
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID,
 AVG(Salary) AS [AverageSalary]
FROM TempTable
GROUP BY DepartmentID
go
--Problem 16
SELECT DepartmentID,
MAX(Salary) AS [MaxSalary]
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000
go
--Problem 17
SELECT COUNT(*)
FROM Employees
WHERE ManagerID IS NULL
go
--Problem 18
SELECT DepartmentID, ThirdHighestSalary FROM
(
	SELECT DepartmentID,
	 MAX(Salary) AS ThirdHighestSalary,
	 DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS Rank
	FROM Employees
	GROUP BY DepartmentID, Salary
)
AS ThirdPart
WHERE Rank = 3

--problem 19    
SELECT TOP 10 e1.FirstName, e1.LastName, e1.DepartmentID 
FROM Employees AS e1
WHERE Salary >
(
	SELECT AVG(Salary)
	FROM Employees AS e2
	WHERE e2.DepartmentID = e1.DepartmentID
	GROUP BY DepartmentID
)


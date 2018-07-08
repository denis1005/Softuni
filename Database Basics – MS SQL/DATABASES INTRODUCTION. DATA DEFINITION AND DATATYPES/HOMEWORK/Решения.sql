Problem 1.
CREATE DATABASE Minions
Problem 2.
CREATE TABLE Minions(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR (50),
Age INT
)
CREATE TABLE TOWN(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR (50),
)
Problem 3.
ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCEs TOWN(Id)

Problem 4.
INSERT INTO Towns (Id,Name) VALUES ('1','Sofia'),('2','Plovdiv'),('3','Varna'); INSERT INTO Minions (Id,Name,Age,TownId) VALUES('1','Kevin','22','1'),('2', 'Bob','15','3'),('3', 'Steward',NULL,'2');

Problem 5.
TURNICATE TABLE Minions

Problem 6.
DROP TABLE Minions
DROP TABLE Towns
Problem 7.
CREATE TABLE People(
Id BigINT PRIMARY KEY IDENTITY,
[Name] VARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Hight DECIMAL(15,1),
[Weight] DECIMAL,
Gender VARCHAR(1) NOT NULL,
BirhDate DATETIME NOT NULL,
Biography NTEXT,


)

INSERT INTO People([Name],Picture,Hight,[Weight],Gender,BirhDate,Biography)
VALUES
('Ivan',NULL,1.56,1.43,'m',CONVERT(datetime,'11-10-2018',103),NULL),
('Stoyan',NULL,1.56,1.43,'f',CONVERT(datetime,'11-10-2018',103),NULL),
('Damqn',NULL,1.56,1.43,'f',CONVERT(datetime,'11-10-2018',103),NULL),
('Baraban',NULL,1.56,1.43,'f',CONVERT(datetime,'11-10-2018',103),NULL),
('Stamy',NULL,1.56,1.43,'m',CONVERT(datetime,'11-10-2018',103),NULL)

Problem 8.
CREATE TABLE Users(
Id BigINT PRIMARY KEY IDENTITY,
UserName VARCHAR(30) NOT NULL UNIQUE,
[Password] VARCHAR (26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLoginTime DATETIME,
isDeleted BIT,

)
INSERT INTO Users (UserName,[Password],ProfilePicture,LastLoginTime,isDeleted)
VALUES
('Stamat','123',NULL,CONVERT(datetime,'22-05-2018',103),0),
('Ivan','1223',NULL,CONVERT(datetime,'23-05-2018',103),1),
('Todor','321',NULL,CONVERT(datetime,'22-05-2018',103),0),
('Kokoshka','12332',NULL,CONVERT(datetime,'21-05-2018',103),0),
('Krasnodarka','132323',NULL,CONVERT(datetime,'22-05-2018',103),1)

Problem 9
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC0795902651

ALTER TABLE USERS
ADD CONSTRAINT PK_USERS PRIMARY KEY (Id,UserName)
Problem 11
ALTER TABLE USERS
ADD DEFAULT GETDATE() FOR LastLoginTime,

Problem 12
ALTER TABLE USERS
ADD CONSTRAINT CHK_USERS CHECK (LEN(UserName)>=3)
Problem 13
CREATE TABLE Dircetors(
Id INT PRIMARY KEY IDENTITY,
DirectorName VARCHAR(50) NOT NULL,
Notes NTEXT,
)

CREATE TABLE Ganres(
Id INT PRIMARY KEY IDENTITY,
GanreName VARCHAR(50) NOT NULL,
Notes NTEXT,
)

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(50) NOT NULL,
Notes NTEXT,
)
CREATE TABLE Movies(
Id INT PRIMARY KEY IDENTITY,
Title VARCHAR(50) NOT NULL,
DirectorId INT FOREIGN KEY REFERENCES Dircetors(Id) NOT NULL,
CopyrightYear INT,
[Length] INT ,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
Notes NTEXT,
)
INSERT INTO Movies(Title,DirectorId,CategoryId)
VALUES
('SAW',1,1),
('KARIBSKI PIRATI',2,2),
('Jenini s DEca',3,1),
('Voina na SVetoveto',5,1),
('Koi shte kara vlaka',4,3)
INSERT INTO Dircetors(DirectorName)
VALUES
('Ivan'),
('Dragan'),
('Pesho'),
('Stamat'),
('Kiril')
 INSERT INTO Ganres(GanreName)
 VALUES
 ('komediq'),
 ('horor'),
 ('romantika'),
 ('fantastika'),
 ('psixo')
 INSERT INTO Categories(CategoryName)
 VALUES
 ('serial'),
 ('film'),
 ('semeen'),
 ('zabaven'),
 ('trivialno')

Problem 14

CREATE TABLE Categories (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		CategoryName NVARCHAR(50),
		DailyRate DECIMAL(5, 2) NOT NULL,
		WeeklyRate DECIMAL(5, 2) NOT NULL,
		MonthlyRate DECIMAL(5, 2) NOT NULL,
		WeekendRate DECIMAL(5, 2) NOT NULL
	)
	INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
	('monster trucks', 5.21, 23.5, 125.5, 45.5)
	

	INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
	('tesla cars', 51.21, 123.5, 225.5, 435.5)
	

	INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
	('opel astrak', 0.21, 3.5, 5.5, 1.5)
	

	CREATE TABLE Cars (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		PlateNumber VARCHAR(8),
		Manufacturer VARCHAR(30),
		Model VARCHAR(30),
		CarYear DATE,
		CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
		Doors REAL,
		Picture VARBINARY(MAX),
		Condition NVARCHAR(100),
		Available BIT
	)
	

	INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Condition, Available) VALUES
	('B 0525 A', 'Opel', 'Astra', '1994', 3, 4, 'BRAND NEW WITH RUST', 1)
	

	INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Condition, Available) VALUES
	('A 2241 X', 'Opel', 'Cadet', '1990', 1, 2, 'BRAND NEW WITH RUST', 1)
	

	INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Condition, Available) VALUES
	('X 4452 A', 'Opel', 'Vectra', '1997', 3, 4, 'BRAND NEW WITH RUST', 2)
	

	CREATE TABLE Employees (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		FirstName NVARCHAR(50) NOT NULL,
		LastName NVARCHAR(50) NOT NULL,
		Title NVARCHAR(30),
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO Employees (FirstName, LastName) VALUES
	('Dancho', 'Lechkov'),
	('Hristo', 'Stoichkov'),
	('Emil', 'Kremenliev')
	

	CREATE TABLE Customers (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		DriverLicenceNumber NVARCHAR(15) NOT NULL,
		FullName NVARCHAR(100) NOT NULL,
		Address NVARCHAR(500),
		City NVARCHAR(50),
		ZIPCode NVARCHAR(10),
		Notes NVARCHAR(200)
	)
	

	INSERT INTO Customers (DriverLicenceNumber, FullName) VALUES
	('Bql', 'Georgi Ivanov'),
	('Zelen', 'Petur Hubchev'),
	('Cherven', 'Dimitur Penev')
	

	CREATE TABLE RentalOrders (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
		CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
		CarId INT,
		TankLevel INT,
		KilometrageStart INT,
		KilometrageEnd INT,
		TotalKilometrage INT,
		StartDate DATE,
		EndDate DATE,
		TotalDays AS DATEDIFF(DAY, StartDate, EndDate),
		RateApplied INT,
		TaxRate DECIMAL(5, 2),
		OrderStatus NVARCHAR(50),
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO RentalOrders (EmployeeId, CustomerId, StartDate, EndDate) VALUES
	(1, 1, '05/05/1995', '05/10/1995'),
	(2, 1, '10/10/2010', '10/12/2010'),
	(3, 3, '06/07/2017', '09/07/2017')

Problem 15
CREATE DATABASE Hotel
	USE Hotel
	

	CREATE TABLE Employees (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		FirstName NVARCHAR(50) NOT NULL,
		LastName NVARCHAR(50) NOT NULL,
		Title NVARCHAR(100),
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO Employees (FirstName, LastName) VALUES
	('Michael', 'Jackson'),
	('Michael', 'Jordan'),
	('Michael', 'Keaton')
	

	CREATE TABLE Customers (
		AccountNumber INT UNIQUE IDENTITY NOT NULL,
		FirstName NVARCHAR(50) NOT NULL,
		LastName NVARCHAR(50) NOT NULL,
		PhoneNumber INT,
		EmergencyName NVARCHAR(100),
		EmergencyNumber INT,
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO Customers (FirstName, LastName) VALUES
	('Josh', 'Brolin'),
	('Jon', 'Snow'),
	('Jake', 'Gylenhaal')
	

	CREATE TABLE RoomStatus (
		RoomStatus NVARCHAR(50) PRIMARY KEY NOT NULL,
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO RoomStatus (RoomStatus) VALUES
	('Occupied'),
	('Available'),
	('Cleaning')
	

	CREATE TABLE RoomTypes (
		RoomType NVARCHAR(50) PRIMARY KEY NOT NULL,
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO RoomTypes (RoomType) VALUES
	('4 person'),
	('2 person'),
	('Boksonierka, brat')
	

	CREATE TABLE BedTypes (
		BedType NVARCHAR(50) PRIMARY KEY NOT NULL,
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO BedTypes (BedType) VALUES
	('King'),
	('Queen'),
	('Midget')
	

	CREATE TABLE Rooms (
		RoomNumber INT PRIMARY KEY IDENTITY NOT NULL,
		RoomType NVARCHAR(50) FOREIGN KEY REFERENCES RoomTypes(RoomType),
		BedType NVARCHAR(50) FOREIGN KEY REFERENCES BedTypes(BedType),
		Rate DECIMAL(6,2),
		RoomStatus NVARCHAR(50),
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO Rooms (Rate) VALUES
	(12.55),
	(43.99),
	(60.33)
	

	CREATE TABLE Payments (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		EmployeeId INT,
		PaymentDate DATE,
		AccountNumber INT,
		FirstDateOccipied DATE,
		LastDateOccupied DATE,
		TotalDays AS DATEDIFF(DAY, FirstDateOccipied, LastDateOccupied),
		AmountCharged DECIMAL(10, 2),
		TaxRate DECIMAL(6, 2),
		TaxAmount DECIMAL(6, 2),
		PaymentTotal DECIMAL(12, 2),
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO Payments (EmployeeId, PaymentDate, AmountCharged) VALUES
	(1, GETDATE(), 60.25),
	(2, GETDATE(), 160.25),
	(3, GETDATE(), 460.25)
	

	CREATE TABLE Occupancies (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		EmployeeId INT,
		DateOccipied DATE,
		AccountNumber INT,
		RoomNumber INT,
		RateApplied DECIMAL(6, 2),
		PhoneCharge DECIMAL(10, 2),
		Notes NVARCHAR(MAX)
	)
	

	INSERT INTO Occupancies (EmployeeId, RateApplied, Notes) VALUES
	(1, 55.55, 'enough is enough'),
	(2, 15.55, 'now I know how the typewriters feel'),
	(3, 35.55, 'these exercises are obsolete')

Problem 16


CREATE DATABASE SoftUni
	GO  
	

	USE SoftUni
	GO
	

	CREATE TABLE Towns (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		[Name] NVARCHAR(50)
	)
	

	CREATE TABLE Addresses (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		AddressText NVARCHAR(100),
		TownId INT FOREIGN KEY REFERENCES Towns(Id)
	)
	

	CREATE TABLE Departments (
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		Name NVARCHAR(50)
	)
	

	CREATE TABLE Employees
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		FirstName NVARCHAR(50),
		MiddleName NVARCHAR(50),
		LastName NVARCHAR(50),
		JobTitle NVARCHAR(35),
		DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
		HireDate DATE,
		Salary DECIMAL(10,2),
		AddressId INT FOREIGN KEY REFERENCES Addresses(Id)
	)
	

	--problem 17
	BACKUP DATABASE SoftUni
		TO DISK = 'D:\softuni-backup.bak' --location where the backup file will be saved
			WITH FORMAT,
				MEDIANAME = 'DB Back up',
				NAME = 'SoftUni DataBase 2017-09-22';
	GO
	

	RESTORE DATABASE SoftUni
	FROM DISK = 'D:\softuni-backup.bak' --location of the db on your hard drive
	GO
	

	--problem 18
	USE SoftUni
	

	INSERT INTO Towns ([Name]) VALUES
	('Sofia'),
	('Plovdiv'),
	('Varna'),
	('Burgas')
	

	INSERT INTO Departments (Name) VALUES
	('Engineering'),
	('Sales'),
	('Marketing'),
	('Software Development'),
	('Quality Assurance')
	

	INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary) VALUES
	('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013/01/02', 3500.00),
	('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004/02/03', 4000.00),
	('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016/28/08', 525.25),
	('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007/09/12', 3000.00),
	('Peter', 'Pan', 'Pan', 'Intern', 3, '2016/28/08', 599.88)
	--it's quite possible for the dates to be reversed, e.g. the last one to be 2016/08/28, depends on your PC's settings
	


	--problem 19
	SELECT * FROM Towns
	

	SELECT * FROM Departments
	

	SELECT * FROM Employees
	

	--problem 20
	SELECT * FROM Towns ORDER BY Name
	

	SELECT * FROM Departments ORDER BY Name
	

	SELECT * FROM Employees ORDER BY Salary DESC --this is order by descending
	

	--problem 21
	SELECT Name FROM Towns ORDER BY Name
	

	SELECT Name FROM Departments ORDER BY Name
	

	SELECT FirstName, LastName, JobTitle, Salary FROM Employees ORDER BY Salary DESC --the listing should be done with a comma
	

	--problem 22
	UPDATE Employees
	SET Salary += Salary * 0.1  
	

	SELECT Salary FROM Employees
	

	--problem 23
	USE Hotel
	

	UPDATE Payments
	SET TaxRate -= TaxRate * 0.03
	

	SELECT TaxRate FROM Payments
	

	--problem 24
	DELETE FROM Occupancies
	SELECT * FROM Occupancies


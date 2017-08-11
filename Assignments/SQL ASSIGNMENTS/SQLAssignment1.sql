CREATE DATABASE Assignment1
 ON
( NAME = N'Assignment1', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Assignment1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Assignment1_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Assignment1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)

USE Assignment1
GO

CREATE TABLE Employee
(
Id int null,
Name varchar(20) null,
Gender varchar(20) null,
Basic int null,
HR int null,
DA int null,
TAX int null,
DeptID int null
);

INSERT INTO Employee
VALUES 
(1,'Anil','Male',10000,5000,1000,400,1),
(2,'Sanjana','Female',12000,6000,1000,500,2),
(3,'Johnny','Male',5000,2500,500,200,2),
(4,'Suresh','Male',6000,3000,500,250,1),
(5,'Anglia','Female',11000,5500,1000,500,4),
(6,'Saurabh','Male',12000,6000,1000,600,1),
(7,'Manish','Male',4000,2000,500,150,2),
(8,'Neeraj','Male',5000,2500,500,200,3),
(9,'Suman','Female',5000,2500,500,200,4),
(10,'Tina','Female',6000,3000,500,220,1);

SELECT * FROM Employee

CREATE TABLE Department
(
DeptID int null,
DeptName varchar(20) null,
DeptHeadID int null
);


INSERT INTO Department
VALUES
(1,'HR',1),
(2,'Admin',2),
(3,'Sales',9),
(4,'Engineering',5);


SELECT * FROM Department


CREATE TABLE EmployeeAttendance
(
EmpID int null,
Date date null,
WorkingDays int null,
PresebtDays int null
);

INSERT INTO EmployeeAttendance
VALUES
(1,'20100101',22,21),
(1,'20100201',20,20),
(1,'20100301',22,20),
(2,'20100101',22,22),
(2,'20100201',20,20),
(2,'20100301',22,22),
(3,'20100101',22,21),
(3,'20100201',20,20),
(3,'20100301',22,21),
(4,'20100101',22,21),
(4,'20100201',20,19),
(4,'20100301',22,22),
(5,'20100101',22,22),
(5,'20100201',20,20),
(5,'20100301',22,22),
(6,'20100101',22,21),
(6,'20100201',20,20),
(6,'20100301',22,20),
(7,'20100101',22,21),
(7,'20100201',20,20),
(7,'20100301',22,21),
(8,'20100101',22,21),
(8,'20100201',20,20),
(8,'20100301',22,21),
(9,'20100101',22,22),
(9,'20100201',20,20),
(9,'20100301',22,21),
(10,'20100101',22,22),
(10,'20100201',20,20),
(10,'20100301',22,22);


SELECT * FROM EmployeeAttendance

SELECT
	A.DeptID,
	Gender,
	NoOfEmployees
FROM
(
(
SELECT 
	DeptID,
	Gender,
	COUNT(Name)
	AS
		NoOfEmployees
FROM
	Employee
GROUP BY
	DeptID,
	Gender
)
AS
	A
INNER JOIN
(
SELECT 
	DeptID,
	DeptName
FROM
	Department
)
AS
	B
ON
	A.DeptID=B.DeptID
)


SELECT
	DName.DeptName,
	NoOfEmployees,
	HighestGrossSalary,
	TotalSalary
FROM
(
(
SELECT 
	DeptID,
	COUNT(Name)
	AS
		NoOfEmployees
FROM
	Employee
GROUP BY
	DeptID
)
AS
	CountEmp
INNER JOIN
(
SELECT
	DeptID,
	MAX(Basic+HR+DA)
	As 
		HighestGrossSalary,
	SUM(Basic+HR+DA-Tax)
	As
		TotalSalary
FROM
	Employee
GROUP BY
	DeptID
)
AS
	DeptSalary
ON
	CountEmp.DeptID=DeptSalary.DeptId
INNER JOIN
(
SELECT 
	DeptID,
	DeptName
FROM
	Department
)
AS
	DName
ON
	CountEmp.DeptID=DName.DeptID
)



SELECT
	DeptID,
	MAX(Name)
	AS
		NameOfEmployee,
	MAX(Basic+HR+DA)
	As 
		HighestGrossSalary
FROM
	Employee
GROUP BY
	DeptID



SELECT 
	ID,
	Name
FROM
	Employee
WHERE
	(Basic+HR+DA)>15000


SELECT
	Name
FROM
	Employee

WHERE
	Employee.Basic=
           (	
		   SELECT 
		   MIN(Basic)
		   FROM
		   (
		   SELECT DISTINCT TOP 2 
		       Basic
		   FROM
			   Employee
           ORDER BY
		       Basic DESC
           )AS 
		       C1
		   )
          
		  
SELECT
	DeptName,
	NoOfEmployees
FROM
	(
	(
	SELECT
	DeptID,
	COUNT(Name)
	AS
		NoOfEmployees
	FROM
		Employee
	GROUP BY
		DeptId
	)
	AS
		T1
	INNER JOIN
	(
	SELECT
		DeptId,
		DeptName
	FROM
		Department
	)
	AS
		T2
	ON
		T1.DeptID=T2.DeptID
	)
WHERE
	NoOfEmployees>3
	
	
SELECT
	DeptName,
	Name
	AS
		DeptHeadName
	FROM
		Department D
	INNER JOIN
		Employee E
	ON
		D.DeptHeadID=E.ID			  
		   

SELECT
	Name
FROM
	(
	SELECT	
		EmpID
	FROM
		EmployeeAttendance
	GROUP BY
		EmpID
	HAVING
		SUM(WorkingDays)=SUM(PresebtDays)
	)
	AS
		T1
	INNER JOIN
		Employee E
	ON
		E.Id=T1.EmpID



SELECT
	Name
FROM
(
SELECT
	EmpID,
	SUM(PresebtDays)
	AS
		PD
FROM
	EmployeeAttendance
GROUP BY
	EmpID
)
AS
	T1
INNER JOIN
	Employee
ON
	T1.EmpID=Employee.ID

WHERE
	PD=(
	    SELECT
			MIN(PD)
		FROM
			(
			SELECT
				EmpID,
				SUM(PresebtDays)
				AS
					PD
			FROM
				EmployeeAttendance
			GROUP BY
				EmpID
			)
			AS
				T1
		)
		

SELECT
	*
FROM
(
SELECT
	EmpID,
	SUM(PresebtDays)
	AS
		PD,
	SUM(WorkingDays)
	AS
		WD
FROM
	EmployeeAttendance
GROUP BY
	EmpID
)
AS
	T1
INNER JOIN
	Employee
ON
	T1.EmpID=Employee.ID
WHERE
	(WD-PD)>3

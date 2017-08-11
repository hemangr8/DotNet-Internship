
CREATE DATABASE [EntityFrameworkAssignment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntityFrameworkAssignment', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EntityFrameworkAssignment.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EntityFrameworkAssignment_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EntityFrameworkAssignment_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO


Create table Users
(
     ID int primary key identity,
     Name nvarchar(50),
     Gender nvarchar(50),
     UserType nvarchar(20)
)


Insert into Users values ('Mark', 'Male', 'Admin')
Insert into Users values ('Steve', 'Male', 'Normal')
Insert into Users values ('Ben', 'Male', 'Admin')
Insert into Users values ('Philip', 'Male', 'Normal')
Insert into Users values ('Mary', 'Female', 'Admin')
Insert into Users values ('Valarie', 'Female', 'Admin')
Insert into Users values ('John', 'Male', 'Normal')

Select * From Users;

Create procedure InsertUser
@Name nvarchar(50),
@Gender nvarchar(50),
@UserType nvarchar(20)
as
Begin
     Insert into Users values (@Name, @Gender, @UserType)   
End
Go

Create procedure UpdateUser
@ID int,
@Name nvarchar(50),
@Gender nvarchar(50),
@UserType nvarchar(20)
as
Begin
     Update Employees Set Name = @Name, Gender = @Gender,
     @UserType = @UserType
     where ID = @ID
End
Go


Create procedure DeleteUsers
@ID int
as
Begin
     Delete from Users where ID = @ID
End
Go


Create Procedure spAuthenticateUser
@Name nvarchar(50),
@UserType nvarchar(20)
as
Begin
 Declare @Count int
 
 Select @Count = COUNT(Name) from Users
 where [Name] = @Name and [UserType] = @UserType
 
 if(@Count = 1)
 Begin
  Select 1 as ReturnCode
 End
 Else
 Begin
  Select -1 as ReturnCode
 End
End 

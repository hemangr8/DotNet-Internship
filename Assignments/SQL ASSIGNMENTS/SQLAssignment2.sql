
CREATE DATABASE Assignment2
 ON 
( NAME = N'Assignment2', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Assignment2.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Assignment2_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Assignment2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%);


USE Assignment2
GO

CREATE TABLE TProductMaster
(
ProductId varchar(20) null,
ProductName varchar(20) null,
CostPerItem int null
);

INSERT INTO TProductMaster (ProductID, ProductName, CostPerItem)
VALUES ('P1','Pen', 10);

INSERT INTO TProductMaster (ProductID, ProductName, CostPerItem)
VALUES ('P2','Scale', 15);

INSERT INTO TProductMaster (ProductID, ProductName, CostPerItem)
VALUES ('P3','Note Book', 25);

SELECT * FROM TProductMaster;


CREATE TABLE TUserMaster
(
UserId varchar(20) null,
UserName varchar(20) null
);

INSERT INTO TUserMaster (UserId, UserName)
VALUES ('U1','Alfred Lawrence');

INSERT INTO TUserMaster (UserId, UserName)
VALUES ('U2','William Paul');

INSERT INTO TUserMaster (UserId, UserName)
VALUES ('U3','Edward Filip');


SELECT * FROM TUserMaster;

CREATE TABLE TTransaction
(
UserId varchar(20) null,
ProductId varchar(20) null,
TransactionDate date null,
TransactionType varchar(20) null,
TransactionAmount int null
);


INSERT INTO TTransaction (UserId, ProductId, TransactionDate, TransactionType, TransactionAmount)
VALUES ('U1','P1','20101025','Order',150);

INSERT INTO TTransaction (UserId, ProductId, TransactionDate, TransactionType, TransactionAmount)
VALUES ('U1','P1','20101120','Payment',750);

INSERT INTO TTransaction (UserId, ProductId, TransactionDate, TransactionType, TransactionAmount)
VALUES ('U1','P1','20101120','Order',200);

INSERT INTO TTransaction (UserId, ProductId, TransactionDate, TransactionType, TransactionAmount)
VALUES ('U1','P3','20101125','Order',50);

INSERT INTO TTransaction (UserId, ProductId, TransactionDate, TransactionType, TransactionAmount)
VALUES ('U3','P2','20101126','Order',100);

INSERT INTO TTransaction (UserId, ProductId, TransactionDate, TransactionType, TransactionAmount)
VALUES ('U2','P1','20101215','Order',75);

INSERT INTO TTransaction (UserId, ProductId, TransactionDate, TransactionType, TransactionAmount)
VALUES ('U3','P2','20110115','Payment',250);

SELECT * FROM TTransaction;



SELECT 
UserName,
ProductName,
OrderedQuantity,
ISNULL(AmountPaid,0)
	AS
		AmountPaid,
LastTransationDate,
Balance
FROM
(
(
SELECT 
	UserID,
	UserName
FROM
	TUserMaster
)
AS
	C1Table
INNER JOIN
(
SELECT
	Quantities.UserId,
	Quantities.ProductId,
	OrderedQuantity,
	AmountPaid,
	LastTransationDate,
	Balance
FROM
		(
		(
		(
		(
		SELECT UserId, t.ProductId,
			SUM(TransactionAmount)
			AS 
				OrderedQuantity
		FROM
			TTransaction t
		WHERE
			TransactionType='Order'
		GROUP BY
			t.UserId,
			t.ProductId
		)
        AS 
			Quantities
		LEFT JOIN
		(
		SELECT 
			UserId, 
			ProductId,
			SUM(TransactionAmount) 
			AS 
				AmountPaid
		FROM
			TTransaction t
		WHERE
			TransactionType='Payment'
		GROUP BY
			UserId,
			ProductId			
        ) 
		AS 
			Payments
		ON
			Quantities.UserId = Payments.UserId AND Quantities.ProductId = Payments.ProductId
		LEFT JOIN
		(
		SELECT 
			UserId, 
			ProductId, 
			MAX(TransactionDate) 
			AS
				LastTransationDate
		FROM 
			TTransaction
		GROUP BY 
			UserId, 
			ProductId
		) 
		AS
			Dates
		ON Quantities.UserId = Dates.UserId AND Quantities.ProductId = Dates.ProductId
		INNER JOIN
		(
		SELECT
			OAmount.UserId,
			OAmount.ProductId,
			(OAmount.Amount-ISNULL(Payments.AmountPaid,0))
			AS
				Balance
			FROM
			(
			SELECT 
				UserId, 
				ProductId,
				SUM(TransactionAmount) 
				AS 
					AmountPaid
			FROM
				TTransaction t
			WHERE
				TransactionType='Payment'
			GROUP BY
				UserId,
				ProductId			
			) 
			AS 
				Payments
			RIGHT JOIN
			(
			SELECT
				UserID,
				TTransaction.ProductId,
				SUM(TransactionAmount)*TProductMaster.CostPerItem
				AS
					Amount
			FROM
				TTransaction
			INNER JOIN
				TProductMaster
			ON
				TProductMaster.ProductId=TTransaction.ProductId
			WHERE
				TransactionType='Order'
			GROUP BY
				TTransaction.UserId,
				TTransaction.ProductId,
				TProductMaster.CostPerItem
			)
			AS
				OAmount
			ON Payments.UserId=OAmount.UserID AND Payments.ProductId=OAmount.ProductID 

			GROUP BY
			OAmount.ProductId,
			OAmount.UserId,
			OAmount.Amount,
			Payments.AmountPaid
		)
		AS
			Bal
		ON
			Quantities.UserId=Bal.UserId AND Quantities.ProductId=Bal.ProductId
	)
	)
)
)
AS
	FTable
ON
	C1Table.UserId=FTable.UserId
INNER JOIN
(
SELECT
	ProductId,
	ProductName
FROM
	TProductMaster
)
AS
	C2Table
ON
FTable.ProductId=C2Table.ProductId
)


USE Delwar
Select * from CustomerInfo;

UPDATE CustomerInfo SET Name = 'Asad', Contact = '0177', Address =  'Dhaka', Orders = 'Black', Quantity = 2 WHERE ID = 1;

ALTER TABLE CustomerInfo
ADD ID INT NULL

DROP TABLE CustomerInfo

CREATE TABLE CustomerInfo (
ID INT NULL,
Name VARCHAR (50),
Contact VARCHAR (50),
Address VARCHAR (50),
Orders VARCHAR (50),
Quantity INT
)

DELETE FROM CustomerInfo WHERE ID = 2

SELECT * FROM CustomerInfo WHERE ID =1
CREATE DATABASE WearHouse;
USE WearHouse;

CREATE TABLE UserData (
	UserID VARCHAR(5) PRIMARY KEY,
	Name VARCHAR(255) NOT NULL,
	Email VARCHAR(255) NOT NULL,
	Password VARCHAR(255) NOT NULL,
);

CREATE TABLE Category (
	UserID VARCHAR(5) FOREIGN KEY REFERENCES UserData(UserID),
	CategoryName VARCHAR(255),
	Id INT IDENTITY(1,1) PRIMARY KEY

);

INSERT INTO UserData (Name, Email, Password)
VALUES ('Dummy', 'dummy001@gmail.com', 'p4$$wOrd001');

INSERT INTO Category (UserID, CategoryName)
VALUES ('UU223', 'Shoes'),
('UU223', 'Hats'),
('UU223', 'Clothes'),
('UU223', 'Gloves'),
('UU223', 'Socks');


 EXEC sp_help Category
 EXEC sp_help UserData;

 DELETE FROM UserData 
 WHERE Name = 'Nelvin';

SELECT * FROM UserData;
SELECT * FROM Category;

DELETE FROM Category
WHERE CategoryName = 'skirt';
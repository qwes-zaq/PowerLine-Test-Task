use PowerLinedb

CREATE TABLE Customers(
	Id int NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Name nvarchar(50) NOT NULL
);

CREATE TABLE Orders(
	Id int NOT NULL  PRIMARY KEY IDENTITY(1, 1),
	CustomerId int FOREIGN KEY REFERENCES Customers(Id)
);
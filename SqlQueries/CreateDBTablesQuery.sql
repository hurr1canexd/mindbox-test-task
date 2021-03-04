CREATE DATABASE MindboxDB;
GO

USE MindboxDB;
GO

IF OBJECT_ID('Product') IS NOT NULL DROP TABLE Product;
GO
IF OBJECT_ID('Category') IS NOT NULL DROP TABLE Category;
GO

CREATE TABLE Category(
	CategoryId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CategoryName VARCHAR(30) NOT NULL
);

CREATE TABLE Product(
	ProductId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ProductName VARCHAR(30) NOT NULL,
	CategoryId INT FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
);
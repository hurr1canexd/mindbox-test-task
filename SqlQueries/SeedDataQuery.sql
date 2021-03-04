USE MindboxDB;
GO

INSERT INTO Category (CategoryName) VALUES
('Морепродукты'),
('Овощи'),
('Фрукты')
GO

INSERT INTO Product(ProductName, CategoryId) VALUES
('Креветки', 1),
('Огурцы', 2),
('Бананы', 3),
('Мандарины', 3),
('Кальмары', 1)
GO

INSERT INTO Product(ProductName) VALUES
('Мочалка')
GO
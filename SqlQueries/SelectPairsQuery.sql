-- Выбор всех пар "Имя продукта - Имя категории"
SELECT Product.ProductName, Category.CategoryName 
FROM Product
LEFT JOIN Category ON Product.CategoryId = Category.CategoryId;

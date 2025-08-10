DROP TABLE IF EXISTS Products;
CREATE TABLE Products (
    ProductID INTEGER PRIMARY KEY,
    ProductName TEXT,
    Category TEXT,
    Price REAL
);

INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Product A', 'Electronics', 500.00),
(2, 'Product B', 'Electronics', 300.00),
(3, 'Product C', 'Electronics', 500.00),
(4, 'Product D', 'Furniture', 1000.00),
(5, 'Product E', 'Furniture', 950.00),
(6, 'Product F', 'Furniture', 1000.00),
(7, 'Product G', 'Books', 50.00),
(8, 'Product H', 'Books', 60.00),
(9, 'Product I', 'Books', 55.00),
(10, 'Product J', 'Books', 60.00);

-- Top 3 most expensive products per category using ROW_NUMBER
SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER(PARTITION BY Category ORDER BY Price DESC) AS row_num
    FROM Products
) ranked
WHERE row_num <= 3;

-- Compare RANK and DENSE_RANK
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS rank_num,
    DENSE_RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS dense_rank_num
FROM Products;

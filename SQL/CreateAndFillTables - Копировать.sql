SELECT p.Product_name AS 'Product Name', COALESCE(c.Category_name, 'No category') AS 'Category Name'
FROM Product p
LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
LEFT JOIN Category c ON pc.CategoryId = c.Id;
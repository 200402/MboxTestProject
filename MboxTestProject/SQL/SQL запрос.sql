/****** Script for SelectTopNRows command from SSMS  ******/
SELECT product.Name, category.Name
    FROM product, category, productCategory
    WHERE [productCategory].[IDProduct] = product.id and [productCategory].IDCategory = category.id 
UNION 
SELECT product.Name, null
  FROM product 
	WHERE not exists (
    SELECT product.Name, null
    FROM [productCategory] 
    WHERE [productCategory].[IDProduct] = product.id) 
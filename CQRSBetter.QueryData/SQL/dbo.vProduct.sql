CREATE VIEW dbo.vProduct
	AS 
	SELECT p.ProductId, p.ProductName, pc.ProductCategoryId, pc.ProductCategoryName
	FROM Product p
	INNER JOIN ProductCategory pc ON pc.ProductCategoryId = p.ProductCategoryId

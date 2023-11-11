CREATE PROCEDURE [dbo].[GetExpensiveProducts]
    @price money,
    @count int OUT
AS
SELECT @count = COUNT(*)
FROM Products
WHERE UnitPrice > @price
SELECT *
FROM Products
WHERE UnitPrice > @price
    RETURN 0

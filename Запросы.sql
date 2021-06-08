/* Task 1*/
SELECT Product.ProductId , Product.Name , Product.ProductNumber , Product.Color 
FROM SalesLT.Product

SELECT Customer.CustomerID, Customer.FirstName,Customer.MiddleName,Customer.LastName, Customer.EmailAddress, Customer.Phone
FROM SalesLT.Customer

/* Task 2*/
SELECT*
FROM SalesLT.Product
WHERE Product.Color = 'Black'

SELECT* 
FROM SalesLT.Product
WHERE Product.Color = 'Black' OR Product.Color = 'Grey' OR Product.Color = 'Multi'
SELECT*
FROM SalesLT.Product
WHERE Product.Color = 'Black' OR Product.Color = 'Yellow' 

SELECT*
FROM SalesLT.Product
WHERE Weight IS NULL

SELECT*
FROM SalesLT.Product
WHERE Weight > 1000

SELECT*
FROM SalesLT.Product
WHERE Weight < 6000

SELECT*
FROM SalesLT.Product
WHERE Product.Weight BETWEEN 1000 AND 5000

SELECT*
FROM SalesLT.Product
WHERE Product.ProductNumber LIKE 'B[K,B]'

SELECT*
FROM SalesLT.Product
WHERE Product.SellEndDate IS NULL

/* Task 3*/
SELECT*
FROM SalesLT.Product
ORDER BY Product.Color

SELECT*
FROM SalesLT.Product
ORDER BY Product.Color ASC, Product.Weight DESC;

SELECT*
FROM SalesLT.Product
ORDER BY Product.ProductNumber ASC, Product.Weight DESC;

/* Task 4*/
SELECT TOP 10*
FROM SalesLT.Product

SELECT TOP 10*
FROM SalesLT.Product
ORDER BY Product.Weight


SELECT TOP (10) *
FROM SalesLT.Product
ORDER BY Product.Weight DESC


/* Task 5*/
SELECT Product.ProductID, Product.Name, Product.ProductNumber, Product.Color, Product.Weight, Product.StandardCost
FROM SalesLT.Product

SELECT Customer.CustomerID, Customer.EmailAddress, 
Customer.FirstName, Customer.MiddleName, Customer.LastName, Customer.Phone, Address.City, Address.CountryRegion, Address.PostalCode, Address.AddressLine1
FROM SalesLT.Customer 
JOIN SalesLT.CustomerAddress ON Customer.CustomerID = CustomerAddress.CustomerID
INNER JOIN SalesLT.Address  ON  Address.AddressID = CustomerAddress.AddressID

SELECT Product.ProductID, Product.Name, Product.ProductNumber, ProductCategory.ParentProductCategoryID
FROM SalesLT.Product
JOIN SalesLT.ProductCategory ON Product.ProductCategoryID = ProductCategory.ProductCategoryID

/* Task 6*/
SELECT COUNT(*)
FROM SalesLT.Product

SELECT COUNT(*)
FROM SalesLT.Product
WHERE Product.SellEndDate IS NOT NULL

SELECT COUNT(*)
FROM SalesLT.Product
WHERE Product.Weight IS NULL

SELECT AVG(Product.Weight)
FROM SalesLT.Product
WHERE Product.Weight IS NOT NULL

SELECT AVG(Product.Weight)
FROM SalesLT.Product

SELECT MIN(Product.Weight) AS Minimum, MAX(Product.Weight) AS Maximum
FROM SalesLT.Product

SELECT Product.ProductCategoryID,  ProductCategory.Name, Count(*) AS Products, SUM(Product.Weight) AS Summa,MIN(Product.Weight) AS Minimum, MAX(Product.Weight) AS Maximum
FROM SalesLT.Product
JOIN SalesLT.ProductCategory ON Product.ProductCategoryID = ProductCategory.ProductCategoryID
GROUP BY Product.ProductCategoryID, ProductCategory.Name

SELECT Product.ProductCategoryID,  ProductCategory.Name, Count(*) AS Product, SUM(Product.Weight) AS Summa,MIN(Product.Weight) AS Minimum, MAX(Product.Weight) AS Maximum
FROM SalesLT.Product
JOIN SalesLT.ProductCategory ON Product.ProductCategoryID = ProductCategory.ProductCategoryID
GROUP BY Product.ProductCategoryID, ProductCategory.Name

SELECT Product.ProductCategoryID,  ProductCategory.Name, Count(*) AS Products, SUM(Product.Weight) AS Summa,MIN(Product.Weight) AS Minimum, MAX(Product.Weight) AS Maximum
FROM SalesLT.Product
JOIN SalesLT.ProductCategory ON Product.ProductCategoryID = ProductCategory.ProductCategoryID
WHERE Product.Weight IS NOT NULL 
GROUP BY Product.ProductCategoryID, ProductCategory.Name

SELECT Product.ProductCategoryID,  ProductCategory.Name, Count(*) AS Products, SUM(Product.Weight) AS Summa,MIN(Product.Weight) AS Minimum, MAX(Product.Weight) AS Maximum
FROM SalesLT.Product
JOIN SalesLT.ProductCategory ON Product.ProductCategoryID = ProductCategory.ProductCategoryID
WHERE Product.Weight >10000 
GROUP BY Product.ProductCategoryID, ProductCategory.Name

/* Task 7*/
SELECT ProductCategory.ProductCategoryID, ProductCategory.Name, COUNT(Product.StandardCost) AS Cost
FROM SalesLT.Product 
INNER JOIN SalesLT.ProductCategory ON Product.ProductCategoryID= ProductCategory.ProductCategoryID 
WHERE Product.SellEndDate IS NOT NULL
GROUP BY ProductCategory.ProductCategoryID, ProductCategory.Name

SELECT Customer.CustomerID, Customer.FirstName, Customer.MiddleName, Customer.LastName
FROM SalesLT.Customer
JOIN SalesLT.SalesOrderHeader ON Customer.CustomerID = SalesOrderHeader.CustomerID
JOIN SalesLT.SalesOrderDetail ON SalesOrderHeader.SalesOrderID = SalesOrderDetail.SalesOrderID
WHERE SalesOrderDetail.UnitPriceDiscount >= 0.40

SELECT Customer.CustomerID, Customer.FirstName, Customer.MiddleName, Customer.LastName
FROM SalesLT.Customer
JOIN SalesLT.SalesOrderHeader ON Customer.CustomerID = SalesOrderHeader.CustomerID
JOIN SalesLT.SalesOrderDetail ON SalesOrderHeader.SalesOrderID = SalesOrderDetail.SalesOrderID
JOIN SalesLT.Product ON SalesOrderDetail.ProductID = Product.ProductID
GROUP BY Customer.CustomerID, Customer.FirstName, Customer.MiddleName, Customer.LastName
HAVING SUM(Product.ListPrice) > 15000

/* Задание 1*/
SELECT Product.ProductId , Product.Name , Product.ProductNumber , Product.Color 
FROM SalesLT.Product

SELECT Customer.CustomerID, Customer.FirstName,Customer.MiddleName,Customer.LastName, Customer.EmailAddress, Customer.Phone
FROM SalesLT.Customer

/* Задание 2*/
SELECT*
FROM SalesLT.Product
WHERE Product.Color = 'Black'

SELECT*
FROM SalesLT.Product
WHERE Product.Color = 'Black' OR Product.Color = 'Grey'

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
WHERE Product.ProductNumber LIKE 'BK' OR Product.ProductNumber LIKE 'BB'

SELECT*
FROM SalesLT.Product
WHERE Product.SellEndDate IS NULL

/* Задание 3*/
SELECT*
FROM SalesLT.Product
ORDER BY Product.Color

SELECT*
FROM SalesLT.Product
ORDER BY Product.Color ASC, Product.Weight DESC;

SELECT*
FROM SalesLT.Product
ORDER BY Product.ProductNumber ASC, Product.Weight DESC;

/* Задание 4*/
SELECT TOP 10*
FROM SalesLT.Product

SELECT TOP 10*
FROM SalesLT.Product
ORDER BY Product.Weight

WITH SRC AS (
        SELECT TOP (10) *
        FROM SalesLT.Product
		ORDER BY Product.Weight DESC
   )
SELECT * FROM SRC

/* Задание 5*/
SELECT Product.ProductID, Product.Name, Product.ProductNumber, Product.Color, Product.Weight, Product.StandardCost
FROM SalesLT.Product

SELECT Customer.CustomerID, Customer.EmailAddress, 
Customer.FirstName, Customer.MiddleName, Customer.LastName, Customer.Phone, Address.City, Address.CountryRegion, Address.PostalCode, Address.AddressLine1
FROM SalesLT.Customer 
INNER JOIN `Customer` c ON c.CustomerID = CustomerAddress.CustomerID 
INNER JOIN `Address` a ON a.AdressID = CustomerAddress.AddressID


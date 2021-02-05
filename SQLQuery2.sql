--Select
--ANSII Standardı
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers Where City = 'London'

--case insensitive - Büyük küçük harf duyarsın
Select * from Products where categoryId=1 or CategoryID=3

Select * from Products where categoryId=1 and UnitPrice>=10

--asc > ascending artan sıra. desc > descending
Select * from Products where categoryId=1 order by UnitPrice desc


Select count(*) from Products where categoryID=2


Select categoryId,count(*) from products group by CategoryID


Select categoryId,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

--inner join sadece iki tabloda eşleşenleri getirir
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTO Data Transformation Object

-- solda olup sağda olmayanları da getir
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null




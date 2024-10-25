

-- Opg. 2
select * from Products
order by UnitPrice desc;

-- Opg. 3
select * from Customers
where Country in ('UK', 'Spain');

-- Opg. 4
select * from Products
where UnitsInStock > 100 and
UnitPrice >= 25;

-- Opg. 5
select distinct ShipCountry from Orders;

-- Opg. 6
select * from Orders
where month(OrderDate) = 10 and
year(OrderDate) = 1996;

-- Opg. 7
select * from Orders
where ShipRegion is NULL	and
ShipCountry = 'Germany' 	and
Freight >= 100 				and
EmployeeID = 1 				and
year(OrderDate) = 1996;

-- Opg. 8
select * from Orders
where ShippedDate > RequiredDate;

-- Opg. 9
select * from Orders
where month(OrderDate) between 1 and 4
and year(OrderDate) = 1997
and ShipCountry = 'Canada';

-- Opg. 10
select * from Orders
where EmployeeID in (2, 5, 8)	and
ShipRegion is not NULL			and
ShipVia in (1, 3)
order by EmployeeID, ShipVia asc;

-- Opg. 11
select * from Employees
where Region is NULL and
year(BirthDate) <= 1960;




-----Database-------

create database ProductDatabase;
use ProductDatabase;


-----Product Definition------

 create table Product (
 
	ID int primary key identity(101, 1),
	Name varchar(50),
	CID int foreign key references ProductCategory(CID),
	ExpiryDate datetime,
	Quantity int,
	Price money
	);

insert into Product values

('Steering Wheel', 204, '2/13/2021', 15, 45),
('Hersheys', 203, '1/26/2022', 75, 5),
('Curtains', 201, '12/16/2023', 20, 17 ),
('Spoons', 202, '08/08/2023', 50, 2.99),
('Spoons', 202, '08/08/2023', 50, 2.99),
('Tfal FryPan', 202,'11/21/2025', 10, 29.99);





 drop table Product;
 select * from Product;
 exec sp_help Product;


 
 -----Product Categories Definition------


 create table ProductCategory (

	CID int primary key identity (201, 1),
	CatName varchar(50) unique
	);

insert into ProductCategory values

('Home'),
('Kitchen'),
('Candy'),
('Auto');


drop table ProductCategory;

select * from Product;
select * from ProductCategory;

delete from ProductCategory where CatName like '%foo%';
delete from Product where Name like '%Savanth%';

select ProductCategory.CatName, count(ProductCategory.CatName)  from ProductCategory
inner join Product on ProductCategory.CID = Product.CID 
group by ProductCategory.CatName order by count(ProductCategory.CatName) desc ;
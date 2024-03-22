use Assignment2

create table Books
( id int primary key,
title varchar (50),
author varchar (20),
isbn bigint unique,
published_date date)
drop table Books

insert into Books values (1,'My First SQL Book','Mary Parker',981483029127,'2012-02-22'),
(2,'My Second SQL Book','John Mayer',857300923713,'1972-07-03'),
(3,'My Third SQL Book','Cary Flint',523120967812,'2015-10-18')

--Write a query to fetch the details of the books written by author whose name ends with er

select * from Books where author like '%er'

create table reviews(
id int identity,
book_id int,
reviwer_name varchar(30),
content varchar (20),
rating int ,
published_date date)
drop table reviews
insert into reviews values (1,'John Smith','My first review',4,'2017-12-10'),
(2,'John Smith','My second review',5,'2017-10-13'),
(2,'Alice Walker','Another Review',1,'2017-10-22')

select * from reviews
select * from books
--Display the Title ,Author and ReviewerName for all the books from the above table
select title,author,reviwer_name from books b, reviews r  where b.id=r.id

--Display the reviewer name who reviewed more than one book.

select reviwer_name from reviews group by reviwer_name having count(reviwer_name)>1   


create table customer(
id int identity,
name varchar (20),
age int,
address varchar(20),
salary float)

insert into customer values ('Ramesh',32,'Ahmedabad',2000),
('Khilan',25,'Delhi',1500),('Kaushik',23,'Kota',2000),('Chaitali',25,'Mumbai',6500),('Hardik',27,'Bhopal',8500),
('Komal',22,'MP',4500),('Muffy',24,'Indore',10000)

select * from customer
--Display the Name for the customer from above customer table who live in same address which has character o anywhere in address
select name from customer where address like '%o%'

create table orders(
OID int,
date date,
customer_id int,
amount int)

insert into orders values (102,'2009-10-08',3,3000),(100,'2009-10-08',3,1500),(101,'2009-11-20',2,1560),
(103,'2008-05-20',4,2060)
select * from orders
select * from customer

--Write a query to display the Date,Total no of customer placed order on same Date
select date,count(OID) as Total_no_of_customer_placed from orders group by date


create table employee(
id int identity,
name varchar (20),
age int,
address varchar(20),
salary int)
drop table employee
insert into employee values ('Ramesh',32,'Ahmedabad',2000),
('Khilan',25,'Delhi',1500),('Kaushik',23,'Kota',2000),('Chaitali',25,'Mumbai',6500),('Hardik',27,'Bhopal',8500),
('Komal',22,'MP',null),('Muffy',24,'Indore',null)


select * from employee
--display names of employees in lowercase whose salary is null
select LOWER(name) as LOWER_CASE from employee where salary is null

create table Students_details(
RegisterNo int,
name varchar(20),
Age int,
Qualification varchar (10),
MobileNo bigint,
mail_id varchar(20),
Location varchar (20),
Gender char)
drop table Students_details
select * from Students_details
INSERT INTO Students_details
Values (1, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
       (2, 'Kumar', 20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
       (3, 'Selvi', 22, 'B.TECH', 8904567342, 'selvi@gmail.com', 'Salem', 'F'),
       (4, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
       (5, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
       (6, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M')

--Write a sql server query to display the Gender,Total no of male and female from the above relation .
select gender, count(*) AS TotalCount
from students_details
group by gender;
 
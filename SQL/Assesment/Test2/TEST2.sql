--1.	Write a query to display your birthday( day of week)
SELECT DATENAME(WEEKDAY, '2000-07-27') AS DayOfWeek;

--2. Write a query to display your age in days

select datediff(day, '2000-07-27', getdate()) AS AgeInDays;

--3.	Write a query to display all employees information those who joined before 5 years in the current month
 --(Hint : If required update some HireDates in your EMP table of the assignment)
 use Assignment2
 select * from EMP

select * from EMP where datediff(yy,hiredate,getdate()) >5


--4.	Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
--	a. First insert 3 rows 
--	b. Update the second row sal with 15% increment  
--        c. Delete first row.
--After completing above all actions how to recall the deleted row without losing increment of second row.
select * from tblemployee

-- creatign emp table
begin transaction
create table tblEmployee(
empno int,
ename varchar(10),
sal int,
doj date)
drop table tblEmployee
-- 4(a)-> inserting values

insert into tblEmployee values(1,'Avinash',100,'2000-01-12'),(2,'Arjun',200,'2000-01-19'),(3,'Avi',300,'2000-01-8')
-- 4(b) -> Update the second row sal with 15% increment  

update tblEmployee set sal=sal*1.15 where empno=2
save tran t1
--4(c) Delete first row.

--delete from tblEmployee where empno=1
rollback tran t1
select * from tblEmployee where empno=1
commit


----After completing above all actions how to recall the deleted row without losing increment of second row.
-- we can rollback save tran t1 without 


----After completing above all actions how to recall the deleted row without losing increment of second row.
--In this we have also create temporary table to store the deleted row...

create table #DeletedRow (
empno int,
ename varchar(10),
sal int,
doj date
)
-- Move deleted row -> temporary table
insert into #DeletedRow
select empno, ename, sal, doj
from tblEmployee
where empno = 1
-- delete the original row
delete from tblEmployee where empno=1
select * from tblEmployee
-- calling the delete row from temp table
select * from #DeletedRow

-----------------------------------------------------------------------------------------------------------------------------

--5.      Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
--	a.     For Deptno 10 employees 15% of sal as bonus.
--	b.     For Deptno 20 employees  20% of sal as bonus
--	c      For Others employees 5%of sal as bonus
select * from EMP
-- creating function -> CalculateBonus..
--create or alter function CalculateBonus(@deptno int,@sal int)
--returns int
--as 
--begin
--	declare @bonus int 
--	--declare @salary int
--	if @deptno = 10
--		--declare @salary int = (select sal from EMP where deptno=10)
--        set @bonus = @sal * 0.15
--    else if @deptno = 20
--        set @bonus = @sal * 0.20
--    else
--        set @bonus = @sal * 0.05

--    return @bonus
--end
---- calling the function
--declare @Sal int = 850
--declare @Deptno INT = 20

--select @Sal AS salary,@Deptno AS DepartmentNO, dbo.CalculateBonus(@Deptno, @Sal) as Bonus

-------------------------------

create or alter function CalculateBonus1(@deptno int,@sal int)
returns int
as 
begin
	declare @bonus int 
	declare @salary int
	if @deptno = 10
		begin
		set @salary = (select sal from EMP where deptno=10)
        set @bonus = @salary * 0.15
		end
    else if @deptno = 20
		begin
		set @salary  = (select sal from EMP where deptno=20)
        set @bonus = @salary * 0.20
		end
    else
		begin
		set @salary = (select sal from EMP)
        set @bonus = @salary * 0.05
		end

    return @bonus
end

select * from EMP
-- calling the above function
--select  dbo.CalculateBonus(10) as Bonus
select @Sal AS salary,@Deptno AS DepartmentNO, dbo.CalculateBonus(@Deptno) as Bonus








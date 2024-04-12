create database Employeemanagement
use Employeemanagement

create table Employee_Details (
Empno int primary key,
EmpName varchar(50) NOT NULL,
Empsal numeric(10,2) CHECK (Empsal >= 25000),
Emptype char(1) CHECK (Emptype in ('P', 'C'))
)

select * from Employee_Details
-- creating Stored procedure...

create or alter proc Insert_Emp_Details 
@ename varchar(50), 
@esal numeric(10,2),
@etype char(1)
as

BEGIN
-- generating empno...
declare @eno int =0;
select @eno = (count(Empno)) + 1 from Employee_Details
--inserting emp details...
insert into Employee_Details (Empno,EmpName,Empsal,Emptype) values(@eno,@ename,@esal,@etype)
end

--executing through procedure......
Insert_Emp_Details 'Avi', 25000, 'P'
Insert_Emp_Details 'John', 50000, 'C'

select * from  Employee_Details

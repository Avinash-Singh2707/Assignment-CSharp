--Ques 1= Write a T-SQL Program to find the factorial of a given number.

declare @num int = 5
declare @fac int =1
declare @temp int = @num   -- store num in temporary variable
while(@num>1)
 begin
  set @fac=@fac*@num
  set @num=@num-1
 end
print 'The factorial of ' + cast(@temp as varchar(10)) + ': ' + cast(@fac as varchar(10))


--Ques 2 = Create a stored procedure to generate multiplication tables up to a given number.
--declare @n int

create or alter proc table_print (@multiplicant int)
as
begin
declare @count int =1
declare @multiplier int=1
while(@multiplicant>=@count)       --checking the condition to print table from given number to one    
   begin
	while(@multiplier<=10)
       begin
	    print cast(@multiplicant as varchar(10))  + '*' + cast(@multiplier as varchar(10)) + '=' + cast(@multiplicant*@multiplier as varchar(10))
	    set @multiplier=@multiplier+1    -- increment the multiplier
       end
	set @multiplier=1         -- setting the multiplier to one for next table
	set @multiplicant=@multiplicant-1         -- decrenment multiplicant for next table
	end
end
-- execute the above procedure...
exec table_print 5

--Ques 3.Create a trigger to restrict data manipulation on EMP table during General holidays. 
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc

--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. 
--try to match and stop manipulation 

create table holiday
(
holiday_date date,
Holiday_name varchar (20)
)
drop table holiday
select * from EMP
insert into holiday values('2024-03-25','HOLI'),('2024-08-15','Independence Day'),('2024-10-31','Diwali'),
('2024-12-25','Christmas Day')
select * from holiday

create table emptb(
empname varchar(10),
job varchar(10),
_date date)
insert into emptb values('Avi','Founder','2024-11-01'),('Nityanshu','Co-Founder','2024-03-25'),('Shantanu','CEO','2025-10-01')
select * from emptb

--now lets us create trigger

drop trigger triInsertEmp1

create or alter trigger triInsertEmp1
on emptb
instead of insert,update,delete
as
begin
declare @holiday_count int
declare @holiday_name varchar(100)
select @holiday_count= count(* )from holiday where holiday_date = convert(date,getdate())
--select @holiday_count= count(* )from holiday where holiday_date = convert(date,'2024-03-26')  
if @holiday_count>0 
  begin
     --select @holiday_name=holiday_name from holiday where holiday_date=convert(date,'2024-03-26')    -- here we hardcode value
     select @holiday_name=holiday_name from holiday where holiday_date=convert(date,GETDATE())
	raiserror ('Due to %s, you cannot manipulate date',16,-1,@holiday_name)   -- here we raise error
	--raiserror (50001,16,-1,'Due to %s, you cannot manipulate date',@holiday_name)  
  end
end
select * from emptb
insert into emptb values('Satyam','Manager','2024-03-25')      -- here we are checking if we able to manipulate data.
delete from emptb where empname='Avi'
update emptb set empname='Ram' where job ='founder'


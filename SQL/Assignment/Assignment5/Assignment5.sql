use Assignment2
select * from EMP

create or alter procedure Payslip @EID INT
as
begin
declare @Salary int
declare @HRA int
declare @DA int
declare @PF int
declare @IT int
declare @Deductions int
declare @GrossSalary int
declare @NetSalary int
 
 -- Fetch Salary
select @Salary = sal
from EMP
where empno = @EID
 
set @HRA = @Salary * 0.10
set @DA = @Salary * 0.20
set @PF = @Salary * 0.08
set @IT = @Salary * 0.05
set @Deductions = @PF + @IT
set @GrossSalary = @Salary + @HRA + @DA
set @NetSalary = @GrossSalary - @Deductions
--
select
empno,
@Salary AS Salary,
@HRA AS HRA,
@DA AS DA,
@PF AS PF,
@IT AS IT,
@Deductions AS Deductions,
@GrossSalary AS GrossSalary,
@NetSalary AS NetSalary
from EMP
Where empno = @EID
---priting the message as PAY SLIP-----
print '-----PAY SLIP OF EMPLOYEE-----'
print 'The Salary is: ' + cast(@salary as varchar(10))
print 'HRA: ' + cast(@HRA as varchar(10))
print 'DA: ' + cast(@DA as varchar(10))
print 'PF: ' + cast(@PF as varchar(10))
print 'IT: ' + cast(@IT as varchar(10))
print 'DEDUCTION: ' + cast(@DEDUCTIONS as varchar(10))
print 'GROSS SALARY: ' + cast(@GROSSSALARY as varchar(10))
print 'NET SALARY: ' + cast(@NETSALARY as varchar(10))
end

select * from EMP
-- executing procedure
payslip 7369
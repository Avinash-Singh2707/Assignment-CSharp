use Assignment2

select * from DEPT
select * from EMP

--1. Retrieve a list of MANAGERS.
select ename,job from EMP where job='Manager'

--2. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename,sal from emp where sal>1000

--3. Display the names and salaries of all employees except JAMES. 
select ename,sal from emp where ename!='JAMES'

--4. Find out the details of employees whose names begin with ‘S’. 
select * from EMP where ename like 'S%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name.\
select * from EMP where ename like '%A%'

--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select * from EMP where ename like '__L%'

--7. Compute daily salary of JONES.
select *, (sal/30) as 'DAILY SALARY' from EMP where empno=7566

--8. Calculate the total monthly salary of all employees. 
select sum(sal) as 'TOTAL SALARY' from EMP

--9. Print the average annual salary .
begin
declare @res int 
select @res = avg(sal*12) from EMP
print 'Average Annual Salary of All Employee: ' + cast(@res as varchar(10))
end

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename,job,sal,deptno from emp where job!='SALESMAN' and deptno!=30

--11. List unique departments of the EMP table. -> 
select DISTINCT deptno from emp

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
select ename as EMPLOYEE,sal as SALARY, deptno from EMP where sal>1500 and deptno in(10,30)

--13. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename,job,sal from EMP where job in ('MANAGER','ANALYST') and sal not in(1000,3000,5000)

--14. Display the name, salary and commission for all employees whose commission amount is greater than their 
--salary increased by 10%.
select ename,sal 'old salary',[comm.], (sal*1.1) as 'NEW SALARY' from EMP where sal<[comm.]

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ename from EMP where ename like '%L%L%' and deptno=30 or [mgr-id] like 7782 

--16. Display the names of employees with experience of over 30 years and under 40 yrs.
--Count the total number of employees.

select coalesce (ename,'Total Employee'),count(*) as Total_Employee  from emp where datediff(yy,hiredate,getdate()) between 30 and 40 group by rollup(ename) 

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select d.dname as Department,e.ename from dept d join emp e on d.deptno=e.deptno order by d.dname, e.ename desc

-- 18. Find out experience of MILLER. 
begin
declare @exp date
select @exp = hiredate from emp where ename='MILLER'
select DATEDIFF(yy,@exp,getdate()) as Experience
end


select * from DEPT
select * from EMP
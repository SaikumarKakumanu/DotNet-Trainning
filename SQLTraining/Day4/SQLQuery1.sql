--string Functions
select lower('HELLO WORLD')
select upper('hello  world')
select replace('jack and jil','j','bl')
select substring('This is SQL Query Command',9,9)
select ASCII('a')
select CONCAT('Happy ', ' Birthday ' ,'To',' you', ' 17')

/* Datatypes
char(6)
varchar(20)
nvarchar(30)
nvarchar(max)
date 
money
time 
ntext*/

--stored procedures
create procedure sp_sample
as
begin
select 'Hello and welcome to store proc'
end

execute sp_sample

create or alter proc sp_deptdetails
as
begin
select * from tblDepartment
update tblEmployee set gender='Male' where Empid=114
delete from tblEmployee where EmpName='AA'
select * from tblEmployee
end

execute sp_deptdetails


--procedures with parameters
--1. 
create or alter proc sp_procwith_param(@name varchar(25))
as
begin
  select concat('Hello ', @name)
end
 
exec sp_procwith_param 'SaiKumar'
 
--2.
 create or alter proc sp_findEmployee(@eid int)
 as
 begin
  select * from tblEmployee where Empid=@eid
  end
 

  exec sp_findEmployee 112

  create or alter proc sp_displayemployees(@did int)
  as
  begin
  select * from tblEmployee where did=@did
  select tblEmployee.*,tblDepartment.DeptId from tblEmployee join tblDepartment on tblemployee.did=tblDepartment.DeptId
  where tblDepartment.DeptId=@did
  end

  exec sp_displayemployees 2

  --4. procedure with more than 1 parameter
  create or alter proc sp_updatesalary(@increment int, @empid int)
  as
  begin
  declare @newsalary float
  set @newsalary = (select salary from tblEmployee where Empid = @empid)
  if(@newsalary<=6000)
  begin
    set @newsalary=@newsalary+@increment
	print @newsalary
  end
  else
  begin
    print 'salary is greater than 6000'
  end
  end

  execute sp_updatesalary @increment=1000,@empid =102

  --Hands on eg print the emp salary and update the salary from output
  create or alter proc sp_salaryadding(@empid int, @sal float output)
  as
  begin
   declare @salary float
   declare @upsal float
   set @salary=(select tblEmployee.Salary from tblEmployee where Empid = @empid)
   set @sal=@salary
   print 'salary'+' '+cast(@sal as varchar(10))

   update tblEmployee 
   set @upsal = @sal+100 where empid = @empid
   print 'update salary'+' '+cast(@upsal as varchar(10))
  end

begin
  declare @temp float
  execute sp_salaryadding 100,@temp output
end

  select * from tblEmployee

  --procedure with return parameter
  create or alter proc sp_getdept(@ename varchar(20))
  as
  begin
  return(select salary from tblEmployee where EmpName=@ename)
  end

 --to execute the above
 declare @deptid char(7)
 exec @deptid =sp_getdept 'SaiKumar'
 select @deptid as 'salary'

  --procedures with both input and output parameters
  create or alter proc sp_TaxCalculator
 (@id int, @annualsalary float output, @ename varchar(30) output)
 as
 begin
 declare @temp float
 set @ename=(select empname from tblEmployee where Empid=@id)
 select @temp =(salary*12) from tblEmployee where empid=@id
  if(@temp>75000)
    begin
	  set @annualsalary=@temp
    end
  else
    print 'No tax payment'
 end

 begin
  declare @TotalTax float
  declare @name varchar(30)
  exec sp_TaxCalculator 104,@TotalTax output,@name output
  set @TotalTax=((@TotalTax)*10/100)
  print @TotalTax
  print @name

  select concat(@name,'  has to pay tax amount of ',@TotalTax)
  print 'TaxAmount to be paid is '+''+cast(@TotalTax as varchar(10))
 end

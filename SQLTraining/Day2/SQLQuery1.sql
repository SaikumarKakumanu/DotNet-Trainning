select * from tblEmployee
--few columns
select EmpId,EmpName,salary from tblEmployee
--restricting the number of rows display
select * from tblEmployee where did=1
select Empid,empname,salary,gender from tblemployee where gender='FeMale'
select * from tblEmployee where Salary>=6000
select * from tblEmployee where salary>=5000 and salary<=6000

--between opertaor

select * from tblEmployee where salary between 5000 and 6000
select * from tblEmployee where salary not between 5000 and 6000

--null opertaor

select * from tblEmployee where EmpName is null
select * from tblEmployee where EmpName is not null

-- in operator choose from multiple values
select * from tblEmployee where did in(1,2,3)
select * from tblEmployee where did not in(1,2,3) 

--top to select few topmost records
select top 3 * from tblEmployee
select top 10 percent Empname,Salary from tblemployee

--arithmetic operators in select
select Empname,Salary+500 from tblEmployee
select Empname,Salary*12 from tblEmployee

--functions
select count(*) from tblEmployee

--inserting values into tblemployee table
insert into tblEmployee
values(111,'Vajreshwari','FeMale',6200,'vajreshwari@gmail.com',4,'6578493421'),
(112,'','',6400,'someperson@gmail.com',3,'2345678912'),
(113,'','Male',5900,'kishore@gmail.com',4,'8765432198')

--update the columns

update tblEmployee set did =4 where empid = 108
update tblEmployee set EmpName='Krishna' where empid=112
update tblEmployee set empname='Kishore' where empid=113
update tblEmployee set gender ='Male' where empid=112


select * from tblEmployee
select * from tblDepartment

--group by clause
--display the count of male and female employees
--display department wise highest salary
 select did, max(salary) from tblemployee
 group by did

 --list the names of employees along with their department names
select Deptname,max(salary) from tblEmployee,tblDepartment
where tblEmployee.DId=tblDepartment.DeptId
group by DeptName

select gender, count(gender) from tblEmployee
where did =2
group by gender 

select did, min(salary) 'Lowest Salary' from tblemployee
group by did
having min(salary)<=5000

insert into tblEmployee
values(114,'AA',Null,5500,'aa@gmail.com',null,'9987456388')
insert into tblDepartment
values(5,'Admin','Chennai')

--Joins
--1. Equi Join/Natural/inner join
--2. Cross Join (cartesan product)
--3. outer join
    --1.left outer
    --2.right outer
    --3.full outer
--4. self join
--1.
select * from tblEmployee join tblDepartment on tblEmployee.did = tblDepartment.DeptId

--2.
select tblemployee.EmpName,tblEmployee.Salary,tblDepartment.DeptName from
tblEmployee join tblDepartment on tblEmployee.DId=tblDepartment.DeptId

--3.
select t1.EmpName,t1.salary,t2.DeptName from tblEmployee t1 join tblDepartment t2
on t1.did = t2.DeptId

select * from tblEmployee t1 join tblDepartment t2
on t1.DId=t2.DeptId

--left outer join
select * from tblEmployee t1 left outer join tblDepartment t2
on t1.DId=t2.DeptId
 
select * from tblEmployee t1 right outer join tblDepartment t2
on t1.DId=t2.DeptId
 
select * from tblEmployee t1 full  join tblDepartment t2
on t1.DId=t2.DeptId

create database ZensarDB
--creating tables in the database
create table tblDepartment
(
  DeptId int primary key,
  DeptName varchar(20)not null,
  Loc_City varchar(15)
)

insert into tblDepartment
values(1,'HR','Hyd'),(2,'Finacial','Chennai'),(3,'IT','Bangalore')

create table tblEmployee(Empid int primary key,
EmpName varchar(30),
Gender char(7),
Salary float,
Email varchar(30) unique,
DId int foreign key references tblDepartment(DeptId), -- relatating fk with pk
Phoneno varchar(15) unique
)

insert into tblEmployee
values(108,'Sharif','Male',5900,'sharif@gmail.com',2,'1034206089'),
(109,'Saikumar','Male',6500,'saikumar@gmail.com',2,'9304503689'),
(110,'Saikrishna','Male',5600,'krishna.gmail.com',3,'1020398500')

--query select statement
select * from tblEmployee
select * from tblDepartment

--insert rows/record/tuples into a table
insert into tblDepartment(DeptId,DeptName)
values(4,'Trainee')

--to add a default constraint after table creation
alter table tblDepartment
add constraint def_location default 'Chennai' for Loc_City

--update command
update tblDepartment set Loc_City='Hyd' where Loc_City is null


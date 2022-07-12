select * from emp
--all employes one repoting them mgr
select empno,ename,job from emp t1
 where  exists(select 'x'
 from emp where mgrid=t1.empno)

 --these  exists can be replaced with in keyword

 select empno,ename,job from emp t1
 where empno in (select mgrid
 from emp where mgrid is not null)

 --find all departments that do not have employees
select deptno, deptname from dept where not exists(select 'x' from emp where emp.deptno = dept.DeptNo )

select deptno, deptname from dept where deptno not in(select deptno from emp)
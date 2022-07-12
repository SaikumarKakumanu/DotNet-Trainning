 create table Product
  (
  ProductId int Primary key,
  ProductName varchar(50),
  Price int,
  QtyAvailable int)

 insert into Product values('105','Hard drive',200,100),
  (102,'Desktop',5000,40),
  (103,'Tablet',11000,35),
  (104,'Mobile',10000,50)

  select * from Product

  create or alter proc product_insert
  as
  begin
  begin try
   update Product set Productname='Charger' where productid=105
   select * from product
    insert into Product values('106','Pendrive',250,100)
  end try
  begin catch
   print 'Primary key is either duplicated or datatype mismatch'
   end catch
   end

 exec product_insert

 --select max(prodsalesid) from productsales

create table ProductSales
(ProdSalesId int primary key,
productid int,
qtysold int)

select * from ProductSales

create or alter proc sp_Sales(@productid int,@quantitytosell int)
as
begin
 --first we need to check the stock available for the product we want to sell
   declare @stockavilable int
   select @stockavilable=qtyavailable from Product where ProductId = @productid
    --we need to throw an error to the caller application
    --if the stock is less than the qty we want to sell
    --we will raise an error using 3 parameters
    --Raiserror('Error Message',ErrorSeverity',Errorstate')
   if(@stockavilable<@quantitytosell)
    begin
	  Raiserror('Not enough stock available',16,1)
    end
   else
    begin
	 --we need to strat a transaction to control the statements inside else
	 begin transaction 
	   --1. we need to reduce the quantity available in product table
	   update product set
	   QtyAvailable = (QtyAvailable-@quantitytosell)
	   where ProductId=@productid
	   --2. insert a sales record into product sales table, for which we need to give
	   --unique values for the productsales id column(pk)
		 --calculate the max of productsalesid
		 declare @maxproductsales int
		 select @maxproductsales = case
		 when max(prodsalesid) is null then 0
		 else max(prodsalesid)
		 end
		 from ProductSales
		 --increment @maxproductsales by 1, so that we will not have primary key violation
		 set @maxproductsales=@maxproductsales+1
		 -- we need to insert one record in the productsales table
		 insert into ProductSales
		 values(@maxproductsales,@productid,@quantitytosell)
		 --using a globalvariable called @@error, we can find out if our insert was successful or not
		-- if(@@ROWCOUNT<=0)
		 if(@@ERROR <> 0)
		 begin
		   Rollback transaction
		   print 'OOPS!! some error--Rolled back Transaction'
          end
		  else
		   begin
		    commit transaction
			print 'Successful transaction'
		     select * from Product
		     select * from productsales
           end
        end
     end

	 exec sp_Sales 105,20

     select * from sys.messages

	exec sp_addmessage 60000,13,'It is an Errormessage'


-- Functions
--1. add 2 nos
create function addTwoNos(@num1 int, @num2 int)
returns int
as
begin
 return @num1 + @num2
 end

  --to execute the above function, we need to give a 2 part qualification
  select zensarDB.dbo.addTwoNos(10,20) --or
 select dbo.addTwoNos(10,20) -- or
  declare @result int
 set @result=(select dbo.addTwoNos(15,20))
 set @result=(@result+10)
 print @result

 --write a function to find the area of rectangle, given length and breadth
create or alter function AreaofRec(@length int, @breadth int)
returns int 
as
begin
  return @length*@breadth
end
 
select dbo.AreaofRec(10,20)

create or alter function joincolumns
(@ename nvarchar(30),
 @phone nvarchar(20),
 @sal float)
 returns nvarchar(100)
 as
 begin
  --return(select @ename+'  '+@phone+'  '+cast(@sal as varchar(20)))
  return(select concat(@ename,'  ',@phone,'  ',@sal))
 end

 select Empid as EmployeeNumber,dbo.Joincolumns(Empname,Phoneno,Salary) as 'Employee Details' 
from tblEmployee

--to call a function from a procedure

create or alter proc proc_tocall_function
(@eid int)
as
begin
  print 'going to call procedure'
  declare @result nvarchar(100)
  set @result = (select dbo.joincolumns(empname,phoneno,salary) from tblEmployee where empid =@eid)
  select @result
end

exec proc_tocall_function 105

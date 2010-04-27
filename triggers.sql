Use kafeesa
go
Create trigger trg_InsteadofDeleteEmployees
on Employees
Instead of delete
as  
Begin
	Update Employees
	Set Active_Status = 'No'
	from deleted join
	Employees e on e.Employee_ID = deleted.Employee_ID
End

go


Use kafeesa
go
Create trigger trg_Update_stock_Quantity
on Sales_Details
for insert
as  
declare @Quantity smallint
declare @Product_ID int

select @Quantity = Quantity from inserted 

select @Product_ID = Product_ID from inserted

	if exists(select inserted.Quantity from Inserted
			join Stock s
			on inserted.Product_ID = s.Product_ID
			where Product_ID = @Product_ID) 
begin 
		update Stock set Quantity = Quantity - (select Quantity from inserted)
		where Product_ID = @Product_ID
		
		print 'Quantity updated'
end

--OR

Use kafeesa
go
Create trigger trg_Update_stock_Quantity
on Sales_Details
for insert
as

declare @Product_ID int

select @Product_ID = inserted.Product_ID from inserted

begin 
		Update Stock 
		set Quantity = Quantity - (select Quantity from inserted)
		where Product_ID = @Product_ID
		
		print 'Quantity updated'
end
go

select * from Company

go

update Stock
set
Markup = '34'
where Product_name = 'para'
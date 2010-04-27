/*
************************************************
This script creates the tables for Kafeesa 
Pharma Database.
By Peter Mensah and Owusua Frimpong
Catholic University College Of Ghana, Fiapre.
************************************************

select * from suppliers
select * from stock

*/

Use KAFEESA
GO
Create table CompanyInfo
(
	Company_name nvarchar(50) not null,
	Company_address nvarchar(60) null,
	City nvarchar(20) null,
	Phone nvarchar(13) null, --Constraint chk_Company_land_phone1 Check (Company_land_phone1 like('([0-9][0-9][0-9])[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Fax nvarchar(13) null,
	Email nvarchar(30) null,
	Web nvarchar(30) null,
	Tax_rate int not null,
	Nhil_rate int not null,
	Logo nvarchar(500) null,
	Vat_Registration_No nvarchar(30) null,
	Modified_date datetime2 not null Constraint def_Modified_date14 Default Getdate(),
	Constraint pk_Company_name Primary Key Clustered (Company_name)
)



Use KAFEESA
GO
Create table Payment_Methods
(
	Payment_method_ID tinyint IDENTITY (1, 1) not null,
	Payment_name nvarchar(50) not null,
	Constraint pk_Payment_method_ID Primary Key Clustered (Payment_method_ID),
)


Use KAFEESA
GO
Create table Category
(
	Category_ID tinyint IDENTITY (1, 1) not null,
	Category_name nvarchar(50) not null,
	Returnable nvarchar(5) not null constraint def_Returnble default 'False',
	Constraint pk_Category_ID Primary Key Clustered (Category_ID),
)

Use KAFEESA
GO
Create table Suppliers
(
	Supplier_ID nvarchar(10) not null,
	Supplier_name nvarchar(50) not null,
	Contact_person nvarchar(100) null,
	Supplier_address nvarchar(50) null,
	Supplier_land_phone1 nvarchar(13) null, --Constraint chk_Supplier_land_phone1 Check (Supplier_land_phone1 like('([0-9][0-9][0-9])[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Supplier_land_phone2 nvarchar(13) null, --Constraint chk_Supplier_land_phone2 Check (Supplier_land_phone2 like('([0-9][0-9][0-9])[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Supplier_mobile_phone nvarchar(13) null, --Constraint chk_Supplier_mobile_phone Check (Supplier_mobile_phone like('([0-9][0-9][0-9])([0])[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Supplier_email nvarchar(30) null,
	Modified_date datetime2 not null Constraint def_Modified_date Default Getdate(),
	Constraint pk_Supplier_ID Primary Key Clustered (Supplier_ID),
)

--Use KAFEESA
--GO
--Create table Users
--(
--	UserID smallint not null Constraint fk_UserID Foreign Key References Employees (UserID),
--	Username nvarchar(50) not null,
--	Pass nvarchar(30) not null,
--	Employee_position nvarchar(50) not null,
--	Active_Status int null,
--	Modified_date datetime2 not null Constraint def_Modified_date1 Default Getdate(),
--	Constraint pk_Username Primary Key Clustered (UserID),
--)

Use KAFEESA
GO
Create table Employees
(
	Employee_ID nvarchar(10) not null,
	Title nvarchar(5) null,
	First_name nvarchar(50) not null,
	Last_name nvarchar(50) not null,
	Employee_address nvarchar(50) null,
	Employee_position nvarchar(50) null,
	Photo varchar(max) null,
	Employee_phone nvarchar(13) null, --Constraint chk_Employee_phone Check (Employee_phone like('([0-9][0-9][0-9])([0])[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Employee_email nvarchar(30) null,
	DateOfBirth datetime2 null,
	StartDate date null,
	EndDate date null,
	Username nvarchar(50) not null,
	Pass nvarchar(30) not null,
	Active_Status nvarchar(3) null,
	Modified_date datetime2 not null Constraint def_Modified_date2 Default Getdate(),
	constraint pk_Employee_ID Primary Key Clustered (Employee_ID),
)


Use KAFEESA
GO
Create table Logins
(
	Login_ID int IDENTITY (1, 1) not null,
	Employee_ID nvarchar(10) not null Constraint fk_Employee_ID Foreign Key References Employees (Employee_ID),
	Login_time datetime2 null constraint def_Login_time default (getdate()),
	Logout_time datetime2 null constraint def_Logout_time default (getdate()),
	constraint pk_Login_ID Primary Key Clustered (Login_ID),
)


Use KAFEESA
GO
Create table Company
(
	Company_ID nvarchar(10) not null,
	Company_name nvarchar(50) not null,
	Contact_person nvarchar(20) null,
	Company_address nvarchar(max) null,
	Company_land_phone1 nvarchar(13) null, --Constraint chk_Company_land_phone1 Check (Company_land_phone1 like('([0-9][0-9][0-9])[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Company_land_phone2 nvarchar(13) null, --Constraint chk_Company_land_phone2 Check (Company_land_phone2 like('([0-9][0-9][0-9])[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Company_mobile_phone nvarchar(13) null, --Constraint chk_Company_mobile_phone Check (Company_mobile_phone like('([0-9][0-9][0-9])([0])[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Company_email nvarchar(30) null,
	Company_debit Money null,
	Modified_date datetime2 not null Constraint def_Modified_date3 Default Getdate(),
	Constraint pk_Company_ID Primary Key Clustered (Company_ID),
)



Use KAFEESA
GO
Create table Customers
(
	Customer_ID nvarchar(25) not null,
	Title nvarchar(5) null,
	First_name nvarchar(50) not null,
	Last_name nvarchar(50) not null,
	Company_ID nvarchar(10) not null Constraint fk_Company_ID Foreign Key References Company (Company_ID),
	Customer_address nvarchar(50) null,
	Photo nvarchar(max) null,
	Customer_phone nvarchar(15) null, --Constraint chk_Company_employee_phone Check (Customer_phone like('([0-9][0-9][0-9])([0])[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	Customer_email nvarchar(30) null,
	Modified_date datetime2 not null Constraint def_Modified_date4 Default Getdate(),
	constraint pk_Company_employee_ID Primary Key Clustered (Customer_ID),
)



Use KAFEESA
GO
Create table Stock
(
	Product_ID int IDENTITY (100, 1) NOT NULL, --Constraint uni_Product_ID Unique (Product_ID),
	Supplier_ID nvarchar(10) not null Constraint fk_Supplier_ID Foreign Key References Suppliers (Supplier_ID),
	Product_name nvarchar(50) not null Constraint UQ_Product_name Unique (Product_name),
	Product_description nvarchar(max) null,
	Reorder_point int null,
	Quantity smallint not null,
	Cost_price Money null,
	Markup Money null,
	Unit_price Money null,
	Total_Amount Money null,
	Produce_date datetime null,
	Expiration_date datetime null,
	In_Stock nvarchar(3) null,
	Category_ID tinyint null Constraint fk_Category_ID Foreign Key References Category (Category_ID),
	Modified_date datetime2 not null Constraint def_Modified_date5 Default Getdate(),
	constraint pk_ProductID Primary Key Clustered (Product_ID),
)

Alter table Stock
Add constraint StockMinQuantityValue Check (Quantity > 0)



Use KAFEESA
GO
Create table Sales
(
	Sale_ID int IDENTITY (1,1) not null,
	Customer_ID nvarchar(25) null Constraint fk_Customer_ID Foreign Key References Customers (Customer_ID),
	Quantity smallint not null,
	Vat Money null,
	Discount Money null,
	Nhil Money null,
	Nhis_ID nvarchar(20) null Constraint def_Nhis_ID Default ('N/A'),
	Amount_Paid Money not null,
	Change Money null,
	Total_Amount Money null,
	Payment_MethodID tinyint not null Constraint fk_Payment_MethodID Foreign Key References Payment_Methods (Payment_method_ID),
	Employee_ID nvarchar(10) not null Constraint fk_Sales_Employee_ID Foreign Key References Employees (Employee_ID),
	Modified_date datetime2 not null Constraint def_Modified_date6 Default Getdate(),
	Constraint pk_Sale_ID Primary Key Clustered (Sale_ID),
)

Alter table Sales
Add constraint SalesMinQuantityValue Check (Quantity > 0)


Use KAFEESA
GO
Create table Sales_Details
(
	Sale_ID int not null Constraint fk_Sales_ID Foreign Key References Sales (Sale_ID),
	Product_ID int not null Constraint fk_Sales_Product_ID Foreign Key References Stock (Product_ID),
	Modified_date datetime2 not null Constraint def_Modified_date7 Default Getdate(),
	Constraint pk_Sale_ID_Sales_Details Primary Key Clustered (Sale_ID, Product_ID),
)


Use KAFEESA
GO
Create table Refunds
(
	Refund_ID int IDENTITY (1, 1) not null,
	Sale_ID int not null Constraint fk_Refund_Sale_ID Foreign Key References Sales (Sale_ID),
	Modified_date datetime2 not null Constraint def_Modified_date8 Default Getdate(),
	constraint pk_RefundID Primary Key Clustered (Refund_ID)
)


Use KAFEESA
GO
Create table Symptoms
(
	Symptoms_ID int IDENTITY (1, 1) not null,
	Symptom nvarchar(max) not null,
	Modified_date datetime2 not null Constraint def_Modified_date10 Default Getdate(),
	constraint pk_Symptoms_ID Primary Key Clustered (Symptoms_ID),
)



Use KAFEESA
GO
Create table knowledgebase
(
	knowledgebase_ID int  IDENTITY (1, 1) not null,
	Employee_ID nvarchar(10) not null Constraint fk_Kb_Employee_ID Foreign Key References Employees (Employee_ID),
	Symptoms_ID int null constraint fk_Symptoms_ID Foreign Key References Symptoms (Symptoms_ID),
	Prescribed_medicine nvarchar(50) null,
	Modified_date datetime2 not null Constraint def_Modified_date9 Default Getdate(),
	constraint pk_knowledgebase Primary Key Clustered (knowledgebase_ID),
)




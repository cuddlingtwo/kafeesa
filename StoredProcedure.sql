

--uspInsertCompanyInfo

CREATE PROCEDURE uspInsertCompanyInfo

@strCompanyName NVARCHAR (50),
@strCompanyAddress NVARCHAR (60),
@strCity NVARCHAR(20),
@strPhone NVARCHAR (13),
@strFax NVARCHAR (13),
@strEmail NVARCHAR (30),
@strWeb NVARCHAR (30),
@strTaxRate INT,
@strNhilRate int,
@picLogo as nvarchar(500),
@strVatRegistrationNumber NVARCHAR (30)

AS

BEGIN TRANSACTION

INSERT INTO CompanyInfo (Company_Name, Company_Address, City, Phone, Fax, Email, Web, Tax_rate, Nhil_rate, Logo, Vat_Registration_No)
VALUES	(@strCompanyName, @strCompanyAddress, @strCity, @strPhone, @strFax, @strEmail, @strWeb,  @strTaxRate, @strNhilRate, @picLogo, @strVatRegistrationNumber)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO

select * from CompanyInfo


go
--uspUpdateCompanyInfo

CREATE PROCEDURE uspUpdateCompanyInfo

@strCompanyName NVARCHAR (50),
@strCompanyAddress NVARCHAR (60),
@strCity NVARCHAR(20),
@strPhone NVARCHAR (13),
@strFax NVARCHAR (13),
@strEmail NVARCHAR (30),
@strWeb NVARCHAR (30),
@strTaxRate INT,
@strNhilRate INT,
@picLogo NVARCHAR(500),
@strVatRegistrationNumber NVARCHAR (30)

AS

BEGIN TRANSACTION

UPDATE CompanyInfo
SET
	 Company_Address = @strCompanyAddress,
	 City = @strCity,
	 Phone = @strPhone,
	 Fax = @strFax,
	 Email = @strEmail,
	 Web = @strWeb,
	 Tax_rate = @strTaxRate,
	 Nhil_Rate = @strNhilRate,
	 Logo = @picLogo,
	 Vat_Registration_No = @strVatRegistrationNumber
	 
WHERE Company_Name  = @strCompanyName

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK

GO


--uspDeleteCompanyInfo

CREATE PROCEDURE uspDeleteCompanyInfo
@strCompanyname as nvarchar(50)
AS

BEGIN TRANSACTION

DELETE FROM CompanyInfo
where Company_name = @strCompanyname

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


--uspInsertPaymentmethod

CREATE PROCEDURE uspInsertPaymentmethod

@strPaymentmethodname nvarchar(50)

As

BEGIN TRANSACTION

INSERT INTO Payment_Methods(Payment_name)
VALUES	(@strPaymentmethodname)
DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


--uspUpdatePaymentmethod

CREATE PROCEDURE uspUpdatePaymentmethod

@intpaymentmethodID int,
@strPaymentmethodname nvarchar(50)

As

BEGIN TRANSACTION

UPDATE Payment_Methods
SET


	 Payment_name = @strPaymentmethodname
	 
WHERE Payment_method_ID = @intpaymentmethodID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK

GO


--uspDeletePaymentmethod

CREATE PROCEDURE uspDeletePaymentmethod

@strPaymentmethodname nvarchar(50)

As

BEGIN TRANSACTION

Delete from Payment_Methods
	 
WHERE Payment_name = @strPaymentmethodname

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK

GO


--uspInsertCompanies

CREATE PROCEDURE uspInsertCompanies

@strCompanyID NVARCHAR (10),
@strCompanyName NVARCHAR (50),
@strContactperson NVARCHAR(20),
@strCompanyAddress NVARCHAR (60),
@strCompanylandphone1 NVARCHAR (13),
@strCompanylandphone2 NVARCHAR (13),
@strCompanymobilephone NVARCHAR (13),
@strCompanyemail NVARCHAR (30),
@intCompanydebit DECIMAL

AS

BEGIN TRANSACTION

INSERT INTO Company (Company_ID, Company_Name, Contact_person, Company_Address, Company_land_phone1, Company_land_phone2, Company_mobile_phone, Company_email, Company_debit)
VALUES	(@strCompanyID, @strCompanyName, @strContactperson, @strCompanyAddress, @strCompanylandphone1, @strCompanylandphone2, @strCompanymobilephone, @strCompanyemail, @intCompanydebit)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO

select * from Company


go
--uspUpdateCompanies


CREATE PROCEDURE uspUpdateCompanies

@strCompanyID NVARCHAR (10),
@strCompanyName NVARCHAR (50),
@strContactperson NVARCHAR(20),
@strCompanyAddress NVARCHAR (60),
@strCompanylandphone1 NVARCHAR (13),
@strCompanylandphone2 NVARCHAR (13),
@strCompanymobilephone NVARCHAR (13),
@strCompanyemail NVARCHAR (30),
@intCompanydebit DECIMAL

AS

BEGIN TRANSACTION

UPDATE Company
SET

	 Company_name = @strCompanyName,
	 Contact_person = @strContactperson,
	 Company_Address = @strCompanyAddress,
	 Company_land_phone1 = @strCompanylandphone1,
	 Company_land_phone2 = @strCompanylandphone2,
	 Company_mobile_phone = @strCompanymobilephone,
	 Company_email = @strCompanyemail,
	 Company_debit = @intCompanydebit
	 
WHERE Company_ID  = @strCompanyID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK

GO

select * from Company
go
--uspDeleteCompanyInfo

CREATE PROCEDURE uspDeleteCompanies
@strCompanyID as nvarchar(10)
AS

BEGIN TRANSACTION

DELETE FROM Company
where Company_ID = @strCompanyID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO



--uspInsertCustomers

create PROCEDURE uspInsertCustomers

	(@strCustomerID nvarchar(25),
	 @strTitle nvarchar(5),
	 @strFirstname nvarchar(50),
	 @strLastname nvarchar(50),
	 @strCompanyID nvarchar(10),
	 @strAddress nvarchar(50),
	 @strPhoto nvarchar(max),
	 @strPhone nvarchar(15),
	 @strEmailAddress nvarchar(30))


AS

BEGIN TRANSACTION

 INSERT INTO Customers (Customer_ID, Title, First_Name, Last_Name, Company_ID, Customer_address, Photo, Customer_phone, Customer_email)
 VALUES (@strCustomerID, @strTitle, @strFirstname, @strLastname, @strCompanyID, @strAddress, @strPhoto, @strPhone, @strEmailAddress)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO



--uspUpdateCustomers

CREATE PROCEDURE uspUpdateCustomers

	(@strCustomerID nvarchar(10),
	 @strTitle nvarchar (5),
	 @strFirstname nvarchar(50),
	 @strLastname nvarchar(50),
	 @strCompanyID nvarchar(10),
	 @strAddress nvarchar(50),
	 @strPhoto nvarchar(max),
	 @strPhone nvarchar(15),
	 @strEmailAddress nvarchar(30))


AS

BEGIN TRANSACTION

 UPDATE Customers
 SET 
 
	 Title = @strTitle,
	 First_Name = @strFirstname, 
	 Last_Name = @strLastname, 
	 Company_ID = @strCompanyID, 
	 Customer_address = @strAddress, 
	 Photo = @strPhoto, 
	 Customer_phone = @strPhone, 
	 Customer_email = @strEmailAddress

	 
	 WHERE Customer_ID = @strCustomerID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO



--uspDeleteCustomers

create PROCEDURE uspDeleteCustomers

	@strCustomerID nvarchar(25)
	 
AS

BEGIN TRANSACTION

 DELETE FROM Customers
  WHERE Customer_ID = @strCustomerID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO





--uspInsertEmployee

CREATE PROCEDURE uspInsertEmployees

	(
	 @strEmployeeID nvarchar(10),
	 @strTitle nvarchar (5),
	 @strFirstname nvarchar(50),
	 @strlastname nvarchar(50),
	 @strEmployeeaddress nvarchar(50),
	 @strEmployeeposition nvarchar(50),
	 @strPhoto nvarchar(max),
	 @strEmployeephone nvarchar(13),
	 @strEmployeeemail nvarchar(30),
	 @dteDOB datetime2,
	 @dteStartDate datetime2,
	 @dteEndDate datetime2,
	 @strUsername nvarchar(50),
	 @strPass nvarchar(30),
	 @strActiveStatus nvarchar(3))

AS

BEGIN TRANSACTION

 INSERT INTO Employees
	 (Employee_ID, Title, First_name, Last_name, Employee_address, Employee_position, Photo, Employee_phone, Employee_email, DateOfBirth, StartDate, EndDate, Username, Pass, Active_Status) 
 VALUES (@strEmployeeID, @strTitle, @strFirstname, @strlastname, @strEmployeeaddress, @strEmployeeposition, @strPhoto, @strEmployeephone, @strEmployeeemail,	 @dteDOB, @dteStartDate, @dteEndDate, @strUsername, @strPass, @strActiveStatus)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


select * from Employees
go

--uspUpdateEmployee

CREATE PROCEDURE uspUpdateEmployees

	(@strEmployeeID nvarchar(10),
	 @strTitle nvarchar (5),
	 @strFirstname nvarchar(50),
	 @strlastname nvarchar(50),
	 @strEmployeeaddress nvarchar(50),
	 @strEmployeeposition nvarchar(50),
	 @strPhoto nvarchar(max),
	 @strEmployeephone nvarchar(13),
	 @strEmployeeemail nvarchar(30),
	 @dteDOB datetime2,
	 @dteStartDate datetime2,
	 @dteEndDate datetime2,
	 @strUsername nvarchar(50),
	 @strPass nvarchar(30),
	 @strActiveStatus nvarchar(3))
	
AS

BEGIN TRANSACTION

 UPDATE Employees
	SET 
	Title = @strTitle,
	First_name = @strFirstname,
	Last_name = @strlastname,	
	Employee_address = @strEmployeeaddress,
	Employee_position = @strEmployeeposition,
	Photo = @strPhoto,
	Employee_phone  = @strEmployeephone,
	Employee_email = @strEmployeeemail,
	DateOfBirth = @dteDOB,
	StartDate = @dteStartDate,
	EndDate = @dteEndDate,
	Username = @strUsername,
	Pass = @strPass,
	Active_Status = @strActiveStatus
	
	WHERE Employee_ID = @strEmployeeID 

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO



--uspDeleteEmployee

CREATE PROCEDURE uspDeleteEmployees

	@strEmployeeID nvarchar(10)

AS

BEGIN TRANSACTION

DELETE Employees
WHERE Employee_ID = @strEmployeeID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO



--uspInsertLogins

CREATE PROCEDURE uspInsertLogins

	(
	 @strEmployeeID nvarchar(10),
	 @dteLogin_time datetime2,
	 @strLogout_time datetime2)

AS

BEGIN TRANSACTION

 INSERT INTO Logins
	 (Employee_ID, Login_time, Logout_time) 
 VALUES (@strEmployeeID, @dteLogin_time, @strLogout_time)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


--uspInsertStocks

CREATE PROCEDURE uspInsertStocks

	(
	@strSupplierID nvarchar(10),
	@strProductname NVARCHAR (50),
	@strProductdescription NVARCHAR(max),
	@intReorderpoint int,
	@intQuantity SMALLINT,
	@monCostprice DECIMAL,
	@monMarkup DECIMAL,
	@monUnitprice DECIMAL,
	--@monTotalAmount MONEY,
	@dteProducedate DATETIME,
	@dteExpirationdate DATETIME,
	@strInstock NVARCHAR (3),
	@intCategoryID TINYINT)


AS

BEGIN TRANSACTION

INSERT INTO Stock 	(Supplier_ID, Product_name, Product_description, Reorder_point, Quantity, Cost_price, Markup, Unit_price, Produce_date, Expiration_date, In_Stock, Category_ID)
VALUES		 	(@strSupplierID, @strProductname, @strProductdescription, @intReorderpoint,@intQuantity, @monCostprice, @monMarkup, @monUnitprice, @dteProducedate, @dteExpirationdate, @strInstock, @intCategoryID)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


select * from stock
go



--uspUpdateStocks

CREATE PROCEDURE uspUpdateStocks

	(
	@intProductID int,
	@strSupplierID nvarchar(10),
	@strProductname NVARCHAR (50),
	@strProductdescription NVARCHAR(max),
	@intReorderpoint INT,
	@intQuantity SMALLINT,
	@monCostprice DECIMAL,
	@monMarkup DECIMAL,
	@monUnitprice DECIMAL,
	@dteProducedate DATETIME,
	@dteExpirationdate DATETIME,
	@strInstock NVARCHAR (3),
	@intCategoryID TINYINT)

AS

BEGIN TRANSACTION

UPDATE Stock SET

	Supplier_ID = @strSupplierID,
	Product_name = @strProductname,
	Product_description = @strProductdescription,
	Reorder_point = @intReorderpoint,
	Quantity = @intQuantity,
	Cost_price = @monCostprice,
	Markup = @monMarkup,
	Unit_price = @monUnitprice,
	Produce_date = @dteProducedate,
	Expiration_date = @dteExpirationdate,
	In_Stock = @strInstock,
	Category_ID = @intCategoryID

	WHERE
	Product_ID = @intProductID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK

GO



--uspUpdateQuantityInStocks

CREATE PROCEDURE uspUpdateQuantityInStock

@intProductID INTEGER,
@intQuantity INTEGER

AS

BEGIN TRANSACTION

UPDATE Stock SET
Quantity = @intQuantity 
WHERE
Product_ID = @intProductID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK

GO



--uspDeleteStock

CREATE PROCEDURE uspDeleteStock

@strProductname NVARCHAR(50)

AS

BEGIN TRANSACTION

DELETE Stock
WHERE Product_name = @strProductname

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK

GO



go
--uspInsertSuppliers

CREATE PROCEDURE uspInsertSuppliers

	(@strSupplierID nvarchar(10),
	 @strSupplierName nvarchar(50),
	 @strContactperson nvarchar(100),
	 @strSupplieraddress nvarchar(50),
	 @strSupplierlandline1 nvarchar(13),
	 @strSupplierlandline2 varchar(13),
	 @strSuppliermobile nvarchar(13),
	 @strSupplieremail nvarchar(30))

AS

BEGIN TRANSACTION

 INSERT INTO Suppliers
	 (Supplier_ID, Supplier_name, Contact_person, Supplier_address, Supplier_land_phone1, Supplier_land_phone2, Supplier_mobile_phone, Supplier_email)
 VALUES (@strSupplierID, @strSupplierName, @strContactperson, @strSupplieraddress, @strSupplierlandline1, @strSupplierlandline2, @strSuppliermobile, @strSupplieremail)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO



--uspUpdateSuppliers

CREATE PROCEDURE uspUpdateSuppliers

	(@strSupplierID nvarchar(10),
	 @strSupplierName nvarchar(50),
	 @strContactperson nvarchar(100),
	 @strSupplieraddress nvarchar(50),
	 @strSupplierlandline1 nvarchar(13),
	 @strSupplierlandline2 varchar(13),
	 @strSuppliermobile nvarchar(13),
	 @strSupplieremail nvarchar(30))

AS

BEGIN TRANSACTION

 UPDATE Suppliers SET
	 
	Supplier_name = @strSupplierName,
	Contact_person = @strContactperson,
	Supplier_address = @strSupplieraddress,
	Supplier_land_phone1 = @strSupplierlandline1,
	Supplier_land_phone2 = @strSupplierlandline2,
	Supplier_mobile_phone = @strSuppliermobile,
	Supplier_email = @strSupplieremail
	 
 WHERE  Supplier_ID = @strSupplierID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


--uspDeleteSuppliers

CREATE PROCEDURE uspDeleteSuppliers

	@strSupplierID nvarchar(10)
AS

BEGIN TRANSACTION

DELETE Suppliers
 	
WHERE Supplier_ID = @strSupplierID

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO



--uspInsertUsers

--CREATE PROCEDURE uspInsertUsers

--	(
--	@strUsername nvarchar(50),
--	@strPass nvarchar(30),
--	@strEmployeeposition nvarchar(50),
--	@intActivestatus tinyint,
--	@dteLogintime datetime2,
--	@dteLogouttime datetime2)

--AS

--BEGIN TRANSACTION

--INSERT INTO Users(Username, Pass, Active_Status, Login_time, Logout_time)
--VALUES		 	(@strUsername, @strPass, @strEmployeeposition, @intActivestatus, @dteLogintime, @dteLogouttime)

--DECLARE @intError INT

--SET @intError = @@Error

--IF @intError = 0
--	COMMIT
--ELSE
--	ROLLBACK
--GO


--uspUpdateUsers

--CREATE PROCEDURE uspUpdateUsers
--(
--	@intUserID SMALLINT,
--	@strUsername VARCHAR(50),
--	@strPassword VARCHAR(30)
-- )
	
--AS

--BEGIN TRANSACTION

--UPDATE Users SET

--	Username = @strUsername,
--	Pass = @strPassword

--WHERE(UserID = @intUserID)
	
--DECLARE @intError INT

--SET @intError = @@Error

--IF @intError = 0
--	COMMIT
--ELSE
--	ROLLBACK
--GO


--use kafeesa
--go
--exec uspInsertUsers

--	@strUsername = 'f.apallo',
--	@strPass = '123abc',
--	@strEmployeeposition = 'Cashier',
--	@intActivestatus = '1',
--	@dteLogintime = '',
--	@dteLogouttime = ''
--go

--select * from customers
--go



--uspInsertSales

CREATE PROCEDURE uspInsertSales

@strCustomerID nvarchar(25) ,
@intQuantity SMALLINT,
@monVat MONEY,
@monDiscount MONEY,
@monNhil MONEY,
@strNhisID NVARCHAR,
@monAmountPaid MONEY,
@monChange MONEY,
@monTotalAmount MONEY,
@intPaymentMethodID TINYINT


AS

BEGIN TRANSACTION

INSERT INTO Sales (Customer_ID, Quantity, Vat, Discount, Nhil, Nhis_ID, Amount_Paid, Change, Total_Amount, Payment_MethodID)
VALUES		 	(@strCustomerID, @intQuantity, @monVat, @monDiscount, @monNhil, @strNhisID, @monAmountPaid, @monChange, @monTotalAmount, @intPaymentMethodID)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


--Variables for inserting into Sales_Details
--@intSaleID INTEGER,
--@intProductID INTEGER

--BEGIN TRANSACTION

--INSERT INTO Sales_Details 	(Sale_ID, Product_ID)
--VALUES		 	(@intSaleID, @intProductID)

--DECLARE @intError INT

--SET @intError = @@Error

--IF @intError = 0
--	COMMIT
--ELSE
--	ROLLBACK
--GO



--use kafeesa
--GO
--EXEC uspInsertSales
	
--	@strCustomerID = 'EA123/01',
--	@intQuantity = '3',
--	@monVat = '2',
--	@monDiscount = '0.00',
--	@monNhil = '0.05',
--	@strNhisID = '0.05',
--	@monAmountPaid = '20.00',
--	@monChange = '1.00',
--	@monTotalAmount = '15.00',
--	@intPaymentMethodID = '1'
--go

--select * from Sales

--select * from customers

--go
--uspInsertSaleDetails

CREATE   PROCEDURE uspInsertSalesDetails

@intSaleID INTEGER,
@intProductID INTEGER

AS

BEGIN TRANSACTION

INSERT INTO Sales_Details 	(Sale_ID, Product_ID)
VALUES		 	(@intSaleID, @intProductID)

DECLARE @intError INT

SET @intError = @@Error

IF @intError = 0
	COMMIT
ELSE
	ROLLBACK
GO


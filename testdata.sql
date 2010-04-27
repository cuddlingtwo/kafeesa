
Use kafeesa
go
Insert Category (Category_name)
values ('Medicines')

Insert Category (Category_name, Returnable)
values ('Toiletries', 'True')

Insert Category (Category_name, Returnable)
values ('Baby Products', 'True')

Insert Category (Category_name, Returnable)
values ('Body care', 'True')

Insert Category (Category_name, Returnable)
values ('Herbal', 'True')



Use kafeesa
go
Insert Company (Company_name, Contact_person, Company_address, Company_land_phone1, Company_land_phone2, Company_mobile_phone, Company_email)
values ('Catholic Uni', 'Frimpong', 'kkk street', '2330208008001', '2330208023478', '2330208453478', 'o.frimpong@kafeesa.com')

Insert Company (Company_name, Contact_person, Company_address, Company_land_phone1, Company_land_phone2, Company_mobile_phone, Company_email)
values ('Nestle Gh', 'Frimpong', 'bbb street', '2330208008001', '2330208023478', '2330208453478', 'o.frimpong@kafeesa.com')

Insert Company (Company_name, Contact_person, Company_address, Company_land_phone1, Company_land_phone2, Company_mobile_phone, Company_email)
values ('ELAC', 'kofi', 'ccc street', '2330208008001', '2330208023478', '2330208453478', 'kofi@kafeesa.com')

Insert Company (Company_name, Contact_person, Company_address, Company_land_phone1, Company_land_phone2, Company_mobile_phone, Company_email)
values ('Glico', 'kwame', 'mmm street', '2330208008001', '2330208023478', '2330208453478', 'Kwame@kafeesa.com')

Insert Company (Company_name, Contact_person, Company_address, Company_land_phone1, Company_land_phone2, Company_mobile_phone, Company_email)
values ('Chase', 'cinthia', 'ggg street', '2330208008001', '2330208023478', '2330208453478', 'cinthia@kafeesa.com')



Use kafeesa
go
Insert CompanyInfo (Company_name, Company_address, city, Phone, Fax, Email, Web, Tax_rate, Nhil_rate, Vat_Registration_No)
values ('KafeesaPharma', 'IPS', 'Accra', '2330208008001', '2330208023', 'cinthia@kafeesa.com', 'www.kafeesa.com', '5', '2', '12345')



Use kafeesa
go
Insert Customers(Customer_ID, First_name, Last_name, Company_ID, Customer_address, Photo, Customer_phone, Customer_email)
values ('EA123/01', 'Edith', 'Akos', '2', 'South ridge', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330244234890', 'e.a@kafeesa.com')

Insert Customers(Customer_ID, First_name, Last_name, Company_ID, Customer_address, Photo, Customer_phone, Customer_email)
values ('JB123/02', 'Junior', 'Bediako', '2', 'North ridge', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330244234890', 'j.b@kafeesa.com')

Insert Customers(Customer_ID, First_name, Last_name, Company_ID, Customer_address, Photo, Customer_phone, Customer_email)
values ('PM12345/01', 'Peter', 'Mensah', '4', 'Lagos street', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330244234890', 'p.m@kafeesa.com')

Insert Customers(Customer_ID, First_name, Last_name, Company_ID, Customer_address, Photo, Customer_phone, Customer_email)
values ('PK12345/02', 'Paa', 'Kwasi', '4', 'Berlin', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330244234890', 'p.k@kafeesa.com')

Insert Customers(Customer_ID, First_name, Last_name, Company_ID, Customer_address, Photo, Customer_phone, Customer_email)
values ('DA12345/01', 'Dela', 'Ahento', '1', 'South ridge', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330244234890', 'd.a@kafeesa.com')

Insert Customers(Customer_ID, First_name, Last_name, Company_ID, Customer_address, Photo, Customer_phone, Customer_email)
values ('LA12345/01', 'Loveia', 'Ahento', '1', 'La-pas', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330244234890', 'l.a@kafeesa.com')



--Use kafeesa
--go
--Insert Users (Username, Pass, Employee_position, Active_Status, Login_time, Logout_time)
--values ('p.mensah', '123xyz', 'Pharmacist', '1', '', '')

--Insert Users (Username, Pass, Employee_position, Active_Status, Login_time, Logout_time)
--values ('f.apallo', '123abc', 'Cashier', '1', '', '')

--Insert Users (Username, Pass, Employee_position, Active_Status, Login_time, Logout_time)
--values ('o.frimpong', '123ABC', 'Manager', '1', '', '')

--select * from Users



Use kafeesa
go
Insert Employees (Employee_ID, Title, First_name, Last_name, UserID, Employee_address, Photo, Employee_phone, Employee_email, DateOfBirth)
values ('01', 'Mr', 'Peter', 'Mensah', '01', 'ABC street', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330208769325', 'p.mensah@kafeesa.com', '01/04/1985')

Insert Employees (Employee_ID, Title, First_name, Last_name, UserID, Employee_address, Photo, Employee_phone, Employee_email, DateOfBirth)
values ('02', 'Mr', 'Fred', 'Apallo', '02', '123 street', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330205555555', 'f.apallo@kafeesa.com', '12/09/1975')

Insert Employees (Employee_ID, Title, First_name, Last_name, UserID, Employee_address, Photo, Employee_phone, Employee_email, DateOfBirth)
values ('03', 'Mrs', 'Owusua', 'Frimpong', '03', 'kkk street', 'C:\Users\pitt\Pictures\alba1631600x1200.jpg', '2330208008001', 'o.frimpong@kafeesa.com', '03/01/1986')

select * from employees




Use kafeesa
go
Insert Payment_Methods (Payment_name)
values ('Cash')

Insert Payment_Methods (Payment_name)
values ('E-zwich')

Insert Payment_Methods (Payment_name)
values ('NHIS')



Use kafeesa
go
Insert Suppliers (Supplier_name, Contact_person, Supplier_address, Supplier_land_phone1, Supplier_land_phone2, Supplier_mobile_phone, Supplier_email, Modified_date)
values ('Enerst drugs', 'Mr Akins', 'South ridge zone', '021234567', '021345678', '2330201234567', 'enerstdrugs@gmail.com', '')

Insert Suppliers (Supplier_name, Contact_person, Supplier_address, Supplier_land_phone1, Supplier_land_phone2, Supplier_mobile_phone, Supplier_email, Modified_date)
values ('Owusu baby care', 'Mrs Kofi', 'North ridge zone', '021234567', '021345678', '2330201234567', 'owusu@yahoo.com', '')

Insert Suppliers (Supplier_name, Contact_person, Supplier_address, Supplier_land_phone1, Supplier_land_phone2, Supplier_mobile_phone, Supplier_email, Modified_date)
values ('Top herbal', 'Mr Sewa', '34, Estate road', '021234567', '021345678', '2330201234567', 'Sales@topherbal.com', '')




Use kafeesa
go
Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Actifed Syrup', 'Pain releiver', '20', '2.00', '0.50', '2.50', '50.00', '12/12/2009', '12/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Amoxyl 250mg', 'Antibiotic', '100', '2.00', '0.50', '2.50', '250.00', '12/12/2009', '12/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Amoxyl 500mg', 'Antibiotic', '150', '2.00', '0.50', '', '', '5/12/2009', '5/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Bells children cough syrup', 'cough syrup', '15', '2.00', '0.50', '', '', '6/12/2009', '6/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Castor oil', 'Essensial oil', '15', '2.00', '0.50', '', '', '9/12/2009', '9/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Celebrex 200g', 'Spinal builder', '10', '2.00', '0.50', '', '', '10/12/2009', '10/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Cerelac', 'Baby food', '25', '2.00', '0.50', '', '', '7/12/2009', '7/12/2012', '03')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'Citro-C tabs', 'Vitamin C', '100', '0.20', '0.10', '', '', '4/12/2009', '4/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'cipromax 500mg', 'Liver oil', '10', '2.00', '0.50', '', '', '9/08/2009', '9/12/2012', '01')

Insert Stock (Supplier_ID, Product_name, Product_description, Quantity, Cost_price, Markup, Unit_Price, Total_Amount, Produce_date, Expiration_date, Category_ID)
values ('01', 'HEATOL', 'Pain releiver', '55', '2.00', '0.50', '', '', '11/01/2010', '11/12/2012', '04')



use kafeesa
go
Exec uspInsertStock 01, heatol, painreleiver, 55, 2.00, 0.50, select (Cost_price * Markup) as Unit_Price from Stock, select (Quantity * Unit_Price) as Total_Amount from stock, 11/04/2009, 03/04/2010, 1



Use kafeesa
go
Insert Sales (Customer_ID, Quantity, Vat, Discount, Nhil, Nhis_ID, Amount_Paid, Change, Total_Amount, Payment_MethodID)
values ('DA12345/01', '3', '2', '0.30', '0.05', '0.05', '20.00', '1.00', '15.00', '01')

select * from Sales
select * from Suppliers
select * from Stock
select * FROM customers
select * from Sales_Details


Use kafeesa
go
Insert Sales_Details (Sale_ID, Product_ID, Employee_ID)
values ('1', '101', '03')

go

select * from Employees
go

delete Employees
where Employee_ID = 'hjnjh102'
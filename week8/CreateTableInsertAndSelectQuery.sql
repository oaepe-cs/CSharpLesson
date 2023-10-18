CREATE TABLE tbl_Persons
(
	PersonID int,
	Name nvarchar(50),
	FatherName nvarchar(50),
	Address nvarchar(100)
);
--Add data to table
Insert into tbl_Persons Values(1, 'Ma Ma', 'U Myint', 'Mandalay');

--Read data from table
SELECT PersonID, Name, City FROM tbl_Persons WHERE City='Mandalay'

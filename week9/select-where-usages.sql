--*
SELECT * From tbl_Persons;

--top(No)
SELECT TOP(3) * FROM tbl_Persons;

--DISTINCT
SELECT DISTINCT City FROM tbl_Persons;

--WHERE
SELECT * FROM tbl_Persons WHERE City='Mandalay';

-- && = AND
-- || = OR
SELECT * FROM tbl_Persons WHERE 
(
	(City='Mandalay' OR Name='Ma Ma') OR 
	(City='Sittwe')
); 

--LIKE
SELECT * FROM tbl_Persons WHERE NAME LIKE ('M%');
SELECT * FROM tbl_Persons WHERE NAME LIKE ('%IN%');
SELECT * FROM tbl_Persons WHERE NAME LIKE ('%G');



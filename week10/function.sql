SELECT * FROM [DBSpring].[dbo].[tbl_IncomesExpenses]
--SUM
SELECT SUM(Amount) Total FROM tbl_IncomesExpenses WHERE Type='INCOME';

SELECT (SUM(Amount)/Count(Amount)) AS _avg FROM tbl_IncomesExpenses WHERE Type='INCOME';
--Avg
SELECT AVG(Amount) avg FROM tbl_IncomesExpenses WHERE Type='INCOME';
--Count
SELECT Count(Amount) _count FROM tbl_IncomesExpenses WHERE Type='INCOME';
--Max
SELECT Max(CreatedDate) FROM tbl_IncomesExpenses;
--Min
SELECT Min(CreatedDate) FROM tbl_IncomesExpenses;
SELECT * FROM [DBSpring].[dbo].[tbl_IncomesExpenses] order by CreatedDate ASC;
--Var
SELECT VAR(12568) AS _var FROM tbl_IncomesExpenses;

--Len
SELECT Category, LEN(Category) _Len FROM tbl_IncomesExpenses;
--Lower , --Upper
SELECT LOWER(CATEGORY) _LowerCase, CATEGORY, UPPER(Category) AS _upperCase  FROM tbl_Categories;

--Left, Right
SELECT Category, LEFT(CATEGORY, 3) _left, RIGHT(Category, 3) _right FROM tbl_Categories;

--Ltrim, Rtrim, Trim
SELECT Category, '    ' + Category as c, LTRIM('    ' + Category) FROM tbl_Categories;
SELECT ('	Spring C#') AS Name;-- Tab
SELECT LTRIM('	Spring C#') AS Name; --TAb
SELECT LTRIM('    Spring C#') AS Name;-- Space
SELECT RTRIM('Spring C#   ') AS Name;-- Space
SELECT TRIM('    Spring DB    ') AS Name;
--Concat
SELECT CONCAT(Type, ' - ', Category, ' [', Amount, ']') AS newColumn FROM tbl_IncomesExpenses
--SubString
SELECT Category, SUBSTRING(Category,3, 3) FROM tbl_IncomesExpenses
Select Category, Left(Category, 3) as c From tbl_IncomesExpenses;
--Replace
SELECT Category, REPLACE(Category, 'a','_a_') FROM tbl_Categories;

--Day
SELECT DAY(CreatedDate) AS dd, * FROM tbl_IncomesExpenses
--Moth
SELECT Month(CreatedDate) AS MM, * FROM tbl_IncomesExpenses
--Year
SELECT YEAR(CreatedDate) AS yyyy, * FROM tbl_IncomesExpenses
--DateAdd
SELECT DATEADD(DAY, 2, CreatedDate) AS _MyColumn, * FROM tbl_IncomesExpenses
--DateDiff
SELECT  DateDiff(Year, CreatedDate, DATEADD(DAY, 2, CreatedDate)) AS _DateDiffColumn, CreatedDate AS StartDate,
DATEADD(DAY, 2, CreatedDate) AS EndDate, * FROM tbl_IncomesExpenses;

--Group By
SELECT SUM(Amount) AS Total, Type FROM tbl_IncomesExpenses GROUP BY Type;

SELECT SUM(Amount) AS Total, Month(CreatedDate) AS MM, Type 
FROM tbl_IncomesExpenses 
GROUP BY Month(CreatedDate), Type
HAVING Month(CreatedDate)=9
ORDER BY MM

SELECT Category, Count(Category) recordCount FROM tbl_Categories GROUP BY Category

SELECT DISTINCT Category FROM tbl_Categories ORDER BY Category ASC;
SELECT Category FROM tbl_Categories GROUP BY Category;

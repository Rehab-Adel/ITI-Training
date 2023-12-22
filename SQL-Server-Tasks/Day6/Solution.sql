-- Constrains
CREATE Table Instructor (
ID int IDENTITY PRIMARY KEY,
Hiredate date DEFAULT GETDATE(),
Adress varchar(50) CHECK (Adress = 'Cairo' OR Adress = 'Alex'),
Salary int DEFAULT 3000 CHECK (Salary BETWEEN 1000 AND 5000),
Overtime int UNIQUE,
BD date,
Fname varchar(20),
Lname varchar(20))
 -------------------------------------
CREATE Table Course (
CID int IDENTITY PRIMARY KEY,
CName varchar (20),
Duration int UNIQUE)
---------------------------------------
CREATE Table Lab (
CID int FOREIGN KEY REFERENCES Course(CID) ON UPDATE CASCADE ON DELETE CASCADE,
LID int IDENTITY,
Location varchar(20),
Capacity int CHECK (Capacity <20),
PRIMARY KEY (CID, LID))

CREATE Table Ins_Lab (
ID int FOREIGN KEY REFERENCES Instructor (ID) ON UPDATE CASCADE ON DELETE CASCADE,
CID int FOREIGN KEY REFERENCES Course (CID) ON UPDATE CASCADE ON DELETE CASCADE,
PRIMARY KEY (ID, CID))

ALTER TABLE Instructor ADD Age AS (YEAR(GETDATE()) - YEAR(BD));
ALTER TABLE Instructor ADD Netsalary AS (Salary + Overtime);
--------------------------------------------------------------------------------
go
CREATE Function Month_name (@date DATE)
Returns varchar(20)
AS
BEGIN
RETURN DATENAME(MONTH, @date)
END;
----------------
go
CREATE FUNCTION NAMEMSG (@id int)
RETURNS varchar(50)
AS
BEGIN
DECLARE @FirstName varchar(50);
DECLARE @LastName varchar(50);
DECLARE @MSG Varchar(50);
SELECT @FirstName = st_fname, @LastName = St_Lname
FROM Student
WHERE st_id = @id;
IF @FirstName IS NULL AND @LastName IS NULL
SET @MSG = 'First name & last name are null';
ELSE IF @FirstName IS NULL
SET @MSG ='First name is null';
ELSE IF @LastName IS NULL
SET @MSG= 'Last name is null';
ELSE
SET @MSG ='First name & last name are not null';
RETURN @MSG
END
---------------
go
CREATE FUNCTION std_dep (@id int)
RETURNS TABLE
AS
RETURN
SELECT St_id, st_fname, dept_name
FROM Student s INNER JOIN Department d
ON s.Dept_ID = d.Dept_ID
WHERE St_Id = @id;

--------------
go
CREATE FUNCTION MNGRINFO (@id int)
RETURNS TABLE
AS
RETURN
SELECT dept_name, Ins_Name, Manager_hiredate
FROM Department INNER JOIN Instructor ON
Dept_Manager = Ins_Id
WHERE Dept_Manager = @id;


--Functions
-- 2.	 Create a multi-statements table-valued function that takes 2
--       integers and returns the values between them.
GO
CREATE FUNCTION valuesbetween (@first int, @last int)
RETURNS @t Table (value int)
AS
BEGIN
DECLARE @current int = @first + 1
WHILE @current < @last
BEGIN 
INSERT INTO @t (value) VALUES (@current)
SET @current = @current + 1
END
RETURN;
END;

SELECT * FROM valuesbetween(5,12)


--6.	Create multi-statements table-valued function that takes a string
--      If string='first name' returns student first name
--      If string='last name' returns student last name 
--      If string='full name' returns Full Name from student table 
--      Note: Use “ISNULL” function
GO
CREATE FUNCTION getname (@length varchar(20))
RETURNS @t table (name varchar(50))
AS
BEGIN
IF @length = 'first name'
INSERT INTO @t 
SELECT ISNULL(st_fname, 'NO FIRST NAME') FROM dbo.Student
ELSE IF @length = 'last name'
INSERT INTO @t
SELECT ISNULL(st_lname, 'NO LAST NAME') FROM dbo.Student
ELSE IF @length = 'full name'
INSERT INTO @t
SELECT ISNULL(CONCAT(st_fname, ' ' , st_lname), 'NO NAME') FROM dbo.Student
ELSE 
INSERT INTO @t values ('WRONG INPUT')
RETURN;
END;
GO

SELECT * FROM getname('full name')

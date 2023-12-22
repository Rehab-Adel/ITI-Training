--1.	 Create a view that displays student full name, 
--       course name if the student has a grade more than 50. 
CREATE VIEW studentpass AS
SELECT CONCAT(st_fname, ' ' , st_lname) "FULLNAME", crs_name "Course Name", grade "Grade"
FROM Student s INNER JOIN Stud_Course sc
ON sc.St_Id = s.St_Id
INNER JOIN Course c
ON sc.Crs_Id = c.Crs_Id
WHERE Grade < 50;

SELECT * FROM studentpass

--2.	 Create an Encrypted view that displays manager names 
--       and the topics they teach. 
CREATE VIEW mgrtopics WITH ENCRYPTION AS
SELECT Ins_Name "Manager Name", top_name "Topic"
FROM Department d, Instructor i, Ins_Course ic, Course c, Topic t
WHERE Dept_Manager = i.Ins_Id
AND i.Ins_Id = ic.Ins_Id
AND ic.Crs_Id = c.Crs_Id
AND c.Top_Id = t.Top_Id

SELECT * FROM mgrtopics

--3.	Create a view that will display Instructor Name, 
--      Department Name for the ‘SD’ or ‘Java’ Department
CREATE VIEW insdept AS
SELECT ins_name "Instructor Name", Dept_name "Department"
FROM Department d INNER JOIN Instructor i
ON i.Dept_Id = d.Dept_Id
AND Dept_Name IN ('java', 'sd')

SELECT * FROM insdept

-- 4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--       Note: Prevent the users to run the following query 
--       Update V1 set st_address=’tanta’
--       Where st_address=’alex’;
CREATE VIEW v1 AS
SELECT *
FROM dbo.Student
WHERE St_Address IN ('alex', 'cairo')
WITH CHECK OPTION

Update V1 set st_address='tanta'
Where st_address='alex'

--5.	Create a view that will display the project name and the number
--      of employees work on it. “Use Company DB”
CREATE VIEW Projcount AS
SELECT Pname, COUNT(ESSN)
FROM Project INNER JOIN Works_for
ON Pnumber = Pno
GROUP BY Pname

--6.	Create index on column (Hiredate) that allow u to cluster 
--      the data in table Department. What will happen?
CREATE CLUSTERED INDEX hireindx ON dbo.Departments ([MGRStart Date])

--7.	Create index that allow u to enter unique ages in student table.
--      What will happen?
CREATE UNIQUE INDEX StdIndx ON dbo.Student (st_age)

--8.	Using Merge statement between the following two tables 
--      [User ID, Transaction Amount]
CREATE table dailytrans (id int, trans int)
CREATE table lasttrans (id int, trans int)

Merge into [dbo].[dailytrans] as T 
using [dbo].[lasttrans] as S
On T.[id]=S.[id]

When matched then
update set T.trans=S.trans

When not matched by target Then 
insert(id, trans)
values(S.id,S.trans);

SELECT * FROM dailytrans

--9.	Try to Create Login Named(ITIStud) who can access Only student
--      and Course tables from ITI DB then allow him to select and insert 
--      data into tables and deny Delete and update
GRANT SELECT ON STUDENT TO ITISTUD
GRANT INSERT ON STUDENT TO ITISTUD
REVOKE DELETE ON STUDENT TO ITISTUD
REVOKE UPDATE ON STUDENT TO ITISTUD
--Procedures Tasks
--problem 1 (iti db)
create procedure stud_count_dept as
select dept_name, count(*) as numberofstudents
from student s, Department d
where s.Dept_Id = d.Dept_Id
group by dept_name;

--problem 2 (company_sd db)
create procedure checkemployeesinprojectp1 as
begin
declare @num int;
select count(*) emp_count
from employee, Works_for, project
where ssn = essn and pno = Pnumber and Pname = 'P1'
if @num >= 3 select 'the number of employees in the project p1 is 3 or more' as message;
else select 'the following employees work for the project p1' as "message", fname, lname
from employee, Works_for, project
where ssn = essn and pno = Pnumber and Pname = 'P1'
end

--problem 3 (company_sd db)
go
create procedure update_project_emp(@oldssn int, @newssn int, @pnum int) as
begin
update works_for
set ESSn = @newssn
WHERE essn = @oldssn and Pno = @pnum;
end

--Trigger Tasks
--problem 4 (company_sd db)
alter table project
add budget int;
create table audit (projectNo int, useName varchar(50), modifiedDate date, Bbdget_old int, budget_new int)
go
create trigger update_trigger on project after update as
begin
if update (buget)
insert into Project
select d.pnumber, SUSER_NAME(), GETDATE(), d.budget, i.budget
from deleted d, inserted i
end

update Project set budget = 100000 where Pnumber = 800

--problem 5 (company_sd db)
go
create trigger prevent_insert on departments instead of insert as
begin
select 'you cant allowed to insert a new record'
end

--problem 6 (company_sd db)
go
create trigger null_month on employee instead of insert as
begin
declare @currentmonth varchar(20)= month(getdate());
if @currentmonth = 'march'
 select 'you cannot add any employee in march'
 else
 begin
insert into employee
select * from inserted;
end
end

--problem 7 (iti db)
create table studentaudit (server_user_name varchar(50), date_ date, note varchar(100))
go
create trigger s_audit on student after insert as
begin
insert into studentaudit
select user_name(), getdate(),  user_name()+' insert new row with key= '+ i.st_id + ' in table student' "note"
from inserted i
end

--problem 8 (iti db)
go
create trigger auditpreventtrigger on student instead of delete as
begin
insert into studentaudit 
select user_name(), getdate(), 'try to delete row with key= ' + d.st_id
from deleted d
end

--------------------------------------------------------------------------------------------------

--Cursor Tasks
--problem 1 (comapany_sd db)
declare @empid int, @currentsalary decimal(10, 2), @newsalary decimal(10, 2)
declare empcursor cursor for
select ssn, salary
from employee
open empcursor
fetch next from empcursor into @empid, @currentsalary
while @@fetch_status = 0
begin
if @currentsalary < 3000
set @newsalary = @currentsalary * 1.1
else set @newsalary = @currentsalary * 1.2
update employee
set salary = @newsalary
where ssn = @empid
fetch next from empcursor into @empid, @currentsalary
end
close empcursor
deallocate empcursor;

--problem 2 (iti db)
declare @deptname nvarchar(50), @instructor_name nvarchar(50)
declare deptcursor cursor for
select dept_name, ins_name 
from department, instructor
where dept_manager = ins_id
open deptcursor
fetch next from deptcursor into @deptname, @instructor_name
while @@fetch_status = 0 
begin
select 'department: ' + @deptName + ', instructor: ' + @instructor_name;
fetch next from deptcursor into @deptname, @instructor_name
end
close deptcursor
deallocate deptcursor;

--problem 3 (iti db)
declare @studentfname nvarchar(max) = '';
declare studentcursor cursor for
select st_fname from student;
open studentcursor;
fetch next from studentcursor into @studentfirstname;
while @@fetch_status = 0
begin
set @studentfname = @studentfname + ',' + @studentfname;
fetch next from studentcursor into @studentfirstname;
end
close studentcursor;
deallocate studentcursor;
select @studentfname as listed_Names

--problem 4 (company_sd db)
--full backup
backup database company_sd to disk = 'D:\backup\sd30_company_full.bak' with init
backup database company_sd to disk = 'D:\backup\sd30_company_diff.bak' with differential
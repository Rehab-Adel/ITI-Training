-- 1.	display (using union function)
-- a.	 the name and the gender of the dependence that's gender is female and depending on female employee.
-- b.	 and the male dependence that depends on male employee.
select d.dependent_name, d.sex
from dependent d , employee e
where ssn = essn and e.sex = 'f' and d.sex = 'f'
union
select d.dependent_name, d.sex
from dependent d , employee e
where ssn = essn and e.sex = 'm' and d.sex = 'm'

--2.	for each project, list the project name and the total hours per week (for all employees) spent on that project.
select pname, sum(hours) "total hours"
from works_for inner join project
on pno = pnumber
group by pname

--3.	display the data of the department which has the smallest employee id over all employees' id.
select top (1) dname, dnum, mgrssn, [mgrstart date]
from departments inner join employee
on dno = dnum
order by ssn

--4.	for each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select dname, max(salary) "max" , min(salary) "min" , avg(salary)"avg"
from departments inner join employee 
on dno = dnum
group by dname

--5.	list the full name of all managers who have no dependents.
select fname, lname
from employee inner join departments
on mgrssn = ssn
except
select fname, lname
from dependent inner join employee
on ssn = essn

-- 6.	for each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
select dno, dname, count (ssn) "no. of emp"
from departments inner join employee
on dno = dnum
group by dno, dname
having avg (salary) < all (
select avg (salary)
from employee)

-- 7.	retrieve a list of employees names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
select fname, lname, pname
from employee inner join works_for
on ssn = essn
inner join project
on pno = pnumber
order by dno, lname, fname

-- 8.	try to get the max 2 salaries using subquery
select (
select max(salary)
from employee) "max", max(salary)
from employee
where salary <> (
select max(salary)
from employee)

--9.	get the full name of employees that is similar to any dependent name
select fname, lname
from employee, dependent
where dependent_name = fname + ' ' + lname

-- 10.	display the employee number and name if at least one of them have dependents (use exists keyword)
select ssn, fname, lname
from employee
where exists ( 
select essn
from dependent)

--11.	in the department table insert new department called "dept it" , with id 100, employee with ssn = 112233 as a manager for this department. the start date for this manager is '1-11-2006'
insert into departments
values ('dept_it', 100, 112233, '1-11-2006')

--12.	do what is required if you know that : mrs.noha mohamed(ssn=968574)  moved to be the manager of the new department (id = 100), and they give you(your ssn =102672) her position (dept. 20 manager) 
--a.	first try to update her record in the department table
--b.	update your record to be department 20 manager.
--c.	update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your ssn =102672)
update departments 
set mgrssn = 968574
where dnum = 100
update departments
set mgrssn = 102672
where dnum = 20
update employee
set superssn = 102672
where ssn = 102660

-- 13.	unfortunately the company ended the contract with mr. kamel mohamed (ssn=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
update employee
set superssn = 102672
where superssn = 223344
delete from works_for
where essn = 223344
update departments
set mgrssn = 102672
where mgrssn = 223344
delete from employee
where ssn = 223344

--14.	try to update all salaries of employees who work in project ‘al rabwah’ by 30%
update employee
set salary = salary * 1.3
where salary in (
select salary
from employee inner join works_for
on ssn = essn
inner join project 
on pnumber = pno and pname = 'al rabwah')
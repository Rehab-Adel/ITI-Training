-- 1. display the department id, name and id and the name of its manager.
select d.dnum, d.dname, d.mgrssn, e.fname + ' ' + e.lname as manager_name
from departments d
inner join employee e on d.mgrssn = e.ssn;

-- 2. display the name of the departments and the name of the projects under its control.
select d.dname, p.pname
from departments d
inner join project p on d.dnum = p.dnum;

-- 3. display the full data about all the dependence associated with the name of the employee they depend on.
select e.fname, e.lname, d.*
from employee e
left join dependent d on e.ssn= d.essn;

-- 4. display the id, name and location of the projects in cairo or alex city.
select pnumber, pname, plocation
from project
where plocation in ('cairo', 'alex');

-- 5. display the projects full data of the projects with a name starting with a letter.
select *
from project
where pname like 'a%';

-- 6. display all the employees in department 30 whose salary is from 1000 to 2000 le monthly.
select *
from employee
where dno = 30 and salary between 1000 and 2000;

-- 7. retrieve the names of all employees in department 10 who work more than or equal to 10 hours per week on the al rabwah project.
select e.fname, e.lname
from employee e
inner join works_for w on e.ssn = w.essn
inner join project p on w.pno = p.pnumber
where e.dno = 10 and p.pname = 'al rabwah' and w.hours >= 10;

-- 8. find the names of the employees who directly supervised with kamel mohamed.
select e.fname, e.lname
from employee e
inner join employee s on e.superssn = s.ssn
where s.lname = 'kamel' and s.fname = 'mohamed';

-- 9. retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select e.fname, e.lname, p.pname
from employee e
inner join works_for w on e.ssn = w.essn
inner join project p on w.pno = p.pnumber
order by p.pname;

-- 10. for each project located in cairo city, find the project number, the controlling department name, the department manager last name, address, and birthdate.
select p.Pnumber, p.Plocation, d.Dname, e.lname as manager_last_name, e.address, e.bdate
from project p
join departments d on p.Dnum = d.Dnum
join employee e on d.MGRSSN = e.SSN
where p.Plocation = 'cairo';

-- 11. display all data of the managers.
select *
from employee
where SSN in (select mgrssn from Departments);

-- 12. display all employees data and the data of their dependents even if they have no dependents.
select e.*, d.*
from employee e
left join dependent d on e.SSN = d.ESSN;

-- 13. insert your personal data into the employee table as a new employee in department number 30, ssn = 102672, superssn = 112233, salary = 3000.
insert into employee (SSN, fname, lname, Dno, ssn, Superssn, salary)
values (195005, 'Rehab', 'Adel', 30, 102672, 112233, 3000);

-- 14. insert another employee with personal data for your friend as a new employee in department number 30, ssn = 102660, but don’t enter any value for salary or supervisor number for him.
insert into employee (SSN, fname, lname, Dno, ssn)
values (191919, 'Khadija', 'Adel', 30, 102660);

-- 15. upgrade your salary by 20% of its last value.
update employee
set salary = salary * 1.20
where ssn = 195005;

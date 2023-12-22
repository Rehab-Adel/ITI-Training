-- 1. display all the employees data.
select * from employee;

-- 2. display the employee first name, last name, salary and department number.
select fname, lname, salary, dno from employee;

-- 3. display all the projects names, locations and the department which is responsible about it.
select pname, plocation, dnum from project;

-- 4. if you know that the company policy is to pay an annual commission for each employee with
-- specific percent equals 10% of his/her annual salary .display each employee full name and his
-- annual commission in an annual comm column (alias).
select fname + ' ' + lname as full_name, salary * 0.1 as "annual comm" from employee;

-- 5. display the employees id, name who earns more than 1000 le monthly.
select ssn, fname + ' ' + lname as full_name from employee where salary > 1000;

-- 6. display the employees id, name who earns more than 10000 le annually.
select ssn, fname + ' ' + lname as full_name from employee where salary * 12 > 10000;

-- 7. display the names and salaries of the female employees
select fname, lname, sex, salary from employee where sex = 'f';

-- 8. display each department id, name which managed by a manager with id equals 968574.
select dnum, dname from departments where mgrssn = 968574;

-- 9. dispaly the ids, names and locations of the pojects which controled with department 10.
select pnumber, pname, plocation from project where dnum = 10;

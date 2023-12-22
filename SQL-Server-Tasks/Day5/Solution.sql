-- ITI DB
-- 1. retrieve number of students who have a value in their age. 
select count (st_id)
from student
where st_age is not null

-- 2. get all instructors names without repetitions
select distinct ins_name
from instructor

--3. display student with the following format (use is null function)
select isnull (st_id, 'no id') as [student id],
isnull (concat(st_fname, ' ', st_lname), 'no name') as [student full name],
isnull (dept_name, 'no department') as [department name]
from student s inner join department d
on s.dept_id = d.dept_id

--4. display instructor name and department name 
--   note: display all the instructors if they are attached to a department or not
select ins_name, dept_name
from instructor i left join department d
on i.dept_id = d.dept_id

-- 5. display student full name and the name of the course he is taking
-- for only courses which have a grade 
select concat(st_fname, ' ', st_lname) as [student full name], crs_name
from student s inner join stud_course sc
on s.st_id = sc.st_id
inner join course c
on sc.crs_id = c.crs_id
and sc.grade is not null

--6. display number of courses for each topic name
select count (crs_id), top_name
from course c inner join topic t
on t.top_id = c.top_id
group by top_name

-- 7. display max and min salary for instructors
select max(salary), min(salary)
from instructor

--8. display instructors who have salaries less than the average salary of all instructors.
select *
from instructor
where salary < (select avg(salary), 0) from instructor)

--9. display the department name that contains the instructor who receives the minimum salary.
select dept_name
from department d inner join instructor i
on i.dept_id = d.dept_id
and salary = (select min(salary) from instructor)

--10. select max two salaries in instructor table. 
-- for distinct max salaries
select salary
from (select distinct salary, dense_rank() over (order by salary desc) "rank" from instructor) as rankquery
where rank in (1,2)
-- for max salary with allowed repition
select salary
from (select salary, rank() over (order by salary desc) "rank" from instructor) as rankquery
where rank in (1,2)

--11. select instructor name and his salary but if there is no salary display instructor bonus keyword.
-- “use coalesce function”
select ins_name, coalesce(convert(varchar,salary), 'bonus')
from instructor

--12. select average salary for instructors 
select avg(salary)
from instructor

--13. select student first name and the data of his supervisor 
select s.st_fname "student", spv.*
from student s inner join student spv
on s.st_id = spv.st_super

--14.write a query to select the highest two salaries in each department for instructors who have salaries.
-- “using one of ranking functions”
select salary, row_number () over (partition by dept_id order by salary desc) as ranked into temp_rank
from instructor

select salary
from temp_rank
where ranked <= 2

--15. write a query to select a random  student from each department.  “using one of ranking functions”
select st_fname
from (select st_fname, row_number() over (partition by dept_id order by newid()) random_rank from student) as ranksubquery
where random_rank = 1


-- adventureworks2012 DB
--1. display the salesorderid, shipdate of the salesorderheader table (sales schema) to show salesorders
-- that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
select salesorderid, shipdate
from sales.salesorderheader
where orderdate between '7/28/2002' and '7/29/2014'

-- 2. display only products(production schema) with a standardcost below $110.00 (show productid, name only)
select productid, name
from production.product
where standardcost < 110.00

--3. display productid, name if its weight is unknown
select productid, name
from production.product
where weight is null

-- 4. display all products with a silver, black, or red color
select *
from production.product
where color in ('silver', 'black', 'red')

-- 5. display any product with a name starting with the letter b
select *
from production.product
where name like 'b%'

--6. run the following query
update production.productdescription
set description = 'chromoly steel_high of defects'
where productdescriptionid = 3

select description
from production.productdescription
where description like '%[_]%'

--7. calculate sum of totaldue for each orderdate in sales.salesorderheader table for the period between
-- '7/1/2001' and '7/31/2014'
select sum(totaldue)
from sales.salesorderheader
where orderdate between '7/1/2001' and '7/31/2014'
group by orderdate

-- 8. display the employees hiredate (note no repeated values are allowed)
select distinct hiredate
from humanresources.employee

-- 9. calculate the average of the unique listprices in the product table
select avg (distinct listprice)
from production.product

--10. display the product name and its listprice within the values of 100 and 120 the list should has the
--  following format "the [product name] is only! [list price]" (the list will be sorted according to 
-- its listprice value)
select concat('the ', name, ' is only! ', listprice)
from production.product
where listprice between 100 and 120
order by listprice

--11. a)	 transfer the rowguid ,name, salespersonid, demographics from sales.store table  in a newly created table named [store_archive]
--   note: check your database to see the new table and how many rows in it?
--   b)	try the previous query but without transferring the data?
select rowguid, name, salespersonid, demographics into store_archive
from sales.store

select *
from store_archive

select rowguid, name, salespersonid, demographics
from sales.store

--12. using union statement, retrieve the today’s date in different styles using convert or format function.
select datename(dw, getdate()) "day", datename(month, getdate()) "month", datename(year, getdate()) "year"
union
select convert (varchar, day(getdate())) "day" , convert (varchar, month(getdate())) "month" , year(getdate()) "year"
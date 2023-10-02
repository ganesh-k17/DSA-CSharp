/* 1. 
Write an SQL query to report the first name, last name, city, and state of each person in the Person
table. If the address of a personId is not present in the Address table, report null instead.

Person(personId, firstName, lastName), Address(addressId, personId, city, state)
*/
select p.personId, p.firstName, p.lastName, a.city, a.state
from person p
left join address a on p.personId = a.personId; 

/* 2 & 3.
Second Highest Salary
tag: Nth Highest Salary
Write an SQL query to report the second highest salary from the Employee table. If there is no second
highest salary, the query should report null.

employee (id, salary)
*/

SELECT DISTINCT salary
FROM employee
ORDER BY salary DESC
LIMIT 1 OFFSET 1;


SELECT DISTINCT salary
FROM (
  SELECT salary, DENSE_RANK() OVER (ORDER BY salary DESC) AS rank
  FROM employee
) ranked
WHERE rank = 2;


SELECT MAX(salary) 
FROM employee
WHERE salary < (SELECT MAX(salary) FROM employee);

/* 4
Write an SQL query to rank the scores, The ranking should e calculated according to the
2ollowing rules1
 The scores should be ranked 2rom the highest to the lowest+
 If there is a tie between two scores, both should have the same ranking+
 After a tie, the next ranking number should be the next consecutive integer value, In other
words, there should be no holes between ranks,
id is the primary key 2or this table.

Each row o2 this tale contains the score o2 a game,
Score is a floating point value with two decimal
places,
Return the result table ordered by score in descending order.

Table => Scores (int score)
*/



select score, dense_rank() over (order by score desc) as rank from scores


/* 5.
Write an SQL query to find all numbers that appear at least three times consecutively.

Table=> Logs( id int, num varchar)
*/

SELECT num
FROM (
    SELECT num, 
           LEAD(num, 1) OVER (ORDER BY id) AS next_num, 
           LAG(num, 1) OVER (ORDER BY id) AS prev_num
    FROM Logs
) t
WHERE num = next_num AND num = prev_num;


/* 6.
Write an sql query to find the employees who earn more than their managers

Table => Employee (id int, name varchar, salary int, managerId int)
*/

SELECT e1.name AS EmployeeName, e1.salary AS EmployeeSalary, e2.name AS ManagerName, e2.salary AS ManagerSalary
FROM Employee e1
INNER JOIN Employee e2 ON e1.managerId = e2.id
WHERE e1.salary > e2.salary;



SELECT name, salary
FROM Employee
WHERE salary > (SELECT salary FROM Employee AS M WHERE M.id = Employee.managerId);


/* 7.
Duplicate Emails
Write an SQL query to report all the duplicate emails. Note that it's guaranteed that the email
field is not NULL.

Table => person (id int, email varchar)
*/

SELECT email
FROM person
GROUP BY email
HAVING COUNT(email) > 1;

select email 
from (SELECT email, DENSE_RANK() OVER (PARTITION BY email ORDER BY id) AS rank FROM person) ranked 
where rank = 1


/* 8.
Customers Who Never Order
Write an SQL query to report all customers who never order anything.

Table => customers (id int, name varchar)
Table => orders (id int, customerID int)
*/

SELECT c.id, c.name
FROM customers c
LEFT JOIN orders o ON c.id = o.customerID
WHERE o.id IS NULL;


/* 9.
Department highest salary
Write sql query to find employees who have the highest salary in each of the departments

Table => Emplyoee (id int, name varchar, salary int, departmentID int)
Table => Department (id int, name varchar)
*/

-- approach 1  (using subquery)

select employee_name, department_name 
from (select 
	e.id, 
	e.name as employee_name, 
	d.name as department_name, 
    e.salary AS employee_salary,
	dense_rank() over (partition by d.id order by e.salary desc) rank 
	from 
		employee e 
	join
		department d on e.departmentID = d.id
 ) as ranked
where rank = 1

-- approach 2 (using cte)

WITH RankedEmployees AS (
    SELECT
        e.id AS employee_id,
        e.name AS employee_name,
        e.salary AS employee_salary,
        e.departmentID AS employee_department,
        d.name AS department_name,
        RANK() OVER (PARTITION BY d.id ORDER BY e.salary DESC) AS salary_rank
    FROM
        Employee e
    JOIN
        Department d ON e.departmentID = d.id
)

SELECT
    employee_id,
    employee_name,
    employee_salary,
    employee_department,
    department_name
FROM
    RankedEmployees
WHERE
    salary_rank = 1;

    -- here we can use rank() or dense_rank() both would have same result as we are taking only the top value.



/* 10

A company's executives are interested in seeing who earns the most money in each of the
company's departments. A high earner in a department is an employee who has a salary in the
top three unique salaries for that department.

Write an SQL query to find the employees who are high earners in each of the departments.

Table => Emplyoee (id int, name varchar, salary int, departmentID int)
Table => Department (id int, name varchar)
*/

-- approach 1

select employee_name, department_name , salary
from (select 
	e.id, 
	e.name as employee_name, 
	d.name as department_name, 
	e.salary,
	rank() over (partition by d.id order by e.salary desc) rank 
	from 
		employee e 
	join
		department d on e.departmentID = d.id
 ) as ranked
where rank <= 3 

-- approach 2

WITH RankedEmployees AS (
    SELECT
        e.id AS employee_id,
        e.name AS employee_name,
        e.salary AS employee_salary,
        e.departmentID AS employee_department,
        d.name AS department_name,
        dense_rank() OVER (PARTITION BY d.id ORDER BY e.salary DESC) AS rank
    FROM
        Employee e
    JOIN
        Department d ON e.departmentID = d.id
)

SELECT
    employee_name,
    department_name,
    employee_salary
FROM
    RankedEmployees
WHERE
    rank <= 3 ;


/* 11.

Delete Duplicate Emails
Question. 11
Write an SQL query to delete all the duplicate emails, keeping only one unique email with the
smallest id. Note that you are supposed to write a DELETE statement and not a SELECT one.

After running your script, the answer shown is the Person table. The driver will first compile and
run your piece of code and then show the Person table. The final order of the Person table does
not matter.

Table => person (id int, email varchar)

*/

-- approach 1

with rankedEmails as (
	SELECT id, email, DENSE_RANK() OVER (PARTITION BY email ORDER BY id) AS rank 
		FROM 
	person
)

delete person where id in ( select id from rankedEmails where rank > 1)

-- approach 2

WITH DuplicateEmails AS (
    SELECT
        email,
        DENSE_RANK() OVER (ORDER BY email) AS rank
    FROM
        person
)

DELETE FROM person
WHERE (email, rank) IN (
    SELECT email, rank
    FROM DuplicateEmails
    WHERE rank > 1
);


/* 12.
Rising Temperature
Question. 12
Write an SQL query to find all dates' Id with higher temperatures compared to its previous dates
(yesterday).

Table=> Weather (id int, recordDate date, temperature int)
*/

-- approach 1 (this could be okie if comparing previous recorded date.  
--             But the question is for previous day so the next solution is appropriate)

with lagTemperature as(
	select id, recordDate, lag(temperature, 1) over (order by recordDate) as lagTemperature, temperature 
    from Weather 
)

select id, recordDate, temperature from lagTemperature where temperature > lagTemperature

-- approach 2  (this would be appropriate as the previous date is calcuated)

SELECT
    w.id AS date_id,
    w.recordDate AS date,
    w.temperature AS current_temperature
FROM
    Weather w
JOIN
    Weather w_previous ON w.recordDate = DATEADD(day, 1, w_previous.recordDate)
WHERE
    w.temperature > w_previous.temperature;

/* 13.
Trips and Users

The cancellation rate is computed by dividing the number of canceled (by client or driver)
requests with unbanned users by the total number of requests with unbanned users on that
day.

Write a SQL query to find the cancellation rate of requests with unbanned users (both client and
driver must not be banned) each day between "2013-10-01" and "2013-10-03". Round
Cancellation Rate to two decimal points.

Table => Users (users_id int, banned enum, role enum)

*/


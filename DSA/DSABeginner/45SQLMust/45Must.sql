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
--Question 1 
select * from Works_on;

--Question 2
select Emp_no from Works_on where Job='Clerk';

--Question 3
select Emp_no from Works_on where Project_no='p2' and Emp_no<10000;

--Question 4
select Emp_no from Works_on where year(Entry_date)!=1998;

--Question 5
select Emp_no from Works_on where Project_no='p1' and (Job='Manager' or Job='Analyst');

--Question 6
select Entry_date from Works_on where (Job is null and Project_no='p2'); 

--Question 7
select Emp_no, Emp_lname from Employee where Emp_fname like '%t%t%';
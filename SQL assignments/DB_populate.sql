create database Company;
create table Department (
	Dept_no varchar(10) NOT NULL,
	Dept_name varchar(100) NOT NULL,
	Location varchar(100),
	PRIMARY KEY (Dept_no)
);
select * from Department;
insert into Department values('d1', 'Research', 'Dallas');
insert into Department values('d2', 'Accounting', 'Seattle');
insert into Department values('d3', 'Marketing', 'Dallas');


create table Employee (
	Emp_no int NOT NULL,
	Emp_fname varchar(100) NOT NULL,
	Emp_lname varchar(100) NOT NULL,
	Dept_no varchar(10) NOT NULL,
	PRIMARY KEY (Emp_no),
	FOREIGN KEY (Dept_no) REFERENCES Department(Dept_no)
);

select * from Employee;
insert into Employee values(25348, 'Matthew', 'Smith', 'd3');
insert into Employee values(10102, 'Ann', 'Jones', 'd3');
insert into Employee values(18316, 'John', 'Doe', 'd1');
insert into Employee values(29346, 'Walter', 'White', 'd2');
insert into Employee values(2581, 'Heisenberg', 'W', 'd1');

create table Project (
	Project_no varchar(10) NOT NULL,
	Project_name varchar(100) NOT NULL,
	Budget bigint,
	PRIMARY KEY (Project_no)
);

select * from Project;
insert into Project values('p1', 'Apollo',120000);
insert into Project values('p2', 'Gemini',95000);
insert into Project values('p3', 'Mercury',185600);


create table Works_on (
	Emp_no int NOT NULL REFERENCES Employee(Emp_no),
	Project_no varchar(10) NOT NULL REFERENCES Project(Project_no),
	Job varchar(100),
	Entry_date date,
	PRIMARY KEY (Emp_no, Project_no)
);
select * from Works_on;	
insert into Works_on values(10102, 'p1', 'Analyst', '1-10-1997');
insert into Works_on values(10102, 'p3', 'Manager', '1-1-1997');
insert into Works_on values(25348, 'p2', 'Clerk', '2-15-1998');
insert into Works_on(Emp_no, Project_no, Entry_date) values(18316, 'p2', '6-1-1998');
insert into Works_on(Emp_no, Project_no, Entry_date) values(29346, 'p2', '12-15-1997');
insert into Works_on values(2581, 'p3', 'Analyst', '10-15-1998');


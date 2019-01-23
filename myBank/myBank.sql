Create database myBank;
Use myBank;

Create table Customer
(
customerid int identity,
fname varchar(30),
lname varchar(30),
gender char,
dob varchar(30),
address varchar(30),
phonenumber varchar(30), 
balance float,
accountNo int ,
pinNo int,
Constraint pk_Customer primary key(customerid)
);
sp_help Customer;
select * from Customer;
drop table Transactions;
Create table Transactions
(
t_id int identity,
customerid int,
t_status varchar(25),
amount float,
constraint pk_Transactions primary key(t_id),
constraint fk_Transactions_customerid foreign key(customerid) references Customer
);
sp_help Transactions;
select * from Transactions;

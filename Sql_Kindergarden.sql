create database sd;
use StudentDb;

create table Student(St_Id int,St_Name varchar(30),St_Address varchar(34),St_DOB date);

insert into Student Values(1001,'dp','chennai','03/14/1999');

insert into Student Values(1002,'anil','chennai','08/19/1997');

insert into Student Values(1003,'prasad','England','05/23/1996');
select * from Student;


create table Teachers(T_Name varchar(44),St_Id int,T_Depart varchar(33),T_salart int);

insert into Teachers Values('sreeshant',1003,'english',20000);

insert into Teachers Values('Kiran',1003,'science',30000);

insert into Teachers Values('dileep',1003,'maths',25000);


insert into Teachers Values('ravi',1002,'social',29000);

insert into Teachers Values('vishnu',1002,'drawing',26000);

select * from Teachers;

create table Toys(toy_Name varchar(40),St_Id int,toy_cost int,toy_type varchar(55));

insert into Toys Values('Bike',1001,2300,'Plastic');

insert into Toys Values('Car',1002,300,'Iron');

insert into Toys Values('Bike',1002,450,'Wood');

select * from Toys;
select *from Student;
select *from Teachers;


create database cafe
use cafe
create table items(
iid int identity (1,1) primary key, 
name varchar(250) not null, 
category varchar(250) not null, 
price bigint not null
);

SET IDENTITY_INSERT items ON

INSERT INTO items
            (iid,name,category,price)
VALUES     ('3','Dosa','South Indian','40')


name,category, price

select * from items


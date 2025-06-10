
create database agent; 

use agent;

create table Chamado (
id int auto_increment,
nome varchar (150) not null,
service varchar (50),
datahora datetime ,
observacao varchar (200),
primary key (id)
);


drop table Chamado;

select * from chamado;
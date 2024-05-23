create database app_hdp2;
use app_hdp2;

create table usuario (
	id int primary key identity (1,1) not null,
	usuario varchar(20) not null,
	clave varchar(30) not null,
	nombre varchar(40) not null,
	apellido varchar(40) not null,
	roll int not null,
	foreign key (roll) references roll(id)
);

create table venta(
	id int primary key identity (1,1) not null,
	producto int,
	fecha date,
	cliente int not null,
	foreign key (producto) references producto(id),
	foreign key (cliente) references cliente (id)
);

create table roll (
	id int primary key identity (1,1) not null,
	descripcion varchar(40)
);

create table cliente (
	id int primary key identity (1,1) not null,
	nombre varchar (40) not null,
	apellido varchar(40) not null,
	direccion varchar(40) not null
);

create table producto (
	id int primary key identity (1,1) not null,
	nombre varchar(40),
	precio int not null
);


/*create table categoria(
	id int primary key identity (1,1) not null,
	nombre varchar(50)
);*/

drop table categoria;

insert into roll (descripcion) values ('administrador');
insert into roll (descripcion) values ('vendedor');

insert into usuario (usuario,clave,nombre,apellido,roll) values ('sebasl','123456','sebastian','lopez',1);
insert into usuario (usuario,clave,nombre,apellido,roll) values ('luism','123456','luis','mena',2);

insert into categoria (nombre) values ('tecnologia');
insert into categoria (nombre) values ('hogar');

select id,usuario,clave,nombre,apellido,roll from usuario where id=1;
select * from usuario;
select * from roll;
select * from producto;
select * from categoria;
select * from venta;

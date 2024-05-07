create database app_hdp2;
use app_hdp2;

create table usuario (
	id int primary key identity (1,1) not null,
	usuario varchar(20) not null,
	clave varchar(30) not null,
	nombre varchar(40) not null,
	apellido varchar(40) not null,
	roll int not null,
);

create table venta(
	id int primary key identity (1,1) not null,
	fecha date
	vendedor int not null,
	foreign key (vendedor) references usuario (id)
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
	precio decimal(10,2),
	categoria int not null,
	foreign key (categoria) references categoria (id)
);

create table categoria(
	id int primary key identity (1,1) not null,
	nombre varchar(50)
)

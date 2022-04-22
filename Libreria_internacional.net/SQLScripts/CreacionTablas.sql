create database LibreriaInternacional
use LibreriaInternacional
create table Usuarios(
id int IDENTITY(1,1) primary key,
usuario varchar(30) NOT NULL,
passw varchar (30) NOT NULL,
email varchar(30) NOT NULL,
);

drop table dbo.Libros

create table Libros(
isbn varchaR(50) UNIQUE not null,
titulo varchar(30) not null,
autor varchar(30) not null,
anioPublicacion varchar(30) not null,
foto varchar(100) not null,
precio float not null
);
use LibreriaInternacional

create table LibrosFavoritos(
isbn varchar(50) primary key not null,
usuario varchar(30) not null,
constraint fk_favoritos foreign key(isbn) references dbo.Libros(isbn)
);

select * from LibrosFavoritos

truncate table dbo.LibrosFavoritos
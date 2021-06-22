create database testoriontek
;

create table Clientes(
IdCliente int identity(1,1) not null primary key,
Nombre varchar(50),
Apellido varchar(50),
Cedula varchar(15),
Telefono varchar(15)
)
;

create table Direcciones(
IdDireccion int identity(1,1) primary key,
DescDireccion varchar(100),
IdCliente int not null,
constraint fk_dir_clt foreign key(IdCliente) references Clientes
)
;

select * from Clientes
--Script

create database DataBank
go
use DataBank
go

CREATE TABLE Cliente(
	IdCliente int NOT NULL identity unique, --hice unico este campo
	Nombre varchar(50) NOT NULL,
	Apellido varchar(50) NOT NULL,
	Direccion varchar(80) NOT NULL,
	Telefono varchar(10) NOT NULL,
	Cedula varchar(11) NOT NUll primary key --Hice clave primaria la cedula
	)
	go
	--insert into Cliente values('Kelvin','Perez','El vergel','8896635523','2369587469')
	CREATE TABLE Prestamo(
	Cedula varchar(11) not null,
	IdPrestamo int NOT NULL primary key identity,
	Monto money NOT NULL,
	Interes int NOT NULL, --Hice cambio en el tipo
	Tiempo_Meses int NOT NULL, -- Hice cambio en el tipo
	--FechaCierre date not null, -- Agregue esto
	Cuota money NOT NULL,
	Monto_Adeudado money NOT NULL,
	Constraint fk_cliente foreign key(Cedula) references Cliente
	)
	

	select c.*,p.*  from Cliente c
	join Prestamo p on c.IdCliente=p.IdCliente;

	create proc sp_listar
	as
	select c.*,p.*  from Cliente c
	join Prestamo p on c.IdCliente=p.IdCliente;

	
	
	create proc sp_listarClientes
	as
	select Cliente.* from Cliente;

	create proc sp_listarPrestamos -- crearlo
	as
	select Prestamo.* from Prestamo;

	drop table Prestamo


	drop table Cliente;
	go
	drop table Prestamo;
	
	select * from Prestamo
	
	create proc sp_listarConsulta
	as
	Select c.Cedula, c.Nombre, c.Apellido, p.*  from Cliente as c join Prestamo as p on c.Cedula=p.Cedula where p.Cedula = '2369587467'

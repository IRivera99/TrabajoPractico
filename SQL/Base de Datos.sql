create database CarreraDB
GO

use CarreraDB
go

SET DATEFORMAT DMY

--Carreras--
create table Carreras(
idCarrera int identity (1,1),
nCarrera varchar(100) not null,
titulo varchar(100) null,
constraint pkCarrera primary key (idCarrera)
)
go

--Asignaturas--
create table Asignaturas(
idAsignatura int identity (1,1),
nAsignatura varchar(100) not null,
constraint pkAsignatura primary key (idAsignatura),
)
go

--Detalle Carreras--
create table DetalleCarreras(
idCarrera int not null,
idAsignatura int not null,
aCursado int not null,
cuatrimestre int  not null,
constraint pkDetalle primary key (idAsignatura, idCarrera),
constraint fkDetalleCarrera foreign key (idCarrera)
	references Carreras (idCarrera),
constraint fkDetalleAsignatura foreign key (idAsignatura)
	references Asignaturas (idAsignatura),
)
go

--Usuarios--
create table Usuarios(
nUsuario varchar(100) not null,
contraseña varchar(20) not null,
constraint pkUsuario primary key (nUsuario, contraseña)
)

insert into Usuarios(nUsuario,contraseña) values('admin','admin')


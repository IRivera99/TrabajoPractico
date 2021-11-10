use CarreraDB
go

--CARRERA--
create proc SP_INSERTAR_CARRERA
	@nCarrera varchar(100),
	@titulo varchar(150),
	@idCarrera int out
as
begin
	insert into carreras (nCarrera, titulo)
	values (@nCarrera, @titulo)
	set @idCarrera = SCOPE_IDENTITY()
end
go

create proc SP_BORRAR_CARRERA
	@idCarrera int
as
begin
	delete DetalleCarreras
	where idCarrera = @idCarrera
	delete Carreras
	where idCarrera = @idCarrera
end
go

create proc SP_MODIFICAR_CARRERA
	@idCarrera int,
	@nCarrera varchar(100),
	@titulo varchar(100)
as
begin
	update Carreras
	set nCarrera = @nCarrera,
		titulo = @titulo
	where idCarrera = @idCarrera
end
go

create proc SP_CONSULTAR_CARRERAS
as
begin
	select idCarrera,nCarrera from Carreras
end
go

create proc SP_COSULTAR_CARRERAS_ID
as
begin
	select idCarrera from Carreras
	order by nCarrera
end
go

create proc SP_PROXIMO_ID_CARRERA
	@proximo int out
as
begin
	set @proximo = (select MAX(idCarrera)+1 from Carreras)
end
go

create proc SP_CONSULTAR_CARRERA_POR_ID
	@idCarrera int
as
begin
	select * from Carreras
	where idCarrera = @idCarrera
end
go

create proc SP_CONSULTAR_CARRERA_POR_IDREPORTE
    @idCarrera int
as
begin
    select nCarrera, titulo, aCursado, cuatrimestre, nAsignatura
    from asignaturas a join DetalleCarreras d on a.idAsignatura = d.idAsignatura
    join carreras c on c.idCarrera = d.idCarrera
    where c.idCarrera = @idCarrera
end

--ASIGNATURA--
create proc SP_INSERTAR_ASIGNATURA
	@nombre varchar(100)
as
begin
	insert into Asignaturas (nAsignatura)
	values (@nombre)
end
go

create proc SP_BORRAR_ASIGNATURA
	@idAsignatura int
as
begin
	delete DetalleCarreras
	where idAsignatura = @idAsignatura
	delete Asignaturas
	where idAsignatura = @idAsignatura	
end
go

create proc SP_MODIFICAR_ASIGNATURA
	@idAsignatura int,
	@nAsignatura varchar (100)
as
begin
	update Asignaturas
	set nAsignatura = @nAsignatura
	where idAsignatura = @idAsignatura
end
go

create proc SP_COSULTAR_ASIGNATURAS
as
begin
	select * from Asignaturas
	order by nAsignatura
end
go

create proc SP_COSULTAR_ASIGNATURAS_ID
as
begin
	select idAsignatura from Asignaturas
	order by nAsignatura
end
go

create proc SP_PROXIMO_ID_ASIGNATURA
	@proximo int out
as
begin
	set @proximo = (select MAX(idAsignatura)+1 from Asignaturas)
end
go

--DETALLESCARRERAS--

create proc SP_INSERTAR_DETALLESCARRERAS
	@idCarrera int,
	@idAsignatura int,
	@aCursado int,
	@cuatrimestre int
as
begin
	insert into DetalleCarreras(idCarrera, idAsignatura, aCursado, cuatrimestre)
	values (@idCarrera, @idAsignatura, @aCursado, @cuatrimestre)
end
go

create proc SP_BORRAR_DETALLESCARRERAS
	@idCarrera int
as
begin
	delete DetalleCarreras
	where idCarrera = @idCarrera
end
go

create proc SP_CONSULTAR_DETALLESCARRERAS
	@idCarrera int
as
begin
	select a.idAsignatura, a.nAsignatura, aCursado, cuatrimestre
	from DetalleCarreras dc
	join Asignaturas a on dc.idAsignatura=a.idAsignatura
	where dc.idCarrera = @idCarrera
end
go

--USUARIOS--

create proc SP_CONSULTAR_USUARIO
	@usuario varchar(100),
	@contraseña varchar(20),
	@valido bit out
as
begin
	if exists(select * from Usuarios where nUsuario like @usuario and contraseña like @contraseña)
	begin
		set @valido = 1
		return
	end
	else
	begin
		set @valido = 0
		return
	end
end
go

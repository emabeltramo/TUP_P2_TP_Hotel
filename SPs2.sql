--MODIFICAR CLIENTE
CREATE PROCEDURE SP_MODIFICAR_CLIENTE
@id int,@nombre varchar(50),@apellido varchar(50),@tdoc int,
@dni int, @email varchar(100), @tCliente int , @razonSoc varchar(50),@celular int
AS 
BEGIN 
	UPDATE CLIENTES
	SET 
		NOMBRE = @nombre,
		APELLIDO = @apellido,
		TIPO_DOCUMENTO =@tdoc ,
		DNI = @dni, 
		EMAIL = @email ,
		CELULAR = @celular,
		tipo_cliente = @tCliente, 
		Razon_Social = @razonSoc
	WHERE ID = @id
END;

--INSERTAR CLIENTE
CREATE PROCEDURE SP_INSERTAR_CLIENTE
@nombre varchar(50),@apellido varchar(50),@tdoc int,@cuil int,
@dni int, @email varchar(100), @tCliente int , @razonSoc varchar(50),@celular int
AS 
BEGIN 
	INSERT INTO CLIENTES(NOMBRE,APELLIDO,TIPO_DOCUMENTO,DNI,CUIL,EMAIL,CELULAR,
	tipo_cliente,Razon_Social)
	VALUES(@nombre,@apellido,@tdoc ,@dni,@cuil, @email ,@celular, @tCliente, @razonSoc)
END;

--BORRAR CLIENTE
CREATE PROCEDURE SP_BORRAR_CLIENTE
@id int
AS 
BEGIN 
	DELETE FROM CLIENTES 
	WHERE ID=@id
END;

--SELECT TIPOCLIENTE
CREATE PROCEDURE SP_CONSULTAR_TIPOCLIENTE

AS 
BEGIN 
	SELECT * FROM TIPOS_CLIENTES
END;

--SELECT TIPODOCUMENTO
CREATE PROCEDURE SP_CONSULTAR_TIPODOCUMENTO

AS 
BEGIN 
	SELECT * FROM TIPO_DOCUMENTOS
END;

--LISTAR CLIENTES
CREATE PROCEDURE SP_LISTA_CLIENTES
AS
BEGIN
	SELECT C.NOMBRE 'Nombre',C.APELLIDO'Apellido',T.TIPO_DOCUMENTO 'Tipo Documento',C.DNI 'Numero Documento',
	C.CUIL 'Numero CUIL',C.EMAIL 'Email',C.CELULAR 'Celular',TC.Descripcion 'Tipo Cliente',C.Razon_Social 'Razon Social'
	FROM CLIENTES C 
	JOIN TIPO_DOCUMENTOS T ON C.TIPO_DOCUMENTO = T.ID 
	JOIN TIPOS_CLIENTES TC ON C.tipo_cliente = TC.ID
	ORDER BY 1
END


create procedure ps_HabDisponibles @desde date, @hasta date, @hotel int
as
begin
select HABITACION_HOTEL.ID as 'Id_Habitacion',HABITACION_HOTEL.CODIGO as 'Codigo_Habitacion',
HABITACION_HOTEL.CAMA_MAX,HABITACION_HOTEL.TELEFONO,
CATEGORIA_HABITACIONES.ID as 'Id_Categoria',CATEGORIA_HABITACIONES.DESCRIPCION,CATEGORIA_HABITACIONES.PRECIO
from HABITACION_HOTEL
inner join PISOS_HOTEL on PISOS_HOTEL.ID=HABITACION_HOTEL.PISO
inner join HOTELES on PISOS_HOTEL.HOTEL=HOTELES.ID
inner join CATEGORIA_HABITACIONES on HABITACION_HOTEL.CATEGORIA=CATEGORIA_HABITACIONES.ID
where HABITACION_HOTEL.ID not in (
select HABITACION from RESERVA_HABITACIONES 
inner join RESERVAS on RESERVAS.ID=RESERVA_HABITACIONES.RESERVA
where RESERVAS.ESTADO!=3 and
(@desde between INGRESO and SALIDA or @hasta between INGRESO and SALIDA) or 
( INGRESO between @desde and @hasta or SALIDA between @desde and @hasta) 
) and HOTELES.ID=@hotel and HOTELES.HABILITADO=1
end;



create procedure ps_InsertReserva
@cliente int,
@ingreso date,
@salida date,
@empleado int,
@id int output
as
begin
insert into RESERVAS(ESTADO,CLIENTE,INGRESO,SALIDA,FECHA_RESERVA,Empleado)
values (1,@cliente,@ingreso,@salida,GETDATE(),@empleado);
select @id= SCOPE_IDENTITY();
end;



create procedure ps_InsertReservaHabitacion
@reserva int,
@habitacion int,
@monto int
as
begin
insert into RESERVA_HABITACIONES(RESERVA,HABITACION,MONTO_HABITACION)
values (@reserva,@habitacion,@monto);
end;

create procedure ps_InsertReservaCuenta
@reserva int,
@servicio int,
@monto decimal(10,2),
@bonificado bit,
@cantidad int
as
begin
insert into RESERVA_CUENTA(RESERVA,SERVICIO,MONTO,BONIFICADO,CANTIDAD)
values (@reserva,@servicio,@monto,@bonificado,@cantidad);
end;
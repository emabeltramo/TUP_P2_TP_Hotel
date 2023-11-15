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



exec SP_CONSULTAR_TIPOCLIENTE


select * from CLIENTES 


-----------------------------MODIFICACION PARA LABO--------------------------------
CREATE TABLE CONSULTAS(
id int identity(1,1),
nombre varchar(25),
enunciado varchar(1000),
sentencia varchar(1500),
primary key (id)
);

INSERT INTO CONSULTAS(nombre,enunciado,sentencia)
values 
('CONSULTA 4',
'4. Se quiere realizar un reporte por cliente y año, indicando la cantidad de
reservas, el promedio de días que se alojan y el total facturado',
    'create view view_Reporte_Clientes as
    select YEAR(FACTURAS.FECHA) ''Año'', CLIENTES.ID ''Cliente_ID'',
        iif(Razon_Social is not null, Razon_Social, APELLIDO + '' '' + nombre) ''Cliente_Nombre'',
        count(distinct RESERVA) ''Reservas'', SUM(CANTIDAD * MONTO) ''Total'',
        (
            select AVG(CANTIDAD)
            from FACTURAS f
            inner join FACTURA_DETALLES fd on f.ID = fd.FACTURA
            where fd.SERVICIO = 14 and YEAR(FACTURAS.FECHA) = YEAR(f.FECHA)
                and CLIENTES.ID = f.CLIENTE
        ) ''Promedio_Dias''
    from CLIENTES
    inner join FACTURAS on CLIENTES.ID = FACTURAS.CLIENTE
    inner join FACTURA_DETALLES on FACTURAS.ID = FACTURA_DETALLES.FACTURA
    inner join RESERVAS on FACTURAS.RESERVA = RESERVAS.ID
    group by CLIENTES.ID, NOMBRE, APELLIDO, Razon_Social, YEAR(FACTURAS.FECHA);
    go
    Select * from view_Reporte_Clientes order by Año, Cliente_Nombre;'
)

INSERT INTO CONSULTAS(nombre,enunciado,sentencia)
values 
('CONSULTA 5',
'5. Se quiere implementar un sistema de premio anual al empleado que
realice más ventas, pero no debe tener más de x% de reservas anuladas','CREATE PROCEDURE Sp_PremioAnual
    @año int,
    @porcen decimal(5,2)
    AS
    BEGIN
        SELECT TOP(1) EMPLEADO,
        ''LEGAJO'', CONCAT(APELLIDO, SPACE(1), nombre) ''Nombre'',
        SUM(MONTO * CANTIDAD) ''Monto Acumulado x venta''
        FROM FACTURAS
        INNER JOIN FACTURA_DETALLES ON FACTURAS.ID = FACTURA_DETALLES.FACTURA
        INNER JOIN EMPLEADO ON FACTURAS.EMPLEADO = EMPLEADO.legajo
        WHERE YEAR(FECHA) = @año AND
        (
            SELECT COUNT(*)
            FROM RESERVAS
            WHERE Empleado = FACTURAS.EMPLEADO AND
            YEAR(RESERVAS.FECHA_RESERVA) = @año AND ESTADO = 3
        ) / (
            SELECT COUNT(*)
            FROM RESERVAS
            WHERE Empleado = FACTURAS.EMPLEADO AND
            YEAR(RESERVAS.FECHA_RESERVA) = @año AND ESTADO = 2
        ) * 100 <= @porcen
        GROUP BY EMPLEADO, APELLIDO, NOMBRE
        ORDER BY 3 DESC
    END;
    EXEC Sp_PremioAnual 2022, 5;'
);

INSERT INTO CONSULTAS(nombre,enunciado,sentencia)
values 
('CONSULTA 7','7. Se desea conocer la cantidad de reservas cuyo estado sea pagado, la
cantidad de habitaciones reservadas y su categoría, el monto total de las
habitaciones donde la fecha de la reserva oscile entre 2020 y 2023, que
hayan sido reservada para clientes cuyo apellido termine con la letra a
por año , estado, habitación, categoría y nombre completo del cliente
para aquellos casos donde el promedio del monto de las habitaciones
sea menor que el monto total de habitaciones a nivel global','select COUNT(r.ID) ''Cantidad de reservas '',
    year(r.FECHA_RESERVA) ''Anio de reserva'',
    er.DESCRIPCION ''Estado'',
    Count(hh.ID) ''Cantidad de Habitaciones'',
    ch.DESCRIPCION ''Categoria Habitacion'',
    c.APELLIDO + SPACE(1) + c.NOMBRE ''Nombre Cliente'',
    sum(rh.MONTO_HABITACION) ''Monto Total Habitaciones''
    from RESERVAS r
    join ESTADOS_RESERVA er on r.ESTADO = er.ID
    join RESERVA_HABITACIONES rh on r.ID = rh.RESERVA
    join HABITACION_HOTEL hh on hh.id = rh.HABITACION
    join CATEGORIA_HABITACIONES ch on ch.id = hh.CATEGORIA
    join CLIENTES c on c.ID = r.CLIENTE
    where YEAR(r.FECHA_RESERVA) between 2020 and 2023 and c.APELLIDO like ''%a''
    and er.DESCRIPCION = ''Pagado''
    group by year(r.FECHA_RESERVA), er.DESCRIPCION, ch.DESCRIPCION, c.APELLIDO, c.NOMBRE
    having avg(rh.MONTO_HABITACION) < (select sum(rh1.MONTO_HABITACION) from RESERVA_HABITACIONES rh1)'
);

INSERT INTO CONSULTAS(nombre,enunciado,sentencia)
values 
('CONSULTA 9','9. Crear un procedimiento almacenado que obtenga estadísticas mensuales
de clientes y montos recaudados, y el servicio más solicitado. Las estadísticas
incluyen la cantidad de clientes que ingresan, el mes y año de las
transacciones, el monto total recaudado y la mayor cantidad de detalles de
factura registrada en un mes. Se debe usar como parametro el año a ingresar', 'CREATE PROCEDURE SP_CLIENTES_MES_AÑO
    @año int
    AS
    BEGIN
        SELECT count(f.CLIENTE) Cantidad, MONTH(F.FECHA) Mes, YEAR(F.FECHA) Año,
        SUM(D.MONTO) Total, max(d.cantidad) MayorCantidad
        FROM FACTURAS F JOIN CLIENTES C ON F.CLIENTE = C.ID
        JOIN FACTURA_DETALLES D ON F.ID = D.FACTURA
        JOIN FACTURAS_FORMAS_PAGO fp ON fp.FACTURA = f.id
        JOIN FORMAS_PAGOS p ON p.ID = fp.FORMA_PAGO
        WHERE YEAR(f.fecha) = @año
        GROUP BY MONTH(F.FECHA), YEAR(F.FECHA)
    END;
    exec SP_CLIENTES_MES_AÑO 2021;'
);

INSERT INTO CONSULTAS(nombre,enunciado,sentencia)
values 
('-','',''
);


CREATE PROCEDURE SP_CONSULTA_4
AS
BEGIN
Select * from view_Reporte_Clientes order by Año, Cliente_Nombre;
END

CREATE PROCEDURE SP_CONSULTA_5
@año int,
@porcen decimal(5,2)
AS
BEGIN
exec Sp_PremioAnual @año, @porcen
END

CREATE PROCEDURE SP_CONSULTA_7
AS
BEGIN
	select COUNT(r.ID) 'Cantidad de reservas ',
	year(r.FECHA_RESERVA) 'Anio de reserva',
	er.DESCRIPCION 'Estado',
	Count (hh.ID) 'Cantidad de Habitaciones',
	ch.DESCRIPCION 'Categoria Habitacion',
	c.APELLIDO+SPACE(1)+c.NOMBRE 'Nombre Cliente',
	sum(rh.MONTO_HABITACION) 'Monto Total Habitaciones'
	from RESERVAS r join ESTADOS_RESERVA er on r.ESTADO=er.ID
	join RESERVA_HABITACIONES rh on r.ID=rh.RESERVA
	join HABITACION_HOTEL hh on hh.id=rh.HABITACION
	join CATEGORIA_HABITACIONES ch on ch.id=hh.CATEGORIA
	join CLIENTES c on c.ID=r.CLIENTE
	where YEAR(r.FECHA_RESERVA) between 2020 and 2023 and c.APELLIDO like
	'%a'
	and er.DESCRIPCION='Pagado'
	group by
	year(r.FECHA_RESERVA),er.DESCRIPCION,ch.DESCRIPCION,c.APELLIDO,c.NOMBRE
	having avg(rh.MONTO_HABITACION)<(select sum(rh1.MONTO_HABITACION) from
	RESERVA_HABITACIONES rh1 )
END

CREATE PROCEDURE SP_CONSULTA_9
@año int
AS
BEGIN
exec SP_CLIENTES_MES_AÑO @año
END


--MODIFIQUE PS Sp_PremioAnual
create procedure  Sp_PremioAnual @año int, @porcen decimal(5,2) as
begin
select top(1)EMPLEADO'LEGAJO',CONCAT(APELLIDO,SPACE(1),nombre)'Nombre',SUM(MONTO*CANTIDAD)
'Monto Acumulado x venta'
from FACTURAS
inner join FACTURA_DETALLES on FACTURAS.ID= FACTURA_DETALLES.FACTURA
inner join EMPLEADO on FACTURAS.EMPLEADO=EMPLEADO.legajo
where YEAR(FECHA)=@año and
(select count(*) from RESERVAS
where Empleado=FACTURAS.EMPLEADO and
YEAR(RESERVAS.FECHA_RESERVA)=@año and ESTADO=3
)/(
select count(*) from RESERVAS
where Empleado=FACTURAS.EMPLEADO and
YEAR(RESERVAS.FECHA_RESERVA)=@año and ESTADO=2
)*100<=@porcen
group by EMPLEADO,APELLIDO,NOMBRE
order by 3 desc
end
go

CREATE PROCEDURE SP_CONSULTAS
AS
BEGIN 
	SELECT * FROM CONSULTAS;
END

GO

CREATE PROCEDURE SP_CONSULTA_TXT
@nombre varchar(15)
AS
BEGIN 
	SELECT c.enunciado,c.sentencia FROM CONSULTAS c WHERE c.nombre LIKE '%'+@nombre+'%';
END

select * from CONSULTAS

EXEC SP_CONSULTA_TXT 'CONSULTA 4';


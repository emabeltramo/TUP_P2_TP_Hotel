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
sentencia varchar(4500),
primary key (id)
);
go
INSERT INTO CONSULTAS(nombre,enunciado,sentencia)
values 
('CONSULTA 1','1. Crear un procedimiento de almacenado donde, dado un piso especifico, liste por nombre del hotel, habitación y su categoría, el importe total recaudado en este
año que supere los 300$ sin contar a los clientes que hallan alquilado alguna vez las habitaciones de la planta baja, su estado no debe ser "anulado".','CREATE PROCEDURE sp_RecaudacionPorHabitacion
    @piso int 
    AS
    BEGIN
        SELECT h.NOMBRE ''Hotel'', hh.CODIGO ''Habitacion'', ch.DESCRIPCION
        ''Categoria de Habitacion'', SUM(rh.MONTO_HABITACION * DATEDIFF(day,
        r.INGRESO, r.SALIDA)) ''Importe Total''
        FROM RESERVAS r 
        JOIN RESERVA_HABITACIONES rh ON r.ID = rh.RESERVA
        JOIN HABITACION_HOTEL hh ON hh.ID = rh.HABITACION
        JOIN PISOS_HOTEL ph ON ph.ID = hh.PISO
        JOIN CATEGORIA_HABITACIONES ch ON ch.ID = hh.CATEGORIA
        JOIN HOTELES h ON h.ID = ph.HOTEL
        WHERE YEAR(r.FECHA_RESERVA) = YEAR(GETDATE()) AND NIVEL = @piso AND
        r.ESTADO != 3 AND
        r.CLIENTE NOT IN (SELECT DISTINCT CLIENTE
        FROM RESERVAS r2 
        JOIN RESERVA_HABITACIONES rh2 ON r2.ID = rh2.RESERVA
        JOIN HABITACION_HOTEL hh2 ON hh2.ID = rh2.HABITACION
        JOIN PISOS_HOTEL ph2 ON ph2.ID = hh2.PISO
        WHERE NIVEL = 1)
        GROUP BY h.NOMBRE, hh.CODIGO, ch.DESCRIPCION
        HAVING SUM(rh.MONTO_HABITACION * DATEDIFF(day, r.INGRESO, r.SALIDA)) > 300;
    END;
	exec sp_RecaudacionPorHabitacion @piso = 2
	exec sp_RecaudacionPorHabitacion @piso = 4
    '
);


INSERT INTO CONSULTAS(nombre,enunciado,sentencia)
values 
('CONSULTA 3',
'3. Se crear procedimiento de almacenado para visualizar número de factura, Cliente con nombre y apellido y documento, fecha de ingreso, salida, el
código de la habitación , número de piso , el hotel con la dirección, el empleado que facturó, reserva y el total de la reserva. Tener en cuenta
que solo hicimos con los parámetros de numero de factura, pero también se puede extender a otros casos siguiendo dicha lógica.',
    'CREATE PROCEDURE sp_consulta_reserva
    @tipo_cliente INT,
    @nro_factura INT
    AS
    BEGIN
        IF EXISTS (SELECT 1 FROM TIPOS_CLIENTES t1 WHERE t1.ID = @tipo_cliente) AND (@tipo_cliente = 1) 
        BEGIN
            IF EXISTS (SELECT 1 FROM FACTURAS f1 WHERE f1.N_FACTURA = @nro_factura)
            BEGIN
                SELECT f.N_FACTURA ''Factura'', CONCAT(''Nombre y Apellido: '', c.NOMBRE, '' '', c.APELLIDO,
                '' |DNI '', C.DNI) ''Cliente'',
                r.INGRESO ''Ingreso'', r.SALIDA ''Salida'', e.DESCRIPCION ''Estado'',
                h.CODIGO ''Habitación'', p.NIVEL ''Piso'',
                CONCAT(''Hotel: '', ho.NOMBRE, ''Direccion: '', ho.DIRECCION, '' |Localidad: '', l.NOMBRE) ''Hotel'',
                CONCAT(''Nombre y Apellido: '', em.NOMBRE, '' '', Em.APELLIDO, '' |Legajo: '', em.legajo) ''Empleado'',
                SUM(fa.CANTIDAD * fa.MONTO) ''Total''
                FROM FACTURAS f JOIN CLIENTES c ON f.CLIENTE = c.ID
                JOIN RESERVAS r ON f.RESERVA = r.ID
                JOIN ESTADOS_RESERVA e ON r.ESTADO = e.ID
                JOIN EMPLEADO em ON r.Empleado = em.legajo
                JOIN RESERVA_HABITACIONES re ON r.ID = re.RESERVA
                JOIN HABITACION_HOTEL h ON h.ID = re.HABITACION
                JOIN PISOS_HOTEL p ON h.PISO = p.ID
                JOIN HOTELES ho ON p.HOTEL = ho.ID
                JOIN LOCALIDADES l ON l.ID_LOCALIDAD = ho.LOCALIDAD
                JOIN FACTURA_DETALLES fa ON fa.FACTURA = f.ID
                WHERE f.N_FACTURA = @nro_factura AND e.ID = 2 
                GROUP BY f.N_FACTURA, c.NOMBRE, c.APELLIDO, C.DNI, r.INGRESO, r.SALIDA, e.DESCRIPCION,
                h.CODIGO, p.NIVEL, ho.NOMBRE, ho.DIRECCION, l.NOMBRE, em.NOMBRE, Em.APELLIDO, em.legajo;		
            END
            ELSE
            BEGIN
                SELECT ''No existe este nro_factura'' Mensaje;
            END
        END
        ELSE
        BEGIN
            IF EXISTS (SELECT 1 FROM FACTURAS f1 WHERE f1.N_FACTURA = @nro_factura)
            BEGIN
                SELECT f.N_FACTURA ''Factura'', CONCAT(''Razon Social: '', c.Razon_Social, '' '',
                '' |CUIL: '', C.CUIL) ''Cliente'',
                r.INGRESO ''Ingreso'', r.SALIDA ''Salida'', e.DESCRIPCION ''Estado'',
                h.CODIGO ''Habitación'', p.NIVEL ''Piso'',
                CONCAT(''Hotel: '', ho.NOMBRE, ''Direccion: '', ho.DIRECCION, '' |Localidad: '', l.NOMBRE) ''Hotel'',
                CONCAT(''Nombre y Apellido: '', em.NOMBRE, '' '', Em.APELLIDO, '' |Legajo: '', em.legajo) ''Empleado'',
                SUM(fa.CANTIDAD * fa.MONTO) ''Total''
                FROM FACTURAS f JOIN CLIENTES c ON f.CLIENTE = c.ID
                JOIN RESERVAS r ON f.RESERVA = r.ID
                JOIN ESTADOS_RESERVA e ON r.ESTADO = e.ID
                JOIN EMPLEADO em ON r.Empleado = em.legajo
                JOIN RESERVA_HABITACIONES re ON r.ID = re.RESERVA
                JOIN HABITACION_HOTEL h ON h.ID = re.HABITACION
                JOIN PISOS_HOTEL p ON h.PISO = p.ID
                JOIN HOTELES ho ON p.HOTEL = ho.ID
                JOIN LOCALIDADES l ON l.ID_LOCALIDAD = ho.LOCALIDAD
                JOIN FACTURA_DETALLES fa ON fa.FACTURA = f.ID 
                JOIN TIPOS_CLIENTES t ON c.ID = t.ID
                where f.N_FACTURA = @nro_factura and e.ID = 2 
			group by f.N_FACTURA,c.NOMBRE,c.APELLIDO,C.DNI,r.INGRESO,r.SALIDA,e.DESCRIPCION,
			h.CODIGO,p.NIVEL,ho.NOMBRE,ho.DIRECCION,l.NOMBRE,em.NOMBRE,Em.APELLIDO,em.legajo;		
		end
		else
		begin
			select''No existe este nro_factura'' Mensaje;
		end		
	end
end
exec sp_consulta_reserva 1,10001
exec sp_consulta_reserva 2,1000'
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
('CONSULTA 9','9. Crear un procedimiento almacenado que obtenga estadísticas mensuales de clientes y montos recaudados, y el servicio más solicitado. Las estadísticas
incluyen la cantidad de clientes que ingresan, el mes y año de las transacciones, el monto total recaudado y la mayor cantidad de detalles de
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



CREATE PROCEDURE SP_CONSULTA_1
@piso int
AS
BEGIN
exec sp_RecaudacionPorHabitacion @piso
END

CREATE PROCEDURE SP_CONSULTA_3
@tipo_cliente int,
@nro_factura int
AS
BEGIN
exec sp_consulta_reserva @tipo_cliente,@nro_factura 
END
go
CREATE PROCEDURE SP_CONSULTA_5
@año int,
@porcen decimal(5,2)
AS
BEGIN
	EXEC Sp_PremioAnual @año, @porcen;
END
go
CREATE PROCEDURE SP_CONSULTA_9
@año int
AS
BEGIN
exec SP_CLIENTES_MES_AÑO @año
END


--MODIFIQUE PS Sp_PremioAnual
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


CREATE PROCEDURE SP_CLIENTES
AS
BEGIN 
	SELECT * FROM TIPOS_CLIENTES
END





create procedure sp_consulta_reserva
	@tipo_cliente int,
	@nro_factura int
as
begin 
	if exists (select 1 from TIPOS_CLIENTES t1 where t1.ID = @tipo_cliente) and (@tipo_cliente = 1) 
	begin
		if exists (select 1 from FACTURAS f1 where f1.N_FACTURA= @nro_factura)
		begin
			select f.N_FACTURA 'Factura',CONCAT('Nombre y Apellido: ',c.NOMBRE,' ',c.APELLIDO,
			' |DNI ',C.DNI)'Cliente',
			r.INGRESO 'Ingreso',r.SALIDA 'Salida',e.DESCRIPCION 'Estado',
			h.CODIGO 'Habitación',p.NIVEL 'Piso',
			CONCAT('Hotel: ',ho.NOMBRE,'Direccion: ',ho.DIRECCION,' |Localidad: ',l.NOMBRE) 'Hotel',
			CONCAT('Nombre y Apellido: ',em.NOMBRE,' ',Em.APELLIDO,' |Legajo: ',em.legajo)'Empleado',
			sum(fa.CANTIDAD * fa.MONTO)'Total'
			from FACTURAS f join CLIENTES c on f.CLIENTE=c.ID
			join RESERVAS r on f.RESERVA = r.ID
			join ESTADOS_RESERVA e on r.ESTADO = e.ID
			join EMPLEADO em on r.Empleado = em.legajo
			join RESERVA_HABITACIONES re on r.ID = re.RESERVA
			join HABITACION_HOTEL h on  h.ID = re.HABITACION
			join PISOS_HOTEL p on h.PISO = p.ID
			join HOTELES ho on p.HOTEL = ho.ID
			join LOCALIDADES l on l.ID_LOCALIDAD = ho.LOCALIDAD
			join FACTURA_DETALLES fa on fa.FACTURA= f.ID
			where f.N_FACTURA = @nro_factura and e.ID = 2
			group by f.N_FACTURA,c.NOMBRE,c.APELLIDO,C.DNI,r.INGRESO,r.SALIDA,e.DESCRIPCION,
			h.CODIGO,p.NIVEL,ho.NOMBRE,ho.DIRECCION,l.NOMBRE,em.NOMBRE,Em.APELLIDO,em.legajo;		
		end
		else
		begin
			select'No existe este nro_factura' Mensaje;
		end
	end
	else
	begin
		if exists (select 1 from FACTURAS f1 where f1.N_FACTURA= @nro_factura)
		begin
			select f.N_FACTURA 'Factura',CONCAT('Razon Social: ',c.Razon_Social,' ',
			' |CUIL: ',C.CUIL)'Cliente',
			r.INGRESO 'Ingreso',r.SALIDA 'Salida',e.DESCRIPCION 'Estado',
			h.CODIGO 'Habitación',p.NIVEL 'Piso',
			CONCAT('Hotel: ',ho.NOMBRE,'Direccion: ',ho.DIRECCION,' |Localidad: ',l.NOMBRE) 'Hotel',
			CONCAT('Nombre y Apellido: ',em.NOMBRE,' ',Em.APELLIDO,' |Legajo: ',em.legajo)'Empleado',
			sum(fa.CANTIDAD * fa.MONTO)'Total'
			from FACTURAS f join CLIENTES c on f.CLIENTE=c.ID
			join RESERVAS r on f.RESERVA = r.ID
			join ESTADOS_RESERVA e on r.ESTADO = e.ID
			join EMPLEADO em on r.Empleado = em.legajo
			join RESERVA_HABITACIONES re on r.ID = re.RESERVA
			join HABITACION_HOTEL h on  h.ID = re.HABITACION
			join PISOS_HOTEL p on h.PISO = p.ID
			join HOTELES ho on p.HOTEL = ho.ID
			join LOCALIDADES l on l.ID_LOCALIDAD = ho.LOCALIDAD
			join FACTURA_DETALLES fa on fa.FACTURA= f.ID 
			join TIPOS_CLIENTES t on c.ID = t.ID
			where f.N_FACTURA = @nro_factura and e.ID = 2  and t.ID = @tipo_cliente
			group by f.N_FACTURA,c.Razon_Social,c.CUIL,r.INGRESO,r.SALIDA,e.DESCRIPCION,
			h.CODIGO,p.NIVEL,ho.NOMBRE,ho.DIRECCION,l.NOMBRE,em.NOMBRE,Em.APELLIDO,em.legajo;		
		end
		else
		begin
			select'No existe este nro_factura' Mensaje;
		end		
	end
end

select * from TIPOS_CLIENTES



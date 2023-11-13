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
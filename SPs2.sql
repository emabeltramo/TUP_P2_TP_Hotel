USE HOTEL_DB
GO
CREATE PROCEDURE [dbo].[SP_MODIFICAR_CLIENTE]
@id int,@nombre varchar(50),@apellido varchar(50),@tdoc int,
@dni int, @email varchar(100), @tCliente int , @razonSoc varchar(50),@celular varchar(50), @cuil varchar(50)
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
		Razon_Social = @razonSoc,
		CUIL= @cuil
	WHERE ID = @id
END;
GO

--INSERTAR CLIENTE
CREATE PROCEDURE [dbo].[SP_INSERTAR_CLIENTE]--OkTotal
@nombre varchar(50),@apellido varchar(50),@tdoc int,@cuil int,
@dni int, @email varchar(100), @tCliente int , @razonSoc varchar(50),@celular int
AS 
BEGIN 
	INSERT INTO CLIENTES(NOMBRE,APELLIDO,TIPO_DOCUMENTO,DNI,CUIL,EMAIL,CELULAR,
	tipo_cliente,Razon_Social)
	VALUES(@nombre,@apellido,@tdoc ,@dni,@cuil, @email ,@celular, @tCliente, @razonSoc)
END;
GO
--BORRAR CLIENTE
CREATE PROCEDURE [dbo].[SP_BORRAR_CLIENTE]
    @id INT
AS
BEGIN


        DELETE FROM CLIENTES WHERE ID = @id;
END;
GO
--SELECT TIPOCLIENTE
CREATE PROCEDURE SP_CONSULTAR_TIPOCLIENTE--OkTotal

AS 
BEGIN 
	SELECT * FROM TIPOS_CLIENTES
END;
GO
--SELECT TIPODOCUMENTO
CREATE PROCEDURE SP_CONSULTAR_TIPODOCUMENTO--OkTotal

AS 
BEGIN 
	SELECT * FROM TIPO_DOCUMENTOS
END;
GO
--LISTAR CLIENTES

CREATE PROCEDURE [dbo].[SP_LISTA_CLIENTES]--OkApi
AS
BEGIN
    SELECT C.ID 'ID', C.NOMBRE 'Nombre',C.APELLIDO'Apellido',T.TIPO_DOCUMENTO 'Tipo Documento',  t.ID 'IDD', C.DNI 'Numero Documento',
    C.CUIL 'Numero CUIL',C.EMAIL 'Email',C.CELULAR 'Celular',tc.ID 'IDC',TC.Descripcion 'Tipo Cliente',C.Razon_Social 'Razon Social'
    FROM CLIENTES C 
    JOIN TIPO_DOCUMENTOS T ON C.TIPO_DOCUMENTO = T.ID 
    JOIN TIPOS_CLIENTES TC ON C.tipo_cliente = TC.ID
    ORDER BY 1
END
GO
CREATE PROCEDURE SP_VERIFICAR_CLIENTE_EXISTENTE
    @ClienteID INT,
    @Resultado BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @Resultado = 1;
    IF EXISTS (SELECT 1 FROM reservas WHERE cliente = @ClienteID)
    BEGIN
        SET @Resultado = 0; 
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM facturas WHERE cliente = @ClienteID)
    BEGIN
        SET @Resultado = 0; 
        RETURN;
    END
END;
GO


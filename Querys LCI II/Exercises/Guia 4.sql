USE LIBRERIA_LCI_II;

-- 1. Declarar 3 variables que se llamen codigo, stock y stockMinimo
-- respectivamente. A la variable codigo setearle un valor. Las variables stock y
-- stockMinimo almacenarán el resultado de las columnas de la tabla artículos
-- stock y stockMinimo respectivamente filtradas por el código que se
-- corresponda con la variable codigo.

-- DECLARE @CODIGO INT ;
-- DECLARE @STOCK INT;
-- DECLARE @STOCKMINIMO INT; 
-- SET @CODIGO = 5;

-- SELECT @STOCK = A.STOCK
-- FROM ARTICULOS A 
-- WHERE A.cod_articulo = @CODIGO;
-- SELECT @STOCK AS 'STOCK';

-- SELECT @STOCKMINIMO = A.stock_minimo
-- FROM ARTICULOS A 
-- WHERE A.cod_articulo = @CODIGO;
-- SELECT @STOCKMINIMO AS 'STOCK MININO';



-- ALTER FUNCTION OCTAVA_FUNCION (@CODIGO INT)
-- RETURNS TABLE 
-- AS 
-- RETURN (SELECT A.STOCK,A.stock_minimo FROM ARTICULOS A WHERE A.cod_articulo = @CODIGO);

-- SELECT * FROM OCTAVA_FUNCION(5);



-- CREATE FUNCTION NOVENA_FUNCION (@CODIGO INT)
-- RETURNS INT  
-- BEGIN
-- DECLARE @STOCK INT
-- SELECT @STOCK = A.stock FROM ARTICULOS A
-- WHERE A.cod_articulo = @CODIGO
-- RETURN @STOCK
-- END;

-- CREATE FUNCTION DECIMAPRIMERA_FUNCION (@CODIGO INT)
-- RETURNS INT  
-- BEGIN
-- DECLARE @STOCKMINIMO INT
-- SELECT @STOCKMINIMO = A.stock_minimo FROM ARTICULOS A
-- WHERE A.cod_articulo = @CODIGO
-- RETURN @STOCKMINIMO
-- END;


-- SELECT dbo.NOVENA_FUNCION(5) AS 'STOCK';


-- 2. Utilizando el punto anterior, verificar si la variable stock o stockMinimo tienen
-- algún valor. Mostrar un mensaje indicando si es necesario realizar reposición
-- de artículos o no.

-- DECLARE @STOCK INT;
-- SELECT @STOCK = A.stock FROM ARTICULOS A
-- WHERE A.cod_articulo = 5;
-- SELECT @STOCK AS 'STOCK';


/*NO HAY STOCK NULOS POR ESO LO PUSE CON < 10*/

-- CREATE FUNCTION DECIMA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100)
-- BEGIN 
-- DECLARE @SALIDA VARCHAR(100)
-- DECLARE @STOCK INT 
-- SELECT @STOCK = dbo.NOVENA_FUNCION(@CODIGO)
-- IF(@STOCK < 10)
-- SELECT @SALIDA = 'ES NECESARIO REPONER'
-- ELSE
-- SELECT @SALIDA = 'STOCK SUFICIENTE'
-- RETURN @SALIDA
-- END;

-- SELECT dbo.DECIMA_FUNCION (10) AS 'CONTROL STOCK';

/*CAMBIA LA CONDICION NOMÁS*/

-- CREATE FUNCTION DECIMA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100)
-- BEGIN 
-- DECLARE @SALIDA VARCHAR(100)
-- DECLARE @STOCK INT 
-- DECLARE @STOCKMINIMO INT
-- SELECT @STOCK = dbo.NOVENA_FUNCION(@CODIGO)
-- SELECT @STOCKMINIMO = dbo.DECIMAPRIMERA_FUNCION(@CODIGO);
-- IF(@STOCK IS NULL OR @STOCKMINIMO IS NULL)
-- SELECT @SALIDA = 'ES NECESARIO REPONER'
-- ELSE 
-- SELECT @SALIDA = 'STOCK SUFICIENTE'
-- RETURN @SALIDA
-- END;

-- SELECT dbo.DECIMA_FUNCION (10) AS 'CONTROL STOCK';


-- 3. Modificar el ejercicio 1 agregando una variable más donde se almacene el
-- precio del artículo. En caso que el precio sea menor a $500, aplicarle un
-- incremento del 10%. En caso de que el precio sea mayor a $500 notificar dicha
-- situación y mostrar el precio del artículo.

-- DECLARE @CODIGO INT;
-- DECLARE @STOCK INT;
-- DECLARE @STOCKMINIMO INT;
-- DECLARE @PRECIO INT;
-- SET @CODIGO = 5;

-- CREATE FUNCTION DECIMASEGUNDA_FUNCION (@CODIGO INT )
-- RETURNS TABLE 
-- AS
-- RETURN (SELECT A.stock,A.stock_minimo,A.pre_unitario FROM ARTICULOS A WHERE A.cod_articulo = @CODIGO)

-- SELECT @STOCK = A.STOCK FROM ARTICULOS A WHERE A.cod_articulo =  @CODIGO;

-- SELECT @STOCKMINIMO = A.stock_minimo FROM ARTICULOS A WHERE A.cod_articulo =  @CODIGO;

-- SELECT @PRECIO = A.pre_unitario FROM ARTICULOS A WHERE A.cod_articulo =  @CODIGO;

-- SELECT @STOCK AS 'STOCK',@STOCKMINIMO AS 'STOCK MINIMO',@PRECIO AS 'PRECIO';

-- CREATE FUNCTION DECIMATERCERA_FUNCION(@CODIGO INT)
-- RETURNS TABLE  
-- AS
-- BEGIN
-- DECLARE @PRECIO INT
-- DECLARE @SALIDA VARCHAR (100) 
-- SELECT  @PRECIO = A.pre_unitario FROM articulos A WHERE A.cod_articulo = @CODIGO
-- IF(@PRECIO < 500)
-- --UPDATE ARTICULOS SET pre_unitario = (((@PRECIO * 10) / 100) + @PRECIO) WHERE cod_articulo = @CODIGO
-- RETURN (SELECT (((@PRECIO * 10) / 100) + @PRECIO) AS 'PRECIO CON AUMENTO' )
-- ELSE 
-- SET @SALIDA = 'EL PRECIO ES MAYOR A $500'
-- RETURN (SELECT @SALIDA,@PRECIO)
-- RETURN (SELECT @SALIDA,@PRECIO
-- END

-- ALTER FUNCTION DECIMATERCERA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100) 
-- AS
-- BEGIN
-- DECLARE @PRECIO INT
-- DECLARE @SALIDA VARCHAR (100) 
-- SELECT  @PRECIO = A.pre_unitario FROM articulos A WHERE A.cod_articulo = @CODIGO
-- IF(@PRECIO < 500)
-- --UPDATE ARTICULOS SET pre_unitario = (((@PRECIO * 10) / 100) + @PRECIO) WHERE cod_articulo = @CODIGO
-- SET @SALIDA = 'EL PRECIO ES MENOR A $500'
-- ELSE 
-- SET @SALIDA = 'EL PRECIO ES MAYOR A $500'
-- RETURN @SALIDA
-- RETURN @SALIDA
-- END

-- SELECT dbo.DECIMATERCERA_FUNCION(5);

-- 4. Declarar dos variables enteras, y mostrar la suma de todos los números
-- comprendidos entre ellos. En caso de ser ambos números iguales mostrar un
-- mensaje informando dicha situación

-- 5. Mostrar nombre y precio de todos los artículos. Mostrar en una tercer columna
-- la leyenda ‘Muy caro’ para precios mayores a $500, ‘Accesible’ para precios
-- entre $300 y $500, ‘Barato’ para precios entre $100 y $300 y ‘Regalado’ para
-- precios menores a $100.




-- CREATE FUNCTION DECIMACUARTA_FUNCION()
-- RETURNS TABLE 
-- RETURN
-- (
-- SELECT 
-- A.descripcion AS 'ARTICULOS',
-- A.pre_unitario AS 'PRECIO UNITARIO' ,
-- 'MUY CARO' AS 'CLASIFICACION'
-- FROM ARTICULOS A
-- WHERE A.pre_unitario > 500
-- )


-- SELECT descripcion,pre_unitario, TIPO_PRECIO = 

-- CASE

-- WHEN  pre_unitario > 500 THEN 'MUY CARO'

-- WHEN pre_unitario BETWEEN 300 and 500 THEN 'ACCESIBLE'

-- WHEN pre_unitario BETWEEN 100 AND 300 THEN 'BARATO'

-- WHEN pre_unitario <= 100 THEN 'REGALADO'

-- END 

-- FROM ARTICULOS;





-- 6. Modificar el punto 2 reemplazando el mensaje de que es necesario reponer
-- artículos por una excepción.

-- ALTER FUNCTION DECIMA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100)
-- BEGIN 
-- DECLARE @SALIDA VARCHAR(100)
-- DECLARE @STOCK INT 
-- SELECT @STOCK = dbo.NOVENA_FUNCION(@CODIGO)
-- IF(@STOCK < 10)
-- ERROR_MESSAGE() AS 'ERROR'
-- ELSE
-- SELECT @SALIDA = 'STOCK SUFICIENTE'
-- RETURN @SALIDA
-- END;

-- 4.3: Programación aplicada a Procedimientos Almacenados y Funciones
-- definidas por el usuario

-- a. Mostrar los artículos cuyo precio sea mayor o igual que un valor que se
-- envía por parámetro.


-- CREATE FUNCTION ARTICULOS_MAYORES_MENORES (@PRECIO DECIMAL (10,2) )
-- RETURNS TABLE 
-- RETURN 
-- (SELECT * FROM ARTICULOS WHERE pre_unitario >= @PRECIO )

-- b. Ingresar un artículo nuevo, verificando que la cantidad de stock que se
-- pasa por parámetro sea un valor mayor a 30 unidades y menor que 100.
-- Informar un error caso contrario.


--CREATE PROCEDURE INSERCION_ARTICULOS 
--@DESCRIPCION VARCHAR (100),
--@STOCK_MINIMO INT,
--@STOCK INT,
--@PRECIO DECIMAL (10,2),
--@OBSERVACIONES VARCHAR (100),
--@MESSAGE VARCHAR (300) OUTPUT
--AS
--BEGIN 
--IF(@STOCK < 30 OR @STOCK > 100) 
--RAISERROR (15600, -1, -1, 'EL STOCK INGRESADO NO PUEDE SER MENOR A 30 O MAYOR A 100...');
--ELSE 
--INSERT INTO articulos  (descripcion,stock_minimo,stock,pre_unitario,observaciones) VALUES (@DESCRIPCION,@STOCK_MINIMO,@STOCK,@PRECIO,@OBSERVACIONES)
--SET @MESSAGE = 'LA INSERCION SE REALIZO CORRECTAMENTE...'
--END 

-- DECLARE @DESCRIPCION VARCHAR (100) = 'ESTO ES UNA PRUEBA';
-- DECLARE @STOCK_MINIMO INT = 25; 
-- DECLARE @STOCK INT = 32;
-- DECLARE @PRECIO DECIMAL (10,2) = 50;
-- DECLARE @OBSERVACIONES VARCHAR (100) = 'ESTO TAMBIEN ES UNA PRUEBA';


--DECLARE @MESSAGE AS VARCHAR(100);
--EXEC INSERCION_ARTICULOS @DESCRIPCION,@STOCK_MINIMO,@STOCK,@PRECIO,@OBSERVACIONES,@MESSAGE OUTPUT
--SELECT @MESSAGE AS RETORNO_FROM_SP


--SINTAXIS CORRECTA DE FUNCIONES QUE DEVUELVEN UN UNICO VALOR.

-- CREATE FUNCTION INSERCION_ARTICULOS
-- (@DESCRIPCION VARCHAR (100), @STOCK_MINIMO INT,@STOCK INT,@PRECIO DECIMAL (10,2),@OBSERVACIONES VARCHAR (100))
-- RETURNS VARCHAR (100)
-- BEGIN 
-- DECLARE @MESSAGE VARCHAR (100);
-- IF(@STOCK < 30 OR @STOCK > 100)
-- SET @MESSAGE = 'EL STOCK NO PUEDE SER MENOR QUE 30 O MAYOR A 100'
-- RETURN @MESSAGE;
-- INSERT INTO articulos  (descripcion,stock_minimo,stock,pre_unitario,observaciones) VALUES (@DESCRIPCION,@STOCK_MINIMO,@STOCK,@PRECIO,@OBSERVACIONES)
-- SET @MESSAGE = 'LA INSERCION SE REALIZO CORRECTAMENTE';
-- RETURN @MESSAGE;
-- END 

--c. Mostrar un mensaje informativo acerca de si hay que reponer o no
--stock de un artículo cuyo código sea enviado por parámetro


--CREATE PROCEDURE INFORMAR_STOCK
--@CODIGO INT,
--@MESSAGE VARCHAR (100) OUTPUT
--AS 
--BEGIN
--IF((SELECT stock_minimo FROM articulos WHERE cod_articulo = @CODIGO) = 0) 
--SET @MESSAGE = 'HAY QUE REPONER EL STOCK'
--ELSE
--SET @MESSAGE = 'NO HAY QUE REPONER EL STOCK...'
--END ;

--DECLARE @CODIGO INT = 5;
--DECLARE @MESSAGE VARCHAR (100);

--EXEC INFORMAR_STOCK @CODIGO,@MESSAGE OUTPUT;
--SELECT @MESSAGE AS MESSAGE_FROM_SP

--UPDATE articulos SET stock_minimo = 0 WHERE cod_articulo = 5;


--REVISAR 

--d. Actualizar el precio de los productos que tengan un precio menor a uno
--ingresado por parámetro en un porcentaje que también se envíe por
--parámetro. Si no se modifica ningún elemento informar dicha situación

--ALTER PROCEDURE AUMENTAR_PRECIOS_MENORES_A_UNO
--@PRECIO DECIMAL (10,2),
--@PORCENTAJE INT,
--@MESSAGE VARCHAR (100) OUTPUT
--AS
--BEGIN
--IF(@PRECIO IS NULL OR @PORCENTAJE IS NULL)
--SET @MESSAGE = 'DEBE ENVIAR LOS PARAMETROS!!!' 
--ELSE
--SELECT pre_unitario FROM articulos WHERE pre_unitario > @PRECIO
--SET @MESSAGE = 'NO HACE FALTA ACTUALIZAR EL PRECIO'
--END



--DECLARE @PRECIO DECIMAL (10,2) = NULL;
--DECLARE @PORCENTAJE INT = 10;
--DECLARE @MESSAGE VARCHAR (100);

--EXEC AUMENTAR_PRECIOS_MENORES_A_UNO @PRECIO,@PORCENTAJE,@MESSAGE OUTPUT
--SELECT @MESSAGE AS MESSAGE_FROM_SP;



--e. Mostrar el nombre del cliente al que se le realizó la primer venta en un
--parámetro de salida.

--ALTER PROCEDURE PRIMER_CLIENTE
--@NOMBRE VARCHAR (100) OUTPUT
--AS 
--BEGIN
--SELECT TOP 1 @NOMBRE =  C.nom_cliente FROM clientes C 
--JOIN facturas F ON F.cod_cliente = C.cod_cliente
--END 


--DECLARE @NOMBRE VARCHAR (100);
--EXEC PRIMER_CLIENTE @NOMBRE OUTPUT
--SELECT @NOMBRE AS 'CLIENTE'

--f. Realizar un select que busque el artículo cuyo nombre empiece con un
--valor enviado por parámetro y almacenar su nombre en un parámetro
--de salida. En caso que haya varios artículos ocurrirá una excepción
--que deberá ser manejada con try catch.


--CREATE PROCEDURE BUSCAR_ARTICULO
--@PALABRA VARCHAR(10),
--@NOMBRE VARCHAR (100) OUTPUT
--AS
--BEGIN
--BEGIN TRY
--SELECT @NOMBRE =  A.descripcion  FROM articulos A WHERE A.descripcion LIKE '%' + @PALABRA + '%' 
--END TRY
--BEGIN CATCH
--RAISERROR (15600, -1, -1, 'LA BUSQUEDA HA DEVUELTO MAS DE 1 VALOR...');
--END CATCH
--END


--DECLARE @PALABRA VARCHAR (10) = 'Goma';
--DECLARE @NOMBRE VARCHAR (100);

--EXEC BUSCAR_ARTICULO @PALABRA,@NOMBRE OUTPUT 
--SELECT @NOMBRE AS 'NOMBRE FROM SP'

--2. Programar funciones que permitan realizar las siguientes tareas:

--a. Devolver una cadena de caracteres compuesto por los siguientes
--datos: Apellido, Nombre, Telefono, Calle, Altura y Nombre del Barrio,
--de un determinado cliente, que se puede informar por codigo de cliente
--o email.

--CREATE FUNCTION ARMAR_CADENA (@CODIGO INT,@EMAIL VARCHAR (100))
--RETURNS VARCHAR (200)
--AS 
--BEGIN
--DECLARE @SALIDA VARCHAR (200)
--if(@codigo IS NULL)
--SELECT @SALIDA = C.nom_cliente + ' ' +  C.ape_cliente + ' ' + CONVERT(VARCHAR(100),C.nro_tel) + ' ' + C.calle + ' ' + CONVERT(VARCHAR(100),C.altura) + ' ' + B.barrio   FROM CLIENTES C 
--JOIN barrios B ON B.cod_barrio = C.cod_barrio
--WHERE C.cod_cliente = @EMAIL
--ELSE IF(@EMAIL IS  NULL)
--SELECT  @SALIDA = C.nom_cliente + ' ' +  C.ape_cliente + ' ' + CONVERT(VARCHAR(100),C.nro_tel) + ' ' + C.calle + ' ' + CONVERT(VARCHAR(100),C.altura) + ' ' + B.barrio   FROM CLIENTES C 
--JOIN barrios B ON B.cod_barrio = C.cod_barrio
--WHERE C.cod_cliente = @CODIGO
--RETURN @SALIDA
--END;

--DECLARE @CODIGO INT = 4;
--DECLARE @EMAIL VARCHAR (100) = NULL;
--SELECT  dbo.ARMAR_CADENA(@CODIGO, @EMAIL) AS 'SALIDA FROM FUNCTION';

--b. Devolver todos los artículos, se envía un parámetro que permite
--ordenar el resultado por el campo precio de manera ascendente (‘A’), o
--descendente (‘D’).


--CREATE PROCEDURE ORDERNAR_ARTICULOS
--@ORDEN VARCHAR (1)
--AS 
--BEGIN 
--IF(@ORDEN = 'A')
--SELECT * FROM ARTICULOS ORDER BY cod_articulo ASC
--ELSE 
--SELECT * FROM ARTICULOS ORDER BY cod_articulo DESC
--END


--c. Crear una función que devuelva el precio al que quedaría un artículo en
--caso de aplicar un porcentaje de aumento pasado por parámetro.


--CREATE FUNCTION AUMENTAR_PRECIO (@PORCENTAJE INT,@CODIGO INT)
--RETURNS DECIMAL (10,2)
--AS 
--BEGIN
--DECLARE @PRECIO INT
--SELECT @PRECIO = (PRE_UNITARIO * @PORCENTAJE) + PRE_UNITARIO FROM ARTICULOS WHERE COD_ARTICULO = @CODIGO
--RETURN @PRECIO
--END;


--DECLARE @PORCENTAJE INT = 10;
--DECLARE @CODIGO INT = 5;

--4.4: Triggers

--1. Crear un desencadenador para las siguientes acciones:

--a. Restar stock DESPUES de INSERTAR una VENTA

--ALTER TRIGGER CONTROL_STOCK
--ON DETALLE_FACTURAS
--FOR INSERT
--AS
--DECLARE @STOCK INT
--SELECT @STOCK = STOCK FROM ARTICULOS
--JOIN INSERTED
--ON INSERTED.COD_ARTICULO = ARTICULOS.COD_ARTICULO
--IF (@STOCK >= (SELECT CANTIDAD FROM INSERTED))
--UPDATE ARTICULOS SET STOCK = STOCK - INSERTED.CANTIDAD
--FROM ARTICULOS
--JOIN INSERTED
--ON INSERTED.COD_ARTICULO = ARTICULOS.COD_ARTICULO
--ELSE
--BEGIN
--RAISERROR ('EL STOCK DE LOS ARTICULOS ES MENOR QUE LA CANTIDAD SOLICITADAS', 16, 1)
--ROLLBACK TRANSACTION
--END--b. Para no poder modificar el nombre de algún artículo--CREATE TRIGGER NO_MODIFICAR_NOMBRE_ARTICULOS--ON ARTICULOS--FOR UPDATE--AS --IF UPDATE (DESCRIPCION)--RAISERROR ('NO ESTA PERMITIDO MODIFICAR EL NOMBRE DE LOS ARTICULOS...',1,1)--ROLLBACK TRANSACTION;--c. Insertar en la tabla HistorialPrecio el precio anterior de un artículo si el
--mismo ha cambiado

--ALTER TRIGGER HISTORICO_PRECIOS
--ON ARTICULOS 
--FOR UPDATE
--AS
--BEGIN
--IF UPDATE (PRE_UNITARIO)
--CREATE TABLE HISTORICO_PRECIOS_ARTICULOS
--(PRECIOS_HISTORICOS DECIMAL (10,2))
--DECLARE @PRECIO DECIMAL (10,2)
--SELECT @PRECIO = PRE_UNITARIO FROM DELETED WHERE COD_ARTICULO = DELETED.COD_ARTICULO
--INSERT INTO HISTORICO_PRECIOS_ARTICULOS (PRECIOS_HISTORICOS) VALUES (@PRECIO)
--END

--INSERT INTO HISTORICO_PRECIOS_ARTICULOS (PRECIOS_HISTORICOS) VALUES ( (SELECT PRE_UNITARIO FROM DELETED WHERE COD_ARTICULO = DELETED.cod_articulo))


--UPDATE ARTICULOS SET PRE_UNITARIO = 10 WHERE COD_ARTICULO = 1;

--SELECT * FROM HISTORICO_PRECIOS_ARTICULOS
 

--d. Bloquear al vendedor con código 4 para que no pueda registrar ventas
--en el sistema.--REVISAR NOSE POR QUE NO ANDA----ALTER TRIGGER BLOQUEAR_VENDEDOR_4--ON FACTURAS--FOR INSERT --AS--DECLARE @VENDEDOR INT;--IF (@VENDEDOR = (SELECT COD_VENDEDOR FROM INSERTED WHERE cod_vendedor = 4) )--RAISERROR ('EL VENDEDOR CON CODIGO Nº 4 NO PUEDE REALIZAR VENTAS...',1,1)--ROLLBACK TRANSACTION

--INSERT INTO FACTURAS (FECHA,COD_CLIENTE,COD_VENDEDOR) VALUES (GETDATE(),1,5)

--ALTER TRIGGER CONTROL_STOCK
--ON DETALLE_FACTURAS
--FOR INSERT
--AS
--DECLARE @STOCK INT
--SELECT @STOCK = STOCK FROM ARTICULOS
--JOIN INSERTED
--ON INSERTED.COD_ARTICULO = ARTICULOS.COD_ARTICULO
--IF (@STOCK >= (SELECT CANTIDAD FROM INSERTED))
--UPDATE ARTICULOS SET STOCK = STOCK - INSERTED.CANTIDAD
--FROM ARTICULOS
--JOIN INSERTED
--ON INSERTED.COD_ARTICULO = ARTICULOS.COD_ARTICULO
--ELSE
--BEGIN
--RAISERROR ('EL STOCK DE LOS ARTICULOS ES MENOR QUE LA CANTIDAD SOLICITADAS', 16, 1)
--ROLLBACK TRANSACTION
--END

--4.5: Tablas temporales

--1. Crear un procedimiento almacenado que devuelva la primera y la última venta
--en una sola tabla

--2. Crear un procedimiento almacenado que devuelva en una sola tabla las
--facturas realizadas en días impares dentro de un mes / año pasado por
--parámetro

--CREATE PROCEDURE PRIMERA_ULTIMA_VENTA
--AS 
--BEGIN 
--DECLARE @PRIMERAVENTA INT
--DECLARE @ULTIMAVENTA INT 
--SELECT @PRIMERAVENTA = MAX(F.NRO_FACTURA) FROM FACTURAS F  
--SELECT @ULTIMAVENTA =  MIN(F.NRO_FACTURA) FROM FACTURAS F 
--CREATE TABLE #TEMPORAL_PRIMERA_ULTIMA_VENTA
--(PRIMERA_VENTA INT,
--ULTIMA_VENTA  INT)
--INSERT INTO #TEMPORAL_PRIMERA_ULTIMA_VENTA (PRIMERA_VENTA,ULTIMA_VENTA) VALUES (@PRIMERAVENTA,@ULTIMAVENTA)
--END

--EXEC PRIMERA_ULTIMA_VENTA

--SELECT * FROM #TEMPORAL_PRIMERA_ULTIMA_VENTA


--CREATE PROCEDURE PRIMERA_ULTIMA_VENTA_2
--@PRIMERAVENTA INT OUTPUT,
--@ULTIMAVENTA INT OUTPUT
--AS 
--BEGIN
--SELECT @PRIMERAVENTA = MIN(F.NRO_FACTURA) FROM FACTURAS F
--SELECT @ULTIMAVENTA = MAX(F.NRO_FACTURA) FROM FACTURAS F
--END

--DECLARE @PRIMERA_VENTA INT;
--DECLARE @ULTIMA_VENTA INT;
--EXEC PRIMERA_ULTIMA_VENTA_2 @PRIMERA_VENTA OUTPUT,@ULTIMA_VENTA OUTPUT
--SELECT @PRIMERA_VENTA AS 'PRIMERA VENTA', @ULTIMA_VENTA AS 'ULTIMA VENTA'

--2. Crear un procedimiento almacenado que devuelva en una sola tabla las
--facturas realizadas en días impares dentro de un mes / año pasado por
--parámetro


--ALTER PROCEDURE FACTURAS_REALIZADAS_DIAS_IMPARES
--@FECHA DATETIME,
--@ENTRADA VARCHAR (100)
--AS 
--BEGIN
--IF(@ENTRADA IS NULL)
--RAISERROR('DEBE INGRESAR EL AÑO O EL MES PARA CONSULTAR...',1,1)
--ELSE IF (@ENTRADA = 'MES')
--SELECT 
--F.nro_factura AS 'NRO_FACTURA' ,
--DAY(F.FECHA) 'DIA IMPAR' , 
--F.cod_cliente AS 'CLIENTES' , 
--F.cod_vendedor AS 'VENDEDORES' 
--FROM FACTURAS F 
--WHERE MONTH(F.fecha) = MONTH(@FECHA) AND DAY(F.FECHA) % 2 != 0
--ELSE
--SELECT 
--F.nro_factura AS 'NRO_FACTURA' ,
--DAY(F.FECHA) 'DIA IMPAR' , 
--F.cod_cliente AS 'CLIENTES' , 
--F.cod_vendedor AS 'VENDEDORES' 
--FROM FACTURAS F 
--WHERE YEAR(F.fecha) = YEAR(@FECHA) AND DAY(F.FECHA) % 2 != 0
--END


--CONSULTA PARA VERIFICAR DIAS IMPARES--
--SELECT DISTINCT DAY(F.FECHA) AS 'IMPARES' FROM FACTURAS F WHERE DAY(F.FECHA) % 2 != 0 ORDER BY DAY(F.FECHA) ASC;


--DECLARE @FECHA DATETIME = '22/10/2018';
--DECLARE @ENTRADA VARCHAR = 'MES';

--EXEC FACTURAS_REALIZADAS_DIAS_IMPARES @FECHA,@ENTRADA;

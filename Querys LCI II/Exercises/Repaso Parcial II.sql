--Problema 3.1: Vistas

--Desde el área de programación del sistema de información de una librería
--mayorista se solicita la creación de una serie de vistas desde la base de datos de la
--facturación de este negocio.

--1. El código y nombre completo de los clientes, la dirección (calle y número) y
--barrio.


--CREATE VIEW REPASO_VISTAS1
--AS 
--SELECT 
--C.cod_cliente AS 'CODIGO_CLIENTE',
--C.nom_cliente + ' ' + C.ape_cliente AS 'NOMBRE_COMPLETO',
--C.calle + ' ' + CONVERT(varchar(100), C.ALTURA) AS 'DIRECCION',
--B.BARRIO AS 'BARRIO'
--FROM clientes C
--JOIN barrios B ON B.cod_barrio = C.cod_barrio;

--SELECT * FROM REPASO_VISTAS1;

--2. Cree una vista que liste la fecha, la factura, el código y nombre del vendedor, el
--artículo, la cantidad e importe, para lo que va del año. Rotule como FECHA,
--NRO_FACTURA, CODIGO_VENDEDOR, NOMBRE_VENDEDOR, ARTICULO,
--CANTIDAD, IMPORTE.--CREATE VIEW REPASO_VISTAS2--AS --SELECT--V.cod_vendedor AS COD_VENDEDOR,--V.nom_vendedor AS NOMBRE_VENDEDOR,--F.nro_factura AS NRO_FACTURA,--A.DESCRIPCION AS ARTICULO,--COUNT(DF.cantidad)AS CANTIDAD,--SUM(DF.pre_unitario) AS IMPORTE,--YEAR(F.FECHA) AS FECHA--FROM FACTURAS F --JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura--JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor--JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo--GROUP BY V.cod_vendedor,V.nom_vendedor, F.nro_factura , A.descripcion,YEAR(F.FECHA)--SELECT * FROM REPASO_VISTAS2;--3. Modifique la vista creada en el punto anterior, agréguele la condición de que
--solo tome el mes pasado (mes anterior al actual) y que también muestre la
--dirección del vendedor.--ALTER VIEW REPASO_VISTAS2--AS --SELECT--V.cod_vendedor AS COD_VENDEDOR,--V.nom_vendedor AS NOMBRE_VENDEDOR,--V.calle + ' ' + CONVERT(varchar (100),V.altura) DIRECCION,--F.nro_factura AS NRO_FACTURA,--A.DESCRIPCION AS ARTICULO,--COUNT(DF.cantidad)AS CANTIDAD,--SUM(DF.pre_unitario) AS IMPORTE,--MONTH(F.FECHA) AS FECHA--FROM FACTURAS F --JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura--JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor--JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo--WHERE MONTH(F.FECHA) = MONTH(GETDATE()) - 1--GROUP BY V.cod_vendedor,V.nom_vendedor, F.nro_factura , A.descripcion,MONTH(F.FECHA),V.calle,V.altura--SELECT * FROM REPASO_VISTAS2;--4. Consulta las vistas según el siguiente detalle:

--a. Llame a la vista creada en el punto anterior pero filtrando por importes
--inferiores a $120.

--SELECT IMPORTE FROM REPASO_VISTAS2 WHERE IMPORTE < 120;

--b. Llame a la vista creada en el punto anterior filtrando para el vendedor
--Miranda.

  --SELECT NOMBRE_VENDEDOR FROM REPASO_VISTAS2 WHERE NOMBRE_VENDEDOR LIKE '%Miranda%'

--c. Llama a la vista creada en el punto 4 filtrando para los importes
--menores a 10.000.


--SELECT IMPORTE FROM REPASO_VISTAS2 WHERE IMPORTE > 10000;

--5. Elimine las vistas creadas en el punto 3 

--DROP VIEW REPASO_VISTAS2;


--Problema N° 3.2: Procedimientos Almacenados

--procedimiento que muestre los artículos cuyo
--precio unitario sea menor a un precio que se ingresará en el momento en que se
--ejecute el mismo:--CREATE PROCEDURE REPASO_PROCEDIMIENTOS1--@PRECIO INT OUTPUT--AS--BEGIN--SELECT * FROM articulos WHERE pre_unitario < @PRECIO--END--DECLARE @PRECIO INT = 5;--EXEC REPASO_PROCEDIMIENTOS1 @PRECIO;--Si se quiere listar los artículos cuyo precio esté entre dos valores--CREATE PROCEDURE REPASO_PROCEDIMIENTOS2--@PRECIO1 INT,--@PRECIO2 INT--AS--BEGIN--SELECT * FROM articulos WHERE pre_unitario BETWEEN @PRECIO1 AND @PRECIO2--END;--DECLARE @PRECIO1 INT = 100;--DECLARE @PRECIO2 INT = 200;--EXEC REPASO_PROCEDIMIENTOS2 @PRECIO1,@PRECIO2;--Crear un procedimiento almacenado que muestre la descripción de un
--artículo de código determinado (enviado como parámetro de entrada) y nos retorne
--el total facturado para ese artículo y el promedio ponderado de los precios de venta
--de ese artículo--CREATE PROCEDURE REPASO_PROCEDIMIENTOS3--@CODIGO INT--AS --BEGIN--SELECT--SUM(DF.PRE_UNITARIO) AS TOTAL_FACTURADO ,--AVG(DF.PRE_UNITARIO) AS PROMEDIO--FROM DETALLE_FACTURAS DF --JOIN ARTICULOS A ON A.COD_ARTICULO = DF.COD_ARTICULO--WHERE A.cod_articulo = @CODIGO--END--DECLARE @CODIGO INT = 5;--EXEC REPASO_PROCEDIMIENTOS3 @CODIGO;--Crear un procedimiento almacenado que ingresa registros en la tabla
--"articulos". Los parámetros correspondientes al pre_unitario DEBEN ingresarse con
--un valor distinto de "null", los demás son opcionales. El procedimiento retorna "1" si
--la inserción se realiza, es decir, si se ingresan valores para pre_unitario y "0", en
--caso que pre_unitario sea nulo:ALTER PROCEDURE REPASO_PROCEDIMIENTOS4@DESCRIPCION VARCHAR (100),@STOCKMINIMO INT,@STOCK INT,@PRECIO INT,@OBSERVACIONES VARCHAR(100)ASBEGINIF(@PRECIO IS NULL)RETURN 0ELSEINSERT INTO articulos (descripcion,stock_minimo,stock,pre_unitario,observaciones) VALUES(@DESCRIPCION,@STOCKMINIMO,@STOCK,@PRECIO,@OBSERVACIONES)RETURN 1END--SELECT * FROM articulos;
--DECLARE @DESCRIPCION VARCHAR (100) = 'TEST2 REPASO PROCEDIMIENTOS';--DECLARE @STOCKMINIMO INT = 5;--DECLARE @STOCK INT = 10;--DECLARE @PRECIO INT = 25;--DECLARE @OBSERVACIONES VARCHAR(100) = 'TEST2 REPASO PROCEDIMIENTOS';--DECLARE @RETORNO INT;--EXEC @RETORNO = REPASO_PROCEDIMIENTOS4 @DESCRIPCION,@STOCKMINIMO,@STOCK,@PRECIO,@OBSERVACIONES;--SELECT @RETORNO AS SALIDA_PROCEDIMIENTO
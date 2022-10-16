USE LIBRERIA_LCI_II;


/*Problema N° 3.2: Procedimientos Almacenados:*/

/*1- Crear un procedimiento almacenado que muestre la descripción de un
artículo de código determinado (enviado como parámetro de entrada) y nos retorne
el total facturado para ese artículo y el promedio ponderado de los precios de venta
de ese artículo*/



-- CREATE PROCEDURE PRIMER_PROCEDIMIENTO
-- @ARTICULO  INT
-- AS 
-- SELECT 
-- A.descripcion AS 'ARTICULO',
-- SUM(DF.pre_unitario) AS 'TOTAL FACTURADO',
-- AVG(DF.pre_unitario) AS 'PROMEDIO'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE A.cod_articulo = @ARTICULO
-- GROUP BY A.descripcion

-- EXEC PRIMER_PROCEDIMIENTO 25;

/*
2- 
Crear un procedimiento almacenado que ingresa registros en la tabla
"articulos". Los parámetros correspondientes al pre_unitario DEBEN ingresarse con
un valor distinto de "null", los demás son opcionales. El procedimiento retorna "1" si
la inserción se realiza, es decir, si se ingresan valores para pre_unitario y "0", en
caso que pre_unitario sea nulo:
*/


-- ALTER PROCEDURE SEGUNDO_PROCEDIMIENTO
-- @PRECIO INT,
-- @STOCK INT 
-- AS 
-- IF(@PRECIO IS NULL)
-- RETURN 0
-- ELSE
-- BEGIN
-- INSERT INTO ARTICULOS (pre_unitario,stock) VALUES (@PRECIO,@STOCK)
-- RETURN 1
-- END;

-- DECLARE @SALIDA INT 
-- EXEC @SALIDA =  SEGUNDO_PROCEDIMIENTO @PRECIO = NULL , @STOCK = 1;
-- SELECT @SALIDA AS 'SALIDA DEL SP';


/*REVISAR POR QUE NO SE PUEDE REALIZAR DE ESTA MANERA...*/
-- CREATE PROCEDURE TERCER_PROCEDIMIENTO 
-- @PRECIO INT
-- AS 
-- IF(@PRECIO IS NOT NULL)
-- INSERT INTO ARTICULOS (pre_unitario) VALUES (@PRECIO)
-- RETURN 1
-- ELSE
-- BEGIN 
-- RETURN 0
-- END;


-- a. Detalle_Ventas: liste la fecha, la factura, el vendedor, el cliente, el
-- artículo, cantidad e importe. Este SP recibirá como parámetros de E un
-- rango de fechas.


-- CREATE PROCEDURE TERCER_PROCEDIMIENTO 
-- @FECHA1 DATETIME,
-- @FECHA2 DATETIME 
-- AS
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE F.fecha = @FECHA1 AND F.fecha = @FECHA2
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC;


-- DECLARE @FECHA1 DATETIME = '1/10/2020';
-- DECLARE @FECHA2 DATETIME = '1/5/2016';
-- EXEC TERCER_PROCEDIMIENTO @FECHA1,@FECHA2;


-- b. CantidadArt_Cli : este SP me debe devolver la cantidad de artículos o
-- clientes (según se pida) que existen en la empresa.



-- CREATE PROCEDURE CUARTO_PROCEDIMIENTO 
-- @TIPO  VARCHAR (100)
-- AS
-- IF(@TIPO = 'CLIENTES')
-- SELECT 
-- COUNT (C.cod_cliente) AS 'TOTAL CLIENTES'
-- FROM CLIENTES C 
-- ELSE 
-- BEGIN 
-- SELECT 
-- COUNT (A.cod_articulo) AS 'TOTAL ARTICULOS'
-- FROM ARTICULOS A 
-- END;



-- DECLARE @ENTRADA VARCHAR (100) = 'ARTICULOS';
-- EXEC CUARTO_PROCEDIMIENTO @ENTRADA;

-- c. INS_Vendedor: Cree un SP que le permita insertar registros en la tabla
-- vendedores.

-- CREATE PROCEDURE QUINTO_PROCEDIMIENTO
-- @NOMBRE VARCHAR (50),
-- @APELLIDO VARCHAR (50),
-- @CALLE VARCHAR (50),
-- @BARRIO INT
-- AS
-- INSERT INTO VENDEDORES  (nom_vendedor,ape_vendedor,calle,cod_barrio) VALUES (@NOMBRE,@APELLIDO,@CALLE,@BARRIO)

-- DECLARE @NOMBRE VARCHAR (50) = 'LEONARDO';
-- DECLARE @APELIIDO VARCHAR (50) = 'BRITOS';
-- DECLARE @CALLE VARCHAR (50) = 'AVENIDA 123';
-- DECLARE @BARRIO INT = 1;
-- EXEC QUINTO_PROCEDIMIENTO @NOMBRE,@APELIIDO,@CALLE,@BARRIO


-- CREATE PROCEDURE SEXTO_PROCEDIMIENTO 
-- @NOMBRE VARCHAR (50),
-- @APELLIDO VARCHAR (50),
-- @CALLE VARCHAR (50),
-- @BARRIO INT,
-- @VENDEDOR INT
-- AS 
-- UPDATE VENDEDORES SET nom_vendedor = @NOMBRE ,ape_vendedor = @APELLIDO, calle = @CALLE, cod_barrio = @BARRIO
-- WHERE cod_vendedor = @VENDEDOR

-- DECLARE @NOMBRE VARCHAR (50) = 'LEONARDO';
-- DECLARE @APELIIDO VARCHAR (50) = 'BRITOS';
-- DECLARE @CALLE VARCHAR (50) = 'AVENIDA 123';
-- DECLARE @BARRIO INT = 1;
-- DECLARE @VENDEDOR INT = 8;
-- EXEC SEXTO_PROCEDIMIENTO @NOMBRE,@APELIIDO,@CALLE,@BARRIO,@VENDEDOR;


-- e. DEL_Vendedor: cree un SP que le permita eliminar un vendedor
-- ingresado.

-- CREATE PROCEDURE SEPTIMO_PROCEDIMIENTO
-- @VENDEDOR INT 
-- AS 
-- DELETE FROM VENDEDORES WHERE cod_vendedor = @VENDEDOR


-- EXEC SEPTIMO_PROCEDIMIENTO 8;

-- 2. Modifique el SP 1-a, permitiendo que los resultados del SP puedan filtrarse por
-- una fecha determinada, por un rango de fechas y por un rango de vendedores;
-- según se pida.


-- a. Detalle_Ventas: liste la fecha, la factura, el vendedor, el cliente, el
-- artículo, cantidad e importe. Este SP recibirá como parámetros de E un
-- rango de fechas.


-- ALTER PROCEDURE TERCER_PROCEDIMIENTO 
-- @FECHA1 DATETIME,
-- @FECHA2 DATETIME, 
-- @VENDEDOR1 INT, 
-- @VENDEDOR2 INT 
-- AS

-- IF(@FECHA1 IS NULL)
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE F.fecha = @FECHA2
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC

-- ELSE IF(@FECHA2 IS NULL)
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE F.fecha = @FECHA1
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC

-- ELSE IF(@FECHA1 IS NOT NULL AND @FECHA2 IS NOT NULL)
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE F.fecha = @FECHA1 AND F.fecha = @FECHA2
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC

-- ELSE IF(@VENDEDOR1 IS NULL)
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE v.cod_vendedor = @VENDEDOR2
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC

-- ELSE IF(@VENDEDOR2 IS NULL)
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE V.cod_vendedor = @VENDEDOR1
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC

-- ELSE IF(@VENDEDOR1 IS NOT NULL AND @VENDEDOR2 IS NOT NULL)
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE V.cod_vendedor = @VENDEDOR1 AND V.cod_vendedor = @VENDEDOR2 
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC

-- ELSE IF(@FECHA1 IS NOT NULL AND @FECHA2 IS NOT NULL AND @VENDEDOR1 IS NOT NULL AND @VENDEDOR2 IS NOT NULL)
-- SELECT
-- F.nro_factura AS 'FACTURA ID',
-- F.fecha AS 'FECHA',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE',
-- A.cod_articulo AS 'ARTICULO ID',
-- SUM(DF.cantidad) AS 'CANTIDAD',
-- SUM(DF.pre_unitario) AS 'IMPORTE'
-- FROM FACTURAS F 
-- JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
-- JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
-- WHERE F.fecha = @FECHA1 AND F.fecha = @FECHA2 
-- AND V.cod_vendedor = @VENDEDOR1 AND V.cod_vendedor = @VENDEDOR2
-- GROUP BY F.nro_factura,F.fecha,V.nom_vendedor,C.nom_cliente,A.cod_articulo
-- ORDER BY F.nro_factura ASC;

-- DECLARE @FECHA1 DATETIME = '22/10/1993';
-- DECLARE @FECHA2 DATETIME = '22/10/2018';
-- DECLARE @VENDEDOR1 INT = 5;
-- DECLARE @VENDEDOR2 INT = 6;
-- EXEC TERCER_PROCEDIMIENTO @FECHA1,@FECHA2,@VENDEDOR1, @VENDEDOR2;

/*4. Elimine los SP creados en el punto 1.*/

/*Problema N° 3.3: Funciones definidas por el usuario*/

-- 5. Cree las siguientes funciones:

-- a. Hora: una función que les devuelva la hora del sistema en el formato
-- HH:MM:SS (tipo carácter de 8).

-- CREATE FUNCTION PRIMERA_FUNCION ()
-- RETURNS TABLE 
-- AS
-- RETURN
-- (SELECT DATENAME(HOUR,GETDATE()) + ':'  + DATENAME(MINUTE,GETDATE()) + ':' + DATENAME(SECOND,GETDATE()) AS 'TIME');

-- SELECT * FROM PRIMERA_FUNCION();

-- b. Fecha: una función que devuelva la fecha en el formato AAAMMDD (en
-- carácter de 8), a partir de una fecha que le ingresa como parámetro
-- (ingresa como tipo fecha).

-- CREATE FUNCTION SEGUNDA_FUNCION (@FECHA DATETIME = NULL)
-- RETURNS TABLE
-- AS 
-- RETURN 
-- (SELECT FORMAT(@FECHA,'dd/MM/yyyy') AS 'FECHA FORMATEADA');

-- SELECT * FROM SEGUNDA_FUNCION('1993/10/22');

-- c. Dia_Habil: función que devuelve si un día es o no hábil (considere
-- como días no hábiles los sábados y domingos). Debe devolver 1
-- (hábil), 0 (no hábil)


-- CRATE FUNCTION TERCERA_FUNCION (@DIA VARCHAR (50) = NULL)
-- RETURNS INT
-- AS
-- BEGIN
-- DECLARE @SALIDA INT 
-- IF(@DIA = 'SABADO' OR @DIA = 'DOMINGO')
-- SET @SALIDA = 0
-- ELSE 
-- SET @SALIDA = 1
-- RETURN @SALIDA
-- END;

-- SELECT dbo.TERCERA_FUNCION('LUNES') AS 'DIA HABIL';

-- 6. Modifique la f(x) 1.c, considerando solo como día no hábil el domingo.

-- ALTER FUNCTION TERCERA_FUNCION (@DIA VARCHAR (50) = NULL)
-- RETURNS INT
-- AS
-- BEGIN
-- DECLARE @SALIDA INT 
-- IF(@DIA = 'DOMINGO')
-- SET @SALIDA = 0
-- ELSE 
-- SET @SALIDA = 1
-- RETURN @SALIDA
-- END;

-- 7. Ejecute las funciones creadas en el punto 1 (todas).

-- SELECT * FROM PRIMERA_FUNCION();

-- SELECT * FROM SEGUNDA_FUNCION('1993/10/22');

-- SELECT dbo.TERCERA_FUNCION('LUNES') AS 'DIA HABIL';

-- 8. Elimine las funciones creadas en el punto 1.

-- DROP PRIMERA_FUNCION();

-- DROP SEGUNDA_FUNCION('1993/10/22');

-- SELECT dbo.TERCERA_FUNCION('LUNES') AS 'DIA HABIL';






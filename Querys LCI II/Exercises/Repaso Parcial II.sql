--Problema 3.1: Vistas

--Desde el �rea de programaci�n del sistema de informaci�n de una librer�a
--mayorista se solicita la creaci�n de una serie de vistas desde la base de datos de la
--facturaci�n de este negocio.

--1. El c�digo y nombre completo de los clientes, la direcci�n (calle y n�mero) y
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

--2. Cree una vista que liste la fecha, la factura, el c�digo y nombre del vendedor, el
--art�culo, la cantidad e importe, para lo que va del a�o. Rotule como FECHA,
--NRO_FACTURA, CODIGO_VENDEDOR, NOMBRE_VENDEDOR, ARTICULO,
--CANTIDAD, IMPORTE.
--solo tome el mes pasado (mes anterior al actual) y que tambi�n muestre la
--direcci�n del vendedor.

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


--Problema N� 3.2: Procedimientos Almacenados

--procedimiento que muestre los art�culos cuyo
--precio unitario sea menor a un precio que se ingresar� en el momento en que se
--ejecute el mismo:
--art�culo de c�digo determinado (enviado como par�metro de entrada) y nos retorne
--el total facturado para ese art�culo y el promedio ponderado de los precios de venta
--de ese art�culo
--"articulos". Los par�metros correspondientes al pre_unitario DEBEN ingresarse con
--un valor distinto de "null", los dem�s son opcionales. El procedimiento retorna "1" si
--la inserci�n se realiza, es decir, si se ingresan valores para pre_unitario y "0", en
--caso que pre_unitario sea nulo:

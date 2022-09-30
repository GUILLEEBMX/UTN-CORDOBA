USE LIBRERIA_LCI_II;

/*CREATE VIEW view_clients AS 
SELECT 
C.nom_cliente  AS 'CLIENTES', 
B.barrio AS 'Bº', 
C.calle AS 'CALLE' , 
C.altura AS 'Nº'
FROM CLIENTES C 
JOIN BARRIOS B ON C.cod_barrio = B.cod_barrio*/

/*SELECT CLIENTES, Bº,CALLE,Nº 
FROM view_clients;*/

/*ALTER VIEW  CLIENTS_NO_EMAIL AS
SELECT 
C.nom_cliente AS 'CLIENTS',
C.[e-mail] AS 'EMAIL',
C.nro_tel AS 'TEL'
FROM CLIENTES C 
WHERE C.[e-mail] IS NULL
AND C.nro_tel IS NOT NULL

SELECT CLIENTS, EMAIL,TEL 
FROM  CLIENTS_NO_EMAIL;*/

/*CREATE VIEW  CLIENTS_HAS_EMAIL AS
SELECT 
C.nom_cliente AS 'CLIENTES',
C.[e-mail] AS 'EMAIL'
FROM CLIENTES C 
WHERE C.[e-mail] IS NOT NULL

SELECT CLIENTES, EMAIL 
FROM  CLIENTS_HAS_EMAIL*/


/*CREATE VIEW CLIENTS_VIEW
WITH
    ENCRYPTION

AS
    SELECT
        C.nom_cliente AS 'CLIENTS',
        B.barrio AS 'Bº'
    FROM CLIENTES C
        JOIN BARRIOS B ON C.cod_barrio = B.cod_barrio


SELECT *
FROM CLIENTS_VIEW;*/

/*EJERCICIO 2 A - F  */

/*2. Cree una vista que liste la fecha, la factura, el código y nombre del vendedor, el
artículo, la cantidad e importe, para lo que va del año. Rotule como FECHA,
NRO_FACTURA, CODIGO_VENDEDOR, NOMBRE_VENDEDOR, ARTICULO,
CANTIDAD, IMPORTE.*/


/*CREATE VIEW SEND_TEACHER
AS
    SELECT DISTINCT 
        F.nro_factura AS 'Nº FACTURA',
        YEAR(F.fecha) AS 'FECHA',
        F.cod_vendedor AS 'CODIGO_VENDEDOR',
        V.nom_vendedor AS 'NOMBRE_VENDEDOR',
        A.descripcion AS 'ARTICULO',
        SUM(DF.cantidad) AS 'CANTIDAD',
        SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE'
    FROM detalle_facturas DF
        JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
        JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor
        JOIN articulos A ON A.cod_articulo = DF.cod_articulo
    WHERE YEAR(F.fecha) = YEAR(GETDATE())
    GROUP BY F.nro_factura, F.fecha, F.cod_vendedor,V.nom_vendedor,A.descripcion

SELECT * FROM SEND_TEACHER*/

/*3. Modifique la vista creada en el punto anterior, agréguele la condición de que
solo tome el mes pasado (mes anterior al actual) y que también muestre la
dirección del vendedor.*/

/*ALTER VIEW SEND_TEACHER
AS
    SELECT DISTINCT 
        F.nro_factura AS 'Nº FACTURA',
        MONTH(F.fecha) AS 'MES',
        F.cod_vendedor AS 'CODIGO_VENDEDOR',
        V.nom_vendedor AS 'NOMBRE_VENDEDOR',
        A.descripcion AS 'ARTICULO',
        SUM(DF.cantidad) AS 'CANTIDAD',
        SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE'
    FROM detalle_facturas DF
        JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
        JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor
        JOIN articulos A ON A.cod_articulo = DF.cod_articulo
    WHERE MONTH(F.fecha) = MONTH(GETDATE()) -1
    GROUP BY F.nro_factura, F.fecha, F.cod_vendedor,V.nom_vendedor,A.descripcion;

    SELECT * FROM SEND_TEACHER*/

/* 4. Consulta las vistas según el siguiente detalle:
a. Llame a la vista creada en el punto anterior pero filtrando por importes
inferiores a $120.
b. Llame a la vista creada en el punto anterior filtrando para el vendedor
Miranda.
c. Llama a la vista creada en el punto 4 filtrando para los importes
menores a 10.000.*/


/*SELECT * FROM SEND_TEACHER WHERE IMPORTE < 120;
SELECT * FROM SEND_TEACHER WHERE NOMBRE_VENDEDOR = 'Miranda';
SELECT * FROM SEND_TEACHER WHERE IMPORTE < 100000;*/

/*5. Elimine las vistas creadas en el punto 3*/


/*######################################## STORES PROCEDURES #################################################*/

/*CREATE PROCEDURE SP_ARTICULOS_SUMA_PROMEDIO
    @descripcion VARCHAR (100) = '%',
    @suma DECIMAL (10,2) OUTPUT,
    @promedio DECIMAL (8,2) OUTPUT
AS
SELECT
    A.descripcion AS 'DESCRIPCION',
    A.pre_unitario AS 'PRECIO',
    A.observaciones AS 'OBSERVACIONES'
FROM ARTICULOS A
WHERE A.descripcion LIKE @descripcion
SELECT
    @promedio = AVG(pre_unitario)
FROM ARTICULOS
WHERE descripcion LIKE @descripcion*/


/*ENVIAR SP 8-7*/

-- CREATE PROCEDURE SP_ARTICULOS_OFERTAS
-- AS
-- SELECT
--     A.descripcion AS 'DESCRIPCION',
--     A.pre_unitario AS 'PRECIO',
--     A.observaciones AS 'OBSERVACIONES'
-- FROM ARTICULOS A
-- WHERE A.pre_unitario < 100 ;


-- CREATE PROCEDURE SP_ARTICULOS_SUMA_PROMEDIO_ENCRYPTED
--     @descripcion VARCHAR (100) = '%',
--     @suma DECIMAL (10,2) OUTPUT,
--     @promedio DECIMAL (8,2) OUTPUT
-- WITH
--     ENCRYPTION
-- AS
-- SELECT
--     A.descripcion AS 'DESCRIPCION',
--     A.pre_unitario AS 'PRECIO',
--     A.observaciones AS 'OBSERVACIONES'
-- FROM ARTICULOS A
-- WHERE A.descripcion LIKE @descripcion
-- SELECT
--     @promedio = AVG(pre_unitario)
-- FROM ARTICULOS
-- WHERE descripcion LIKE @descripcion


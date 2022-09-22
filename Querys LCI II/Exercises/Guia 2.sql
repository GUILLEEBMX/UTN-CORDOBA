USE LIBRERIA_LCI_II;

/*Problema 2.1: Subconsultas en el Where*/

/*1. Se solicita un listado de artículos cuyo precio es inferior al promedio de
precios de todos los artículos. (está resuelto en el material teórico)*/


SELECT *
FROM ARTICULOS A
WHERE A.pre_unitario <  (SELECT AVG(A.pre_unitario)
FROM ARTICULOS A )

/*2. Emitir un listado de los artículos que no fueron vendidos este año. En ese
listado solo incluir aquellos cuyo precio unitario del artículo oscile entre
50 y 100. */



/*3. Genere un reporte con los clientes que vinieron más de 2 veces el año
pasado. */





/*4. Se quiere saber qué clientes no vinieron entre el 12/12/2015 y el 13/7/2020*/

SELECT DISTINCT F.cod_cliente AS 'CLIENTES'
FROM FACTURAS F
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE  NOT EXISTS (SELECT F.cod_cliente
FROM FACTURAS F
WHERE F.fecha NOT BETWEEN '12/12/2015' AND '13/7/2020' )

--REVISAR--


/*5. Listar los datos de las facturas de los clientes que solo vienen a comprar
en febrero es decir que todas las veces que vienen a comprar haya sido
en el mes de febrero (y no otro mes). */

SELECT
    C.nom_cliente AS 'CLIENTES',
    F.nro_factura AS 'Nº FACTURA',
    MONTH(F.fecha) AS 'MES'
FROM FACTURAS F
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE F.nro_factura IN
(SELECT F.nro_factura
WHERE MONTH(F.fecha) = 2)

/*6. Mostrar los datos de las facturas para los casos en que por año se hayan
hecho menos de 9 facturas. */

SELECT
    F.fecha AS 'FECHA',
    F.nro_factura AS 'ID FACTURA'
FROM FACTURAS F
WHERE YEAR(fecha) IN (SELECT YEAR(fecha)
FROM FACTURAS
GROUP BY YEAR(fecha)
HAVING
COUNT(nro_factura) <9 )

/*7. Emitir un reporte con las facturas cuyo importe total haya sido superior a
1.500 (incluir en el reporte los datos de los artículos vendidos y los
importes).*/

SELECT
    F.nro_factura AS 'ID FACTURA',
    A.descripcion AS 'ARTICULO',
    DF.pre_unitario AS 'IMPORTE',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
GROUP BY F.nro_factura, A.descripcion,DF.pre_unitario
HAVING SUM(DF.cantidad * DF.pre_unitario) > 1500
ORDER BY 4;


/*8. Se quiere saber qué vendedores nunca atendieron a estos clientes: 1 y 6.
Muestre solamente el nombre del vendedor. */

SELECT DISTINCT
    V.cod_vendedor AS 'VENDEDORES'
FROM FACTURAS F
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
WHERE F.cod_cliente IN (SELECT C.cod_cliente
FROM CLIENTES C
WHERE C.cod_cliente != 1 AND C.cod_cliente != 6)
ORDER BY 1;

/*9. Listar los datos de los artículos que superaron el promedio del Importe de
ventas de $ 1.000.*/

SELECT DISTINCT
    A.descripcion AS 'ARTICULOS',
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO VENTAS'
FROM detalle_facturas DF
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
GROUP BY A.descripcion
HAVING AVG(DF.cantidad * DF.pre_unitario) > 1000

--REVEER--

/*10. ¿Qué artículos nunca se vendieron? Tenga además en cuenta que su
nombre comience con letras que van de la “d” a la “p”. Muestre solamente
la descripción del artículo. */


SELECT DISTINCT
    A.descripcion AS 'ARTICULOS'
FROM detalle_facturas DF
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE DF.cod_articulo NOT IN (SELECT DF.cod_articulo
WHERE A.descripcion LIKE '[D-P]%' )

--REVISAR--

/*11. Listar número de factura, fecha y cliente para los casos en que ese cliente
haya sido atendido alguna vez por el vendedor de código 3. */

SELECT DISTINCT
    F.nro_factura AS 'Nº FACTURA',
    DAY(F.fecha) AS 'FECHA',
    F.cod_cliente AS 'ID CLIENTE',
    F.cod_vendedor AS 'VENDEDOR'
FROM FACTURAS F
WHERE F.nro_factura IN (SELECT DISTINCT F.nro_factura
WHERE F.cod_vendedor = 3)
ORDER BY F.cod_cliente,DAY(F.fecha);

--REVISAR--

/*12. Listar número de factura, fecha, artículo, cantidad e importe para los
casos en que todas las cantidades (de unidades vendidas de cada
artículo) de esa factura sean superiores a 40.*/


SELECT
    F.nro_factura AS 'Nº FACTURA',
    F.fecha AS 'FECHA',
    DF.cod_articulo AS 'ARTICULO ID',
    SUM(DF.cantidad) AS 'CANTIDAD',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
GROUP BY F.nro_factura, F.fecha,DF.cod_articulo
HAVING SUM(DF.cantidad) > 40

/*13. Emitir un listado que muestre número de factura, fecha, artículo, cantidad
e importe; para los casos en que la cantidad total de unidades vendidas
sean superior a 80. */

SELECT
    F.nro_factura AS 'Nº FACTURA',
    F.fecha AS 'FECHA',
    DF.cod_articulo AS 'ARTICULO ID',
    SUM(DF.cantidad) AS 'CANTIDAD',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
GROUP BY F.nro_factura, F.fecha,DF.cod_articulo
HAVING SUM(DF.cantidad) > 80

--PARA MI ESTA BIEN EL PROFE LO RESUELVE CON OTROS PARAMETROS--

/*14. Realizar un listado de número de factura, fecha, cliente, artículo e importe
para los casos en que al menos uno de los importes de esa factura sea
menor a 3.000.*/

SELECT DISTINCT
    F.nro_factura AS 'Nº FACTURA',
    F.fecha AS 'FECHA',
    F.cod_cliente AS 'CLIENTE',
    DF.cod_articulo AS 'ARTICULO',
    SUM(DF.cantidad * DF .pre_unitario) AS 'TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
GROUP BY F.nro_factura, F.fecha, F.cod_cliente,DF.cod_articulo
HAVING SUM(DF.cantidad * DF.pre_unitario) < 3000;

/*Problema 2.2: Subconsultas en el Having*/


/*1. Se quiere saber ¿cuándo realizó su primer venta cada vendedor? y
¿cuánto fue el importe total de las ventas que ha realizado? Mostrar estos
datos en un listado solo para los casos en que su importe promedio de
vendido sea superior al importe promedio general (importe promedio de
todas las facturas). */

SELECT
    V.nom_vendedor AS 'NAME',
    MIN(FORMAT(F.fecha,'dd/MM/yyyy')) AS 'FECHA',
    SUM(DF.cantidad * DF.pre_unitario) AS 'TOTAL VENTAS'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
GROUP BY V.nom_vendedor
HAVING AVG(DF.cantidad * DF.pre_unitario) < (SELECT AVG(cantidad * pre_unitario)
FROM detalle_facturas )
ORDER BY 1;

/*2. Liste los montos totales mensuales facturados por cliente y además del
promedio de ese monto y el promedio de precio de artículos Todos esto
datos correspondientes a período que va desde el 1° de febrero al 30 de
agosto del 2014. Sólo muestre los datos si esos montos totales son
superiores o iguales al promedio global. */


SELECT
    C.nom_cliente AS 'CLIENTE',
    MONTH(F.fecha) AS 'FECHA',
    SUM(DF.cantidad * DF.pre_unitario) AS 'MONTOS TOTALES',
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO',
    AVG(DF.pre_unitario) AS 'PROMEDIO ARTICULOS'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE F.fecha BETWEEN '1/2/2014' AND '30/8/2014'
GROUP BY C.nom_cliente,MONTH(F.fecha)
HAVING SUM(DF.cantidad * DF.pre_unitario) >= (SELECT AVG(cantidad * pre_unitario)
FROM detalle_facturas);

/*3. Por cada artículo que se tiene a la venta, se quiere saber el importe
promedio vendido, la cantidad total vendida por artículo, para los casos
en que los números de factura no sean uno de los siguientes: 2, 10, 7, 13,
22 y que ese importe promedio sea inferior al importe promedio de ese
artículo.*/

SELECT
    A.cod_articulo AS 'ARTICULO',
    AVG(DF.pre_unitario * DF.cantidad) AS 'IMPORTE PROMEDIO',
    SUM(DF.cantidad) AS 'CANTIDAD VENDIDA'
FROM detalle_facturas DF
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE DF.nro_factura NOT IN (2,10,7,13,22)
GROUP BY A.cod_articulo
HAVING AVG(DF.pre_unitario * DF.cantidad) < (SELECT AVG(DF2.cantidad * DF2.pre_unitario)
FROM detalle_facturas DF2
WHERE DF2.cod_articulo = A.cod_articulo)
ORDER BY 1;

/*4. Listar la cantidad total vendida, el importe y promedio vendido por fecha,
siempre que esa cantidad sea superior al promedio de la cantidad global.
Rotule y ordene. */

SELECT
    FORMAT(F.FECHA,'dd/MM/yyyy') AS 'FECHA',
    SUM(DF.cantidad) AS 'CANTIDAD TOTAL',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL',
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
GROUP BY F.fecha
HAVING SUM(DF.cantidad) > (SELECT AVG(cantidad)
FROM detalle_facturas);

/*5. Se quiere saber el promedio del importe vendido y la fecha de la primer
venta por fecha y artículo para los casos en que las cantidades vendidas
oscilen entre 5 y 20 y que ese importe sea superior al importe promedio
de ese artículo.*/

SELECT
    A.cod_articulo AS 'CODIGO ARTICULO',
    A.descripcion AS 'ARTICULO',
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO',
    MIN(F.FECHA) AS 'FECHA'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE DF.cantidad BETWEEN 5 AND 20
GROUP BY A.cod_articulo, A.descripcion
HAVING SUM(DF.cantidad * DF.pre_unitario) > (SELECT AVG(pre_unitario)
FROM articulos )
ORDER BY A.cod_articulo

/*6. Emita un listado con los montos diarios facturados que sean inferior al
importe promedio general. */

SELECT
    FORMAT(F.fecha, 'dd/MM/yyyy') AS 'FECHA',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE DIARIO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
GROUP BY F.fecha
HAVING SUM(DF.cantidad * DF.pre_unitario) < (SELECT AVG(cantidad  * pre_unitario)
FROM detalle_facturas)


/*7. Se quiere saber la fecha de la primera y última venta, el importe total
facturado por cliente para los años que oscilen entre el 2010 y 2015 y que
el importe promedio facturado sea menor que el importe promedio total
para ese cliente. */

SELECT
    C.nom_cliente AS 'CLIENTE',
    MIN(F.fecha) AS 'PRIMERA VENTA',
    MAX(F.fecha) AS 'ULTIMA VENTA',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE YEAR (F.fecha) BETWEEN 2010 AND 2015
GROUP BY C.nom_cliente
HAVING AVG(DF.cantidad * DF.pre_unitario) < 
(SELECT SUM(DF.cantidad * DF.pre_unitario) / COUNT(DISTINCT DF.nro_factura)
FROM facturas F
    JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura)


/*8. Realice un informe que muestre cuánto fue el total anual facturado por
cada vendedor, para los casos en que el nombre de vendedor no comience
con ‘B’ ni con ‘M’, que los números de facturas oscilen entre 5 y 25 y que
el promedio del monto facturado sea inferior al promedio de ese año. */

SELECT
    V.nom_vendedor AS 'VENDEDORES',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE ANUAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
WHERE V.nom_vendedor NOT LIKE 'B%' AND V.nom_vendedor NOT LIKE 'M%'
    AND F.nro_factura BETWEEN 5 AND 25
GROUP BY V.nom_vendedor
HAVING AVG(DF.cantidad * DF.pre_unitario) < 
(SELECT SUM(DF.cantidad * DF.pre_unitario) / COUNT(DISTINCT DF.nro_factura )
FROM FACTURAS F JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura)
ORDER BY 1;



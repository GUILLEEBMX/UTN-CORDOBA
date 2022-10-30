USE LIBRERIA_LCI_II;

/*2. Se quiere saber qué vendedores y clientes hay en la empresa; para los casos en
que su teléfono y dirección de e-mail sean conocidos. Se deberá visualizar el
código, nombre y si se trata de un cliente o de un vendedor. Ordene por la
columna tercera y segunda.*/



    SELECT C.cod_cliente, C.nom_cliente AS 'CLIENTES', C.[e-mail] AS 'EMAIL', C.nro_tel AS 'TEL' , 'CLIENTES' TIPO
    FROM CLIENTES C
    WHERE C.nro_tel IS NOT NULL
        AND C.[e-mail] IS NOT  NULL

UNION

    SELECT V.cod_vendedor, V.nom_vendedor AS 'VENDEDORES', V.[e-mail] AS 'EMAIL', V.nro_tel AS 'TEL', 'VENDEDORES' TIPO
    FROM VENDEDORES V
    WHERE V.nro_tel IS NOT NULL
        AND V.[e-mail] IS NOT  NULL
ORDER BY 3,2; 


/*3. Emitir un listado donde se muestren qué artículos, clientes y vendedores hay en
la empresa. Determine los campos a mostrar y su ordenamiento.*/



    SELECT A.descripcion AS 'ARTICULOS' , 'ARTICULOS' TIPO
    FROM ARTICULOS A

UNION

    SELECT C.nom_cliente AS 'CLIENTES', 'CLIENTES'
    FROM CLIENTES C

UNION

    SELECT V.nom_vendedor AS 'VENDEDORES' , 'VENDEDORES'
    FROM VENDEDORES V

ORDER BY 2;



/*4. Se quiere saber las direcciones (incluido el barrio) tanto de clientes como de
vendedores. Para el caso de los vendedores, códigos entre 3 y 12. En ambos
casos las direcciones deberán ser conocidas. Rotule como NOMBRE,
DIRECCION, BARRIO, INTEGRANTE (en donde indicará si es cliente o vendedor).
Ordenado por la primera y la última columna.*/


    SELECT C.nom_cliente AS 'CLIENTES', C.calle, C.altura AS 'DIRECCION', B.barrio AS 'BARRIOS', 'CLIENTES' INTEGRANTES
    FROM CLIENTES C
        JOIN BARRIOS B ON B.cod_barrio = C.cod_barrio
    WHERE C.cod_barrio IS NOT NULL


UNION

    SELECT V.nom_vendedor AS 'VENDEDORES' , V.calle, V.altura AS 'DIRECCION', B.barrio AS 'BARRIOS', 'VENDEDORES' INTEGRANTES
    FROM VENDEDORES V
        JOIN BARRIOS B ON B.cod_barrio = V.cod_barrio
    WHERE V.cod_vendedor BETWEEN 3 AND 12
        AND
        V.cod_barrio IS NOT NULL
ORDER BY 1;

/*5. Ídem al ejercicio anterior, sólo que además del código, identifique de donde
obtiene la información (de qué tabla se obtienen los datos).*/



    SELECT C.nom_cliente AS 'CLIENTES', C.calle, C.altura AS 'DIRECCION', B.barrio AS 'BARRIOS', 'CLIENTES' TABLA
    FROM CLIENTES C
        JOIN BARRIOS B ON B.cod_barrio = C.cod_barrio
    WHERE C.cod_barrio IS NOT NULL


UNION

    SELECT V.nom_vendedor AS 'VENDEDORES' , V.calle, V.altura AS 'DIRECCION', B.barrio AS 'BARRIOS', 'VENDEDORES' TABLA
    FROM VENDEDORES V
        JOIN BARRIOS B ON B.cod_barrio = V.cod_barrio
    WHERE V.cod_vendedor BETWEEN 3 AND 12
        AND
        V.cod_barrio IS NOT NULL
ORDER BY 1;

/*6. Listar todos los artículos que están a la venta cuyo precio unitario oscile entre 10
y 50; también se quieren listar los artículos que fueron comprados por los
clientes cuyos apellidos comiencen con “M” o con “P”.*/


    SELECT A.pre_unitario AS 'PRECIO UNITARIO' , A.stock AS 'STOCK', '1st CONSULTA' 'TIPO CONSULTA'
    FROM ARTICULOS A
    WHERE A.stock >=1 AND A.pre_unitario BETWEEN 10 AND 50

UNION
    SELECT A.pre_unitario AS 'PRECIO UNITARIO', A.stock AS 'STOCK', '2nd CONSULTA'
    FROM ARTICULOS A
        JOIN detalle_facturas DF ON DF.cod_articulo = A.cod_articulo
        JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
        JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
    WHERE C.ape_cliente LIKE 'M%'
        OR
        C.ape_cliente LIKE 'P%'
ORDER BY 1;

/*7. El encargado del negocio quiere saber cuánto fue la facturación del año pasado.
Por otro lado, cuánto es la facturación del mes pasado, la de este mes y la de
hoy (Cada pedido en una consulta distinta, y puede unirla en una sola tabla de
resultado)*/

    SELECT SUM(DF.pre_unitario * DF.cantidad)  AS 'TOTAL FACTURADO', 'AÑO PASADO' 'TIPO'
    FROM FACTURAS F
        JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
    WHERE YEAR(F.fecha) = YEAR(GETDATE()) -1

UNION

    SELECT SUM(DF.pre_unitario * DF.cantidad)  AS 'TOTAL FACTURADO', 'MES PASADO' 'TIPO'
    FROM FACTURAS F
        JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
    WHERE MONTH(F.fecha) = MONTH(GETDATE()) -1

UNION

    SELECT SUM(DF.pre_unitario * DF.cantidad)  AS 'TOTAL FACTURADO', 'MES ACTUAL' 'TIPO'
    FROM FACTURAS F
        JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
    WHERE MONTH(F.fecha) = MONTH(GETDATE())

UNION

    SELECT SUM(DF.pre_unitario * DF.cantidad)  AS 'TOTAL FACTURADO'  , 'DIA ACTUAL' 'TIPO'
    FROM FACTURAS F
        JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
    WHERE DAY(F.fecha) = DAY(GETDATE())


/*Problema 1.2: Consultas Sumarias*/

/*7. Se quiere saber la cantidad de ventas que hizo el vendedor de código 3.*/


SELECT V.cod_vendedor AS 'VENDEDOR', COUNT(*)  AS 'TOTAL VENTAS '
FROM FACTURAS F
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
WHERE V.cod_vendedor = 3
GROUP BY V.cod_vendedor


/*8. ¿Cuál fue la fecha de la primera y última venta que se realizó en este
negocio?*/

SELECT MAX(FORMAT(F.fecha,'dd/MM/yyyy')) AS 'FECHA MÁS ANTIGUA', MIN(FORMAT(F.fecha,'dd/MM/yyyy')) AS 'FECHA MÁS ACTUAL'
FROM FACTURAS F

/*9. Mostrar la siguiente información respecto a la factura nro.: 450: cantidad
total de unidades vendidas, la cantidad de artículos diferentes vendidos y
el importe total.*/

SELECT SUM( DF.cantidad) AS 'UNIDADES VENDIDAS' ,
    COUNT (DISTINCT DF.cod_articulo) AS 'CANT ARTICULOS VENDIDOS',
    SUM(DF.pre_unitario * DF.cantidad) AS 'IMPORTE TOTAL VENDIDO'
FROM detalle_facturas DF
WHERE DF.nro_factura = 450

/*10.¿Cuál fue la cantidad total de unidades vendidas, importe total y el
importe promedio para vendedores cuyos nombres comienzan con letras
que van de la “d” a la “l”?*/


SELECT SUM(DF.cantidad) AS 'UNIDADES VENDIDAS' , SUM(DF.pre_unitario * cantidad) AS 'TOTAL VENDIDO', AVG(DF.pre_unitario) 'PROMEDIO VENDEDORES'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
WHERE V.nom_vendedor LIKE '[D-L]%'


/*11.Se quiere saber el importe total vendido, el promedio del importe vendido
y la cantidad total de artículos vendidos para el cliente Roque Paez.*/

SELECT SUM(DF.pre_unitario * DF.cantidad) AS 'TOTAL VENDIDO' , AVG(DF.pre_unitario * DF.cantidad) AS 'PROMEDIO', COUNT(DF.cod_articulo) AS 'TOTAL ARTICULOS'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE C.nom_cliente = 'Roque'
    AND C.ape_cliente = 'Paez'

/*12.Mostrar la fecha de la primera venta, la cantidad total vendida y el importe
total vendido para los artículos que empiecen con “C”.*/

SELECT MIN(YEAR(F.fecha)) AS 'FECHA 1era VENTA', COUNT(DF.cantidad) AS 'CANTIDAD TOTAL VENDIDO' , SUM(DF.pre_unitario * DF.cantidad) AS 'IMPORTE TOTAL VENDIDO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE A.descripcion LIKE 'C%'

/*13.Se quiere saber la cantidad total de artículos vendidos y el importe total
vendido para el periodo del 15/06/2011 al 15/06/2017.*/

SELECT COUNT(DF.cantidad) AS 'TOTAL ARTICULOS', SUM(DF.pre_unitario * DF.cantidad) AS 'IMPORTE TOTAL' , F.fecha AS 'FECHA'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
WHERE F.fecha BETWEEN '15/06/2011' AND '15/06/2017'
GROUP BY F.fecha

SELECT DF.cod_articulo AS 'ARTICULOS', (A.pre_unitario *
COUNT(DF.cod_articulo)) AS 'TOTAL VENDIDO'
FROM detalle_facturas DF
    JOIN ARTICULOS A ON DF.cod_articulo = A.cod_articulo
    JOIN FACTURAS F ON DF.nro_factura = f.nro_factura
WHERE F.fecha >= CAST('06/15/2011' as date) AND F.fecha <= CAST('06/15/2017' as date)
GROUP BY A.pre_unitario,DF.cod_articulo;

--VER PARA MI NO HACE FALTA EL JOIN CON ARTICULOS


/*14.Se quiere saber la cantidad de veces y la última vez que vino el cliente de
apellido Abarca y cuánto gastó en total.*/

SELECT MAX(F.fecha) 'LAST DATE', COUNT(DISTINCT F.nro_factura) AS 'CANTIDAD DE VECES' , SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE C.ape_cliente = 'Abarca';

/*15.Mostrar el importe total y el promedio del importe para los clientes cuya
dirección de mail es conocida.*/

SELECT SUM(DF.pre_unitario * DF.cantidad) AS 'IMPORTE TOTAL', AVG(DF.pre_unitario * DF.cantidad) AS 'PROMEDIO' , C.[e-mail]
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE C.[e-mail] IS NOT  NULL
GROUP BY C.[e-mail]

/*16.Obtener la siguiente información: el importe total vendido y el importe
promedio vendido para números de factura que no sean los siguientes:
13, 5, 17, 33, 24.*/

SELECT F.nro_factura AS 'NRO FACTURA', SUM(DF.cantidad * DF.pre_unitario) AS 'TOTAL VENDIDO' , AVG(DF.cantidad * DF.pre_unitario) AS  'PROMEDIO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE F.nro_factura NOT IN (13,5,17,33,24)
GROUP BY F.nro_factura
;

/*Problema 1.3: Consultas agrupadas: Cláusula GROUP BY*/

/*2. Por cada factura emitida mostrar la cantidad total de artículos vendidos
(suma de las cantidades vendidas), la cantidad ítems que tiene cada
factura en el detalle (cantidad de registros de detalles) y el Importe total
de la facturación de este año.*/


SELECT F.nro_factura AS 'NRO FACTURA' , SUM(DF.cantidad) AS 'CANTIDAD ARTICULOS' , COUNT(DF.nro_factura) AS 'CANTIDAD ITEMS' , SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
WHERE YEAR (F.fecha) = YEAR (GETDATE())
GROUP BY F.nro_factura
ORDER BY F.nro_factura DESC;

/*3. Se quiere saber en este negocio, cuánto se factura:
a. Diariamente
b. Mensualmente
c. Anualmente */

    SELECT SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL' , 'IMPORTE DIARIO' TIEMPO
    FROM detalle_facturas DF
        JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    WHERE DAY(F.fecha) = DAY(GETDATE()) AND MONTH(F.fecha) = MONTH(GETDATE()) AND YEAR(F.fecha) = YEAR(GETDATE())

UNION

    SELECT SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL ' , 'IMPORTE MENSUAL'
    FROM detalle_facturas DF
        JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    WHERE MONTH(F.fecha) = MONTH(GETDATE()) AND YEAR (F.fecha) = YEAR(GETDATE())


UNION

    SELECT SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL ' , 'IMPORTE ANUAL'
    FROM detalle_facturas DF
        JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    WHERE YEAR(F.fecha) = YEAR(GETDATE()) AND YEAR (F.fecha) = YEAR(GETDATE())



/*4. Emitir un listado de la cantidad de facturas confeccionadas diariamente,
correspondiente a los meses que no sean enero, julio ni diciembre.
Ordene por la cantidad de facturas en forma descendente y fecha.*/


SELECT F.fecha AS 'FECHA', COUNT (F.nro_factura) AS 'CANTIDAD FACTURAS'
FROM FACTURAS F
WHERE MONTH(F.fecha) NOT IN (1,7,12)
GROUP BY F.fecha
ORDER BY 2 DESC,F.fecha;


/*5. Se quiere saber la cantidad y el importe promedio vendido por fecha y
cliente, para códigos de vendedor superiores a 2. Ordene por fecha y
cliente.*/

SELECT FORMAT(F.fecha,'dd/MM/yyyy') AS 'FECHA', F.cod_cliente AS 'CLIENTE', SUM(DF.cantidad) AS 'CANTIDAD' , AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
WHERE V.cod_vendedor > 2
GROUP BY F.fecha,F.cod_cliente
ORDER BY F.fecha, F.cod_cliente

/*6. Se quiere saber el importe promedio vendido y la cantidad total vendida
por fecha y artículo, para códigos de cliente inferior a 3. Ordene por fecha
y artículo.*/

SELECT
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL VENDIDO' ,
    FORMAT(F.fecha,'dd/MM/yyyy') AS 'FECHA' ,
    DF.cod_articulo AS 'ARTICULO'
--C.cod_cliente AS 'CLIENTE'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE C.cod_cliente < 3
GROUP BY DF.cod_articulo,F.fecha
ORDER BY DF.cod_articulo,F.fecha;

/*7. Listar la cantidad total vendida, el importe total vendido y el importe
promedio total vendido por número de factura, siempre que la fecha no
oscile entre el 13/2/2007 y el 13/7/2010.*/

SELECT
    F.nro_factura AS 'Nº FACTURA' ,
    DF.cantidad AS 'CANTIDAD TOTAL',
    A.descripcion AS 'ARTICULO',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL' ,
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE F.fecha NOT BETWEEN '13/2/2007' AND '13/7/2010'
GROUP BY F.nro_factura,A.descripcion,DF.cantidad
--935 Resultados sin poner la fecha como el profe


SELECT
    F.nro_factura AS 'Nº FACTURA' ,
    SUM(DF.cantidad) AS 'CANTIDAD TOTAL',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL' ,
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
WHERE F.fecha NOT BETWEEN '13/2/2007' AND '13/7/2010'
GROUP BY F.nro_factura
--538 Resultados


select
    f.nro_factura 'N FACTURA',
    a.descripcion 'NOMBRE ARTICULO',
    df.cantidad 'CANTIDAD',
    sum(cantidad * a.pre_unitario) 'IMPORTE TOTAL',
    SUM(cantidad* a.pre_unitario) 'PROM TOTAL'
from detalle_facturas df
    join articulos a on a.cod_articulo = df.cod_articulo
    join facturas f on f.nro_factura = df.nro_factura
where f.fecha not between DATEFROMPARTS(2007, 7, 13) and
DATEFROMPARTS(2010, 7, 13)
group by f.nro_factura, a.descripcion, df.cantidad
--PROFE PARA MI ESTA MAL

/*8. Emitir un reporte que muestre la fecha de la primer y última venta y el
importe comprado por cliente. Rotule como CLIENTE, PRIMER VENTA,
ÚLTIMA VENTA, IMPORTE.*/

SELECT
    C.cod_cliente AS 'CLIENTE',
    MAX(F.fecha) AS 'ULTIMA VENTA' ,
    MIN(F.FECHA) AS 'PRIMERA VENTA' ,
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
    JOIN CLIENTES C ON F.cod_cliente = C.cod_cliente
GROUP BY C.cod_cliente;

/*9. Se quiere saber el importe total vendido, la cantidad total vendida y el
precio unitario promedio por cliente y artículo, siempre que el nombre del
cliente comience con letras que van de la “a” a la “m”. Ordene por cliente,
precio unitario promedio en forma descendente y artículo. Rotule como
IMPORTE TOTAL, CANTIDAD TOTAL, PRECIO PROMEDIO.*/


SELECT
    C.nom_cliente AS 'CLIENTE',
    A.descripcion AS 'ARTICULO',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTAL TOTAL',
    SUM(DF.cantidad) AS 'CANTIDAD TOTAL',
    AVG(DF.pre_unitario) AS 'PRECIO PROMEDIO'
FROM detalle_facturas DF
    JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE C.nom_cliente LIKE '[A-M]%'
GROUP BY C.nom_cliente, A.descripcion
ORDER BY C.nom_cliente, 5 DESC,A.descripcion

--102 RESULTADOS



SELECT c.nom_cliente + ' ' + c.ape_cliente Cliente,
    a.descripcion,
    sum(cantidad) 'Cantidad Total',
    sum(df.pre_unitario*cantidad) 'Importe Total',
    avg(df.pre_unitario)'PRECIO PROMEDIO'
from facturas f, detalle_facturas df, clientes c, articulos a
where c.cod_cliente = f.cod_cliente and f.nro_factura=df.nro_factura
    and c.nom_cliente >= 'A' and c.nom_cliente <= 'M'
group by c.cod_cliente,c.nom_cliente,c.ape_cliente,a.descripcion

--108 RESULTADOS PARA MI ESTA MAL

/*10.Se quiere saber la cantidad de facturas y la fecha la primer y última
factura por vendedor y cliente, para números de factura que oscilan entre
5 y 30. Ordene por vendedor, cantidad de ventas en forma descendente y
cliente.*/

SELECT
    C.cod_cliente AS 'CLIENTE',
    V.cod_vendedor AS 'VENDEDOR',
    COUNT(DISTINCT F.nro_factura) AS 'CANTIDAD FACTURAS' ,
    MIN(F.fecha) AS 'PRIMER FACTURA' ,
    MAX (F.fecha) AS 'ULTIMA FACTURA'
FROM FACTURAS F
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE F.nro_factura BETWEEN 5 AND 30
GROUP BY C.cod_cliente, V.cod_vendedor
ORDER BY V.cod_vendedor, 3 DESC, 1;

    SELECT v.ape_vendedor + ' ' + v.nom_vendedor 'Nombre y Apellido',
        COUNT(f.nro_factura) 'Cantidad de Facturas', MIN(f.fecha) 'Primer
Factura', MAx(f.fecha) 'Ultima Factura', 'Vendedor' Tipo
    FROM vendedores v
        JOIN facturas f ON f.cod_vendedor = v.cod_vendedor
    WHERE f.nro_factura BETWEEN 5 AND 30
    GROUP BY v.ape_vendedor + ' ' + v.nom_vendedor
UNION
    SELECT c.ape_cliente + ' ' + c.nom_cliente, COUNT(f.nro_factura),
        MIN(f.fecha), MAx(f.fecha), 'Cliente' Tipo
    FROM clientes c
        JOIN facturas f ON f.cod_cliente = c.cod_cliente
    WHERE f.nro_factura BETWEEN 5 AND 30
    GROUP BY c.ape_cliente + ' ' + c.nom_cliente
ORDER BY Tipo DESC, COUNT(f.nro_factura) DESC

--REVISAR 

/*Problema 1.4: Consultas agrupadas: Cláusula HAVING*/


/*3. Se quiere saber la fecha de la primera venta, la cantidad total vendida y
el importe total vendido por vendedor para los casos en que el promedio
de la cantidad vendida sea inferior o igual a 56.*/

SELECT
    V.cod_vendedor AS 'VENDEDOR',
    MIN(F.fecha) AS 'FECHA 1º VENTA',
    COUNT(DF.cantidad) AS 'CANTIDAD TOTAL VENDIDA',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL VENDIDO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
GROUP BY V.cod_vendedor
HAVING AVG(DF.cantidad) <= 56

/*4. Se necesita un listado que informe sobre el monto máximo, mínimo y
total que gastó en esta librería cada cliente el año pasado, pero solo
donde el importe total gastado por esos clientes esté entre 300 y 800.*/


SELECT
    C.cod_cliente AS 'CLIENTE',
    MAX(DF.cantidad * DF.pre_unitario) AS 'MONTO MAXIMO',
    MIN(DF.cantidad * DF.pre_unitario) AS 'MONTO MINIMO',
    SUM(DF.CANTIDAD * DF.pre_unitario) AS 'MONTO TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE YEAR(F.fecha) = YEAR(GETDATE()) -1
GROUP BY C.cod_cliente
HAVING 
SUM(DF.cantidad * DF.pre_unitario) >= 300 AND SUM(DF.cantidad * DF.pre_unitario) <= 800

--EL RESUELTO POR EL PROFE ESTA MAL

/*5. Muestre la cantidad facturas diarias por vendedor; para los casos en que
esa cantidad sea 2 o más.*/

SELECT
    V.cod_vendedor AS 'VENDEDORES',
    COUNT(F.nro_factura) AS 'CANTIDAD FACTURAS'
FROM FACTURAS F
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
WHERE DAY(F.fecha) = DAY(GETDATE())
/*AND MONTH(F.fecha) = MONTH(GETDATE()) AND YEAR(F.fecha) = YEAR(GETDATE())*/
GROUP BY V.cod_vendedor
HAVING COUNT(F.nro_factura) >= 2;

--PARA MI ESTA BIEN RESUELTO EL PROFE LE AGREGA FILTROS QUE NO SE PIDEN EN LA CONSIGNA

/*6. Desde la administración se solicita un reporte que muestre el precio
promedio, el importe total y el promedio del importe vendido por artículo
que no comiencen con “c”, que su cantidad total vendida sea 100 o más
o que ese importe total vendido sea superior a 700.*/

SELECT
    A.descripcion AS 'ARTICULO',
    AVG(DF.pre_unitario) AS 'PRECIO PROMEDIO',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL',
    AVG(DF.pre_unitario * DF.cantidad) AS 'PROMEDIO VENDIDO POR ARTICULO'
FROM detalle_facturas DF
    JOIN articulos A ON DF.cod_articulo = A.cod_articulo
WHERE A.descripcion NOT LIKE 'C%'
GROUP BY A.descripcion
HAVING SUM(DF.cantidad) >= 100 OR SUM(DF.cantidad * DF.pre_unitario) > 700


/*7. Muestre en un listado la cantidad total de artículos vendidos, el importe
total y la fecha de la primer y última venta por cada cliente, para lo
números de factura que no sean los siguientes: 2, 12, 20, 17, 30 y que el
promedio de la cantidad vendida oscile entre 2 y 6. */

SELECT
    C.cod_cliente AS 'CLIENTES',
    SUM(DF.cantidad) AS 'CANTIDAD TOTAL DE ARTICULOS',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL VENDIDO',
    MAX(F.fecha) AS 'ULTIMA FACTURA',
    MIN(F.fecha) AS 'PRIMER FACTURA'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
WHERE F.nro_factura NOT IN (2,12,20,17,30)
GROUP BY C.cod_cliente
HAVING AVG(DF.cantidad) BETWEEN 2 AND 6;

--ESTA PERFECTO EL PROFE USA OTROS PARAMETROS QUE NO SE PIDEN EN LA CONSIGNA--

/*8. Emitir un listado que muestre la cantidad total de artículos vendidos, el
importe total vendido y el promedio del importe vendido por vendedor y
por cliente; para los casos en que el importe total vendido esté entre 200
y 600 y para códigos de cliente que oscilen entre 1 y 5.*/


SELECT
    F.cod_cliente AS 'CLIENTE',
    F.cod_vendedor AS 'VENDEDOR',
    SUM(DF.cantidad) AS 'TOTAL ARTICULOS',
    SUM(DF.cantidad * DF.pre_unitario) AS 'TOTAL VENDIDO',
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO VENDIDO'
FROM detalle_facturas DF
    JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
WHERE F.cod_cliente BETWEEN 1 AND 5
GROUP BY F.cod_cliente, F.cod_vendedor
HAVING SUM(DF.cantidad * DF.pre_unitario) BETWEEN 200 AND 600;

--ESTA PERFECTO EL PROFE USA OTROS PARAMETROS QUE NO SE PIDEN EN LA CONSIGNA--

/*9. ¿Cuáles son los vendedores cuyo promedio de facturación el mes
pasado supera los $ 800?*/


SELECT
    F.cod_vendedor AS 'VENDEDORES',
    F.fecha AS 'FECHA',
    AVG(DF.cantidad * DF.pre_unitario) AS 'PROMEDIO FACTURACION'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
    JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
WHERE MONTH(F.fecha) = MONTH(GETDATE()) -1
GROUP BY F.cod_vendedor,F.fecha
HAVING AVG(DF.cantidad * DF.pre_unitario) > 800

/*10.¿Cuánto le vendió cada vendedor a cada cliente el año pasado siempre
que la cantidad de facturas emitidas (por cada vendedor a cada cliente)
sea menor a 5?*/

SELECT
    F.cod_cliente AS 'CLIENTES',
    F.cod_vendedor AS 'VENDEDORES',
    COUNT( F.nro_factura) AS 'CANTIDAD FACTURAS',
    SUM(DF.cantidad * DF.pre_unitario) AS 'IMPORTE TOTAL'
FROM detalle_facturas DF
    JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE YEAR (F.FECHA) = YEAR (GETDATE()) - 1
GROUP BY f.cod_cliente, f.cod_vendedor
HAVING COUNT( F.nro_factura) < 5

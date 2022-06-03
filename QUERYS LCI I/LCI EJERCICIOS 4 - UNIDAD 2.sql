-- EJERCICIOS 40 --

USE LIBRERIA_LCI2022;

/*2. Genere un reporte con los datos de la facturación (datos de las facturas
incluidos los del vendedor y cliente) de los años 2006, 2007, 2009 y 2012. */

SELECT  F.nro_factura, C.nom_cliente + ',' +  C.ape_cliente AS 'CLIENTES', V.nom_vendedor + ', ' + V.ape_vendedor AS 'VENDEDOR',F.fecha
FROM  facturas F
INNER JOIN clientes C ON  f.cod_cliente = c.cod_cliente
INNER JOIN vendedores V  ON F.cod_vendedor = V.cod_vendedor
WHERE  YEAR(F.fecha)  IN (2006,2007,2009,2012);

/*3. Liste los datos de la facturación, de los artículos y de la venta de las facturas
correspondientes al mes pasado.*/

SELECT f.nro_factura,DF.cod_articulo,F.fecha, DF.cantidad * DF.pre_unitario AS 'PRECIO FINAL'
FROM facturas F , detalle_facturas DF
JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE F.nro_factura = DF.nro_factura 
AND f.nro_factura = f.nro_factura AND 
DATEDIFF (MONTH,F.fecha,GETDATE()) = 1; 

/*4. Emita un listado con los datos del vendedor y las ventas que ha realizado en
lo que va del año. Muestre los vendedores aun así no tengan ventas
registradas en el año solicitado */ 

SELECT F.fecha,V.cod_vendedor,V.nom_vendedor,V.ape_vendedor
FROM vendedores V
LEFT JOIN FACTURAS F ON F.cod_vendedor = v.cod_vendedor 
WHERE YEAR(F.fecha) = YEAR(GETDATE()) OR fecha IS NULL;


/*5. Liste descripción, cantidad e importe; aun para aquellos artículos que no
registran ventas.*/

SELECT A.descripcion,df.cantidad * df.pre_unitario AS 'PRECIO FINAL'
FROM articulos A
LEFT JOIN detalle_facturas DF ON DF.cod_articulo = A.cod_articulo;

/*6. Genere un reporte con los datos de la facturación (datos de las facturas
incluidos los del vendedor y cliente) y de la venta (incluido el importe); para las
ventas de febrero y marzo de los años 2006 y 2007 y siempre que el artículo
empiece con letras que van de la “a” a la “m”. Ordene por fecha, cliente y
artículo*/

SELECT F.nro_factura,F.fecha,C.cod_cliente,A.cod_articulo,A.descripcion,C.nom_cliente + ',' + C.ape_cliente AS 'CLIENTE', V.nom_vendedor + ',' + V.ape_vendedor AS 'VENDEDOR', 
       DF.cantidad * DF.pre_unitario AS 'PRECIO FINAL'
FROM  FACTURAS F
JOIN clientes C ON C.cod_cliente = F.cod_cliente
JOIN vendedores V ON V.cod_vendedor =  F.cod_vendedor
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
JOIN articulos A ON DF.cod_articulo = A.cod_articulo
WHERE YEAR(F.fecha) IN (2006,2007)  AND MONTH(F.fecha) IN (2,3) AND A.descripcion NOT LIKE '[A-M]%'
ORDER BY F.fecha, C.cod_cliente, A.cod_articulo ASC;

/*7. Liste código de cliente, nombre, fecha y factura para las ventas del año 2007.
Muestre los clientes hayan comprado o no en ese año.*/

SELECT C.cod_cliente,C.nom_cliente + ',' + C.ape_cliente AS 'CLIENTE',F.nro_factura,F.fecha 
FROM facturas F
RIGHT JOIN clientes C  ON F.cod_cliente = C.cod_cliente
AND YEAR(F.fecha) = 2007 ;

/*8. Se quiere saber los artículos que compro la cliente Elvira López en lo que va
del año. Liste artículo, observaciones e importe.*/

SELECT C.cod_cliente, F.fecha, A.descripcion, A.pre_unitario * DF.cantidad AS 'PRECIO FINAL'
FROM facturas F
JOIN detalle_facturas DF ON F.nro_factura = DF.nro_factura
JOIN  articulos A ON A.cod_articulo = DF.cod_articulo
JOIN clientes C ON C.cod_cliente = F.cod_cliente
WHERE YEAR(F.fecha) = YEAR(GETDATE()) AND C.nom_cliente = 'Elvira Josefa';

/* 9. Se quiere saber los artículos que compraron los clientes cuyos apellidos
empiezan con “p”. Liste cliente, articulo, cantidad e importe. Ordene por cliente
y artículo, este en forma descendente. Rotule como CLIENTE, ARTICULO,
CANTIDAD, IMPORTE.*/

SELECT F.nro_factura, C.ape_cliente AS 'CLIENTES', A.cod_articulo,A.descripcion AS 'ARTICULO',DF.cantidad AS 'CANTIDAD ',A.pre_unitario * DF.cantidad AS 'IMPORTE'
FROM detalle_facturas DF
JOIN facturas F ON DF.nro_factura = F.nro_factura
JOIN CLIENTES C ON F.cod_cliente = C.cod_cliente
JOIN articulos A ON A.cod_articulo = DF.cod_articulo
AND C.ape_cliente LIKE 'P%'
ORDER BY C.ape_cliente, cod_articulo DESC;





USE LIBRERIA_LCI_II;


/*SELECT LOS ARTICULOS CUYO PRECIO UNITARIO SEA MENOR AL PROMEDIO*/

SELECT pre_unitario AS 'MENORES AVG'
FROM ARTICULOS 
WHERE pre_unitario

<

(SELECT AVG(A.pre_unitario) AS 'PROMEDIO' 

FROM articulos A) 




/*GUIA 1  PAGINA 9 EJERCICIO 13*/

/*13.Se quiere saber la cantidad total de artículos vendidos y el importe total
vendido para el periodo del 15/06/2011 al 15/06/2017.*/

/*ccanovas@frc.utn.edu.ar*/

SELECT * FROM detalle_facturas;
SELECT * FROM facturas;


SELECT DF.cod_articulo AS 'ARTICULOS', (A.pre_unitario * COUNT(DF.cod_articulo)) AS 'TOTAL VENDIDO'
FROM detalle_facturas DF 
JOIN ARTICULOS A ON DF.cod_articulo = A.cod_articulo
JOIN FACTURAS F ON DF.nro_factura = f.nro_factura
WHERE F.fecha >= '15/06/2021' AND F.fecha <= '15/06/2017'
GROUP BY A.pre_unitario,DF.cod_articulo;




/*Unidad1-Pag 15-Ej 4: Se necesita un listado que informe sobre el monto máximo, mínimo y
total que gastó en esta librería cada cliente el año pasado, pero solo
donde el importe total gastado por esos clientes esté entre 300 y 800.  */
select c.nom_cliente+' '+c.ape_cliente as 'Cliente',  max(pre_unitario*cantidad) as 'Monto Maximo', min(pre_unitario*cantidad) as 'Monto Minimo', sum(pre_unitario*cantidad) AS 'TOTAL'
from clientes c join facturas f on c.cod_cliente=f.cod_cliente
join detalle_facturas df on df.nro_factura=f.nro_factura
WHERE YEAR(F.fecha)=YEAR(GETDATE())-1  
group BY c.nom_cliente+' '+c.ape_cliente 
having  sum(pre_unitario*cantidad) >= 300 AND sum(pre_unitario*cantidad) <= 800

select * from detalle_facturas


--Listar lso clientes que compraron este año 130 rdos*/
select nom_cliente 
from clientes c join facturas f on  f.cod_cliente=c.cod_cliente
where year(f.fecha)=year(getdate())

/*SELECT cod_cliente codigo, ape_cliente + ' ' + nom_cliente
FROM CLIENTES 
WHERE cod_cliente IN (SELECT cod_cliente FROM FACTURAS WHERE YEAR(FECHA ) = YEAR (GETDATE()));*/



/*LISTAR LOS DATOS DE LOS CLIENTES QUE NO COMPRARON EL AÑO PASADO*/


SELECT cod_cliente codigo, ape_cliente + ' ' + nom_cliente
FROM CLIENTES 
WHERE cod_cliente NOT IN (SELECT cod_cliente FROM FACTURAS WHERE YEAR(FECHA ) = YEAR (GETDATE()));





/*LISTAR LOS DATOS DE LOS CLIENTES QUE COMPRARON ESTE AÑO*/

SELECT cod_cliente AS 'CODIGO', ape_cliente + ' ' + nom_cliente 
FROM CLIENTES C
WHERE EXISTS ( SELECT cod_cliente FROM FACTURAS F WHERE c.cod_cliente = f.cod_cliente
AND YEAR (FECHA) = YEAR (GETDATE()))


/*LISTAR LOS DATOS DE LOS CLIENTES QUE NO COMPRARON EL AÑO PASADO*/


SELECT cod_cliente AS 'CODIGO', ape_cliente + ' ' + nom_cliente 
FROM CLIENTES C
WHERE NOT EXISTS ( SELECT cod_cliente FROM FACTURAS F WHERE c.cod_cliente = f.cod_cliente
AND YEAR (FECHA) = YEAR (GETDATE()))



/*LISTAR LOS CLIENTES QUE ALGUNA VEZ COMPRARON MENOR A $10*/



SELECT cod_articulo AS 'ARTICLE' 
FROM articulos 
WHERE pre_unitario < 10;


SELECT C.cod_cliente AS 'ID' , C.nom_cliente as 'CLIENT NAME', DF.pre_unitario AS 'TOTAL PRICE'
FROM clientes C
JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
JOIN detalle_facturas DF ON DF.nro_factura = f.nro_factura
WHERE (df.pre_unitario < 10)



/*LISTAR LOS CLIENTES QUE SIEMPRE FUERON ANTENDIDOS POR EL VENDEDOR 3*/

SELECT cod_cliente AS 'ID', ape_cliente  + ' ' + nom_cliente AS ' NOMBRE'
FROM CLIENTES C 
WHERE 3 = ALL (SELECT COD_VENDEDOR FROM FACTURAS F WHERE C.cod_cliente = f.cod_cliente)



/*







*/


SELECT C.nom_cliente as 'CLIENTE' , A.stock_minimo AS 'STOCK'
FROM CLIENTES C 
JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
JOIN articulos A ON A.cod_articulo = DF.cod_articulo
WHERE A.stock_minimo IS NOT NULL

/*UNIDAD 2 - GUIA 2*/


SELECT DESCRIPCION, A.pre_unitario, fecha 
FROM ARTICULOS A JOIN detalle_facturas DF
ON A.cod_articulo = DF.cod_articulo
JOIN facturas F 
ON DF.nro_factura = F.nro_factura
WHERE f.nro_factura NOT IN (SELECT nro_factura FROM FACTURAS WHERE YEAR(FECHA) = YEAR(GETDATE()))
AND (A.pre_unitario BETWEEN 50 AND 100)

SELECT A.cod_articulo, a.descripcion, F.fecha 
FROM ARTICULOS A 
JOIN detalle_facturas DF ON DF.cod_articulo = a.cod_articulo
JOIN FACTURAS F ON F.NRO_FACTURA=DF.nro_factura
WHERE YEAR(F.FECHA) NOT IN (YEAR(GETDATE())) AND a.pre_unitario (SELECT PRE_UNITARIO FROM ARTICULOS WHERE pre_unitario BETWEEN 50 AND 100)


SELECT cod_articulo AS 'CODIGO', DESCRIPCION , pre_unitario  AS 'PRECIO'
FROM ARTICULOS 
WHERE pre_unitario BETWEEN 50 AND 100 
AND COD_ARTICULO NOT IN (SELECT cod_articulo
    FROM detalle_facturas DF 
    JOIN FACTURAS F 
    ON DF.nro_factura = F.nro_factura
    WHERE YEAR(fecha) = YEAR (GETDATE()))


    SELECT cod_articulo , descripcion 
    FROM ARTICULOS A 
    WHERE cod_articulo IN (SELECT DF.cod_articulo
    FROM detalle_facturas df JOIN facturas F ON DF.nro_factura = F.nro_factura
    WHERE YEAR(F.fecha) != YEAR(GETDATE()))
    AND A.pre_unitario BETWEEN 50 AND 100;


/*2. Emitir un listado de los artículos que no fueron vendidos este año. En ese
listado solo incluir aquellos cuyo precio unitario del artículo oscile entre
50 y 100. */


SELECT DF.cod_articulo AS 'ARTICLE'
FROM detalle_facturas DF 
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE YEAR(F.fecha) != YEAR(GETDATE())
AND DF.pre_unitario >= 50 AND DF.pre_unitario <= 100;


SELECT  DF.cod_articulo AS 'ARTICLE'
FROM detalle_facturas DF 
WHERE  DF.pre_unitario >= 50 AND DF.pre_unitario <= 100
(SELECT DF.cod_articulo AS 'ARTICLE'
FROM detalle_facturas DF 
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE YEAR(F.fecha) != YEAR(GETDATE()))


/* 2-3 Genere un reporte con los clientes que vinieron más de 2 veces el año
pasado.   */

SELECT C.nom_cliente AS 'CLIENT',FORMAT(F.fecha,'dd/MM/yyyy') AS 'DATE'
FROM CLIENTES C 
JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
WHERE YEAR(F.fecha) IS NOT NULL;



SELECT C.cod_cliente, c.nom_cliente
FROM CLIENTES C 
WHERE C.cod_cliente IN (SELECT cod_cliente FROM FACTURAS F )
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
F.nro_factura
WHERE YEAR (fecha) = YEAR(GETDATE()) -1 
GROUP BY cod_cliente
HAVING COUNT (cod_cliente) > 2 )



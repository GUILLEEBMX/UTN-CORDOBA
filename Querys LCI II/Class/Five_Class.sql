-- 8. Emitir un listado que muestre la cantidad total de artículos vendidos, el
-- importe total vendido y el promedio del importe vendido por vendedor y
-- por cliente; para los casos en que el importe total vendido esté entre 200
-- y 600 y para códigos de cliente que oscilen entre 1 y 5.

USE LIBRERIA_LCI_II;



select sum(cantidad) 'total de artículos',
		   sum(df.pre_unitario * cantidad) 'total vendida',
		   avg (df.pre_unitario * cantidad) 'promedio del importe vendido',
		   f.cod_vendedor 'codigo vendedror',
		   c.ape_cliente + ',' + c.nom_cliente 'Cliente',
		   v.ape_vendedor+ ','+ v.nom_vendedor 'Vendedor'
	from facturas f 
	join detalle_facturas df on df.nro_factura=f.nro_factura
	join vendedores v on v. cod_vendedor=f.cod_vendedor
	join clientes c on c.cod_cliente=f.cod_cliente
	where f.cod_cliente between 1 and 5
	group by  f.cod_vendedor,c.ape_cliente + ',' + c.nom_cliente,v.ape_vendedor+ ','+ v.nom_vendedor
	having sum(df.pre_unitario * cantidad) between 2000 and 6000

--     9. ¿Cuáles son los vendedores cuyo promedio de facturación el mes
-- pasado supera los $ 800?


SELECT V.nom_vendedor AS 'SELLER ID ', AVG(df.pre_unitario * cantidad) as 'AVG'
FROM VENDEDORES V
JOIN FACTURAS F ON F.cod_vendedor = V.cod_vendedor 
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura 
WHERE MONTH(F.fecha) = MONTH(GETDATE()) - 1 
GROUP BY v.nom_vendedor
HAVING AVG(DF.pre_unitario * DF.cantidad) > 800;


-- 10.¿Cuánto le vendió cada vendedor a cada cliente el año pasado siempre
-- que la cantidad de facturas emitidas (por cada vendedor a cada cliente)
-- sea menor a 5?


SELECT SUM(DF.pre_unitario * DF.cantidad) AS 'PRICE TOTAL SOLD',V.nom_vendedor AS 'SELLERS', C.cod_cliente AS 'CLIENT'
FROM detalle_facturas DF  
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor
JOIN CLIENTES C ON  C.cod_cliente = F.cod_cliente
WHERE YEAR(F.fecha) = YEAR(GETDATE()) -1 
GROUP BY v.nom_vendedor,c.cod_cliente
HAVING SUM(F.nro_factura) < 5


/*LISTAR LOS VENDEDORES CUYAS VENTAS TOTALES SEA SUPERIOR AL PROMEDIO GENERAL DE VENTAS  */

SELECT  V.nom_vendedor as 'SELLER NAME', SUM(DF.cantidad * DF.pre_unitario) as 'TOTAL OF SELLER' /*SUM*/
FROM detalle_facturas DF 
JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
JOIN CLIENTES C ON  C.cod_cliente = F.cod_cliente
GROUP BY V.nom_vendedor
HAVING AVG(DF.cantidad * DF.pre_unitario)

>

(SELECT AVG(DF.cantidad * DF.pre_unitario ) AS 'TOTAL SALES'
FROM detalle_facturas DF )

SELECT  V.nom_vendedor as 'SELLER NAME', AVG(DF.cantidad * DF.pre_unitario) as 'TOTAL OF SELLER' /*SUM*/
FROM detalle_facturas DF 
JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
JOIN CLIENTES C ON  C.cod_cliente = F.cod_cliente
GROUP BY V.nom_vendedor
HAVING AVG(DF.cantidad * DF.pre_unitario)

>

(SELECT AVG(DF.cantidad * DF.pre_unitario ) AS 'TOTAL SALES'
FROM detalle_facturas DF )



/* GUIA 2 PAGINA 6 EJERCICIO 4*/

-- 8. Eliminar los clientes que hace más de 10 años que no vienen


SELECT DISTINCT V.cod_vendedor AS 'SELLER', YEAR(F.fecha) AS 'DATE'
FROM detalle_facturas DF  
JOIN FACTURAS F ON DF.nro_factura = DF.nro_factura
JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor

WHERE YEAR(F.fecha) > YEAR(GETDATE()) - 10 
GROUP BY v.cod_vendedor, YEAR(F.fecha)



/*
--Eliminar los clientes que hace más de 10 años que no vienen

select c.cod_cliente, nom_cliente+', '+ape_cliente 'Cliente'
from clientes c
where c.cod_cliente not in (select c.cod_cliente
from clientes c
join facturas f on f.cod_cliente=c.cod_cliente
where year(f.fecha)>year(getdate())-10)
order by 1

*/

/*GUIA 2 PAGINA 4 EJERCICIO 3*/

/*3. Por cada artículo que se tiene a la venta, se quiere saber el importe
promedio vendido, la cantidad total vendida por artículo, para los casos
en que los números de factura no sean uno de los siguientes: 2, 10, 7, 13,
22 y que ese importe promedio sea inferior al importe promedio de ese
artículo.*/


SELECT A.cod_articulo AS 'ARTICLE ID', AVG(DF.cantidad * DF.pre_unitario) AS 'AVERAGE SOLD', SUM(A.cod_articulo * DF.pre_unitario) AS 'AMOUNT ARTICLES'
FROM detalle_facturas DF 
JOIN articulos A ON DF.cod_articulo = A.cod_articulo
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE F.nro_factura  NOT IN (2,10,7,13,22)
GROUP BY A.cod_articulo 
HAVING AVG(DF.cantidad * DF.pre_unitario) 


<

(SELECT AVG(A.cod_articulo * DF.pre_unitario) AS 'AVERAGE ARTICLE') 

/*PAGINA 6 EJERCICIO 6. 
Descontar un 3,5% los precios de los artículos que se vendieron menos de
5 unidades los últimos 3 meses.*/


SELECT  A.cod_articulo AS 'ARTICLE ID', MONTH(F.fecha) AS 'DATE', A.pre_unitario AS 'PRICE', (A.pre_unitario *3.5 / 100) AS 'DISCOUNT'
FROM detalle_facturas DF 
JOIN FACTURAS F ON DF.nro_factura = F.nro_factura
JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE SUM(A.cod_articulo) < 5
AND MONTH(F.fecha) = MONTH(GETDATE()) -3


HAVING SUM(A.cod_articulo) 

<

(SELECT SUM(A.cod_articulo) AS 'AMOUNT ARTICLES', MONTH(F.fecha) AS 'DATE' 
GROUP BY A.cod_articulo)


SELECT A.cod_articulo AS 'ARTICLE ID', A.pre_unitario AS 'PRICE'
FROM ARTICULOS A 
WHERE 5 > ANY (SELECT SUM(DF.cantidad) 
FROM detalle_facturas DF 
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE DF.cod_articulo = A.cod_articulo
AND MONTH(F.fecha) = (MONTH(GETDATE())-3)
GROUP BY DF.cod_articulo)


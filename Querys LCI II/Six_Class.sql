USE LIBRERIA_LCI_II;



/*LISTAR EL PRECIO DE LOS ARTICULOS Y LA DIFERENCIA DE ESTE CON EL PRECIO  DEL ARTICULO MAS CARO*/


SELECT cod_articulo,
 descripcion,
 pre_unitario,
(SELECT MAX(pre_unitario) FROM ARTICULOS) - pre_unitario 'DIFERENCIA'
FROM ARTICULOS 

/*LISTAR LAS FACTURAS DEL AÑO EN CURSO DETALLANDO SUS DATOS Y TOTAL*/


SELECT F.nro_factura as 'FACTURA NRO', YEAR(FORMAT(F.fecha,'dd/MM/yyyy')) AS 'FECHA', SUM((DF.pre_unitario * cantidad)) AS 'TOTAL'
FROM FACTURAS F
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
WHERE YEAR(F.fecha) = YEAR(GETDATE()) 
GROUP BY  F.nro_factura,F.fecha /*OK*/


-- SELECT F.nro_factura as 'FACTURA NRO', YEAR(FORMAT(F.fecha,'dd/MM/yyyy')) AS 'FECHA',SUM((DF.pre_unitario * cantidad)) AS 'TOTAL'
-- FROM FACTURAS F
-- GROUP BY F.nro_factura, F.fecha
-- HAVING YEAR(F.fecha) = YEAR(GETDATE())
-- (SELECT SUM((DF.pre_unitario * cantidad)) AS 'TOTAL'
-- FROM detalle_facturas DF) 



SELECT F.nro_factura, YEAR(F.fecha) AS 'FECHA', C.ape_cliente AS 'CLIENTE',F2.TOTAL
FROM facturas F 
JOIN CLIENTES  C ON C.cod_cliente = F.cod_cliente
JOIN(SELECT nro_factura, SUM(pre_unitario * cantidad) AS 'TOTAL' 
FROM detalle_facturas DF 
GROUP BY nro_factura
) AS F2 ON F2.nro_factura = F.nro_factura
WHERE YEAR(F.fecha) = YEAR(GETDATE())

/* AUMENTAR EN UN 5% LOS PRECIOS DE LOS ARTICULOS CUYOS PRECIOS SON INFERIORES AL PROMEDIO */



SELECT A.cod_articulo AS 'ARTICULO', A.pre_unitario AS 'PRECIO UNITARIO', AVG(A.pre_unitario) AS 'PROMEDIO '
FROM ARTICULOS A 
GROUP BY A.cod_articulo,A.pre_unitario
HAVING A.pre_unitario > AVG(A.pre_unitario)



-- SELECT A.cod_articulo AS 'ARTICULO', A.pre_unitario AS 'PRECIO UNITARIO', (A.pre_unitario * COUNT (cod_articulo) / COUNT(cod_articulo)) AS 'PROMEDIO '
-- FROM ARTICULOS A 
-- --GROUP BY A.cod_articulo,A.pre_unitario
-- WHERE pre_unitario > (A.pre_unitario * COUNT (cod_articulo) / COUNT(cod_articulo))

SELECT A.descripcion, A.pre_unitario,
A.pre_unitario + A.pre_unitario * 0.05
FROM ARTICULOS A 
WHERE A.pre_unitario < (SELECT AVG(A.pre_unitario) FROM ARTICULOS A) --18 RESULTADOS


SELECT pre_unitario * 1.5 'AUMENTADO'
FROM ARTICULOS A 
WHERE pre_unitario < (SELECT AVG(pre_unitario) FROM articulos) --18 RESULTADOS

/*SE QUIERE ELIMINAR LOS CLIENTES QUE NO COMPRARON NUNCA*/


SELECT F.nro_factura AS 'FACTURAS', C.nom_cliente AS 'CLIENTE'
FROM detalle_facturas DF 
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
INNER JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente

SELECT * FROM CLIENTES


SELECT DISTINCT F.cod_cliente AS 'CLIENTES', C.nom_cliente AS 'CLIENTES'
FROM FACTURAS F 
LEFT JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente


SELECT DISTINCT F.nro_factura AS 'NRO FACTURA',F.cod_cliente AS 'CLIENTES', C.nom_cliente AS 'CLIENTES'
FROM CLIENTES C 
LEFT JOIN FACTURAS F ON C.cod_cliente = F.cod_cliente


/*DELETE CLIENTES  
WHERE cod_cliente NOT IN (SELECT cod_cliente FROM FACTURAS)*/

/*LISTAR LOS VENDEDORES QUE NO VENDIERON NUNCA*/


SELECT DISTINCT F.nro_factura AS 'NRO FACTURA',V.cod_vendedor AS 'VENDEDORES', V.nom_vendedor AS 'VENDEDORES'
FROM VENDEDORES V 
LEFT JOIN FACTURAS F ON V.cod_vendedor = F.cod_vendedor



SELECT DISTINCT F.nro_factura AS 'NRO FACTURA',V.cod_vendedor AS 'VENDEDORES', V.nom_vendedor AS 'VENDEDORES'
FROM FACTURAS F 
LEFT JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor


SELECT * FROM vendedores;

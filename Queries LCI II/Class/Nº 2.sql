
USE LIBRERIA_LCI_II;

SELECT cod_cliente Código,ape_cliente  + ' ' + nom_cliente Nombre, 'Cliente' Tipo

FROM Clientes

UNION

SELECT cod_vendedor Código,ape_vendedor + ' ' + nom_vendedor , 'Vendedor' 

FROM vendedores;


SELECT BARRIO AS 'Bº'
FROM CLIENTES C JOIN BARRIOS B ON B.cod_barrio = C.cod_barrio
UNION ALL 
SELECT BARRIO 
FROM vendedores V JOIN BARRIOS B ON B.cod_barrio = V.cod_barrio;


SELECT SUM(pre_unitario * cantidad ) Total, SUM (cantidad) 'Cantidad de Articulos',

COUNT (*) 'Cantidad de Items', max (pre_unitario) 'Mayor precio', min (pre_unitario) 'Menor precio'

from detalle_facturas

where nro_factura = 236;

/**/

SELECT SUM(pre_unitario * cantidad ) Total, SUM (cantidad) 'Cantidad de Articulos',

COUNT (*) 'Cantidad de Items', max (pre_unitario) 'Mayor precio', min (pre_unitario) 'Menor precio'

from detalle_facturas

where nro_factura = 236;

SELECT pre_unitario promedio,
CASE 
WHEN pre_unitario >= 50
THEN 'Mayor'
WHEN pre_unitario < 50
THEN 'Menor'
END AS 'Mayor o Menor'
FROM detalle_facturas
WHERE pre_unitario > 20
ORDER BY promedio DESC;

SELECT * FROM CLIENTES;

SELECT nom_cliente AS 'Client Name',
CASE 
WHEN nom_cliente LIKE  '%i%'
THEN 'LETRA I'
WHEN nom_cliente LIKE '%r%'
THEN 'LETRA R'
END AS 'Result'
FROM CLIENTES
ORDER BY nom_cliente DESC;


SELECT COUNT(DISTINCT cod_cliente) AS 'CONTADOR'
FROM clientes;


SELECT COUNT (*) AS 'CONTADOR'
FROM clientes;



SELECT COUNT (cod_cliente) AS 'CONTADOR'
FROM clientes;

SELECT * FROM articulos;

SELECT stock AS 'STOCK',pre_unitario AS 'PRICE',
CASE 
WHEN pre_unitario >= 100
THEN 'Premium' 
WHEN pre_unitario < 100 
THEN 'Regular'
END AS 'Premium o Regular'
FROM articulos
WHERE pre_unitario > 20
ORDER BY stock DESC;

SELECT * FROM ARTICULOS;



SELECT AVG(pre_unitario * cantidad) 'promedio por detalle factura',
SUM(pre_unitario * cantidad) / COUNT (distinct d.nro_factura) 'promedio por factura'
FROM detalle_facturas d, facturas f 
WHERE d.nro_factura = f.nro_factura
and year(fecha) = year(GETDATE()) -1;


/*EJERCICIO 1-1 GUIA*/


SELECT cod_cliente Código,ape_cliente  + ' ' + nom_cliente Nombre, 'Cliente' Tipo

FROM Clientes

UNION

SELECT cod_vendedor Código,ape_vendedor + ' ' + nom_vendedor , 'Vendedor' 

FROM vendedores

WHERE nro_tel IS NOT NULL 
AND [e-mail] IS NOT NULL  



ORDER BY 3;

/*EJERCICIO 1-2 GUIA*/

SELECT DISTINCT c.cod_cliente, v.cod_vendedor ,  nom_vendedor AS 'VENDEDORES', nom_cliente AS 'CLIENTES'
FROM vendedores V
JOIN FACTURAS F ON F.cod_vendedor = V.cod_vendedor
JOIN CLIENTES C ON F.cod_cliente = C.cod_cliente
WHERE C.nro_tel IS NOT NULL AND V.nro_tel IS NOT NULL 
AND C.[e-mail] IS NOT NULL  AND V.[e-mail] IS NOT NULL 



SELECT cod_cliente Código,ape_cliente  + ' ' + nom_cliente Nombre, 'Cliente' Tipo

FROM Clientes

UNION

SELECT cod_vendedor Código,ape_vendedor + ' ' + nom_vendedor , 'Vendedor' 

FROM vendedores

WHERE nro_tel IS NOT NULL 
AND [e-mail] IS NOT NULL  




SELECT nro_factura Código

FROM facturas 

UNION

SELECT cod_vendedor Código,ape_vendedor + ' ' + nom_vendedor , 'Vendedor' 

FROM vendedores


SELECT TOP 1 V.ape_vendedor 'APELLIDO VENDEDOR'
COUNT(*) 'TOTAL DE VENTAS'
FROM FACTURAS F 
JOIN VENDEDORES V ON v.c


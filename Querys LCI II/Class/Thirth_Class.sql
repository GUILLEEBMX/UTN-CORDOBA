USE LIBRERIA_LCI_II;




/* Por cada factura emitida mostrar la cantidad total de artículos vendidos
(suma de las cantidades vendidas), la cantidad ítems que tiene cada
factura en el detalle (cantidad de registros de detalles) y el Importe total
de la facturación de este año. */

select f.nro_factura,
SUM(d.cantidad) as 'cantidad de articulos vendidos',
COUNT(d.nro_factura) as 'cantidad de registros de detalles',
SUM(cantidad*d.pre_unitario) as 'importe'
from detalle_facturas d join facturas f on d.nro_factura = f.nro_factura
where YEAR(fecha) = YEAR(getdate())
group by f.nro_factura;

SELECT * FROM vendedores;


SELECT V.nom_vendedor as 'NOMBRE_VENDEDOR',  SUM(cantidad * pre_unitario) 'TOTAL'
FROM FACTURAS F JOIN detalle_facturas D 
ON F.nro_factura = D.nro_factura
JOIN vendedores V ON v.cod_vendedor = F.cod_vendedor
GROUP BY V.cod_vendedor,V.nom_vendedor;




select v.cod_vendedor, v.nom_vendedor + ' ' +v.ape_vendedor 'nombre vendedor' ,
c.nom_cliente + ' ' +c.ape_cliente 'nombre cliente',sum(pre_unitario*cantidad) ' total vendido'

from facturas f
join clientes c on f.cod_cliente = c.cod_cliente
join vendedores v on f.cod_vendedor = v.cod_vendedor
join detalle_facturas d on d.nro_factura = f.nro_factura
and  YEAR(fecha)= year(GETDATE()) -1
group by v.cod_vendedor, v.nom_vendedor + ' ' +v.ape_vendedor  , c.nom_cliente + ' ' + c.ape_cliente 
order by 2,3;

SELECT * FROM detalle_facturas;

SELECT nro_factura AS 'Nº Invoice' , SUM(pre_unitario * cantidad) 'Total'
FROM  detalle_facturas
GROUP BY nro_factura
HAVING SUM(pre_unitario * cantidad) < 2500;


SELECT nro_factura AS 'Nº Invoice' , SUM(pre_unitario * cantidad) 'Total'
FROM  detalle_facturas
GROUP BY nro_factura
HAVING SUM(pre_unitario * cantidad) > 2500;


--3. Se quiere saber en este negocio, cuánto se factura:
--a. Diariamente
--b. Mensualmente
--c. Anualmente

select sum (cantidad*pre_unitario)'Importe Diario', day(fecha)dia, month(fecha) mes, year(fecha) 'año'
from facturas f join detalle_facturas d on d.nro_factura=f.nro_factura
group by day(fecha),month(fecha),year(fecha)
Order by 4 desc,3,2;

select sum (cantidad*pre_unitario)'Importe Mensual', month(fecha) mes, year(fecha) 'año'
from facturas f join detalle_facturas d on d.nro_factura=f.nro_factura
group by month(fecha),year(fecha)
Order by 3 desc,2

select sum (cantidad*pre_unitario)'Importe Anual', year(fecha) 'año'
from facturas f join detalle_facturas d on d.nro_factura=f.nro_factura
group by year(fecha)
Order by 2 desc;


/*QUE VENDEDORES VENDIERON MENOS DE 20K EN TOTAL, AL AÑO ANTERIOR Y CUAL ES EL MONTO*/

SELECT * FROM detalle_facturas

SELECT * FROM FACTURAS;

SELECT nom_vendedor as 'Nombre Vendedor' /*SUM(DF.pre_unitario*DF.cantidad) AS 'Total'*/
FROM FACTURAS F
JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
JOIN detalle_facturas DF ON F.nro_factura = DF.nro_factura
WHERE F.fecha = YEAR(GETDATE()) - 1
HAVING SUM(pre_unitario * cantidad) > 20000;

/*SELECT F.cod_vendedor 'CODIGO',V.ape_vendedor + ' ' V.nom_vendedor 'NOMBRE'
SUM (d.cantidad * d.pre_unitario) 'TOTAL_VENDIDO'
FROM FACTURAS F JOIN VENDEDORES V ON V.cod_vendedor = f.cod_vendedor 
JOIN detalle_facturas d on f.nro_factura = d.nro_factura
WHERE YEAR (F.fecha) = YEAR(GETDATE()) -1 
GROUP BY F.cod_vendedor , ape_vendedor + '' + nom_vendedor 
HAVING sum(cantidad*pre_unitario) < 20000
ORDER BY 2 */


/*PROBLEMA 1.3-2*/

select f.nro_factura 'Nro. Factura',
SUM(d.cantidad) as 'Cantidad de articulos vendidos',
COUNT(d.nro_factura) as 'Cantidad de items en detalle',
SUM(cantidad*d.pre_unitario) as 'Importe'
from detalle_facturas d join facturas f on d.nro_factura = f.nro_factura
where YEAR(fecha) = YEAR(getdate())
group by f.nro_factura;




/*PROBLEMA 1.3-3*/

SELECT FORMAT(f.fecha,'dd/MM/yy') as 'FECHA' , f.nro_factura 'Nro. Factura',
SUM(d.cantidad*d.pre_unitario) as 'Cantidad de articulos vendidos',
COUNT(d.nro_factura) as 'Cantidad de items en detalle',
SUM(cantidad*d.pre_unitario) as 'Importe'
from detalle_facturas d join facturas f on d.nro_factura = f.nro_factura
where YEAR(fecha) = YEAR(getdate())
GROUP BY (f.nro_factura);
/*group by day(f.fecha),month(f.fecha),year(f.fecha)*/


select FORMAT(fecha,'dd/MM/yy')
FROM facturas;

SELECT  SUM(pre_unitario * cantidad), DAY(FECHA) 'LAPSE','DIA' TIPO 
FROM detalle_facturas DF 
JOIN FACTURAS F ON F.nro_factura = DF.nro_factura
WHERE DAY (FECHA) = DAY(GETDATE()) AND MONTH(FECHA) = MONTH(GETDATE()) -1  AND YEAR(FECHA) = YEAR(GETDATE())
GROUP BY DAY (FECHA)
SELECT SUM(pre_unitario*cantidad) , MONTH(FECHA) 'MES'
FROM detalle_facturas DF 
JOIN FACTURAS  F ON F.nro_factura = DF.nro_factura
WHERE MONTH(FECHA) = MONTH (GETDATE()) AND YEAR (FECHA) = YEAR(GETDATE())
ORDER BY MONTH(FECHA)
UNION 
SELECT SUM(pre_unitario*cantidad),YEAR (FECHA), 'AÑO'
SELECT SUM(pre_unitario*cantidad),YEAR (FECHA), 'AÑO',
WHERE YEAR(FECHA) = YEAR(GETDATE())
ORDER BY YEAR(FECHA)
ORDER BY TIPO
/*UNION 
SELECT SUM */

/*PROBLEMA 1.3-4*/

SELECT COUNT(*) 'CANTIDAD', F.FECHA 'FECHA'
FROM FACTURAS F 
WHERE MONTH(F.fecha) NOT IN (1,7,12) AND YEAR (F.fecha) = 2021
GROUP BY F.fecha
ORDER BY COUNT (*) DESC, F.fecha;
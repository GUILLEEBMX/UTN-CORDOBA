/*1. Emitir un listado de todos los vendedores incluyendo el nombre del barrio que vendieron, el nombre del producto
de aquellos vendedores que vendieron mas de $100000 en  en los últimos 3 meses.*/

SELECT 
E.NOMBRE AS 'VENDEDORES',
B.NOMBRE AS 'BARRIOS',
PROD.DESCRIPCION AS 'PRODUCTOS',
SUM(DP.IMPORTE) AS 'IMPORTE'
FROM PEDIDOS P 
JOIN EMPLEADOS E ON E.ID_EMPLEADO = P.ID_EMPLEADO_RECEPTOR
JOIN BARRIOS B ON B.ID_BARRIO = E.ID_BARRIO
JOIN DETALLES_PEDIDOS DP ON DP.ID_DETALLE_PEDIDO = P.ID_PEDIDO
JOIN PRODUCTOS PROD ON PROD.ID_PRODUCTO = DP.ID_PRODUCTO
WHERE MONTH(P.FECHA_PEDIDO) = MONTH(GETDATE()) -1 OR
MONTH(P.FECHA_PEDIDO) = MONTH(GETDATE()) -2 OR
MONTH(P.FECHA_PEDIDO) = MONTH(GETDATE()) -3 
GROUP BY E.NOMBRE , B.NOMBRE,PROD.DESCRIPCION
HAVING SUM(DP.IMPORTE) > 100000



/*2. Mostrar en una misma tabla de resultados los empleados que no vendieron nunca este mes (en
primer lugar) y los que tuvieron más de 10 ventas este mes en segundo lugar, ordenados
en forma alfabética por nombre de empleado.
*/


SELECT
E.NOMBRE AS 'EMPLEADOS', 'NO VENDIERON NADA AUN '
FROM EMPLEADOS E
JOIN PEDIDOS P ON P.ID_EMPLEADO_RECEPTOR = E.ID_EMPLEADO
WHERE E.ID_EMPLEADO NOT IN (SELECT ID_EMPLEADO FROM PEDIDOS WHERE YEAR(FECHA_PEDIDO) = YEAR (GETDATE()))
AND YEAR(P.FECHA_PEDIDO) = YEAR(GETDATE())

UNION

SELECT
E.NOMBRE AS 'EMPLEADOS','VENDIERON MAS DE 10 VECES'
FROM EMPLEADOS E 
JOIN PEDIDOS P ON P.ID_EMPLEADO_RECEPTOR = E.ID_EMPLEADO
WHERE YEAR(P.FECHA_PEDIDO) = YEAR(GETDATE())
GROUP BY E.NOMBRE
HAVING COUNT(P.ID_PEDIDO) > 10
ORDER BY 1;

/*3. ¿Cuánto vendio en total cada empleado en pedidos este año? ¿Cuánto fue el importe promedio
y la fecha de la primera y última venta? Siempre y cuando ese promedio cobrado haya sido
superior al promedio del año pasado.*/


SELECT 
E.NOMBRE AS 'EMPLEADOS',
SUM(DP.IMPORTE) AS 'IMPORTE',
AVG(DP.IMPORTE) AS 'PROMEDIO',
MIN(P.FECHA_PEDIDO) AS 'PRIMERA VENTA',
MAX(P.FECHA_PEDIDO) AS 'ULTIMA VENTA'
FROM DETALLES_PEDIDOS DP
JOIN PEDIDOS P ON P.ID_PEDIDO = DP.ID_PEDIDO
JOIN EMPLEADOS E ON E.ID_EMPLEADO = P.ID_EMPLEADO_RECEPTOR
WHERE YEAR(P.FECHA_PEDIDO) = YEAR(GETDATE())
GROUP BY E.NOMBRE
HAVING AVG(DP.IMPORTE) > 
(SELECT AVG(DP2.IMPORTE) FROM DETALLES_PEDIDOS DP2
JOIN PEDIDOS P ON P.ID_PEDIDO = DP2.ID_PEDIDO 
WHERE YEAR(FECHA_PEDIDO) = YEAR(GETDATE()) -1  )

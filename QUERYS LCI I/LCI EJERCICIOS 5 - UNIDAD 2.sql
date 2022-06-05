
 USE LIBRERIA_LCI2022;

/*10.Se necesita mostrar el código, nombre, apellido (todo el apellido en
mayúsculas) y dirección (calle y altura en una sola columna; para la altura
utilice una función de conversión) de todos los clientes cuyo nombre comience
con “C” y cuyo apellido termine con “Z”. Rotule como CÓDIGO DE CLIENTE,
NOMBRE, DIRECCIÓN.*/

SELECT C.cod_cliente AS 'CODIGO DE CLIENTE', C.nom_cliente + ',' +  UPPER(C.ape_cliente) AS 'NOMBRE', C.CALLE + ' ' +  CONVERT(varchar(20),C.altura) AS 'DIRECCION' 
FROM CLIENTES C
WHERE C.nom_cliente LIKE 'C%' AND  C.ape_cliente LIKE '%Z';


/*11.Ídem al anterior pero el apellido comience con letras que van de la “D” a la “L”
y cuyo nombre no comience con letras que van de la “A” a la “G”. */


SELECT C.cod_cliente AS 'CODIGO DE CLIENTE', C.nom_cliente + ',' +  UPPER(C.ape_cliente) AS 'NOMBRE', C.CALLE + ' ' +  CONVERT(varchar(20),C.altura) AS 'DIRECCION' 
FROM CLIENTES C
WHERE C.ape_cliente LIKE '[D-L]%' AND C.nom_cliente NOT LIKE '[A-G]%';

/*12.Muestre los datos de los vendedores (apellido todo en mayúsculas y en la
misma columna que el nombre) cuyo nombre no contenga “Z”, haya nacido en
la década del 70 y que haya realizado ventas el mes pasado.*/
 
SELECT UPPER(V.nom_vendedor + ' ' +  V.ape_vendedor ) AS 'VENDEDORES', V.fec_nac
FROM facturas F
RIGHT JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
AND V.nom_vendedor NOT LIKE '[Z]' 
AND YEAR (V.fec_nac) BETWEEN 1970 AND 1979
AND MONTH(F.fecha) = ((MONTH(F.fecha)) - 1 );

SELECT UPPER(V.nom_vendedor + ' ' +  V.ape_vendedor ) AS 'VENDEDORES', V.fec_nac
FROM vendedores V
LEFT JOIN facturas F ON V.cod_vendedor = F.cod_vendedor
AND V.nom_vendedor NOT LIKE '%Z%' 
AND (YEAR (V.fec_nac) >= 1970 AND YEAR(V.fec_nac) <= 1979)
AND MONTH(F.fecha) = ((MONTH(F.fecha)) - 1 );

SELECT fec_nac, nom_vendedor
FROM 
VENDEDORES 
WHERE YEAR(fec_nac) >= 1970 AND YEAR(fec_nac) <= 1979;

/*13.Mostrar las facturas realizadas entre el 1/1/2007 y el 1/5/2009 y cuyos códigos
de vendedor sean 1, 3 y 4 o bien entre el 1/1/2010 y el 1/5/2011 y cuyos
códigos de vendedor sean 2 y 4. Mostrar la fecha en formato Dia, Mes, y Año
(en ese orden y sin la hora)*/

SET DATEFORMAT DMY;

SELECT v.cod_vendedor, FORMAT(CONVERT(DATE,f.fecha),'dd-MM-yyyy') AS 'FECHA FACTURA'
FROM facturas F
JOIN vendedores V ON F.cod_vendedor = V.cod_vendedor
AND F.fecha >= '1/1/2007' AND F.fecha <= '1/5/2009'
AND V.cod_vendedor in (1,3,4) 
OR (F.fecha >= '1/1/2010' AND F.fecha <= '1/5/2011')
AND V.cod_vendedor IN (2,4)
ORDER BY FECHA DESC;

/*14.Se quiere saber el subtotal de todos los artículos vendidos, para ello liste el
artículo y multiplique la cantidad por el precio unitario de venta; mostrar el
subtotal redondeado a dos decimales (o buscar la forma de dale formato
apropiado). Ordene por alfabéticamente por artículo y cuyo subtotal mayor
aparezca primero. No muestre datos duplicados.*/


SELECT A.cod_articulo, A.descripcion, DF.cantidad * A.pre_unitario AS 'PRECIO FINAL' 
FROM detalle_facturas DF
RIGHT JOIN ARTICULOS A ON DF.cod_articulo = A.cod_articulo
ORDER BY A.descripcion ASC ,[PRECIO FINAL] DESC;

SELECT *
FROM ARTICULOS;


SELECT DISTINCT  A.cod_articulo, A.descripcion, (DF.cantidad * A.pre_unitario) AS 'PRECIO FINAL' 
FROM articulos A
LEFT JOIN detalle_facturas DF ON DF.cod_articulo = A.cod_articulo
ORDER BY [PRECIO FINAL] DESC,A.descripcion ASC;



SELECT DISTINCT  A.cod_articulo, A.descripcion, (DF.cantidad * A.pre_unitario) AS 'PRECIO FINAL' 
FROM articulos A
LEFT JOIN detalle_facturas DF ON DF.cod_articulo = A.cod_articulo
ORDER BY [PRECIO FINAL] DESC;


--REVISAR

/*15.Muestre las ventas (tabla detalle_facturas) de los artículos cuyo precio unitario
actual sea mayor o igual a 50 o cuyos códigos de artículos no sea uno de los
siguientes: 2,5, 6, 8, 10. En ambos casos los precios unitarios a los que fueron
vendidos oscilen entre 10 y 100.*/


SELECT DISTINCT a.cod_articulo,A.pre_unitario, A.pre_unitario * df.cantidad AS 'PRECIO VENDIDO'
FROM articulos A
LEFT JOIN detalle_facturas DF ON DF.cod_articulo = A.cod_articulo
AND A.pre_unitario >= 50 OR (A.cod_articulo NOT IN (2,5,6,8,10))
AND (A.pre_unitario * DF.cantidad) BETWEEN 10 AND 100
ORDER BY A.pre_unitario DESC;


/*16.Listar todos los datos de los artículos cuyo stock mínimo sea superior a 10 o
cuyo precio sea inferior a 20. En ambos casos su descripción no debe
comenzar con las letras “p” ni la letra “r”.*/

SELECT A.cod_articulo, A.descripcion
FROM ARTICULOS A
WHERE A.stock_minimo > 10 OR A.pre_unitario < 20
AND A.descripcion NOT LIKE 'P%' AND A.descripcion NOT LIKE 'R%'


/*17.Listar los datos de los vendedores nacidos en febrero, abril, mayo o
septiembre.*/

SELECT V.nom_vendedor + ' ' +  V.ape_vendedor AS 'VENDEDORES' , FORMAT(CONVERT(DATE,V.fec_nac),'dd/MM/yyyy') AS 'FECHA NACIMIENTO'
FROM VENDEDORES V
WHERE MONTH(V.fec_nac) IN (2,4,5,9);

/*18.Liste número de factura, fecha de venta y vendedor (apellido y nombre), para
los casos en que los códigos del cliente van del 2 al 6. Ordene por vendedor
y fecha, ambas en forma descendente.*/

SELECT F.nro_factura, FORMAT(CONVERT(DATE,F.fecha),'dd/MM/yyyy') AS 'FECHA FACTURA',v.cod_vendedor,  v.nom_vendedor + ' ' + v.ape_vendedor AS 'VENDEDORES'
FROM facturas F
JOIN VENDEDORES V ON v.cod_vendedor = f.cod_vendedor
AND F.cod_cliente BETWEEN 2 AND 6
ORDER BY V.cod_vendedor DESC ,F.fecha DESC;

/*19.Emitir un reporte con los datos de la factura del cliente y del vendedor de
aquellas facturas confeccionadas entre el primero de febrero del 2008 y el
primero de marzo del 2010 y que el apellido del cliente no contenga “C”.*/

SELECT F.nro_factura,FORMAT(CONVERT(DATE,F.fecha),'dd/MM/yyyy') AS 'FECHA',C.ape_cliente AS 'CLIENTE', V.ape_vendedor AS 'VENDEDOR'
FROM FACTURAS F
JOIN CLIENTES C ON F.cod_cliente = C.cod_cliente
JOIN VENDEDORES V ON F.cod_vendedor = V.cod_vendedor
AND F.fecha BETWEEN '01/02/2008' AND '01/03/2010' 
AND C.ape_cliente NOT LIKE '%C%';


/*20.Listar los datos de la factura, los del artículo y el importe (precio por cantidad);
para las facturas emitidas en el 2010, 2015 y 2017 y la descripción no
comience con “R”. Ordene por número de factura e importe, este en forma
descendente. Rotule. */

SELECT F.nro_factura,FORMAT(CONVERT(DATE,F.fecha),'dd/MM/yyyy') AS 'FECHA',DF.cantidad, A.cod_articulo,A.descripcion,A.pre_unitario * DF.cantidad AS 'FINAL PRICE'
FROM FACTURAS F
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
AND YEAR(F.fecha) IN (2010,2015,2017)
AND A.descripcion NOT LIKE 'R%'
ORDER BY F.nro_factura DESC , [FINAL PRICE] DESC;

/*21.Se quiere saber qué artículos se vendieron, siempre que el precio unitario sin
iva al que fue vendido no esté entre $10 y $50. Rotule. */

SELECT A.cod_articulo,A.descripcion,A.pre_unitario
FROM ARTICULOS A 
WHERE A.pre_unitario NOT BETWEEN 10 AND 50; 


SELECT DISTINCT A.cod_articulo, A.descripcion
FROM ARTICULOS A 
LEFT JOIN detalle_facturas DF ON A.cod_articulo = DF.cod_articulo
AND A.pre_unitario NOT BETWEEN 10 AND 50


--REVISAR

/*22.Liste todos los datos de la factura (vendedor, cliente, artículo, incluidos los
datos de la venta: cantidad, precio y subtotal); emitidas a clientes con teléfonos
o direcciones de e-mail conocidas de aquellas facturas cuyo importe haya sido
superior a $250. Agregue rótulos y ordene el listado para darle mejor
presentación*/

SELECT DISTINCT
F.nro_factura, A.cod_articulo, A.descripcion, 
C.nom_cliente + ' ' + C.ape_cliente AS 'CLIENTES', 
V.nom_vendedor + ' ' + V.ape_vendedor AS 'VENDEDORES',
A.pre_unitario * DF.cantidad AS 'FINAL PRICE'
FROM FACTURAS F
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
JOIN CLIENTES C  ON C.cod_cliente = F.cod_cliente
JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor
JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
AND (C.nro_tel IS NOT NULL OR C.[e-mail] IS NOT NULL)
AND A.pre_unitario * DF.cantidad > 250
ORDER BY F.nro_factura; 


 SELECT * FROM FACTURAS;

/*23.Se quiere saber a qué cliente, de qué barrio, vendedor y en qué fecha se les
vendió con los siguientes nros. de factura: 12, 18, 1, 3, 35, 26 y 29.¿El barrio
del cliente es el mismo que el barrio del vendedor que les vendío?*/

--IGUALANDO CODIGO BARRIO CLIENTE CON COD BARRIO VENDEDOR
SELECT F.nro_factura AS 'NRO FACTURA',C.nom_cliente, C.cod_barrio , V.cod_barrio
FROM FACTURAS F 
JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor
WHERE F.nro_factura IN (12,18,1,3,35,26,29)
AND V.cod_barrio = C.cod_barrio
ORDER BY F.nro_factura DESC;

--SIN IGUALAR CODIGO BARRIO CLIENTE CON COD BARRIO VENDEDOR
SELECT F.nro_factura AS 'NRO FACTURA',C.nom_cliente, C.cod_barrio , V.cod_barrio
FROM FACTURAS F 
JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor
WHERE F.nro_factura IN (12,18,1,3,35,26,29)
ORDER BY F.nro_factura DESC;


/*24.Emitir un reporte para informar qué artículos se vendieron, en las facturas
cuyos números no esté entre 17 y 136. Liste la descripción, cantidad e importe
(Importe=cantidad*pre_unitario). Ordene por descripción y cantidad. No
muestre las filas con valores duplicados*/


SELECT  F.nro_factura,A.cod_articulo, A.descripcion , DF.cantidad , DF.cantidad * A.pre_unitario AS 'IMPORTE'
FROM FACTURAS F 
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
JOIN articulos A ON A.cod_articulo = DF.cod_articulo
WHERE F.nro_factura NOT BETWEEN 17 AND 136;

--REVISAR 

/*25.Listar los datos de las facturas (cliente, artículo, incluidos los datos de la venta
incluido el importe) emitidas a los clientes cuyos apellidos comiencen con letras que van de la “l” a “s”
 o los artículos vendidos que tengan descripciones que comiencen con las mismas letras. Ordenar el listado.*/

 SELECT F.nro_factura, C.nom_cliente AS 'CLIENTES', A.cod_articulo, A.descripcion, DF.cantidad * A.pre_unitario AS 'FINAL PRICE'
 FROM FACTURAS F 
 JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
 JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
 JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
 WHERE C.ape_cliente LIKE '[L-S]%' 
 OR (A.descripcion LIKE '[L-S]%')
 ORDER BY F.nro_factura;



 SELECT F.nro_factura, C.nom_cliente AS 'CLIENTES', A.cod_articulo, A.descripcion, DF.cantidad * A.pre_unitario AS 'FINAL PRICE'
 FROM FACTURAS F , CLIENTES C , articulos A , detalle_facturas DF 
 WHERE F.cod_cliente = C.cod_cliente
 AND F.nro_factura = DF.nro_factura
 AND DF.cod_articulo = A.cod_articulo
 AND C.ape_cliente LIKE '[L-S]%' 
 OR (A.descripcion LIKE '[L-S]%')
 ORDER BY F.nro_factura;




 /*JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
 JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
 JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
 WHERE C.ape_cliente LIKE '[L-S]%' 
 OR (A.descripcion LIKE '[L-S]%')
 ORDER BY F.nro_factura;*/



/*26. Realizar un reporte de los artículos que se vendieron en lo que va del año.
(Muestre los datos que sean significativos para el usuario del sistema usando
rótulos para que sea más legible y que los artículos no se muestren repetidos).*/


SELECT F.nro_factura , FORMAT(CONVERT(DATE,F.fecha),'dd/MM/yyyy') AS 'FECHA', DF.cod_articulo
FROM FACTURAS F 
JOIN detalle_facturas DF ON F.nro_factura = DF.nro_factura
JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo
WHERE YEAR(F.fecha) = YEAR(GETDATE())

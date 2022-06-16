-- PROBLEMA 5 (JOIN)

--10.Se necesita mostrar el c�digo, nombre, apellido (todo el apellido en
--may�sculas) y direcci�n (calle y altura en una sola columna; para la altura
--utilice una funci�n de conversi�n) de todos los clientes cuyo nombre comience
--con �C� y cuyo apellido termine con �Z�. Rotule como C�DIGO DE CLIENTE,
--NOMBRE, DIRECCI�N.

SELECT c.cod_cliente, upper(c.ape_cliente) +SPACE(3)+ c.nom_cliente  'CLIENTE',
	   c.calle + SPACE(2)+ STR(c.altura) 'direccion1',
	   c.calle + SPACE(2)+ cast(c.altura as varchar) 'direccion2',
	   c.calle + SPACE(2)+ convert(varchar(10), c.altura) 'direccion3'
  FROM clientes as c
 WHERE c.nom_cliente LIKE 'c%'
   AND c.ape_cliente LIKE '%z'
   

--11.�dem al anterior pero el apellido comience con letras que van de la �D� a la �L�
--y cuyo nombre no comience con letras que van de la �A� a la �G�.

SELECT c.cod_cliente, upper(c.ape_cliente) +SPACE(3)+ c.nom_cliente  'CLIENTE',
	   c.calle + SPACE(2)+ STR(c.altura) 'direccion1',
	   c.calle + SPACE(2)+ cast(c.altura as varchar) 'direccion2',
	   c.calle + SPACE(2)+ convert(varchar(10), c.altura) 'direccion3'
  FROM clientes as c
 WHERE c.nom_cliente  NOT LIKE '[A-G]%' -- c.nom_cliente LIKE '[^A-G]%'
   AND c.ape_cliente LIKE '[D-L]%'


--12.Muestre los datos de los vendedores (apellido todo en may�sculas y en la
--misma columna que el nombre) cuyo nombre no contenga �Z�, haya nacido en
--la d�cada del 70 y que haya realizado ventas el mes pasado.

SELECT UPPER(v.ape_vendedor) +', '+ v.nom_vendedor 'Vendedores', f.fecha, f.nro_factura
  FROM vendedores v
  JOIN facturas f ON f.cod_vendedor = v.cod_vendedor
 WHERE v.nom_vendedor NOT LIKE '%Z%'
   AND YEAR(v.fec_nac) BETWEEN 1970 AND 1979
   --AND fec_nac BETWEEN '01/01/1970' AND '31/12/1979'
   AND DATEDIFF(MONTH, f.fecha , GETDATE()) = 1
   

SELECT FECHA 'FECHA FACTURA', 
	   GETDATE() 'HOY', 
	   DATEDIFF(DAY, f.fecha , GETDATE()) 'DIAS',
	   DATEDIFF(MONTH, f.fecha , GETDATE()) 'MESES',
	   DATEDIFF(YEAR, f.fecha , GETDATE()) 'A�OS',
	   DATEDIFF(month, '02/05/2022' , '02/06/2022') 

  FROM facturas f

SELECT DATEDIFF(MONTH, '02/05/2022' , '02/06/2022') , 
	   DATEDIFF(MONTH, '02/01/2022' , '02/06/2022')  
 

and MONTH(fecha) = MONTH (GETDATE()) -1 -- POR NO

select MONTH (GETDATE()) -1 'HOY',
		MONTH ('01/01/2022') -1 '�Enero?'


--13.Mostrar las facturas realizadas entre el 1/1/2007 y el 1/5/2009 y cuyos c�digos
--de vendedor sean 1, 3 y 4 o bien entre el 1/1/2010 y el 1/5/2011 y cuyos
--c�digos de vendedor sean 2 y 4. Mostrar la fecha en formato Dia, Mes, y A�o
--(en ese orden y sin la hora)

SELECT format(fecha, 'dd/MM/yyyy')'Fechas',
	   CONVERT(varchar(120), fecha, 103)'Fechas'
  FROM facturas f
  JOIN vendedores v ON f.cod_vendedor = v.cod_vendedor
 WHERE (f.fecha between '1/1/2007' and  '1/5/2009' AND v.cod_vendedor IN (1,3,4))
    OR (f.fecha between '1/1/2010' and  '1/5/2011' AND v.cod_vendedor IN (2,4))

--14.Se quiere saber el subtotal de todos los art�culos vendidos, para ello liste el
--art�culo y multiplique la cantidad por el precio unitario de venta; mostrar el
--subtotal redondeado a dos decimales (o buscar la forma de dale formato
--apropiado). Ordene por alfab�ticamente por art�culo y cuyo subtotal mayor
--aparezca primero. No muestre datos duplicados.


--15.Muestre las ventas (tabla detalle_facturas) de los art�culos cuyo precio unitario
--actual sea mayor o igual a 50 o cuyos c�digos de art�culos no sea uno de los
--siguientes: 2, 5, 6, 8, 10. En ambos casos los precios unitarios a los que fueron
--vendidos oscilen entre 10 y 100.
SELECT a.descripcion, a.pre_unitario'precio producto', d.pre_unitario 'precio venta'
  FROM detalle_facturas d
  JOIN articulos a ON a.cod_articulo = d.cod_articulo
 WHERE a.pre_unitario >= 50 and d.pre_unitario between 10 and 100
 OR a.cod_articulo NOT IN (2, 5, 6, 8, 10) and d.pre_unitario between 10 and 100

SELECT a.descripcion, a.pre_unitario'precio producto', d.pre_unitario 'precio venta'
  FROM detalle_facturas d
  JOIN articulos a ON a.cod_articulo = d.cod_articulo
 WHERE ( a.pre_unitario >= 50 OR a.cod_articulo NOT IN (2, 5, 6, 8, 10) )
   and d.pre_unitario between 10 and 100

--16.Listar todos los datos de los art�culos cuyo stock m�nimo sea superior a 10 o
--cuyo precio sea inferior a 20. En ambos casos su descripci�n no debe
--comenzar con las letras �p� ni la letra �r�.


--17.Listar los datos de los vendedores nacidos en febrero, abril, mayo o
--septiembre.
SELECT v.ape_vendedor, v.nom_vendedor, v.fec_nac
  FROM vendedores v
 WHERE MONTH(v.fec_nac) IN (2,4,5,9)

--18.Liste n�mero de factura, fecha de venta y vendedor (apellido y nombre), para
--los casos en que los c�digos del cliente van del 2 al 6. Ordene por vendedor
--y fecha, ambas en forma descendente.


--19.Emitir un reporte con los datos de la factura del cliente y del vendedor de
--aquellas facturas confeccionadas entre el primero de febrero del 2008 y el
--primero de marzo del 2010 y que el apellido del cliente no contenga �C�.


--20.Listar los datos de la factura, los del art�culo y el importe (precio por cantidad);
--para las facturas emitidas en el 2010, 2015 y 2017 y la descripci�n no
--comience con �R�. Ordene por n�mero de factura e importe, este en forma
--descendente. Rotule.


--21.Se quiere saber qu� art�culos se vendieron, siempre que el precio unitario sin
--iva al que fue vendido no est� entre $10 y $50. Rotule.
SELECT a.descripcion, a.pre_unitario , d.pre_unitario'precio vta'
  FROM articulos a
  JOIN detalle_facturas d ON  d.cod_articulo = a.cod_articulo
 WHERE d.pre_unitario / 1.21 NOT BETWEEN 10 and 50


--22.Liste todos los datos de la factura (vendedor, cliente, art�culo, incluidos los
--datos de la venta: cantidad, precio y subtotal); emitidas a clientes con tel�fonos
--o direcciones de e-mail conocidas de aquellas facturas cuyo importe haya sido
--superior a $250. Agregue r�tulos y ordene el listado para darle mejor
--presentaci�n.

--23.Se quiere saber a qu� cliente, de qu� barrio, vendedor y en qu� fecha se les
--vendi� con los siguientes nros. de factura: 12, 18, 1, 3, 35, 26 y 29.�El barrio
--del cliente es el mismo que el barrio del vendedor que les vend�o?
SELECT c.ape_cliente, c.nom_cliente, b.barrio , 
	   v.ape_vendedor , v.nom_vendedor, b1.barrio, 
	   f.fecha
  FROM barrios b
  JOIN clientes c ON c.cod_barrio = b.cod_barrio
  JOIN facturas f ON f.cod_cliente = c.cod_cliente
  JOIN vendedores v ON v.cod_vendedor = f.cod_vendedor
  JOIN barrios b1 ON b1.cod_barrio = v.cod_barrio
WHERE f.nro_factura IN (12, 18, 1, 3, 35, 26, 29)
  AND c.cod_barrio = v.cod_barrio

--24.Emitir un reporte para informar qu� art�culos se vendieron, en las facturas
--cuyos n�meros no est� entre 17 y 136. Liste la descripci�n, cantidad e importe
--(Importe=cantidad*pre_unitario). Ordene por descripci�n y cantidad. No
--muestre las filas con valores duplicados

--25.Listar los datos de las facturas (cliente, art�culo, incluidos los datos de la venta
--incluido el importe) emitidas a los clientes cuyos apellidos comiencen con
--letras que van de la �l� a �s� o los art�culos vendidos que tengan descripciones
--que comiencen con las mismas letras. Ordenar el listado.


--26. Realizar un reporte de los art�culos que se vendieron en lo que va del a�o.
--(Muestre los datos que sean significativos para el usuario del sistema usando
--r�tulos para que sea m�s legible y que los art�culos no se muestren repetidos).
SELECT DISTINCT a.descripcion 'articulo'
  FROM detalle_facturas d
  JOIN articulos a ON a.cod_articulo = d.cod_articulo
  JOIN facturas f ON f.nro_factura = d.nro_factura
 WHERE YEAR(fecha) = YEAR(getdate())
 
 --YEAR(fecha) = 2022 -- INCORRECTO
 --f.fecha > '01/01/2022' -- INCORRECTO
 

--27. Se quiere saber a qu� clientes se les vendi� el a�o pasado, qu� vendedor le
--realiz� la venta, y qu� art�culos compr�, siempre que el vendedor que les
--vendi� sea menor de 35 a�os.
SELECT c.ape_cliente +' '+ c.nom_cliente 'CLIENTES',
       v.ape_vendedor +' '+ v.nom_vendedor 'VENDEDORES',
	   f.fecha,
	   a.descripcion 'ARTICULOS'
  FROM detalle_facturas d
  JOIN articulos a ON a.cod_articulo = d.cod_articulo
  JOIN facturas f ON f.nro_factura = d.nro_factura
  JOIN clientes c ON c.cod_cliente = f.cod_cliente
  JOIN vendedores v ON v.cod_vendedor = f.cod_vendedor
 WHERE YEAR(f.fecha) = YEAR(getdate())-1
   AND DATEDIFF(YEAR, v.fec_nac, GETDATE())<35

   -- YEAR(GETDATE()) - YEAR(FEC_NAC) < 35

--28. El usuario de este sistema necesita ver el listado de facturas, de aquellos
--art�culos cuyos precios unitarios a los que fueron vendidos est�n entre 50 y
--100 y de aquellos vendedores cuyo apellido no comience con letras que van
--de la �l� a la �m�. Ordenado por vendedor, fecha e importe.

--29.Se desea emitir un listado de clientes que compraron en enero, adem�s saber
--qu� compraron cu�nto gastaron (mostrar los datos en forma conveniente)

--30.Emitir un reporte de art�culos vendidos en el 2010 a qu� precios se vendieron
--y qu� precio tienen hoy. Mostrar el porcentaje de incremento.

--31.Listar los vendedores que hace 10 a�os les vendieron a clientes cuyos
--nombres o apellidos comienzan con "C".
SELECT V.ape_vendedor, V.nom_vendedor, F.fecha,  c.ape_cliente, c.nom_cliente
  FROM facturas f
  JOIN clientes c on c.cod_cliente =  f.cod_cliente
  JOIN vendedores V on V.cod_vendedor = f.cod_vendedor
 WHERE DATEDIFF(YEAR, FECHA, GETDATE()) = 10 -- YEAR(GETDATE()) - YEAR(FECHA) = 10
   AND (nom_cliente LIKE 'C%' OR ape_cliente LIKE 'C%')

--32.El encargado de la librer�a necesita tener informaci�n sobre los art�culos que
--se vend�an a menos de $ 20 antes del 2015. Mostrar los datos que se
--consideren relevantes para el encargado, formatear, rotular y ordenar.
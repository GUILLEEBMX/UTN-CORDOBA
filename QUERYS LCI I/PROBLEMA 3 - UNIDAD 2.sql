

USE LIBRERIA;


SELECT *
FROM ARTICULOS;

UPDATE ARTICULOS
SET descripcion = 'Conjunto Geométrico de Plastico'
where descripcion = 'Conjunto Geométrico Maped'




UPDATE ARTICULOS
SET observaciones = 'Caja con motivos de Disney', stock_minimo = 100,pre_unitario = 17.20
where descripcion = 'Lápices Color largos * 12 u. Bic '


SELECT  descripcion FROM ARTICULOS;

UPDATE ARTICULOS
SET descripcion = 'Repuesto Rivadavia cuadriculado'
WHERE cod_articulo = 4;


SELECT cod_cliente,fecha_nac,email FROM CLIENTES WHERE cod_cliente = 2 ;

UPDATE CLIENTES
SET fecha_nac = '10/10/1970',email = 'monti_juan@gmail.com'
where cod_cliente = 2;

SELECT * FROM CLIENTES;

UPDATE CLIENTES
SET nro_tel = '4522221', calle = 'Av.Vélez Sarfield', altura = 125, cod_barrio  = 1
WHERE cod_cliente = 3;

SELECT nro_tel,calle,altura,cod_barrio
FROM CLIENTES
WHERE cod_cliente = 3;

SELECT pre_unitario
FROM ARTICULOS;


UPDATE ARTICULOS
SET pre_unitario = (((pre_unitario * 15) / 100 ) + pre_unitario)
WHERE pre_unitario < 20;

UPDATE ARTICULOS
SET pre_unitario = (((pre_unitario * 10 ) / 100 ) + pre_unitario)
WHERE pre_unitario >= 20 AND pre_unitario <= 30 ;
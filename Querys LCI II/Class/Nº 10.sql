USE LIBRERIA_LCI_II;

/*1. Crear una función que devuelva el nombre completo del dueño con el apellido todo en
mayúsculas, coma, espacio y el nombre con la 1er. letra en mayúsculas y el resto en
minúsculas*/


-- CREATE FUNCTION PONER_MAYUSCULAS(@NOMBRE VARCHAR (100), @APELLIDO VARCHAR (100))
-- RETURNS TABLE 
-- AS 
-- RETURN
-- (SELECT(UPPER(SUBSTRING(@NOMBRE,1,1)) + LOWER(SUBSTRING(@NOMBRE,2,LEN(@NOMBRE))) + ',' + UPPER(@APELLIDO)) AS 'NOMBRE COMPLETO')


-- DECLARE @NOMBRE VARCHAR (100) = 'guillermo';
-- DECLARE @APELLIDO VARCHAR (100) = 'britos';
-- SELECT * FROM dbo.PONER_MAYUSCULAS(@NOMBRE,@APELLIDO);



-- 2. Crear una vista que muestre el listado de mascotas (nombre, tipo, raza, edad) con sus dueños
-- (nombre completo utilizando la función del punto 1, dirección completa, teléfono)

CREATE VIEW LISTADOS_MASCOTAS
AS 
SELECT 
C.nom_cliente AS 'CLIENTES',
A.descripcion AS 'ARTICULOS',
V.nom_vendedor AS 'VENDEDORES',
C.calle AS 'CALLE', 
C.altura  AS 'DIRECCION'
FROM facturas F 
JOIN CLIENTES C ON C.nom_cliente = f.cod_cliente 
JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
JOIN ARTICULOS A ON A.cod_articulo = DF.cod_articulo 
JOIN vendedores V ON V.cod_vendedor = F.cod_vendedor

ESTO ES UN TEST


SELECT 
C.nom_cliente ,
C.calle, C.altura  AS 'DIRECCION'
FROM CLIENTES C 

SELECT 
C.nom_cliente AS 'CLIENTES',
C.calle + ' ' + CONVERT(VARCHAR (50), C.altura ) AS 'DIRECCION'


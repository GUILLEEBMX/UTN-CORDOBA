
--1. Crear una funci�n que devuelva el nombre completo del due�o con el apellido todo en may�sculas,
--coma, espacio y el nombre con la 1er. letra en may�sculas y el resto en min�sculas--ALTER FUNCTION DEVOLVER_NOMBRE_MAYUSCULAS(@NOMBRE VARCHAR (50), @APELLIDO VARCHAR(50) )--RETURNS VARCHAR (100)--AS--BEGIN--DECLARE @NOMBRECOMPLETO VARCHAR(100)--SELECT @NOMBRECOMPLETO = UPPER(SUBSTRING(@NOMBRE,1,1))+LOWER(SUBSTRING(@NOMBRE,2,LEN(@NOMBRE))) + ',' + UPPER(@APELLIDO)--RETURN @NOMBRECOMPLETO--END--DECLARE @NOMBRE VARCHAR(50) = 'GUILLERMO'--DECLARE @APELLIDO VARCHAR (50) = 'BRITOS'--SELECT  dbo.DEVOLVER_NOMBRE_MAYUSCULAS(@NOMBRE,@APELLIDO) --2. Crear una vista que muestre el listado de mascotas (nombre, tipo, raza, edad) con sus due�os
--(nombre completo utilizando la funci�n del punto 1, direcci�n completa, tel�fono)

--ALTER VIEW VISTA_EJERCICIO2_SIMULACRO
--AS
--SELECT 
--dbo.DEVOLVER_NOMBRE_MAYUSCULAS(C.nom_cliente,C.ape_cliente) AS 'CLIENTES',
--C.calle + ' ' +  CONVERT(VARCHAR(50),C.ALTURA) AS 'DIRECCION', 
--B.barrio AS 'B�',
--C.nro_tel AS 'TELEFONO',
--C.[e-mail] AS 'EMAIL',
--dbo.DEVOLVER_NOMBRE_MAYUSCULAS(V.nom_vendedor,V.ape_vendedor) AS 'VENDEDORES',
--YEAR(F.FECHA) AS 'FECHA'
--FROM CLIENTES C
--JOIN BARRIOS B ON B.cod_barrio = C.cod_barrio
--JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
--JOIN VENDEDORES V ON F.cod_vendedor = V.cod_vendedor 

--SELECT * FROM VISTA_EJERCICIO2_SIMULACRO;

--3. Consultar la vista anterior mostrando nombre y raza de perros con m�s de 5 a�os, de due�os con
--tel�fono conocido (mostrar nombre de due�o y tel�fono), que vinieron a consulta este a�o 

--SELECT 
--CLIENTES,
--VENDEDORES,
--TELEFONO, 
--FECHA
--FROM VISTA_EJERCICIO2_SIMULACRO
--WHERE TELEFONO IS NOT NULL AND 
--FECHA = YEAR(GETDATE()) 

--4. Mostrar los importes totales cobrados mensualmente por cada m�dico entre los a�os que se
--ingresar�n por par�metro


--ALTER PROCEDURE EJERCICIO4_SIMULACRO_PARCIAL
--@MES1 DATETIME,
--@MES2 DATETIME
--AS
--BEGIN
--IF(@MES1 IS NULL OR @MES2 IS NULL)
--RAISERROR('DEBE INGRESAR AMBOS MESES PARA CONSULTAR...',1,1)
--ELSE
--SELECT
--V.nom_vendedor AS 'VENDEDORES',
--SUM(DF.pre_unitario) AS 'IMPORTE TOTAL MENSUAL'
--FROM DETALLE_FACTURAS DF 
--JOIN FACTURAS F ON F.NRO_FACTURA = DF.NRO_FACTURA
--JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor
--WHERE MONTH(F.FECHA) BETWEEN MONTH(@MES1) AND MONTH(@MES2)
--GROUP BY V.nom_vendedor
--END

--DECLARE @MES1 DATETIME = '22/02/2006';
--DECLARE @MES2 DATETIME = '8/3/2006';
--EXEC EJERCICIO4_SIMULACRO_PARCIAL @MES1,@MES2;

--5. Crear un trigger que impida que se modifique el importe de las consultas

--CREATE TRIGGER TRIGGER_EJERCICIO5_SIMULACRO
--ON DETALLE_FACTURAS 
--FOR UPDATE
--AS
--BEGIN
--IF UPDATE (PRE_UNITARIO)
--RAISERROR('NO SE PUEDE MODIFICAR EL PRECIO UNITARIO DE LOS DETALLES DE FACTURA...',1,1)
--END
--ROLLBACK TRANSACTION

--UPDATE DETALLE_FACTURAS SET PRE_UNITARIO = 5 WHERE nro_factura = 1;







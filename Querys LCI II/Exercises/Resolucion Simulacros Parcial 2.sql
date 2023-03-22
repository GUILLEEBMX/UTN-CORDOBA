
--1. Crear una función que devuelva el nombre completo del dueño con el apellido todo en mayúsculas,
--coma, espacio y el nombre con la 1er. letra en mayúsculas y el resto en minúsculas

--ALTER FUNCTION DEVOLVER_NOMBRE_MAYUSCULAS(@NOMBRE VARCHAR (50), @APELLIDO VARCHAR(50) )
--RETURNS VARCHAR (100)
--AS
--BEGIN
--DECLARE @NOMBRECOMPLETO VARCHAR(100)
--SELECT @NOMBRECOMPLETO = UPPER(SUBSTRING(@NOMBRE,1,1))+LOWER(SUBSTRING(@NOMBRE,2,LEN(@NOMBRE))) + ',' + UPPER(@APELLIDO)
--RETURN @NOMBRECOMPLETO
--END

--DECLARE @NOMBRE VARCHAR(50) = 'GUILLERMO'
--DECLARE @APELLIDO VARCHAR (50) = 'BRITOS'
--SELECT  dbo.DEVOLVER_NOMBRE_MAYUSCULAS(@NOMBRE,@APELLIDO) 

--2. Crear una vista que muestre el listado de mascotas (nombre, tipo, raza, edad) con sus dueños
--(nombre completo utilizando la función del punto 1, dirección completa, teléfono)

--ALTER VIEW VISTA_EJERCICIO2_SIMULACRO
--AS
--SELECT 
--dbo.DEVOLVER_NOMBRE_MAYUSCULAS(C.nom_cliente,C.ape_cliente) AS 'CLIENTES',
--C.calle + ' ' +  CONVERT(VARCHAR(50),C.ALTURA) AS 'DIRECCION', 
--B.barrio AS 'Bº',
--C.nro_tel AS 'TELEFONO',
--C.[e-mail] AS 'EMAIL',
--dbo.DEVOLVER_NOMBRE_MAYUSCULAS(V.nom_vendedor,V.ape_vendedor) AS 'VENDEDORES',
--YEAR(F.FECHA) AS 'FECHA'
--FROM CLIENTES C
--JOIN BARRIOS B ON B.cod_barrio = C.cod_barrio
--JOIN FACTURAS F ON F.cod_cliente = C.cod_cliente
--JOIN VENDEDORES V ON F.cod_vendedor = V.cod_vendedor 

--SELECT * FROM VISTA_EJERCICIO2_SIMULACRO;

--3. Consultar la vista anterior mostrando nombre y raza de perros con más de 5 años, de dueños con
--teléfono conocido (mostrar nombre de dueño y teléfono), que vinieron a consulta este año 

--SELECT 
--CLIENTES,
--VENDEDORES,
--TELEFONO, 
--FECHA
--FROM VISTA_EJERCICIO2_SIMULACRO
--WHERE TELEFONO IS NOT NULL AND 
--FECHA = YEAR(GETDATE()) 

--4. Mostrar los importes totales cobrados mensualmente por cada médico entre los años que se
--ingresarán por parámetro


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



--Práctico de repaso para 2° parcial
--Tema 2
--Escribir la sentencia SQL que permita realizar las consultas que se piden a continuación:

--1. Crear un procedimiento almacenado para insertar un nuevo médico. (antes de completar este
--punto, agregue lo que se solicita en el punto 2 y 3)--SELECT * FROM CLIENTES;

--ALTER PROCEDURE INSERTAR_CLIENTES
--@NOMBRE VARCHAR (100),
--@APELLIDO VARCHAR (100),
--@CALLE VARCHAR (100),
--@ALTURA INT,
--@COD_BARRIO INT,
--@NRO_TEL VARCHAR (100),
--@EMAIL VARCHAR (100)
--AS
--BEGIN
--INSERT INTO CLIENTES (nom_cliente,ape_cliente,calle,altura,cod_barrio,nro_tel,[e-mail]) VALUES (@NOMBRE,@APELLIDO,@CALLE,@ALTURA,@COD_BARRIO,@NRO_TEL,@EMAIL)
--END

--DECLARE @NOMBRE VARCHAR (100) = 'Guillermo';
--DECLARE @APELLIDO VARCHAR (100) = 'Britos';
--DECLARE @CALLE VARCHAR (100) = 'Avenida Falsa';
--DECLARE  @ALTURA INT = 1236;
--DECLARE  @COD_BARRIO INT = 1;
--DECLARE  @NRO_TEL VARCHAR (50) = '3517550161' ;
--DECLARE @EMAIL VARCHAR (100) = 'gbritos13@gmail.com' ;

--EXEC INSERTAR_CLIENTES @NOMBRE,@APELLIDO,@CALLE,@ALTURA,@COD_BARRIO,@NRO_TEL,@EMAIL;




--2. Modificar el procedimiento anterior para que en caso de que la matricula o el apellido sean
--nulos no permita hacer el insert y de un error por excepción

--SELECT * FROM CLIENTES;

--ALTER PROCEDURE INSERTAR_CLIENTES
--@NOMBRE VARCHAR (100),
--@APELLIDO VARCHAR (100),
--@CALLE VARCHAR (100),
--@ALTURA INT,
--@COD_BARRIO INT,
--@NRO_TEL VARCHAR (100),
--@EMAIL VARCHAR (100)
--AS
--BEGIN
--IF(@APELLIDO IS NULL OR @NOMBRE IS NULL)
--RAISERROR('EL NOMBRE O EL APELLIDO NO PUEDEN SER NULOS',1,1)
--ELSE
--INSERT INTO CLIENTES (nom_cliente,ape_cliente,calle,altura,cod_barrio,nro_tel,[e-mail]) VALUES (@NOMBRE,@APELLIDO,@CALLE,@ALTURA,@COD_BARRIO,@NRO_TEL,@EMAIL)
--END

--DECLARE @NOMBRE VARCHAR (100) = NULL;
--DECLARE @APELLIDO VARCHAR (100) = 'Britos';
--DECLARE @CALLE VARCHAR (100) = 'Avenida Falsa';
--DECLARE  @ALTURA INT = 1236;
--DECLARE  @COD_BARRIO INT = 1;
--DECLARE  @NRO_TEL VARCHAR (50) = '3517550161' ;
--DECLARE @EMAIL VARCHAR (100) = 'gbritos13@gmail.com' ;

--EXEC INSERTAR_CLIENTES @NOMBRE,@APELLIDO,@CALLE,@ALTURA,@COD_BARRIO,@NRO_TEL,@EMAIL;


--3. Cree una tabla temporal para guardar los errores del punto 2

--CREATE TABLE #TEMPORAL_ERRORES
--(
--ID_ERROR INT IDENTITY(1,1),
--MENSAJE VARCHAR (200)
--)

--SELECT * FROM #TEMPORAL_ERRORES;

--ALTER PROCEDURE INSERTAR_CLIENTES
--@NOMBRE VARCHAR (100),
--@APELLIDO VARCHAR (100),
--@CALLE VARCHAR (100),
--@ALTURA INT,
--@COD_BARRIO INT,
--@NRO_TEL VARCHAR (100),
--@EMAIL VARCHAR (100)
--AS
--BEGIN
--DECLARE @MENSAJE VARCHAR(200)
--IF(@APELLIDO IS NULL OR @NOMBRE IS NULL)
--SET @MENSAJE = 'EL NOMBRE O EL APELLIDO NO PUEDEN SER NULOS'
--INSERT INTO #TEMPORAL_ERRORES (MENSAJE) VALUES (@MENSAJE)
--RAISERROR('EL NOMBRE O EL APELLIDO NO PUEDEN SER NULOS',1,1)
--RETURN
--INSERT INTO CLIENTES (nom_cliente,ape_cliente,calle,altura,cod_barrio,nro_tel,[e-mail]) VALUES (@NOMBRE,@APELLIDO,@CALLE,@ALTURA,@COD_BARRIO,@NRO_TEL,@EMAIL)
--END



--DECLARE @NOMBRE VARCHAR (100) = NULL;
--DECLARE @APELLIDO VARCHAR (100) = 'Britos';
--DECLARE @CALLE VARCHAR (100) = 'Avenida Falsa';
--DECLARE  @ALTURA INT = 1236;
--DECLARE  @COD_BARRIO INT = 1;
--DECLARE  @NRO_TEL VARCHAR (50) = '3517550161' ;
--DECLARE @EMAIL VARCHAR (100) = 'gbritos13@gmail.com' ;

--EXEC INSERTAR_CLIENTES @NOMBRE,@APELLIDO,@CALLE,@ALTURA,@COD_BARRIO,@NRO_TEL,@EMAIL;

--SELECT * FROM #TEMPORAL_ERRORES;


--4. Crear una vista que liste la cantidad de consultas, importe total y promedio de importe, mayor
--y menor importe por dueño por año

--ALTER VIEW PUNTO4_SIMULACRO_PARCIAL_II
--AS
--SELECT 
--C.NOM_CLIENTE AS 'CLIENTE',
--YEAR(F.FECHA) AS 'AÑO',
--COUNT(F.nro_factura) AS 'CANTIDAD_FACTURAS',
--SUM(DF.PRE_UNITARIO) AS 'IMPORTE_TOTAL',
--AVG(DF.PRE_UNITARIO) AS 'PROMEDIO_IMPORTE',
--MAX(DF.PRE_UNITARIO) AS 'MAYOR_IMPORTE',
--MIN(DF.PRE_UNITARIO) AS 'MENOR_IMPORTE'
--FROM facturas F 
--JOIN detalle_facturas DF ON DF.nro_factura = F.nro_factura
--JOIN clientes C ON C.cod_cliente = F.cod_cliente
--GROUP BY C.nom_cliente, F.FECHA

--SELECT * FROM PUNTO4_SIMULACRO_PARCIAL_II;


--5. Consultar la vista anterior mostrando el dueño, importe total y cantidad de consultas
--realizadas el año pasado cuyo importe promedio sea mayor al importe promedio de todas las
--consultas de este año--SELECT --CLIENTE,--IMPORTE_TOTAL,--CANTIDAD_FACTURAS,--AÑO ,--PROMEDIO_IMPORTE--FROM PUNTO4_SIMULACRO_PARCIAL_II--WHERE AÑO = YEAR(GETDATE()) - 1--GROUP BY CLIENTE,IMPORTE_TOTAL,CANTIDAD_FACTURAS,AÑO,PROMEDIO_IMPORTE--HAVING PROMEDIO_IMPORTE > (SELECT AVG(DF2.PRE_UNITARIO) --FROM detalle_facturas DF2 JOIN facturas F ON F.nro_factura = DF2.nro_factura WHERE YEAR(F.FECHA) = YEAR(GETDATE()))



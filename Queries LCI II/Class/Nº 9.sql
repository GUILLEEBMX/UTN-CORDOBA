USE LIBRERIA_LCI_II;


-- CREATE FUNCTION LARGO_CADENA
-- @CADENA VARCHAR(100) INPUT, 
-- @CADENA_RESULT INT OUTPUT
-- AS  
-- @CADENA_RESULT = SELECT LEN (@CADENA)
-- RETURN @CADENA_RESULT
-- END 



-- CREATE FUNCTION LARGO_CADENA
-- @CADENA VARCHAR(100) INPUT, 
-- @CADENA_RESULT INT OUTPUT
-- RETURN INT 
-- BEGIN
-- @CADENA_RESULT = SELECT LEN (@CADENA)
-- RETURN @CADENA_RESULT
-- END 





-- SELECT LEN('LABORATORIO_II') AS 'LARGO_CADENA';

-- --CREAR UNA FUNCION QUE DEVUELVA EL LARGO DE UNA CADENA;
-- CREATE FUNCTION LARGO_CADENA (@CADENA VARCHAR(100))
-- RETURNS  INT
-- BEGIN 
-- DECLARE @LARGO INT
-- SET @LARGO =  len(@CADENA)
-- RETURN @LARGO
-- END



-- SELECT dbo.LARGO_CADENA('LABORATORIO II') AS 'LARGO CADENA';



-- --MOSTRAR EL LARGO DE LA DESCRIPCION DE CADA ARTICULO--
-- SELECT A.descripcion,  dbo.LARGO_CADENA(A.descripcion) AS 'LARGO CADENA' FROM articulos A ;



--FUNCION QUE RECIBIENDO UN AÑO DEVUELVE  EL CLIENTE , EL VENDEDOR, EL NUMERO DE FACTURA  DE ESE AÑO;

-- ALTER FUNCTION SEGUNDA_FUNCION(@AÑO INT)
-- RETURNS TABLE
-- AS 
-- RETURN   
-- (SELECT 
-- F.nro_factura AS 'ID_FACTURA',
-- YEAR(F.fecha) AS 'AÑO',
-- V.nom_vendedor AS 'VENDEDOR',
-- C.nom_cliente AS 'CLIENTE'
-- FROM FACTURAS F
-- JOIN VENDEDORES V ON V.cod_vendedor = F.cod_vendedor 
-- JOIN CLIENTES C ON C.cod_cliente = F.cod_cliente
-- WHERE YEAR(F.fecha) = @AÑO);



-- SELECT * FROM dbo.SEGUNDA_FUNCION(2020);


--FUNCION QUE RECIBIENDO UN MONTO EN PESOS  Y UNA COTIZACION  EL DOLAR, DEVUELVA EL MONTO EN DOLARES;

-- CREATE FUNCTION PESOS_DOLARES (@MONEDA INT )
-- RETURNS  INT
-- BEGIN 
-- DECLARE @DOLARES INT
-- SET @DOLARES =  @MONEDA * 289
-- RETURN @DOLARES
-- END
-- funcion que recibe un precio y lo convierte a USD


-- CREATE FUNCTION f_conversion_dolar
-- (@precio decimal(10,2))
-- RETURNS decimal(10,2)
-- BEGIN
--     DECLARE @dolar decimal (10,2) = 289.80
--     DECLARE @conversion decimal (10,2)
--     SET @conversion = @precio / @dolar
--     RETURN @conversion
-- END;

-- SELECT a.descripcion, a.pre_unitario, dbo.f_conversion_dolar(a.pre_unitario)
-- FROM articulos a


-- SELECT dbo.PESOS_DOLARES(1) AS 'DOLARES';


--FUNCION QUE DEVUELVA INDEPENDIENTE DEL PARAMETRO QUE LE LLEGUE ...


-- CREATE FUNCTION USD_ARS (@MONEDA VARCHAR (50), @MONTO INT )
-- RETURNS INT
-- BEGIN
--     DECLARE @SALIDA INT
--     IF(@MONEDA = 'USD')
--     SET @SALIDA = @MONTO * 289
-- else
--     SET @SALIDA =  @MONTO / 289
--     RETURN @SALIDA
-- END;

/*CONTROLAR QUE LA CANTIDAD VENDIDA SEA MENOR O IGUAL AL STOCK DISPONIBLE*/

---controla stock en la venta
-- create trigger venta_con_stock
-- on detalle_facturas
-- for insert
-- as 
-- declare @stock int
-- select @stock=stock from articulos join inserted on inserted.cod_articulo=articulos.cod_articulo
-- if(@stock>=(select cantidad from inserted))
-- 	update articulos set stock=stock-inserted.cantidad
-- 	from articulos join inserted on inserted.cod_articulo=articulos.cod_articulo
-- else 
-- 	begin
-- 	raiserror('El stock es menor que la cant. solicitada', 16,1)--severidad(16), estado (1=valor por defecto)
-- 	rollback transaction
-- 	end

-- 	insert into detalle_facturas(nro_factura,cod_articulo,pre_unitario,cantidad) values(55,1,160,18)


-- CREATE TABLE #FIRST_TEMP_DB
-- (
--     ID_TABLE INT IDENTITY (1,1),
--     NOMBRE VARCHAR (50)

-- );

-- INSERT INTO #FIRST_TEMP_DB VALUES ('GUILLEE');


-- SELECT * FROM #FIRST_TEMP_DB;

-- SELECT * FROM TEMPDB.sys.OBJECTS;
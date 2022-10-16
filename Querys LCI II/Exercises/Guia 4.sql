USE LIBRERIA_LCI_II;

-- 1. Declarar 3 variables que se llamen codigo, stock y stockMinimo
-- respectivamente. A la variable codigo setearle un valor. Las variables stock y
-- stockMinimo almacenarán el resultado de las columnas de la tabla artículos
-- stock y stockMinimo respectivamente filtradas por el código que se
-- corresponda con la variable codigo.

-- DECLARE @CODIGO INT ;
-- DECLARE @STOCK INT;
-- DECLARE @STOCKMINIMO INT; 
-- SET @CODIGO = 5;

-- SELECT @STOCK = A.STOCK
-- FROM ARTICULOS A 
-- WHERE A.cod_articulo = @CODIGO;
-- SELECT @STOCK AS 'STOCK';

-- SELECT @STOCKMINIMO = A.stock_minimo
-- FROM ARTICULOS A 
-- WHERE A.cod_articulo = @CODIGO;
-- SELECT @STOCKMINIMO AS 'STOCK MININO';



-- ALTER FUNCTION OCTAVA_FUNCION (@CODIGO INT)
-- RETURNS TABLE 
-- AS 
-- RETURN (SELECT A.STOCK,A.stock_minimo FROM ARTICULOS A WHERE A.cod_articulo = @CODIGO);

-- SELECT * FROM OCTAVA_FUNCION(5);



-- CREATE FUNCTION NOVENA_FUNCION (@CODIGO INT)
-- RETURNS INT  
-- BEGIN
-- DECLARE @STOCK INT
-- SELECT @STOCK = A.stock FROM ARTICULOS A
-- WHERE A.cod_articulo = @CODIGO
-- RETURN @STOCK
-- END;

-- CREATE FUNCTION DECIMAPRIMERA_FUNCION (@CODIGO INT)
-- RETURNS INT  
-- BEGIN
-- DECLARE @STOCKMINIMO INT
-- SELECT @STOCKMINIMO = A.stock_minimo FROM ARTICULOS A
-- WHERE A.cod_articulo = @CODIGO
-- RETURN @STOCKMINIMO
-- END;


-- SELECT dbo.NOVENA_FUNCION(5) AS 'STOCK';


-- 2. Utilizando el punto anterior, verificar si la variable stock o stockMinimo tienen
-- algún valor. Mostrar un mensaje indicando si es necesario realizar reposición
-- de artículos o no.

-- DECLARE @STOCK INT;
-- SELECT @STOCK = A.stock FROM ARTICULOS A
-- WHERE A.cod_articulo = 5;
-- SELECT @STOCK AS 'STOCK';


/*NO HAY STOCK NULOS POR ESO LO PUSE CON < 10*/

-- CREATE FUNCTION DECIMA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100)
-- BEGIN 
-- DECLARE @SALIDA VARCHAR(100)
-- DECLARE @STOCK INT 
-- SELECT @STOCK = dbo.NOVENA_FUNCION(@CODIGO)
-- IF(@STOCK < 10)
-- SELECT @SALIDA = 'ES NECESARIO REPONER'
-- ELSE
-- SELECT @SALIDA = 'STOCK SUFICIENTE'
-- RETURN @SALIDA
-- END;

-- SELECT dbo.DECIMA_FUNCION (10) AS 'CONTROL STOCK';

/*CAMBIA LA CONDICION NOMÁS*/

-- CREATE FUNCTION DECIMA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100)
-- BEGIN 
-- DECLARE @SALIDA VARCHAR(100)
-- DECLARE @STOCK INT 
-- DECLARE @STOCKMINIMO INT
-- SELECT @STOCK = dbo.NOVENA_FUNCION(@CODIGO)
-- SELECT @STOCKMINIMO = dbo.DECIMAPRIMERA_FUNCION(@CODIGO);
-- IF(@STOCK IS NULL OR @STOCKMINIMO IS NULL)
-- SELECT @SALIDA = 'ES NECESARIO REPONER'
-- ELSE 
-- SELECT @SALIDA = 'STOCK SUFICIENTE'
-- RETURN @SALIDA
-- END;

-- SELECT dbo.DECIMA_FUNCION (10) AS 'CONTROL STOCK';


-- 3. Modificar el ejercicio 1 agregando una variable más donde se almacene el
-- precio del artículo. En caso que el precio sea menor a $500, aplicarle un
-- incremento del 10%. En caso de que el precio sea mayor a $500 notificar dicha
-- situación y mostrar el precio del artículo.

-- DECLARE @CODIGO INT;
-- DECLARE @STOCK INT;
-- DECLARE @STOCKMINIMO INT;
-- DECLARE @PRECIO INT;
-- SET @CODIGO = 5;

-- CREATE FUNCTION DECIMASEGUNDA_FUNCION (@CODIGO INT )
-- RETURNS TABLE 
-- AS
-- RETURN (SELECT A.stock,A.stock_minimo,A.pre_unitario FROM ARTICULOS A WHERE A.cod_articulo = @CODIGO)

-- SELECT @STOCK = A.STOCK FROM ARTICULOS A WHERE A.cod_articulo =  @CODIGO;

-- SELECT @STOCKMINIMO = A.stock_minimo FROM ARTICULOS A WHERE A.cod_articulo =  @CODIGO;

-- SELECT @PRECIO = A.pre_unitario FROM ARTICULOS A WHERE A.cod_articulo =  @CODIGO;

-- SELECT @STOCK AS 'STOCK',@STOCKMINIMO AS 'STOCK MINIMO',@PRECIO AS 'PRECIO';

-- CREATE FUNCTION DECIMATERCERA_FUNCION(@CODIGO INT)
-- RETURNS TABLE  
-- AS
-- BEGIN
-- DECLARE @PRECIO INT
-- DECLARE @SALIDA VARCHAR (100) 
-- SELECT  @PRECIO = A.pre_unitario FROM articulos A WHERE A.cod_articulo = @CODIGO
-- IF(@PRECIO < 500)
-- --UPDATE ARTICULOS SET pre_unitario = (((@PRECIO * 10) / 100) + @PRECIO) WHERE cod_articulo = @CODIGO
-- RETURN (SELECT (((@PRECIO * 10) / 100) + @PRECIO) AS 'PRECIO CON AUMENTO' )
-- ELSE 
-- SET @SALIDA = 'EL PRECIO ES MAYOR A $500'
-- RETURN (SELECT @SALIDA,@PRECIO)
-- RETURN (SELECT @SALIDA,@PRECIO
-- END

-- ALTER FUNCTION DECIMATERCERA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100) 
-- AS
-- BEGIN
-- DECLARE @PRECIO INT
-- DECLARE @SALIDA VARCHAR (100) 
-- SELECT  @PRECIO = A.pre_unitario FROM articulos A WHERE A.cod_articulo = @CODIGO
-- IF(@PRECIO < 500)
-- --UPDATE ARTICULOS SET pre_unitario = (((@PRECIO * 10) / 100) + @PRECIO) WHERE cod_articulo = @CODIGO
-- SET @SALIDA = 'EL PRECIO ES MENOR A $500'
-- ELSE 
-- SET @SALIDA = 'EL PRECIO ES MAYOR A $500'
-- RETURN @SALIDA
-- RETURN @SALIDA
-- END

-- SELECT dbo.DECIMATERCERA_FUNCION(5);

-- 4. Declarar dos variables enteras, y mostrar la suma de todos los números
-- comprendidos entre ellos. En caso de ser ambos números iguales mostrar un
-- mensaje informando dicha situación

-- 5. Mostrar nombre y precio de todos los artículos. Mostrar en una tercer columna
-- la leyenda ‘Muy caro’ para precios mayores a $500, ‘Accesible’ para precios
-- entre $300 y $500, ‘Barato’ para precios entre $100 y $300 y ‘Regalado’ para
-- precios menores a $100.




-- CREATE FUNCTION DECIMACUARTA_FUNCION()
-- RETURNS TABLE 
-- RETURN
-- (
-- SELECT 
-- A.descripcion AS 'ARTICULOS',
-- A.pre_unitario AS 'PRECIO UNITARIO' ,
-- 'MUY CARO' AS 'CLASIFICACION'
-- FROM ARTICULOS A
-- WHERE A.pre_unitario > 500
-- )


-- SELECT descripcion,pre_unitario, TIPO_PRECIO = 

-- CASE

-- WHEN  pre_unitario > 500 THEN 'MUY CARO'

-- WHEN pre_unitario BETWEEN 300 and 500 THEN 'ACCESIBLE'

-- WHEN pre_unitario BETWEEN 100 AND 300 THEN 'BARATO'

-- WHEN pre_unitario <= 100 THEN 'REGALADO'

-- END 

-- FROM ARTICULOS;





-- 6. Modificar el punto 2 reemplazando el mensaje de que es necesario reponer
-- artículos por una excepción.

-- ALTER FUNCTION DECIMA_FUNCION(@CODIGO INT)
-- RETURNS VARCHAR (100)
-- BEGIN 
-- DECLARE @SALIDA VARCHAR(100)
-- DECLARE @STOCK INT 
-- SELECT @STOCK = dbo.NOVENA_FUNCION(@CODIGO)
-- IF(@STOCK < 10)
-- ERROR_MESSAGE() AS 'ERROR'
-- ELSE
-- SELECT @SALIDA = 'STOCK SUFICIENTE'
-- RETURN @SALIDA
-- END;


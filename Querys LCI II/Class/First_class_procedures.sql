CREATE PROCEDURE second_procedure_lciii_ii
as
SELECT *
FROM articulos
WHERE pre_unitario < 70;


EXEC second_procedure_lciii_ii;

CREATE PROCEDURE third_procedure_lci_iii
as 
SELECT *
FROM articulos
where pre_unitario >= 70 and pre_unitario <= 120;

EXEC third_procedure_lci_iii;


DROP PROCEDURE second_procedure_lciii_ii;



ALTER PROC four_procedure
 @firstValue int = 70
 AS 
 SELECT pre_unitario as PRECIO
 FROM articulos
 WHERE pre_unitario <= @firstValue;
 



 EXEC four_procedure @firstValue < 100;

 SELECT * FROM articulos



 ALTER PROCEDURE fiveProcedure
@promedio DECIMAL (10,2)  /*INT*/  OUTPUT
as
SELECT 
@promedio = AVG(pre_unitario)
FROM 
articulos;



DECLARE @prom decimal (10,2) --INT

EXEC fiveProcedure @prom output;

select @prom as 'PROMEDIO';

SELECT AVG(pre_unitario) as 'PROMEDIO'
FROM 
articulos;


SELECT * FROM articulos;


create procedure pa_articulos_sumaypromedio
 @descripcion varchar(100)='%',
 @suma decimal(10,2) output,
 @promedio decimal(8,2) output
 as
 select descripcion,pre_unitario,observaciones
 from articulos
 where descripcion like @descripcion
 select @suma=sum(pre_unitario)
 from articulos
 where descripcion like @descripcion
 select @promedio=avg(pre_unitario)
 from articulos
 where descripcion like @descripcion;
 if(@suma < 100)


 declare @s decimal(10,2), @p decimal(8,2)
execute pa_articulos_sumaypromedio '%lápiz%', @s output, @p output
select @s as total, @p as promedio;


USE LIBRERIA_LCI_II;

CREATE PROCEDURE SP1
@precio INT,
@cant INT OUTPUT
AS
SELECT @cant = COUNT(cod_articulo) * FROM /*TABLENAME*/
WHERE pre_unitario = @precio
DECLARE @cant int 


EXEC SP1 @precio, @cant output
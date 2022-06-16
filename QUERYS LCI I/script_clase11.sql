--1. Mostrar las 10 consultas más costosas, con todo el detalle (fecha y motivo de la consulta,
--médico, dueño, mascota, tipo y raza)
SELECT TOP 10 c.fecha, c.detalle_consulta,
	   m.apellido + ' ' + m.nombre 'MEDICOS',
	   d.apellido + ' ' + d.nombre 'DUEÑOS',
	   ma.nombre 'MASCOTAS',
	   t.tipo, r.raza, 
	   c.importe 'IMPORTE DE CONSULTA'
  FROM consultas c
  JOIN medicos m ON c.id_medico = m.id_medico
  JOIN mascotas ma ON ma.id_mascota = c.id_mascota
  JOIN tipos t ON t.id_tipo = ma.id_tipo
  JOIN razas r ON r.id_raza = ma.id_raza
  JOIN dueños d ON ma.id_dueño = d.id_dueño
ORDER BY c.importe DESC

--2. Listar las mascotas cuyos nombres no comiencen con “A”, “M” ni “P” y cuyos dueños viven en
--Centro, Alberdi u Observatorio.
SELECT m.nombre 'MASCOTAS', d.apellido + ' ' + d.nombre 'DUEÑOS', b.barrios 'BARRIOS'
  FROM mascotas m
  JOIN dueños d ON m.id_dueño = d.id_dueño
  JOIN barrios b ON b.id_barrio = d.id_barrio
 WHERE m.nombre LIKE '[^a,m,p]%' --m.nombre NOT LIKE '[a,m,p]%'
   AND b.barrio IN ('centro', 'alberdi', 'observatorio')
   -- AND ( b.barrio = 'cantro'OR  b.barrio = 'alberdi' OR  b.barrio = 'observatorio')
 ORDER BY [BARRIOS], [MASCOTAS]

--3. Listado de consultas del mes pasado (mostrando médico, mascota, dueño)
SELECT c.fecha,
	   m.apellido + ' ' + m.nombre 'MEDICOS',
	   d.apellido + ' ' + d.nombre 'DUEÑOS',
	   ma.nombre 'MASCOTAS'
  FROM consultas c
  JOIN medicos m ON c.id_medico = m.id_medico
  JOIN mascotas ma ON ma.id_mascota = c.id_mascota
  JOIN dueños d ON ma.id_dueño = d.id_dueño
 WHERE DATEDIFF(MONTH,c.fecha, GETDATE()) = 1 -- EL MES PASADO
 --WHERE MONTH(c.fecha) = MONTH(GETDATE())-1 --ERROR FALLA EN ENERO, POR ESO NO SE DEBE HACER ASI!!!

--4. Emitir un listado con los datos de los dueños que asistieron con sus mascotas el año pasado
--(sin registros duplicados) mostrando el apellido en mayúsculas, nombre con la primer letra en
--mayúscula y el resto en minúscula; además la dirección completa en una sola columna (calle,
--altura, barrio).
SELECT DISTINCT c.fecha,
	   UPPER(d.apellido) + ' ' + UPPER(LEFT(d.nombre,1))+LOWER(RIGHT(d.nombre,LEN(d.nombre)-1))  'DUEÑOS',
	   UPPER(d.apellido) + ' ' + UPPER(SUBSTRING(d.nombre,1,1))+SUBSTRING(d.nombre,2,LEN(d.nombre)) 'DUEÑOS',
	   ma.nombre 'MASCOTAS',
	   calle + ' Nº:' +STR(altura) + ' - Bº:' + b.barrio 'DIRECCION'
  FROM consultas c
  JOIN mascotas ma ON ma.id_mascota = c.id_mascota
  JOIN dueños d ON ma.id_dueño = d.id_dueño
  JOIN barios b ON b.id_barrio =  d.id_barrio
 WHERE YEAR(fecha) = YEAR(getdate())-1 --AÑO PASADO
 ORDER BY 1 -- fecha
  
/* PROBAR EN LIBRERIA*/
--SELECT  c.ape_cliente,
--		c.nom_cliente,
--		UPPER(c.ape_cliente) + ' ' + UPPER(LEFT(c.nom_cliente,1))+LOWER(RIGHT(c.nom_cliente,LEN(c.nom_cliente)-1))  'DUEÑOS',
--	    UPPER(c.ape_cliente) + ' ' + UPPER(SUBSTRING(c.nom_cliente,1,1))+SUBSTRING(c.nom_cliente,2,LEN(c.nom_cliente)) 'DUEÑOS'
--FROM clientes c

--5. Listar las mascotas mayores a 10 años ordenadas por tipo de mascotas y que aparezca
--primero, dentro de cada tipo, las que más tiempo tienen sin asistir a una consulta.
SELECT c.fecha, c.detalle_consulta,
	   ma.nombre 'MASCOTAS',
	   t.tipo, r.raza, 
	   c.importe 'IMPORTE DE CONSULTA'
  FROM consultas c
  JOIN mascotas ma ON ma.id_mascota = c.id_mascota
  JOIN tipos t ON t.id_tipo = ma.id_tipo
  JOIN razas r ON r.id_raza = ma.id_raza
 WHERE DATEDIFF(YEAR, ma.fec_nac, GETDATE())>10 -- YEAR(GETDATE()) - YEAR(ma.fec_nac) > 10
 ORDER BY t.tipo, c.fecha ASC

 /* TIPS */
-- FECHAS
--ASC --> MAS VIEJA
--DESC --> MAS NUEVA
-- NUMEROS
--ASC --> MAS CHICO AL MAS GRANDE
--DESC --> MAS GRANDE AL MAS CHICO

--6. ¿Cuánto gana en cada consulta cada médico si se les deduce un 15% a cada una por pago de
--derecho de uso del consultorio? También mostrar la fecha y el motivo de la consulta. Se quiere
--ver primero los médicos de mayor antigüedad, luego por apellido y nombre, y luego por las
--consultas más caras
SELECT c.fecha, 
	   c.detalle_consulta 'MOTIVO CONSULTA',
	   m.apellido + ' ' + m.nombre 'MEDICOS',
	   c.importe 'IMPORTE DE CONSULTA',
	   c.importe * 0.85 'IMPORTE -15%'
  FROM consultas c
  JOIN medicos m ON c.id_medico = m.id_medico
 ORDER BY fec_ingreso ASC, m.apellido, m.nombre, c.importe DESC
 
/*TIPS CALCULO DE PORCENTAJES EN LIBRERIA */
--SELECT a.descripcion, 
--       a.pre_unitario,
--	     a.pre_unitario * 0.85 '-15%',
--	     a.pre_unitario - pre_unitario * 0.15 '-15%',
--	     a.pre_unitario * 1.15 '+15%',
--	     a.pre_unitario + pre_unitario * 0.15 '+15%'
--  FROM articulos a

--7. Emitir un listado de consultas realizadas en febrero, mayo, agosto y septiembre del 2018 y 2021
--a caniches o las realizadas entre enero y abril del 2020 a terrier.
SELECT c.fecha, 
       c.detalle_consulta 'MOTIVO CONSULTA',
	   ma.nombre 'MASCOTAS',
	   r.raza
  FROM consultas c
  JOIN mascotas ma ON ma.id_mascota = c.id_mascota
  JOIN razas r ON r.id_raza = ma.id_raza
 WHERE ( MONTH(fecha) IN (2, 5, 8, 9) AND YEAR(fecha) IN (2018, 2021) AND r.raza = 'caniche' )
    OR ( MONTH(fecha) BATWEEN 1 AND 4 AND YEAR(fecha) = 2020 AND r.raza = 'terrier' )


--8. Listar los dueños que viven en el mismo barrio que los médicos
SELECT m.apellido + ' ' + m.nombre 'MEDICOS', b.barrio 'BARRIO MEDICO',
       d.apellido + ' ' + d.nombre 'DUEÑOS' , b2.barrio 'BARRIO DUEÑO'
  FROM medicos m,
	   barrios b,
	   dueños d,
       barrios b2 
 WHERE m.id_barrio = b.id_barrio
   AND b2.id_barrio =  b.id_barrio
   AND b2.id_barrio = d.id_barrio
   
--9. Listar las mascotas y el barrio donde se encuentran y listar el médico que los atendió junto con
--el barrio donde viven
select ma.nombre mascota,b1.barrio 'barrio de la mascota',
m.apellido+' '+m.nombre Veterinario, b2.barrio 'barrio del veterinario'
from consultas c join medicos m on m.id_medico=c.id_medico
join mascotas ma on ma.id_mascota=c.id_mascota
join duenio d on d.id_duenio=ma.id_duenio
join barrios b1 on b1.id_barrio=d.id_barrio
join barrios b2 on b2.id_barrio=m.id_barrio

--10. Listar las consultas de los últimos 3 meses (sin contar el actual) y los médicos que la realizaron
--(listar todos los médicos, aunque no haya trabajado en esos meses).
select m.apellido+' '+m.nombre Veterinario,fecha,detalle_consulta,importe
from consultas c right join medicos m on m.id_medico=c.id_medico
where datediff(month,fecha,getdate()) between 1 and 3
or fecha is null

--En otro listado, las mascotas a las que se atendieron en los últimos 3 meses contando el actual
--(listar todas las mascotas, aunque no hayan sido atendidas en esos meses)
select fecha,detalle_consulta,importe,nombre mascota,raza
from razas r join mascotas m on r.id_raza=ma.id_raza left join consultas c
  on m.id_mascota=c.id_mascota
where fecha>dateadd(month,-3,getdate()) 
or fecha is null
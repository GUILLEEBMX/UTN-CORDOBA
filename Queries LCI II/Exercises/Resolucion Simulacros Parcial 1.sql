

/*=========================TEMA 1 ====================================================================*/

/*1. Emitir un reporte del total cobrado por mes por cada médico en sus consultas. Además, la
cantidad de consultas realizadas, siempre que el promedio de importe cobrado por mes sea
mayor a $2.000.-*/


/*
SELECT 
M.NOMBRE AS 'MEDICO',
MONTH(C.FECHA) AS 'MES',
SUM(C.IMPORTE) AS 'IMPORTE MENSUAL',
SUM(C.ID_CONSULTAS) AS 'TOTAL CONSULTAS',
FROM CONSULTAS C 
JOIN MEDICOS M ON M.ID_MEDICO = C.ID_MEDICO
GROUP BY M.NOMBRE,C.FECHA
HAVING AVG(C.IMPORTE) > 2000
ORDER BY 1;

*/

/*2. Listar las consultas del mes pasado cuyo importe superaron el promedio cobrado por consulta
este mes*/


/*

SELECT 
C.ID_CONSULTAS AS 'CONSULTA'
SUM(C.IMPORTE) AS 'IMPORTE MENSUAL'
FROM CONSULTAS C 
WHERE MONTH(C.FECHA) = MONTH(GETDATE()) -1 
GROUP BY C.ID_CONSULTA
HAVING SUM(C.IMPORTE) > (SELECT AVG(IMPORTE) FROM CONSULTAS WHERE MONTH(FECHA) = MONTH(GETDATE()))

*/

/*3. ¿Cuánto fue el importe total cobrado por consultas el año pasado? ¿Cuánto fue el importe de
la consulta más cara y la más barata y cuánto fue el importe promedio por consulta?*/

/*
SELECT
C.ID_CONSULTA AS 'CONSULTAS',
SUM(C.IMPORTE) AS 'IMPORTE TOTAL'
MAX(C.IMPORTE) AS 'CONSULTA MAS CARA',
MIN(C.IMPORTE) AS 'CONSULTA MAS BARATA',
AVG(C.IMPORTE) AS 'PROMEDIO'
FROM CONSULTAS C 
WHERE YEAR(C.FECHA) = YEAR(GETDATE()) - 1
GROUP BY C.ID_CONSULTA
*/



/*4. Mostrar en una misma tabla de resultados las mascotas que no vinieron nunca este año (en
primer lugar) y las que vinieron más de 10 veces este año en segundo lugar, ordenados en
forma alfabética por nombre de mascota.*/


/*

SELECT 
C.ID_CONSULTAS AS 'CONSULTAS'
FROM CONSULTAS C 
JOIN MASCOTAS M ON M.ID_MASCOTA = C.ID_MASCOTA
WHERE YEAR(C.FECHA) = YEAR (GETDATE())
AND C.ID_MASCOTA NOT IN (SELECT C.ID_MASCOTA FROM MASCOTAS WHERE YEAR(C.FECHA) = YEAR(GETDATE()))


SELECT
M.NOMBRE AS 'MASCOTAS', 'NO VINIERON NUNCA' 'VINIERON O NO'
FROM MASCOTAS M
JOIN CONSULTAS C ON C.ID_MASCOTA = M.ID_MASCOTA
WHERE M.ID_MASCOTA NOT IN C.ID_MASCOTA
AND YEAR(C.FECHA) = YEAR(GETDATE())

UNION

SELECT
M.NOMBRE AS 'MASCOTA' 'VINIERON MAS DE 10 VECES'
FROM CONSULTAS C 
JOIN MASCOTAS M ON M.ID_MASCOTA = C.ID_MASCOTA
WHERE YEAR(C.FECHA) = YEAR(GETDATE())
GROUP BY C.ID_MASCOTA
HAVING COUNT(C.ID_MASCOTA) > 10

*/


/*5. ¿Cuánto pagó en total cada dueño por la atención de sus mascotas por año? ¿Cuándo fue el
importe promedio y la fecha de la primera y última consulta? Siempre y cuando el ese promedio
pagado haya sido superior al promedio de ese mismo año.*/

/*
SELECT
D.NOMRE AS 'DUEÑOS',
YEAR(C.FECHA) AS 'AÑO'
SUM(C.IMPORTE) AS 'IMPORTE TOTAL',
AVG(C.IMPORTE) AS 'IMPORTE PROMEDIO',
MAX(C.FECHA) AS 'ULTIMA CONSULTA',
MIN(C.FECHA) AS 'PRIMERA CONSULTA'
FROM CONSULTAS C 
JOIN MASCOTAS M ON C.ID_MASCOTA = M.ID_MASCOTA
JOIN DUEÑOS D ON D.ID_DUEÑO = M.ID_DUEÑO
GROUP BY D.NOMBRE,C.FECHA
HAVING AVG(C.IMPORTE) > (SELECT AVG(IMPORTE), YEAR(FECHA) FROM CONSULTAS )

*/



/*===============================================TEMA 2 ====================================================================*/

/*1. Emitir un listado de todos los dueños incluyendo el nombre del barrio que pagaron más de
$1000 en consultas en los últimos 3 meses.*/

/*

SELECT 
D.NOMBRE AS 'DUEÑOS',
B.BARRIO AS 'BARRIOS',
SUM(C.IMPORTE) AS 'IMPORTE'
FROM CONSULTAS C 
JOIN MASCOTAS M ON M.ID_MASCOTA = C.ID_MASCOTA
JOIN DUEÑOS D ON D.ID_DUEÑO = M.ID_DUEÑO
JOIN BARRIOS B ON B.ID_BARRIO = D.ID_BARRIO
WHERE MONTH(C.FECHA) = MONTH(GETDATE()) -1 OR
WHERE MONTH(C.FECHA) = MONTH(GETDATE()) -2 OR
WHERE MONTH(C.FECHA) = MONTH(GETDATE()) -3 
GROUP BY D.NOMBRE, B.BARRIO
HAVING SUM(C.IMPORTE) > 1000*/


/*2. Listar los dueños que vinieron más de 3 veces el año pasado.*/

/*
SELECT 
D.NOMBRE AS 'DUEÑOS'
FROM CONSULTAS C 
JOIN MASCOTAS M ON M.ID_MASCOTA = C.ID_MASCOTA
JOIN DUEÑOS D ON D.ID_DUEÑO = M.ID_DUEÑO
WHERE YEAR(C.FECHA) = YEAR(GETDATE()) - 1
GROUP BY D.NOMBRE
HAVING COUNT(C.ID_CONSULTA) > 3

*/


/*3. ¿Cuáles es el médico que atendió más consultas este año?*/

/*
SELECT
M.NOMBRE AS 'MEDICOS',
MAX(C.ID_CONSULTA) AS 'MAYOR CANTIDAD  CONSULTAS'
FROM CONSULTAS C 
JOIN MEDICOS M ON M.ID_MEDICO = C.ID_MEDICO
WHERE YEAR(C.FECHA) = YEAR(GETDATE())
GROUP M.NOBRE
*/


/*4. Mostrar en una misma tabla de resultados los médicos que no atendieron nunca este año (en
primer lugar) y los que atendieron más de 10 consultas este año en segundo lugar, ordenados
en forma alfabética por nombre de médico.
*/

/*
SELECT
M.NOMBRE AS 'MEDICOS' 'NO ATENDIERON NUNCA'
FROM CONSULTAS C
JOIN MEDICOS M ON M.ID_MEDICO = C.ID_MEDICO
WHERE C.ID_MEDICO NOT IN (SELECT ID_MEDICO FROM CONSULTAS WHERE YEAR(FECHA) = YEAR (GETDATE()))
AND YEAR(C.FECHA) = YEAR(GETDATE())

UNION

SELECT
M.NOMBRE AS 'MEDICOS' 'ATENDIERON MAS DE 10 CONSULTAS'
FROM CONSULTAS C 
JOIN MEDICOS M ON M.ID_MEDICO = C.ID_MEDICO
WHERE YEAR(C.FECHA) = YEAR(GETDATE())
GROUP BY M.NOMBRE
HAVING COUNT(C.ID_CONSULTA) > 10
ORDER BY 1;

*/


/*5. ¿Cuánto cobró en total cada médico en consultas este año? ¿Cuándo fue el importe promedio
y la fecha de la primera y última consulta? Siempre y cuando ese promedio cobrado haya sido
superior al promedio del año pasado.*/

/*
SELECT 
M.NOMBRE AS 'MEDICOS',
SUM(C.IMPORTE) AS 'IMPORTE',
AVG(C.IMPORTE) AS 'PROMEDIO',
MIN(C.FECHA) AS 'PRIMERA CONSULTA',
MAX(C.FECHA) AS 'ULTIMA CONSULTA'
FROM CONSULTAS C 
JOIN MEDICOS M ON M.ID_MEDICO = C.ID_MEDICO
WHERE YEAR(C.FECHA) = YEAR(GETDATE())
GROUP BY M.NOMBRE
HAVING AVG(C.IMPORTE) > (SELECT AVG(IMPORTE) FROM CONSULTAS WHERE YEAR(FECHA) = YEAR(GETDATE()) -1  )
*/


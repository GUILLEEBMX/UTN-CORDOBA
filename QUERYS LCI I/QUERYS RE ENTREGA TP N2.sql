USE CLINICA;

SELECT  P.NOMBRE + ' ' + P.APELLIDO AS 'FULL NAME',B.BARRIO AS 'BARRIO',DP.DEPARTAMENTO AS 'DEPARTAMENTO', C.CIUDAD AS 'CIUDAD', P.email AS 'EMAIL'
FROM PERSONAS P, BARRIOS B , DEPARTAMENTOS DP, CIUDADES C
WHERE P.id_barrio = B.id_barrio
AND C.id_departamento = DP.id_departamento
AND P.id_barrio = B.id_barrio 
AND DP.DEPARTAMENTO = 'POCHO' 
AND P.APELLIDO NOT LIKE '[D-P]%'
AND P.email IS NULL
ORDER BY B.id_barrio;


    
SELECT DISTINCT  P.nombre + ' ' + P.apellido AS 'PACIENTE', P.documento AS 'DOCUMENTO' , DC.diagnostico, p.cuil AS 'CUIL'
FROM DETALLES_CONSULTAS DC, PERSONAS P, CONSULTAS CS  
WHERE CS.id_paciente = P.id_persona
AND  DC.diagnostico = 'TODO OK'
AND P.email IS  NULL
AND P.cuil IS NOT NULL;
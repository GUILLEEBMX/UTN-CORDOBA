CREATE DATABASE ESCUELA;

USE ESCUELA;

CREATE TABLE BARRIOS 
(
    id_barrio int IDENTITY(1,1),
    nombre_barrio varchar (20),

    CONSTRAINT PK_BARRIO PRIMARY  KEY (id_barrio)

);

CREATE TABLE ALUMNOS
(
    legajo int IDENTITY(1,1),
    nombre varchar (15),
    apellido varchar (15),
    calle varchar (15),
    numero int,
    id_barrio int, 
    nro_dni varchar (20),
    email varchar (15),
    fecha_naci datetime,

    CONSTRAINT PK_ALUMNO PRIMARY KEY (legajo),

    CONSTRAINT FK_BARRIOS_ALUMNOS FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio)

);

INSERT INTO BARRIOS (nombre_barrio) VALUES ('ALBERDI');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('CENTRO');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('ALTO ALBERDI');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('VILLA PAEZ');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('CERRO DE LAS ROSAS');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('SAN MARTIN');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('GENERAL PAZ');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('JUNIOR');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('ALTA CORDOBA');
INSERT INTO BARRIOS (nombre_barrio) VALUES ('SAN VICENTE');

SELECT * FROM BARRIOS;



INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('GUILLERMO','BRITOS','AV COLON',1996,1,'37851938','gbritos13@gmail.com','22/10/1993');

ALTER TABLE ALUMNOS ALTER COLUMN email varchar (50);

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('AUGUSTO','BRITOS','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('YAMILA','ECHENIQUE','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('JAVIER','ECHENIQUE','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('TANIA','ECHENIQUE','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('CELESTE','ECHENIQUE','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('ROBERTO','BRITOS','AV VIVAS',123,4,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('ELIZABETH','BLUMEN','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('NOELIA','MOREL','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

INSERT INTO ALUMNOS (nombre,apellido,calle,numero,id_barrio,nro_dni,email,fecha_naci)
VALUES ('YAMILA','ECHENIQUE','AV CHACABUCO',36,2,'38897604','agbritos@gmail.com','22/10/1993');

SELECT legajo,nombre
FROM ALUMNOS
ORDER BY legajo ASC;

UPDATE ALUMNOS
SET nro_dni = '123456'
WHERE legajo = 6;

UPDATE ALUMNOS
SET apellido = 'NO LO SE'
WHERE legajo = 6;

UPDATE ALUMNOS
SET calle = 'AVENIDA BRASIL'
WHERE LEGAJO = 6;

UPDATE ALUMNOS
SET numero = 1997
WHERE LEGAJO = 7;

DELETE FROM ALUMNOS WHERE legajo = 21;


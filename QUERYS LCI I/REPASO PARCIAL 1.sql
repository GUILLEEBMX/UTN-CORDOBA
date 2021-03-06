
CREATE DATABASE VETERINARIA;

USE VETERINARIA;

CREATE TABLE BARRIOS
(
    id_barrio INT IDENTITY (1,1),
    barrio VARCHAR (20),

    CONSTRAINT PK_BARRIO PRIMARY KEY (id_barrio)

);



CREATE TABLE TIPOS
(
    id_tipo INT IDENTITY(1,1),
    tipo VARCHAR (10),

    CONSTRAINT PK_TIPO PRIMARY KEY (id_tipo)


);

CREATE TABLE RAZAS
(
    id_raza INT IDENTITY (1,1),
    raza VARCHAR (20)

    CONSTRAINT PK_RAZA PRIMARY KEY (id_raza)

);

CREATE TABLE DUEÑOS
(
    id_dueño INT IDENTITY (1,1),
    nombre VARCHAR  (15),
    apellido VARCHAR (15),
    calle VARCHAR (15),
    altura INT,
    id_barrio INT,
    telefono VARCHAR (20),

    CONSTRAINT PK_DUEÑO PRIMARY KEY (id_dueño),

    CONSTRAINT FK_BARRIOS_DUEÑOS FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio)


);

CREATE TABLE MASCOTAS
(
    id_mascota INT IDENTITY(1,1),
    nombre VARCHAR (15),
    id_tipo INT,
    id_raza INT,
    fec_nac DATETIME,
    id_dueño INT,

    CONSTRAINT PK_MASCOTA PRIMARY KEY (id_mascota),

    CONSTRAINT FK_TIPOS_MASCOTAS FOREIGN KEY (id_tipo)
    REFERENCES TIPOS (id_tipo),

    CONSTRAINT FK_RAZAS_MASCOTAS FOREIGN KEY (id_raza)
    REFERENCES RAZAS (id_raza),

    CONSTRAINT FK_DUEÑOS_MASCOTAS FOREIGN KEY (id_dueño)
    REFERENCES DUEÑOS (id_dueño)


);

CREATE TABLE MEDICOS
(
    id_medico INT IDENTITY (1,1),
    nombre VARCHAR (20),
    apellido VARCHAR (20),
    fec_ingreso DATETIME,
    matricula VARCHAR (20),
    telefono VARCHAR (20),

    CONSTRAINT PK_MEDICO PRIMARY KEY (id_medico)

);

CREATE TABLE CONSULTAS
(
    id_consulta INT IDENTITY (1,1),
    id_medico INT,
    id_mascota INT,
    fecha DATETIME NOT NULL,
    detalle_consulta VARCHAR (30),
    importe DECIMAL (10)

    CONSTRAINT PK_CONSULTA PRIMARY KEY (id_consulta),

    CONSTRAINT FK_MEDICOS_CONSULTAS FOREIGN KEY (id_medico)
    REFERENCES MEDICOS (id_medico),

    CONSTRAINT FK_MASCOTAS_CONSULTAS FOREIGN KEY (id_mascota)
    REFERENCES MASCOTAS (id_mascota),


);

---2

ALTER TABLE DUEÑOS  ADD [e-mail ] VARCHAR (20);

--3

ALTER TABLE MEDICOS ALTER COLUMN matricula VARCHAR (10);

--4

ALTER TABLE  MEDICOS DROP COLUMN telefono; 

--5
ALTER TABLE TIPOS
DROP CONSTRAINT PK_TIPO;

--6
--LO HICE CUANDO CREE LA TABLA;

--7

DROP TABLE TIPOS;

ALTER TABLE MASCOTAS DROP CONSTRAINT FK_TIPOS_MASCOTAS;

--8

DROP TABLE CONSULTAS;

--9

INSERT INTO MASCOTAS (nombre) VALUES ('PERRO');

SELECT id_mascota,nombre
FROM MASCOTAS;

INSERT INTO CONSULTAS (id_mascota,detalle_consulta,importe,fecha) VALUES (1,'DETALLE 1', 50,'22/10/1993');

SELECT *  
FROM CONSULTAS;

--10

SELECT * FROM BARRIOS;

UPDATE DUEÑOS
SET CALLE = 'BRASIL', ALTURA = 123, id_barrio = 1
WHERE id_dueño = 30;

--11


DELETE DUEÑOS
WHERE id_dueño = 2;

SELECT * 
FROM DUEÑOS;

INSERT INTO DUEÑOS (nombre,apellido) VALUES ('ROBERTO','BRITOS');

SELECT *
FROM MASCOTAS;


UPDATE MASCOTAS
SET id_dueño = 1
WHERE id_mascota = 1;

--12

SELECT id_consulta
FROM CONSULTAS;

DELETE CONSULTAS
WHERE id_consulta = 111; 

--13

SELECT apellido + ' ' + nombre AS 'NOMBRE COMPLETO'
FROM DUEÑOS
ORDER BY apellido DESC

--14

SELECT id_mascota,id_tipo
FROM MASCOTAS
WHERE fec_nac < '28/04/2022'
ORDER BY id_tipo DESC, id_raza ASC;

--15
SELECT (importe - ((importe * 15) / 100))  AS 'PRECIO FINAL'
FROM CONSULTAS;

SELECT * FROM
CONSULTAS;

--16

SELECT DISTINCT NOMBRE
FROM MASCOTAS;

-- 17

SELECT TOP 10 importe
FROM CONSULTAS
ORDER BY importe DESC;

--18

SELECT *
FROM MASCOTAS;

SELECT TOP 15 fec_nac
FROM MASCOTAS
ORDER BY fec_nac DESC;

--19

SELECT TOP 5 fec_ingreso, nombre
FROM MEDICOS
ORDER BY NOMBRE ASC;

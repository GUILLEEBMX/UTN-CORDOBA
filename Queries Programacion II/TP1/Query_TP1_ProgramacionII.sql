CREATE DATABASE TP1_PROGRAMACION_II

USE TP1_PROGRAMACION_II;


CREATE TABLE CARRERAS
(
    id_carrera int IDENTITY (1,1),
    nombre varchar (50),
    titulo varchar (50),
    CONSTRAINT PK_CARRERA PRIMARY KEY (id_carrera)
);

CREATE TABLE DETALLES_CARRERAS
(
    id_detalle int IDENTITY (1,1),
    id_carrera int,
    anio_cursado VARCHAR (50),
    cuatrimestre VARCHAR (50),
    materia VARCHAR (50),
    CONSTRAINT PK_DETALLE_CARRERA PRIMARY KEY (id_detalle),
    CONSTRAINT FK_ID_CARRERA FOREIGN KEY (id_carrera) REFERENCES CARRERAS (id_carrera)
);


CREATE TABLE ASIGNATURAS
(
    id_asignatura INT IDENTITY(1,1),
    nombre VARCHAR (50),
    CONSTRAINT PK_ASIGNATURA PRIMARY KEY (id_asignatura)
);
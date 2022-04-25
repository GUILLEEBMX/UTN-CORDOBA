CREATE DATABASE BIBLIOTECA ;

USE BIBLIOTECA;

CREATE TABLE ESCRITORES
(
    cod_escritor int IDENTITY (1,1),
    nombre varchar (15),
    apellido varchar (15),
    nacionalidad varchar (10),
    fecha_nac date,
    fecha_def date,

    CONSTRAINT PK_ESCRITORES PRIMARY KEY (cod_escritor)

);

CREATE TABLE LIBROS
(
    legajo int IDENTITY (1,1),
    titulo varchar (20),
    genero varchar (15),
    editorial varchar (20),
    edicion varchar (15),
    cod_escritor int,

    CONSTRAINT PK_LIBRO PRIMARY KEY (legajo),

    CONSTRAINT FK_ESCRITORES_LIBROS FOREIGN KEY (cod_escritor)
    REFERENCES ESCRITORES (cod_escritor)


);



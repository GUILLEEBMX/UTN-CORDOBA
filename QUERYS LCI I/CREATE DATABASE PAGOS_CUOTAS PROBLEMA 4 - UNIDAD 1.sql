CREATE DATABASE PAGOS_CUOTAS;

USE PAGOS_CUOTAS;

CREATE TABLE PROVINCIAS
(
    id_provincia int IDENTITY (1,1),
    nombre_provincia varchar (20),

    CONSTRAINT PK_PROVINCIA PRIMARY KEY (id_provincia)

);

CREATE TABLE LOCALIDADES
(
    id_localidad int IDENTITY (1,1),
    nombre_localidad varchar (20),
    id_provincia int,

    CONSTRAINT PK_LOCALIDAD PRIMARY KEY (id_localidad),

    CONSTRAINT FK_PROVINCIAS_LOCALIDADES FOREIGN KEY (id_provincia)
    REFERENCES PROVINCIAS (id_provincia)


);

CREATE TABLE BARRIOS
(
    id_barrio int IDENTITY (1,1),
    nombre_barrio varchar (50),
    id_localidad int,

    CONSTRAINT PK_BARRIO PRIMARY KEY (id_barrio),

    CONSTRAINT FK_LOCALIDADES_BARRIOS FOREIGN KEY (id_localidad)
    REFERENCES LOCALIDADES (id_localidad)


);

CREATE TABLE ALUMNOS
(
    legajo int IDENTITY (1,1),
    nombre varchar (20),
    apellido varchar (20),
    id_barrio int,
    calle varchar (20),
    nro_calle int,
    telefono varchar (20),
    email varchar (20),

    CONSTRAINT PK_ALUMNO PRIMARY KEY (legajo),

    CONSTRAINT FK_BARRIOS_ALUMNOS FOREIGN KEY (id_barrio) 
    REFERENCES BARRIOS (id_barrio)


);

CREATE TABLE DOCENTES 
(
    id_docente int IDENTITY (1,1),
    nombre varchar (20),
    apellido varchar (20),

    CONSTRAINT PK_DOCENTE PRIMARY KEY (id_docente)

);


CREATE TABLE CURSOS
(
    cod_curso int IDENTITY (1,1),
    decripcion varchar (20),
    nivel varchar (10),
    id_docente int, 
    horario date,

    CONSTRAINT PK_CURSO PRIMARY KEY (cod_curso),

    CONSTRAINT FK_DOCENTES_CURSOS FOREIGN KEY (id_docente)
    REFERENCES DOCENTES (id_docente)

);


CREATE TABLE PAGOS_CUOTAS
(
    id_pago int IDENTITY (1,1),
    legajo int ,
    cod_curso int,
    mes_año date,
    fecha date,
    monto money,

    CONSTRAINT PK_PAGOS_CUOTAS PRIMARY KEY (id_pago),

    CONSTRAINT FK_ALUMNOS_PAGOS_CUOTAS FOREIGN KEY (legajo)
    REFERENCES ALUMNOS (legajo),

    CONSTRAINT FK_CURSOS_PAGOS_CUOTAS FOREIGN KEY (cod_curso)
    REFERENCES CURSOS (cod_curso)


);


CREATE DATABASE FARMACIA;

USE FARMACIA;

CREATE TABLE CIUDADES
(
id_ciudad int IDENTITY(1,1),
ciudad varchar (50)
CONSTRAINT PK_CIUDAD PRIMARY KEY (id_ciudad)
);

CREATE TABLE BARRIOS
(
    id_barrio int IDENTITY(1,1),
    barrio varchar (50),
    id_ciudad int,
    
    CONSTRAINT PK_BARRIO PRIMARY KEY (id_barrio),
    CONSTRAINT FK_CIUDADES_BARRIOS FOREIGN KEY (id_ciudad)
    REFERENCES CIUDADES (id_ciudad)
    
);

CREATE TABLE LABORATORIOS
(
    cod_laboratorio int IDENTITY(1,1),
    nombre_lab varchar (50),
    direccion varchar (30),
    id_barrio int,
    telefono varchar (30),
    email varchar (20),
    
    CONSTRAINT PK_LABORATORIO PRIMARY KEY (cod_laboratorio),
    CONSTRAINT FK_BARRIOS_LABORATORIOS FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio)
);

CREATE TABLE PRESENTACIONES
(
    id_present int IDENTITY(1,1),
    tipo_present varchar (50),
    CONSTRAINT PK_PRESENTACIONES PRIMARY KEY  (id_present),

);

CREATE TABLE MEDICAMENTOS
(
    cod_med int IDENTITY(1,1),
    nombre_med varchar (20),
    cod_laboratorio int,
    id_present int,
    precio varchar (20),
    contenido varchar (20),
    
    CONSTRAINT PK_MEDICAMENTO PRIMARY KEY (cod_med),

    CONSTRAINT FK_LABORATORIOS_MEDICAMENTOS FOREIGN KEY
    (cod_laboratorio) REFERENCES LABORATORIOS (cod_laboratorio),

    CONSTRAINT FK_PRESENTACIONES_MEDICAMENTOS FOREIGN KEY (id_present)
    REFERENCES PRESENTACIONES (id_present)


);
CREATE DATABASE CLUB_CAROLINOS;

USE CLUB_CAROLINOS;

CREATE TABLE PERIODOS
(
    codigo_mes int IDENTITY (1,1),
    nombre_mes varchar (20),

    CONSTRAINT PK_PERIODO PRIMARY KEY (codigo_mes)

);

CREATE TABLE TIPOS_ACTIVIDADES
(
    id_tipo_actividad int IDENTITY (1,1),
    descripcion varchar (25),

    CONSTRAINT PK_TIPO_ACTIVIDAD PRIMARY KEY (id_tipo_actividad)

);

CREATE TABLE ACTIVIDADES
(
    codigo_actividad int IDENTITY (1,1),
    nombre_actividad varchar (25),
    descripcion varchar (25),
    id_tipo_actividad int,
    precio money,

    CONSTRAINT PK_ACTIVIDAD PRIMARY KEY (codigo_actividad),

    CONSTRAINT FK_ID_TIPO_ACTIVIDAD_ACTIVIDADES FOREIGN KEY (id_tipo_actividad)
    REFERENCES TIPOS_ACTIVIDADES (id_tipo_actividad)

);

CREATE TABLE TIPOS_DOC
(
    id_tipo_doc int IDENTITY (1,1),
    descripcion varchar (25),

    CONSTRAINT PK_TIPO_DOC PRIMARY KEY (id_tipo_doc),

);

CREATE TABLE SOCIOS
(
    numero_socio int IDENTITY (1,1),
    nombre varchar (20),
    apellido varchar (20),
    telefono varchar (20),
    email varchar (20),
    direccion varchar (20),
    id_tipo_doc int,
    numero_doc varchar (15),
    fecha_nac date,

    CONSTRAINT PK_SOCIO PRIMARY KEY (numero_socio),

    CONSTRAINT FK_TIPOS_DOC_SOCIOS FOREIGN KEY (id_tipo_doc)
    REFERENCES TIPOS_DOC (id_tipo_doc)

);

CREATE TABLE RECIBOS
(
    numero_recibo int IDENTITY (1,1),
    fecha_recibo date,
    numero_socio int, 

    CONSTRAINT PK_RECIBO PRIMARY KEY (numero_recibo),

    CONSTRAINT FK_SOCIOS_RECIBOS FOREIGN KEY (numero_socio)
    REFERENCES SOCIOS (numero_socio)


);

CREATE TABLE DETALLES_RECIBOS
(
    numero_detalle int IDENTITY (1,1),
    numero_recibo int,
    codigo_actividad int,
    codigo_mes int,
    monto money,

    CONSTRAINT PK_DETALLE_RECIBO PRIMARY KEY (numero_detalle),

    CONSTRAINT FK_RECIBOS_DETALLES_RECIBOS FOREIGN KEY (numero_recibo)
    REFERENCES RECIBOS (numero_recibo),

    CONSTRAINT FK_ACTIVIDADES_DETALLES_RECIBOS FOREIGN KEY (codigo_actividad)
    REFERENCES ACTIVIDADES (codigo_actividad),

    CONSTRAINT FK_PERIODOS_DETALLES_RECIBOS FOREIGN KEY (codigo_mes)
    REFERENCES PERIODOS (codigo_mes)


);
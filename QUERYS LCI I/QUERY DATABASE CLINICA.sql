DROP DATABASE FARMACIA;

CREATE DATABASE CLINICA;

USE CLINICA;

CREATE TABLE CIUDADES
(
id_ciudad int identity (1,1) ,
ciudad nvarchar (30),
constraint PK_CIUDAD PRIMARY KEY (id_ciudad)
);

CREATE TABLE LOCALIDADES
(
id_localidad int identity (1,1), 
localidad nvarchar(30), 
id_ciudad int, 
CONSTRAINT PK_LOCALIDADES PRIMARY KEY (id_localidad),
CONSTRAINT FK_LOCALIDADES_CIUDADES FOREIGN KEY (id_ciudad)
REFERENCES CIUDADES (id_ciudad) 
); 

CREATE TABLE BARRIOS 
(
id_barrio int identity (1,1), 
barrio nvarchar (30), 
id_localidad int,
CONSTRAINT PK_BARRIOS PRIMARY KEY (id_barrio),
CONSTRAINT FK_CIUDADES_BARRIOS FOREIGN KEY (id_localidad) 
REFERENCES LOCALIDADES (id_localidad)
); 

CREATE TABLE TIPOS_CONTACTOS
(
id_tipo_contacto int identity (1,1), 
tipo_contacto nvarchar (30),
CONSTRAINT PK_TIPOS_CONTACTOS PRIMARY KEY (id_tipo_contacto)
); 

CREATE TABLE OBRAS_SOCIALES
(
id_obra_social int identity (1,1),
nro_afiliado nvarchar (20),
nombre nvarchar (30),
cuit varchar (50),
CONSTRAINT PK_OBRAS_SOCIALES PRIMARY KEY (id_obra_social)
);

CREATE TABLE GENEROS
(
    id_genero int IDENTITY (1,1),
    tipo_genero varchar (20)
    CONSTRAINT PK_GENEROS PRIMARY KEY (id_genero)
);


CREATE TABLE PACIENTES
(
id_paciente int identity (1,1),
nombre nvarchar (30),
apellido nvarchar (30),
cuil varchar (15),
id_barrio int, 
id_obra_social int, 
turno bit, 
particular bit ,
id_genero int,
CONSTRAINT PK_PACIENTES PRIMARY KEY (id_paciente), 
CONSTRAINT FK_BARRIOS_PACIENTES FOREIGN KEY (id_barrio)
REFERENCES BARRIOS (id_barrio) , 
CONSTRAINT FK_OBRAS_SOCIALES_PACIENTES FOREIGN KEY (id_obra_social)
REFERENCES OBRAS_SOCIALES (id_obra_social), 
CONSTRAINT FK_GENEROS_PACIENTES FOREIGN KEY (id_genero) 
REFERENCES GENEROS (id_genero)
); 

ALTER TABLE PACIENTES ADD id_tipo_telefono INT;

--ALTER TABLE PACIENTES ADD CONSTRAINT FK_TIPOS_TELEFONOS_PACIENTES FOREIGN KEY (id_tipo_telefono) 
--REFERENCES TIPOS_TELEFONOS (id_tipo_telefono);
--SEGUIR DESDE ACA....


CREATE TABLE  CONTACTOS 
(
id_contacto int, 
contacto varchar (30) ,
id_paciente int, 
id_tipo_contacto int,
CONSTRAINT PK_CONTACTOS PRIMARY KEY (id_contacto) ,
CONSTRAINT FK_PACIENTES_CONTACTOS FOREIGN KEY (id_paciente) 
REFERENCES PACIENTES (id_paciente) ,
CONSTRAINT FK_TIPOS_CONTACTOS FOREIGN KEY (id_tipo_contacto) 
REFERENCES TIPOS_CONTACTOS (id_tipo_contacto) 
);

CREATE TABLE ESPECIALIDADES
(
id_especialidad int, 
especialidad nvarchar (30), 
CONSTRAINT PK_ESPECIALIDADES PRIMARY KEY (id_especialidad)
);
 
CREATE TABLE MEDICOS 
(
id_medico int, 
matricula varchar (30),
nombre nvarchar (30),
apellido nvarchar (30),
id_especialidad int, 
id_genero int,
CONSTRAINT PK_MEDICOS PRIMARY KEY (id_medico),
CONSTRAINT FK_ESPECIALIDADES_MEDICOS FOREIGN KEY (id_especialidad) 
REFERENCES ESPECIALIDADES (id_especialidad),
CONSTRAINT FK_GENEROS_MEDICOS FOREIGN KEY (id_genero) 
REFERENCES GENEROS (id_genero) 

);

CREATE TABLE CONSULTAS
(
    id_consulta int IDENTITY (1,1),
    id_medico int, 
    id_paciente int ,
    fecha_hora datetime,
    CONSTRAINT PK_CONSULTAS PRIMARY KEY (id_consulta),
    CONSTRAINT FK_MEDICOS_CONSULTAS FOREIGN KEY (id_medico)
    REFERENCES MEDICOS (id_medico),
    CONSTRAINT FK_PACIENTES_CONSULTAS foreign key (id_paciente) 
    REFERENCES PACIENTES (id_paciente)

);

CREATE TABLE DETALLES_CONSULTAS
(
id_detalle int IDENTITY (1,1) ,
id_consulta int,
estudios_especiales nvarchar(100), 
diagnosticos varchar (200), 
CONSTRAINT PK_DETALLES_CONSULTAS PRIMARY KEY (id_detalle),
CONSTRAINT FK_CONSULTAS_DETALLES_CONSULTAS FOREIGN KEY (id_consulta)
REFERENCES CONSULTAS (id_consulta)
);

CREATE TABLE PAGOS 
(
    id_pago INT IDENTITY (1,1),
    id_detalle_pago INT,
    id_paciente INT,
    id_forma_pago INT,
    fecha DATE,

    CONSTRAINT PK_PAGOS PRIMARY KEY (id_pago),

    CONSTRAINT FK_DETALLES_PAGOS FOREIGN KEY (id_detalle_pago)
    REFERENCES DETALLES_PAGOS (id_detalle_pago),

    CONSTRAINT FK_FORMAS_PAGOS_PAGOS FOREIGN KEY (id_forma_pago) 
    REFERENCES FORMAS_PAGO (id_forma_pago),

    CONSTRAINT FK_PACIENTES_PAGOS FOREIGN KEY (id_paciente)
    REFERENCES PACIENTES (id_paciente)

);

CREATE TABLE FORMAS_PAGO
(
    id_forma_pago INT IDENTITY(1,1),
    descripcion VARCHAR (50),

    CONSTRAINT PK_FORMA_PAGO PRIMARY KEY (id_forma_pago)
);

CREATE TABLE DETALLES_PAGOS
(
    id_detalle_pago INT IDENTITY (1,1),
    descripcion VARCHAR (20),
    monto DECIMAL ,

    CONSTRAINT PK_DETALLE_PAGO PRIMARY KEY (id_detalle_pago)

);

CREATE TABLE TIPOS_TELEFONOS
(
    id_tipo_tel INT IDENTITY (1,1),
    descripcion VARCHAR (20),

    CONSTRAINT PK_TIPO_TEL PRIMARY KEY (id_tipo_tel)

);








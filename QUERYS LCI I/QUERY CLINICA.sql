
CREATE DATABASE CLINICA;

USE CLINICA;



CREATE TABLE CIUDADES
(
id_ciudad INT identity (1,1) ,
ciudad VARCHAR (30),
constraint PK_CIUDAD PRIMARY KEY (id_ciudad)
);

CREATE TABLE LOCALIDADES
(
id_localidad INT identity (1,1), 
localidad VARCHAR(30), 
id_ciudad INT, 
CONSTRAINT PK_LOCALIDADES PRIMARY KEY (id_localidad),
CONSTRAINT FK_LOCALIDADES_CIUDADES FOREIGN KEY (id_ciudad)
REFERENCES CIUDADES (id_ciudad) 
); 

CREATE TABLE BARRIOS 
(
id_barrio INT identity (1,1), 
barrio VARCHAR (30), 
id_localidad INT,
CONSTRAINT PK_BARRIOS PRIMARY KEY (id_barrio),
CONSTRAINT FK_CIUDADES_BARRIOS FOREIGN KEY (id_localidad) 
REFERENCES LOCALIDADES (id_localidad)
); 

CREATE TABLE OBRAS_SOCIALES
(
id_obra_social INT identity (1,1),
nro_afiliado VARCHAR (20),
nombre VARCHAR (30),
cuit VARCHAR (50),
categoria VARCHAR (20),

CONSTRAINT PK_OBRAS_SOCIALES PRIMARY KEY (id_obra_social)
);

CREATE TABLE GENEROS
(
    id_genero INT IDENTITY (1,1),
    tipo_genero VARCHAR (20)
    CONSTRAINT PK_GENEROS PRIMARY KEY (id_genero)
);




CREATE TABLE TIPOS_DOC
(
    id_tipo_doc INT IDENTITY(1,1),
    tipo_doc VARCHAR (10),
    descripcion VARCHAR (20),

    CONSTRAINT PK_TIPO_DOC PRIMARY KEY (id_tipo_doc)

);

CREATE TABLE ESPECIALIDADES
(
id_especialidad INT, 
especialidad VARCHAR (30), 
CONSTRAINT PK_ESPECIALIDADES PRIMARY KEY (id_especialidad)
);

CREATE TABLE TIPOS_TELEFONOS
(
    id_tipo_tel INT IDENTITY (1,1),
    descripcion VARCHAR (20),

    CONSTRAINT PK_TIPO_TEL PRIMARY KEY (id_tipo_tel)
);

CREATE TABLE PERSONAS
(
    id_persona INT IDENTITY (1,1),
    dni INT,
    nombre VARCHAR (20),
    apellido VARCHAR (20),
    cuil INT,
    fecha_nac DATE,
    id_tipo_doc INT,
    id_genero INT,
    id_barrio INT,
    id_tipo_tel INT,
    num_tel VARCHAR (30),
    email VARCHAR (20)

    CONSTRAINT PK_PERSONA PRIMARY KEY (id_persona),

    CONSTRAINT FK_BARRIOS_PERSONAS FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio),

    CONSTRAINT FK_TIPOS_DOC_PERSONAS FOREIGN KEY (id_tipo_doc)
    REFERENCES TIPOS_DOC (id_tipo_doc),

    
    CONSTRAINT FK_GENEROS_PERSONAS FOREIGN KEY (id_genero)
    REFERENCES GENEROS (id_genero),

     
    CONSTRAINT FK_TIPOS_TEL_PERSONAS FOREIGN KEY (id_tipo_tel)
    REFERENCES TIPOS_TELEFONOS (id_tipo_tel),

);

CREATE TABLE PACIENTES
(
id_paciente INT identity (1,1),
id_persona INT ,
id_obra_social INT, 
turno BIT, 
particular BIT ,

CONSTRAINT PK_PACIENTES PRIMARY KEY (id_paciente), 

CONSTRAINT FK_OBRAS_SOCIALES_PACIENTES FOREIGN KEY (id_obra_social)
REFERENCES OBRAS_SOCIALES (id_obra_social), 

CONSTRAINT FK_PERSONAS_PACIENTES FOREIGN KEY (id_persona) 
REFERENCES PERSONAS (id_persona)


); 

 
CREATE TABLE MEDICOS 
(
id_medico INT, 
matricula VARCHAR (30),
id_especialidad INT, 
id_persona INT,

CONSTRAINT PK_MEDICOS PRIMARY KEY (id_medico),

CONSTRAINT FK_ESPECIALIDADES_MEDICOS FOREIGN KEY (id_especialidad) 
REFERENCES ESPECIALIDADES (id_especialidad),

CONSTRAINT FK_PERSONAS_MEDICOS FOREIGN KEY (id_persona) 
REFERENCES PERSONAS (id_persona)


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


CREATE TABLE CONSULTAS
(
    id_consulta INT IDENTITY (1,1),
    id_medico INT, 
    id_paciente INT ,
    fecha_hora datetime,

    CONSTRAINT PK_CONSULTAS PRIMARY KEY (id_consulta),

    CONSTRAINT FK_MEDICOS_CONSULTAS FOREIGN KEY (id_medico)
    REFERENCES MEDICOS (id_medico),

    CONSTRAINT FK_PACIENTES_CONSULTAS FOREIGN KEY (id_paciente) 
    REFERENCES PACIENTES (id_paciente)

);


CREATE TABLE DETALLES_CONSULTAS
(
id_detalle INT IDENTITY (1,1) ,
id_consulta INT,
estudios_especiales VARCHAR(100), 
diagnosticos VARCHAR (200), 
CONSTRAINT PK_DETALLES_CONSULTAS PRIMARY KEY (id_detalle),
CONSTRAINT FK_CONSULTAS_DETALLES_CONSULTAS FOREIGN KEY (id_consulta)
REFERENCES CONSULTAS (id_consulta)
);














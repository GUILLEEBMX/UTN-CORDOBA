
CREATE DATABASE CLINICA_SECOND25DEMAYO;

USE  CLINICA_SECOND25DEMAYO;

CREATE TABLE DEPARTAMENTOS
(
id_departamento INT identity (1,1), 
departamento VARCHAR (50), 
CONSTRAINT PK_DEPARTAMENTO PRIMARY KEY (id_departamento)
); 

CREATE TABLE CIUDADES
(
id_ciudad INT identity (1,1) ,
ciudad VARCHAR (50),
id_departamento INT,

CONSTRAINT PK_CIUDAD PRIMARY KEY (id_ciudad),

CONSTRAINT FK_DEPARTAMENTOS_CIUDADES FOREIGN KEY (id_departamento)
REFERENCES DEPARTAMENTOS (id_departamento)
);


CREATE TABLE BARRIOS 
(
id_barrio INT identity (1,1), 
barrio VARCHAR (50), 
id_ciudad INT,
CONSTRAINT PK_BARRIOS PRIMARY KEY (id_barrio),

CONSTRAINT FK_CIUDADES_BARRIOS FOREIGN KEY (id_ciudad) 
REFERENCES CIUDADES (id_ciudad)
); 

CREATE TABLE OBRAS_SOCIALES
(
id_obra_social INT identity (1,1),
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
    CONSTRAINT PK_TIPO_DOC PRIMARY KEY (id_tipo_doc)

);

CREATE TABLE ESPECIALIDADES
(
id_especialidad INT, 
especialidad VARCHAR (50), 
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
    documento VARCHAR (50),
    nombre VARCHAR (50),
    apellido VARCHAR (50),
    cuil VARCHAR (50),
    fecha_nac DATE,
    id_tipo_doc INT,
    id_genero INT,
    id_barrio INT,
    id_tipo_tel INT,
    num_tel VARCHAR (50),
    email VARCHAR (50)

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


CREATE TABLE ESTUDIOS_ESPECIALES
(
	id_estudios_especiales INT,
	descripcion VARCHAR(200),
	fecha_estudio DATETIME,

	CONSTRAINT PK_ESTUDIOS_ESPECIALES PRIMARY KEY (id_estudios_especiales)
);



CREATE TABLE DETALLES_CONSULTAS
(
	id_detalle INT IDENTITY (1,1),
	id_consulta INT,
	diagnosticos VARCHAR (200),
	id_estudios_especiales INT,
	
	CONSTRAINT PK_DETALLES_CONSULTAS PRIMARY KEY (id_detalle),
	
	CONSTRAINT FK_CONSULTAS_DETALLES_CONSULTAS FOREIGN KEY (id_consulta)
		REFERENCES CONSULTAS (id_consulta),

	CONSTRAINT FK_ESTUDIOS_ESPECIALES_DETALLES_CONSULTAS FOREIGN KEY (id_estudios_especiales)
		REFERENCES ESTUDIOS_ESPECIALES (id_estudios_especiales)
);










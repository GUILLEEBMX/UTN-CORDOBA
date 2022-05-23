
USE CLINICA;


--DEPARTAMENTOS
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('TULUMBA');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('SOBREMONTE');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('RIO SECO');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('CRUZ DEL EJE');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('ISCHILIN');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('TOTORAL');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('RIO PRIMERO');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('SAN JUSTO');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('MINAS');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('PUNILLA');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('COLYN');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('POCHO');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('CAPITAL');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('SAN ALBERTO');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('SANTA MARIA');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('RIO SEGUNDO');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('SAN JAVIER');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('CALAMUCHITA');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('TERCERO ARRIBA');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('SAN MARTIN');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('UNIYN');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('MARCOS JUAREZ');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('RIO CUARTO');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('JUAREZ CELMAN');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('PTE.ROQUE SAEZ PEÑA');
INSERT INTO DEPARTAMENTOS (DEPARTAMENTO) VALUES ('GRAL ROCA');


--CIUDADES
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ACHIRAS',1);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ADELIA MARIA',2);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('AGUA DE ORO',3);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALCIRA GIGENA',4);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALEJANDRO ROCA',5);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALEJO LEDESMA',6);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALICIA',7);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALMAFUERTE',8);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALPA CORRAL',9);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALTA GRACIA',10);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALTO ALEGRE',11);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ALTOS DE CHIPION',11);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ANISACATE',12);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ARIAS',13);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ARROYITO',14);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ARROYO ALGODÓN',15);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('ARROYO CABRAL',16);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('AUSONIA',17);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BALLESTEROS',18);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BALLESTEROS SUD',19);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BALNEARIA',20);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BELL VILLE',21);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BENGOLEA',22);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BENJAMIN GOULD',23);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BERROTARAN',24);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BIALET MASSE',25);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BOUWER',26);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BRINKMAN',1);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BUCHARDO',2);
INSERT INTO CIUDADES (CIUDAD,ID_DEPARTAMENTO) VALUES ('BULNES',3);





--BARRIOS
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('ALBERDI',1);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('ALTO ALBERDI',2);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('CENTRO',3);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('NUEVA CORDOBA',4);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('ALTO CORDOBA',5);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('CHATEU CARRERAS',6);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('COFICO',7);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('VILLA PAEZ',8);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('VILLA URQUIZA',9);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('JUNIOR',9);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('GENERAL PAZ',10);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('PUEYRREDON',11);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('SAN VICENTE',12);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('TALLERES',12);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('CERRO',13);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('ALTO VERDE',14);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('BAJO PALERMO',15);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('SUAREZ',16);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('BARRIO PARQUE',17);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('PARQUE VELEZ SARFIELD',18);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('FERROVIARIO MITRE',19);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('FERRER',20);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('CASEROS',21);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('VILLA LIBERTADOR',22);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('CABILDO',23);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('SANTA ISABEL I',24);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('SANTA ISABEL II',25);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('SANTA ISABEL III',26);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('QUINTAS DE SANTA ANA',27);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('CRISOL NORTE',28);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('CRISOL SUR',29);
INSERT INTO BARRIOS (BARRIO,ID_CIUDAD) VALUES ('SAN CARLOS',30);

--GENEROS
INSERT INTO GENEROS (TIPO_GENERO) VALUES ('HOMBRE');
INSERT INTO GENEROS (TIPO_GENERO) VALUES ('MUJER');
INSERT INTO GENEROS (TIPO_GENERO) VALUES ('INDEFINIDO');

--TIPOS DOC
INSERT INTO TIPOS_DOC (TIPO_DOC) VALUES ('DNI');
INSERT INTO TIPOS_DOC (TIPO_DOC) VALUES ('L.E');
INSERT INTO TIPOS_DOC (TIPO_DOC) VALUES ('PASAPORTE');
INSERT INTO TIPOS_DOC (TIPO_DOC) VALUES ('CEDULA');

--TIPOS_TELEFONOS
INSERT INTO TIPOS_TELEFONOS (DESCRIPCION) VALUES ('CELULAR');
INSERT INTO TIPOS_TELEFONOS (DESCRIPCION) VALUES ('FIJO');

-- PERSONAS

--HOMBRES
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('37851938','GUILLERMO','BRITOS','20378519382','22/10/1993',1,1,1,1,'3517550161','gbritos13@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('39691077','GASTON','TAIBO','20396910772','23/01/1993',1,1,1,1,'3512487965','taibon_gaston@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('38695654','LUCIANO','MANZANELLI','20386956542','18/05/1990',1,1,1,1,'3515412369','lucho_manzanelli@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('37851938','GOKU','SSJ1','20223547892','01/01/1980',1,1,3,1,'3514236987','goku_ssj1@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('35654741','GOKU','SSJ2','20113547892','05/06/1987',1,1,5,1,'351365874','goku_ssj2@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('32145756','CARLOS','ALVAREZ','20224100322','25/04/1990',1,1,6,1,'351236547','carlos_alvarez@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('38695654','EZEQUIEL','PEREZ','20325417892','05/08/2005',1,1,10,1,'3518095040','ezeperez@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('31045698','ALEJANDRO','MARCHAND','20235416982','11/07/1994',1,1,4,1,'3513256487','ale_ale@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('35477891','ENRIQUE','MACRI','20354778912','26/05/12',1,1,8,1,'3514203698','ENRIQUE@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('38695654','LUCIANO','MANZANELLI','20386956542','18/05/1990',1,1,1,1,'3515412369','lucho_manzanelli@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('25041321','MARTIN','DE PAUL','20250413212','25/04/1990',1,1,14,1,'351542158','martin_dapaul@gmail.com');

--MUJERES
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('25478965','LILIANA','GEYSELS','27254789658','08/03/1974',1,2,15,1,'3517550161','lilian_lilian@outlook.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('38987604','CELESTE','MARTINEZ','27389876048','22/01/1993',1,2,12,1,'351478954','cele_kpa@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('38695654','ESTELA','GOMEZ','275418948','18/05/1975',1,2,20,1,'3515412369','estelita_estelita@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('33654789','MARIELA','GOMEZ','27336547898','05/04/1980',1,2,6,1,'3514236987','mariela_mari@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('28965741','NORA','FUNES','27289657418','05/06/1987',1,2,5,1,'351365874','nora_norita@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('32145756','BULMA','LA MAS LINDA','271234568','08/05/1999',1,2,6,1,'351236547','bulma_capsule_corp@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('35241789','MANUELA','PEDROSKY','27352417898','01/01/2010',1,2,18,1,'3515897410','manuela_manuela@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('32564714','MARCIA','LOPEZ','27325647148','03/05/1974',1,2,4,1,'3513256487','marcia_marcia@yahoo.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('22541789','LUCIA','LUCIANI','27225417898','21/05/12',1,2,7,1,'3514203698','lucia@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('33541258','MARCELA','MANZANELLI','27335412588','05/02/1959',1,2,1,1,'3515412369','marcelita_lita_lita@gmail.com');
INSERT INTO  PERSONAS (DOCUMENTO,NOMBRE,APELLIDO,CUIL,FECHA_NAC,ID_TIPO_DOC,ID_GENERO,ID_BARRIO,ID_TIPO_TEL,NUM_TEL,EMAIL)
VALUES ('21045654','SOFIA','RODRIGUEZ','27210456548','03/04/1990',1,2,14,1,'351542158','sofi_lamastop@gmail.com');


--ESPECIALIDADES
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (1,'ALERGOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (2,'ANESTESIOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (3,'ANGIOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (4,'ENDOCRINOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (5,'ESTOMATOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (6,'FARMACOLOGIA CLINICA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (7,'GASTROENTEROLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (8,'GENETICA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (9,'GERIATRIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (10,'HEMATOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (11,'HEPATOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (12,'INFECTOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (13,'MEDICINA AEROESPACIAL');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (14,'MEDICINA DEL DEPORTE');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (15,'MEDICINA FAMILIAR Y COMUNITARIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (16,'MEDICINA FISICA Y REHABILITACION');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (17,'MEDIFICINA FORENSE');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (18,'MEDICINA INTENSIVA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (19,'MEDICINA INTERNA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (20,'MEDICINA PREVENTIVA Y SALUD PUBLICA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (21,'MEDICINA DEL TRABAJO');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (22,'NEFROLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (23,'NEUMOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (24,'NUTRIOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (25,'ONCOLOGIA MEDICA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (26,'ONCOLOGIA RADIOTERAPICA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (27,'PEDIATRIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (28,'PSIQUIATRIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (29,'REUMATOLOGIA');
INSERT INTO ESPECIALIDADES (ID_ESPECIALIDAD,ESPECIALIDAD) VALUES (30,'TOXICOLOGIA');


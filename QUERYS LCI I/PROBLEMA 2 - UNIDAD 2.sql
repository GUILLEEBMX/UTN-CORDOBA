CREATE DATABASE LIBRERIA;

USE LIBRERIA;

CREATE TABLE BARRIOS
(
    cod_barrio int IDENTITY (1,1),
    barrio varchar (20),

    CONSTRAINT PK_BARRIO PRIMARY KEY (cod_barrio)

);

CREATE TABLE ARTICULOS
(
    cod_articulo int IDENTITY (1,1),
    descripcion varchar (20),
    stock_minimo int,
    pre_unitario money,
    observaciones varchar (15),

    CONSTRAINT PK_ARTICULO PRIMARY KEY (cod_articulo)

);

CREATE TABLE VENDEDORES
(
    cod_vendedor INT IDENTITY (1,1),
    nom_vendedor varchar (15),
    ape_vendedor varchar (15),
    calle varchar (15),
    altura INT,
    cod_barrio INT,
    nro_tel varchar (20),
    fec_nac datetime,
    email varchar (20)

    CONSTRAINT PK_VENDEDOR PRIMARY KEY (cod_vendedor),

    CONSTRAINT FK_BARRIOS_VENDEDORES FOREIGN KEY (cod_barrio)
    REFERENCES BARRIOS (cod_barrio)


);

CREATE TABLE CLIENTES
(
    cod_cliente INT IDENTITY (1,1),
    nom_cliente VARCHAR (15),
    ape_cliente VARCHAR (15),
    calle VARCHAR (20),
    altura INT,
    cod_barrio INT,
    nro_tel VARCHAR (20),
    email VARCHAR (20),

    CONSTRAINT PK_CLIENTE PRIMARY KEY (cod_cliente),

    CONSTRAINT FK_BARRIOS_CLIENTES FOREIGN KEY (cod_barrio)
    REFERENCES BARRIOS (cod_barrio)

);


CREATE TABLE FACTURAS
(
    numero_factura INT IDENTITY (1,1),
    fecha DATETIME,
    cod_cliente INT,
    cod_vendedor INT,

    CONSTRAINT PK_FACTURA PRIMARY KEY (numero_factura),

    CONSTRAINT FK_CLIENTES_FACTURAS FOREIGN KEY (cod_cliente)
    REFERENCES CLIENTES (cod_cliente),

    CONSTRAINT FK_VENDEDORES_FACTURAS FOREIGN KEY (cod_vendedor)
    REFERENCES VENDEDORES (cod_vendedor)


);


CREATE TABLE DETALLES_FACTURAS
(
    id_detalle INT IDENTITY (1,1),
    numero_factura INT,
    cod_articulo INT,
    precio_unitario MONEY,
    cantidad INT,

    CONSTRAINT PK_DETALLE_FACTURA PRIMARY KEY (id_detalle),

    CONSTRAINT FK_FACTURAS_DETALLES_FACTURAS FOREIGN KEY (numero_factura)
    REFERENCES FACTURAS (numero_factura),

    CONSTRAINT FK_ARTICULOS_DETALLES_FACTURAS FOREIGN KEY (cod_articulo)
    REFERENCES ARTICULOS (cod_articulo)

);


ALTER TABLE ARTICULOS ALTER COLUMN descripcion varchar (50);
ALTER TABLE ARTICULOS ALTER COLUMN observaciones VARCHAR (50);

INSERT INTO ARTICULOS (descripcion,pre_unitario) VALUES ('Lápices Color largos * 12 u. Bic',101.50);
INSERT INTO ARTICULOS (descripcion,pre_unitario,observaciones) VALUES ('Conjunto Geométrico Maped',20.50,'Regla, escuadra y transportador');
INSERT INTO ARTICULOS (descripcion,stock_minimo,pre_unitario,observaciones) VALUES ('Repuesto Gloria rallado',120,326.30 ,'200 hojas');
INSERT INTO ARTICULOS (descripcion,pre_unitario,observaciones) VALUES ('Repuesto Rivadavia ',465.90,'260 hojas, margen reforzado');



SELECT descripcion,pre_unitario,observaciones
FROM ARTICULOS;

INSERT INTO BARRIOS (barrio) VALUES ('ALTA CORDOBA');
INSERT INTO BARRIOS (barrio) VALUES ('ALTO ALBERDI');
INSERT INTO BARRIOS (barrio) VALUES ('ALBERDI');
INSERT INTO BARRIOS (barrio) VALUES ('CERRO DE LAS ROSAS');
INSERT INTO BARRIOS (barrio) VALUES ('SAN VICENTE');


INSERT INTO CLIENTES (ape_cliente,nom_cliente,calle,altura,nro_tel,cod_barrio) VALUES 
('Monti','Juan','Altoaguirre',1245,'4522122 ',5);

ALTER TABLE CLIENTES add fecha_nac DATETIME;

INSERT INTO CLIENTES (ape_cliente,nom_cliente,calle,altura,email,fecha_nac,cod_barrio) VALUES 
('Sena','Rosa','Av. Velez Sarsfield ',25,'rsena@hotmail.com','15/5/1968',1);

ALTER TABLE CLIENTES ALTER COLUMN email varchar (50);   

INSERT INTO CLIENTES (ape_cliente,nom_cliente,calle,altura,email,fecha_nac,cod_barrio) VALUES 
('Britos','Guillermo','Av. Colon ',1996,'gbritos13@gmail.com','22/10/1993',3);

INSERT INTO CLIENTES (ape_cliente,nom_cliente,calle,altura,email,fecha_nac,cod_barrio) VALUES 
('Yamila','Echenique','Carmen de Patagones ',1925,'echeniqueyamila1@gmail.com','06/08/1996',3);

INSERT INTO CLIENTES (ape_cliente,nom_cliente,calle,altura,email,fecha_nac,cod_barrio) VALUES 
('Elizabeth','Blumen','Av. Chacabuco',36,'elibblumen@gmail.com','09/02/1962',2);


SELECT *
FROM ARTICULOS;

UPDATE ARTICULOS
SET descripcion = 'Conjunto Geométrico de Plastico'
where descripcion = 'Conjunto Geométrico Maped'




UPDATE ARTICULOS
SET observaciones = 'Caja con motivos de Disney', stock_minimo = 100,pre_unitario = 17.20
where descripcion = 'Lápices Color largos * 12 u. Bic '



-- Para el artículo cuya descripción es “Lápices Color largos * 12 u” Bic; cambie
--el stock mínimo por 100, las observaciones por “Caja con motivos de Disney”
--y al precio por 17.20

b. Para el artículo cuya descripción es “Repuesto Rivadavia”, cambie la
descripción por “Repuesto Rivadavia cuadriculado” y las observaciones por
“48 hojas”.

CREATE DATABASE SUPERMERCADO;

USE SUPERMERCADO;

CREATE TABLE BARRIOS
(
    id_barrio int IDENTITY (1,1),
    nombre_barrio varchar (50),
    
    CONSTRAINT PK_BARRIO PRIMARY KEY (id_barrio)

);

CREATE TABLE MARCAS
(
    id_marca int IDENTITY (1,1),
    nombre_marca varchar (20),

    CONSTRAINT PK_MARCA PRIMARY KEY (id_marca)

);

CREATE TABLE RUBROS
(
    id_rubro int IDENTITY (1,1),
    nombre_rubro varchar (20),

    CONSTRAINT PK_RUBRO PRIMARY KEY (id_rubro)
);

CREATE TABLE PRODUCTOS
(
    cod_producto int IDENTITY (1,1),
    descripcion varchar (30),
    id_marca int,
    id_rubro int,
    precio varchar (20),

    CONSTRAINT PK_PRODUCTO PRIMARY KEY (cod_producto),

    CONSTRAINT FK_MARCAS_PRODUCTOS FOREIGN KEY (id_marca)
    REFERENCES MARCAS (id_marca),

    CONSTRAINT FK_RUBROS_PRODUCTOS FOREIGN KEY (id_rubro)
    REFERENCES RUBROS (id_rubro)


);

CREATE TABLE PROVEEDORES
(
    cod_prove int IDENTITY (1,1),
    nombre varchar (15),
    direccion varchar (20),
    id_barrio int,
    tel varchar (20),
    email varchar (20)

    CONSTRAINT PK_PROVEEDOR PRIMARY KEY (cod_prove),

    CONSTRAINT FK_BARRIOS_PROVEEDORES FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio)


);

CREATE TABLE PRODUCTOS_PROVEEDORES
(

cod_producto int,
cod_prove int ,

CONSTRAINT PK_PROD_PROV PRIMARY KEY (cod_producto,cod_prove)

);
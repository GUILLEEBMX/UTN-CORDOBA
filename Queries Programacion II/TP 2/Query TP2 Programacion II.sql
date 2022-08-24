CREATE DATABASE TPII_PROGRAMACION_II;

USE TPII_PROGRAMACION_II;

SELECT * FROM FACTURAS;

INSERT INTO FACTURAS VALUES (GETDATE(),1,'Guillermo');

CREATE TABLE FORMAS_PAGOS
(
    idFormaPago INT IDENTITY (1,1),
    nombre VARCHAR (30),
    CONSTRAINT PK_FORMA_PAGO PRIMARY KEY (idFormaPago)
);

CREATE TABLE ARTICULOS
(
    id_articulo INT IDENTITY (1,1),
    nombre VARCHAR (20),
    precioUnitario DECIMAL (10,2),
    CONSTRAINT PK_ARTICULO PRIMARY KEY (id_articulo)

)

CREATE TABLE FACTURAS
(
    id_factura INT IDENTITY(1,1),
    fecha DATETIME,
    idFormaPago INT ,
    cliente VARCHAR (20),
    CONSTRAINT PK_FACTURAS PRIMARY KEY (id_factura),
    CONSTRAINT FK_FORMA_PAGO FOREIGN KEY (idFormaPago) REFERENCES FORMAS_PAGOS (idFormaPago)

);


CREATE TABLE DETALLES_FACTURAS
(
    id_detalle INT IDENTITY(1,1),
    id_articulo INT ,
    id_factura INT ,
    cantidad INT,
    CONSTRAINT PK_DETALLE_FACTURA PRIMARY KEY (id_detalle),
    CONSTRAINT FK_FACTURA_DETALLE_FACTURA FOREIGN KEY (id_factura) REFERENCES FACTURAS (id_factura),
    CONSTRAINT FK_ARTICULO_DETALLE_FACTURA FOREIGN KEY (id_articulo) REFERENCES ARTICULOS (id_articulo)


);

INSERT INTO FORMAS_PAGOS VALUES ('EFECTIVO');
INSERT INTO FORMAS_PAGOS VALUES ('DEBITO');
INSERT INTO FORMAS_PAGOS VALUES ('CREDITO');

/*CREATE PROCEDURE SP_INSERTAR_FACTURA
	@fecha DATETIME,
	@idFormaPago int,
    @cliente VARCHAR (100), 
	@id_factura int OUTPUT
AS
BEGIN
	INSERT INTO FACTURAS(fecha, idFormaPago, cliente)
    VALUES (GETDATE(), @idFormaPago, @cliente);
  
    SET @id_factura = SCOPE_IDENTITY();

END
GO*/


/*CREATE PROCEDURE SP_INSERTAR_DETALLE 
	@id_factura int,
	@id_articulo int, 
	@cantidad int
AS
BEGIN
	INSERT INTO DETALLES_FACTURAS (id_factura,id_articulo, cantidad)
    VALUES (@id_factura,@id_articulo,@cantidad);
  
END
GO




CREATE PROCEDURE SP_PROXIMA_FACTURA
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_factura)+1  FROM FACTURAS);
END
GO



CREATE PROCEDURE SP_CONSULTAR_FORMAS_PAGOS
AS
BEGIN
	
	SELECT * FROM FORMAS_PAGOS;
END
GO

EXEC SP_CONSULTAR_MEDIOS_PAGOS;

CREATE PROCEDURE SP_CONSULTAR_ARTICULOS
AS 
BEGIN 
SELECT * FROM ARTICULOS 
END;*/


SELECT * FROM ARTICULOS;


INSERT INTO ARTICULOS VALUES ('AURICULARES GENIUS', 3500);
INSERT INTO ARTICULOS VALUES ('TECLADO GENIUS', 2000);
INSERT INTO ARTICULOS VALUES ('MOUSE GENIUS', 1500);

SELECT * FROM FORMAS_PAGOS;

SELECT * FROM FACTURAS;

SELECT * FROM ARTICULOS;

SELECT * FROM DETALLES_FACTURAS;


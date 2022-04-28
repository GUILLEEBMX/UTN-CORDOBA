USE LIBRERIA;


SELECT nom_cliente,ape_cliente
FROM CLIENTES;

DELETE CLIENTES
where nom_cliente = 'Rosa' 

SELECT descripcion 
FROM ARTICULOS;

DELETE ARTICULOS
WHERE descripcion = 'Repuesto Gloria rallado';

DELETE CLIENTES
WHERE nom_cliente = 'Juan';

SELECT cod_cliente,nom_cliente,ape_cliente
FROM CLIENTES;

DELETE CLIENTES
WHERE cod_cliente = 9;

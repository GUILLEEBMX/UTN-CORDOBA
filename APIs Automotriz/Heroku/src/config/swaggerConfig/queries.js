
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Queries:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Consultas 
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Queries"
 */

/**
 * @swagger
 * /api/query/firstquery:
 *  get:
 *      summary: 1. Emitir un listado de todos los vendedores incluyendo el nombre del barrio que vendieron, el nombre del producto de aquellos vendedores que vendieron mas de $100000 en  en los últimos 3 meses.
 *      tags: [Queries]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Queries'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/query/secondquery:
 *  get:
 *      summary: 2. Mostrar en una misma tabla de resultados los empleados que no vendieron nunca este mes (en primer lugar) y los que tuvieron más de 10 ventas este mes en segundo lugar, ordenados en forma alfabética por nombre de empleado.
 *      tags: [Queries]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Queries'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/query/thirthquery:
 *  get:
 *      summary: 3. ¿Cuánto vendio en total cada empleado en pedidos este año? ¿Cuánto fue el importe promedio y la fecha de la primera y última venta? Siempre y cuando ese promedio cobrado haya sido superior al promedio del año pasado.
 *      tags: [Queries]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Queries'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/query/fourthquery:
 *  get:
 *      summary: 3. ¿Cuánto vendio en total cada empleado en pedidos este año? ¿Cuánto fue el importe promedio y la fecha de la primera y última venta? Siempre y cuando ese promedio cobrado haya sido superior al promedio del año pasado.
 *      tags: [Queries]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Queries'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/query/fourthquery:
 *  get:
 *      summary: 4. Listar Nombre, descripcion y Codigo de los prodcutos que se vendieron mas de 5 veces el año pasado, listar ademas la cantidad de unidades vendidas y los ingresos obtenidos por ese articulo ordenar por articulo con mayor ingreso.
 *      tags: [Queries]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Queries'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/query/fivethquery:
 *  get:
 *      summary: 5. Listar los clientes que vinieron más de 3 veces en los ultimos 10 años, mostrando la cantidad de compras, fecha de su primer compra, de la última y los días que pasaron entre ambas.
 *      tags: [Queries]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Queries'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/query/sixthquery:
 *  get:
 *      summary: 6. Listar los clientes que vinieron más de 3 veces en los ultimos 10 años mostrando la cantidad de compras, fecha de su primer compra, de la iltima  y los días que pasaron entre ambas
 *      tags: [Queries]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Queries'
 *                             
 *                               
 */





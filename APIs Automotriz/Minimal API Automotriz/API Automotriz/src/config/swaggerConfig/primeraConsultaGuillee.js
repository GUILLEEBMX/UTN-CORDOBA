
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Guillee:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Consultas Guillee
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Guillee"
 */

/**
 * @swagger
 * /api/guillee/firstquery:
 *  get:
 *      summary: 1. Emitir un listado de todos los vendedores incluyendo el nombre del barrio que vendieron, el nombre del producto de aquellos vendedores que vendieron mas de $100000 en  en los últimos 3 meses.
 *      tags: [Guillee]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Guillee'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/guillee/secondquery:
 *  get:
 *      summary: 2. Mostrar en una misma tabla de resultados los empleados que no vendieron nunca este mes (en primer lugar) y los que tuvieron más de 10 ventas este mes en segundo lugar, ordenados en forma alfabética por nombre de empleado.
 *      tags: [Guillee]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Guillee'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/guillee/thirthquery:
 *  get:
 *      summary: 3. ¿Cuánto vendio en total cada empleado en pedidos este año? ¿Cuánto fue el importe promedio y la fecha de la primera y última venta? Siempre y cuando ese promedio cobrado haya sido superior al promedio del año pasado.
 *      tags: [Guillee]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Guillee'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/consultasGuillee/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Barrios]
 *      parameters:
 *          -   in: path
 *              name: id
 *              schema:
 *                  type: string    
 *              required: true
 *              description: Enter ID of the province   
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          $ref: '#/components/schemas/Guillee'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */





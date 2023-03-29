
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Productos:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Nombre del producto
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Optica"
 */

/**
 * @swagger
 * /api/productos:
 *  get:
 *      summary: Get all the Provinces from de BD
 *      tags: [Productos]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Productos'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/productos/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Productos]
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
 *                          $ref: '#/components/schemas/Productos'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



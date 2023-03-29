
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Pedidos:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Nombre del Barrio
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Optica"
 */

/**
 * @swagger
 * /api/pedidos:
 *  get:
 *      summary: Get all the Pedidos from de BD
 *      tags: [Pedidos]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Pedidos'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/pedidos/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Pedidos]
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
 *                          $ref: '#/components/schemas/Pedidos'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



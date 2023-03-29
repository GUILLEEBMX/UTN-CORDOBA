
/** 
 * @swagger    
 * components:
 *  schemas:
 *      DetallesPedidos:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Nombre de la provincia
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Cordoba"
 */

/**
 * @swagger
 * /api/detallesPedidos:
 *  get:
 *      summary: Get all the Provinces from de BD
 *      tags: [DetallesPedidos]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/DetallesPedidos'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/detallesPedidos/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [DetallesPedidos]
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
 *                          $ref: '#/components/schemas/DetallesPedidos'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */




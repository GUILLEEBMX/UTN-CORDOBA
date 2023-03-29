
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Sucursales:
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
 * /api/sucursales:
 *  get:
 *      summary: Get all the Sucursales from de BD
 *      tags: [Sucursales]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Sucursales'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/sucursales/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Sucursales]
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
 *                          $ref: '#/components/schemas/Sucursales'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



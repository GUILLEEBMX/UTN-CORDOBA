
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Barrios:
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
 * /api/barrios:
 *  get:
 *      summary: Get all the Barrios from de BD
 *      tags: [Barrios]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Barrios'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/barrios/{id}:
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
 *                          $ref: '#/components/schemas/Barrios'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



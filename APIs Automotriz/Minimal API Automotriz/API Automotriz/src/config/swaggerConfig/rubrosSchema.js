
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Rubros:
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
 * /api/rubros:
 *  get:
 *      summary: Get all the Rubros from de BD
 *      tags: [Rubros]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Rubros'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/rubros/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Rubros]
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
 *                          $ref: '#/components/schemas/Rubros'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



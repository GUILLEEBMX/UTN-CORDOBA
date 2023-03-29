
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Entregas:
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
 * /api/entregas:
 *  get:
 *      summary: Get all the Entregas from de BD
 *      tags: [Entregas]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Entregas'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/entregas/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Entregas]
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
 *                          $ref: '#/components/schemas/Entregas'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



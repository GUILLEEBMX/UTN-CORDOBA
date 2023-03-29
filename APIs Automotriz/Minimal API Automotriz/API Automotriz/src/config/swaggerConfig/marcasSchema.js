
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Marcas:
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
 * /api/marcas:
 *  get:
 *      summary: Get all the Marcas from de BD
 *      tags: [Marcas]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Marcas'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/marcas/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Marcas]
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
 *                          $ref: '#/components/schemas/Marcas'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



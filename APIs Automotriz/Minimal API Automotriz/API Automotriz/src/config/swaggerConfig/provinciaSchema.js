
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Provincias:
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
 * /api/provincias:
 *  get:
 *      summary: Get all the Provincias from de BD
 *      tags: [Provincias]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Provincias'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/provincias/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Provincias]
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
 *                          $ref: '#/components/schemas/Provincias'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */


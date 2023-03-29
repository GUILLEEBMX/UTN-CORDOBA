
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Ciudades:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Nombre de la ciudad
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Córdoba"
 */

/**
 * @swagger
 * /api/ciudades:
 *  get:
 *      summary: Get all the Provinces from de BD
 *      tags: [Ciudades]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Ciudades'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/ciudades/{id}:
 *  get:
 *      summary: Get a Ciudades from the DB
 *      tags: [Ciudades]
 *      parameters:
 *          -   in: path
 *              name: id
 *              schema:
 *                  type: string    
 *              required: true
 *              description: Enter ID of the Ciudades   
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          $ref: '#/components/schemas/Ciudades'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */





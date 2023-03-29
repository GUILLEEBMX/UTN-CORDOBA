
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Paises:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Nombre del pais
 *          required:
 *              - nombre
 *          example:
 *              nombre: "ARGENTINA"
 */

/**
 * @swagger
 * /api/paises:
 *  get:
 *      summary: Get all the Paises from de BD
 *      tags: [Paises]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Paises'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/paises/{id}:
 *  get:
 *      summary: Get a Country from the DB
 *      tags: [Paises]
 *      parameters:
 *          -   in: path
 *              name: id
 *              schema:
 *                  type: string    
 *              required: true
 *              description: Enter ID of the country   
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          $ref: '#/components/schemas/Paises'
 *      404:
 *          description:The Country with the given id was not found
 *                             
 *                               
 */


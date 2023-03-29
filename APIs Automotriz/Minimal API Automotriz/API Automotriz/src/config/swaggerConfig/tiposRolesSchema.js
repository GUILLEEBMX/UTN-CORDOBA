
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Roles:
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
 * /api/tiposRoles:
 *  get:
 *      summary: Get all the Roles from de BD
 *      tags: [Roles]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Roles'
 *                             
 *                               
 */

/**
 * @swagger
 * /api/tiposRoles/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Roles]
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
 *                          $ref: '#/components/schemas/Roles'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */




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




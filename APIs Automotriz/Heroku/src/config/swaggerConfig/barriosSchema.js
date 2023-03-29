
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



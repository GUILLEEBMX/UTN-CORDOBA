
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





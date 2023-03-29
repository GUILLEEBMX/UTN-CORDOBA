
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




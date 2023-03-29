
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




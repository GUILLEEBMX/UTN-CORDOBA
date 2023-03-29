
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


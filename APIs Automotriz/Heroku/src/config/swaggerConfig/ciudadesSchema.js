
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


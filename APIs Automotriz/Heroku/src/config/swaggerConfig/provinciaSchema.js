
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Provincias:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Nombre de la provincia
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Cordoba"
 */

/**
 * @swagger
 * /api/provincias:
 *  get:
 *      summary: Get all the Provincias from de BD
 *      tags: [Provincias]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Provincias'
 *                             
 *                               
 */


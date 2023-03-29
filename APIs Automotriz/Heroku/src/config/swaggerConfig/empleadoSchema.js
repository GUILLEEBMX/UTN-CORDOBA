
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Empleados:
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
 * /api/empleados:
 *  get:
 *      summary: Get all the Provinces from de BD
 *      tags: [Empleados]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Empleados'
 *                             
 *                               
 */


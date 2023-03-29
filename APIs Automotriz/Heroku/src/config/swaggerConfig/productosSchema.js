
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Productos:
 *          type: object
 *          properties:
 *              nombre:
 *                  type: string
 *                  description: Nombre del producto
 *          required:
 *              - nombre
 *          example:
 *              nombre: "Optica"
 */

/**
 * @swagger
 * /api/productos:
 *  get:
 *      summary: Get all the Provinces from de BD
 *      tags: [Productos]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Productos'
 *                             
 *                               
 */


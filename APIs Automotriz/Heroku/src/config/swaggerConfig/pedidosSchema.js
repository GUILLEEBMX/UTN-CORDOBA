
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Pedidos:
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
 * /api/pedidos:
 *  get:
 *      summary: Get all the Pedidos from de BD
 *      tags: [Pedidos]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Pedidos'
 *                             
 *                               
 */


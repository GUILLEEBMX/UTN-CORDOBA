
/** 
 * @swagger    
 * components:
 *  schemas:
 *      DetallesPedidos:
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
 * /api/detallesPedidos:
 *  get:
 *      summary: Get all the Provinces from de BD
 *      tags: [DetallesPedidos]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/DetallesPedidos'
 *                             
 *                               
 */





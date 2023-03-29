
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Sucursales:
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
 * /api/sucursales:
 *  get:
 *      summary: Get all the Sucursales from de BD
 *      tags: [Sucursales]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Sucursales'
 *                             
 *                               
 */




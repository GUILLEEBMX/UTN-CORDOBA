
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Proveedores:
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
 * /api/proveedores:
 *  get:
 *      summary: Get all the Proveedores from de BD
 *      tags: [Proveedores]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Proveedores'
 *                             
 *                               
 */



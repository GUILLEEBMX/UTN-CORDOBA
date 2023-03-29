
/** 
 * @swagger    
 * components:
 *  schemas:
 *      Documentos:
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
 * /api/tiposDocumentos:
 *  get:
 *      summary: Get all the Documentos from de BD
 *      tags: [Documentos]
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Documentos'
 *                             
 *                               
 */




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

/**
 * @swagger
 * /api/tiposDocumentos/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Documentos]
 *      parameters:
 *          -   in: path
 *              name: id
 *              schema:
 *                  type: string    
 *              required: true
 *              description: Enter ID of the province   
 *      responses:
 *          200:
 *              description: OK!  
 *              content: 
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          $ref: '#/components/schemas/Documentos'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



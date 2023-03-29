
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

/**
 * @swagger
 * /api/proveedores/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Proveedores]
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
 *                          $ref: '#/components/schemas/Proveedores'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */



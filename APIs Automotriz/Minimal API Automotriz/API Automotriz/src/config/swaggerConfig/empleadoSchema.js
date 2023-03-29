
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

/**
 * @swagger
 * /api/empleados/{id}:
 *  get:
 *      summary: Get a Province from the DB
 *      tags: [Empleados]
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
 *                          $ref: '#/components/schemas/Empleados'
 *      404:
 *          description:The Province with the given id was not found
 *                             
 *                               
 */


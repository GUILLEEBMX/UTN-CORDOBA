/** 
 * @swagger    
 * components:
 *  schemas:
 *      Users:
 *          type: object
 *          properties:
 *              name:
 *                  type: string
 *                  description: User Name
 *              email:
 *                  type: string
 *                  description: User Email
 *              password:
 *                  type: string
 *                  description: User Password
 *          required:
 *              - email
 *              - password
 *          example:
 *              email: ""
 *              password: ""
 *      Admin:
 *          type: object
 *          properties:
 *              email:
 *                  type: string
 *                  description: User Email
 *          required:
 *              - email
 *          example:
 *              email: ""       
 */


/**
 * @swagger
 * /api/users:
 *  get:
 *      summary: Get all the users from the DB
 *      tags: [Users]
 *      responses:
 *          200:
 *              description: OK!  
 *                             
 *                               
 */

/**
 * @swagger
 * /api/users/{id}:
 *  get:
 *      summary: Get a user from the DB
 *      tags: [Users]
 *      parameters:
 *          -   in: path
 *              name: id
 *              schema:
 *                  type: string    
 *              required: true
 *              description: Enter user ID   
 *      responses:
 *          200:
 *              description: OK!  

 *      404:
 *          description:The user with the given id was not found
 *                             
 *                               
 */

/**
 * @swagger
 * /api/users/registro:
 *  post:
 *      summary: Register an user in the API
 *      tags: [Users]
 *      requestBody:
 *          required: true
 *          content:
 *              application/json:
 *                  schema:
 *                      type: object
 *                      $ref: '#/components/schemas/Users'
 *      responses:
 *          200:
 *              description: A new user has been registered
 */

/**
 * @swagger
 * /api/users/login:
 *  post:
 *      summary: Login an user in the API
 *      tags: [Users]
 *      requestBody:
 *          required: true
 *          content:
 *              application/json:
 *                  schema:
 *                      type: object
 *                      $ref: '#/components/schemas/Users'
 *      responses:
 *          200:
 *              description: A new user has been loged
 */


/**
 * @swagger
 * /api/users/addadmin:
 *  post:
 *      summary: add admin role
 *      tags: [Users]
 *      requestBody:
 *          required: true
 *          content:
 *              application/json:
 *                  schema:
 *                      type: object
 *                      $ref: '#/components/schemas/Admin'
 *      responses:
 *          200:
 *              description: ok
 */

/**
 * @swagger
 * /api/users/removeadmin:
 *  post:
 *      summary: Remove admin role
 *      tags: [Users]
 *      requestBody:
 *          required: true
 *          content:
 *              application/json:
 *                  schema:
 *                      type: object
 *                      $ref: '#/components/schemas/Admin'
 *      responses:
 *          200:
 *              description: Remove admin
 */

/**
 * @swagger
 * /api/users/{id}:
 *  delete:
 *      summary: Delete user
 *      tags: [Users]
 *      parameters:
 *          -   in: path
 *              name: id
 *              schema:
 *                  type: string    
 *              required: true
 *              description: Enter user ID 
 *      responses:
 *          200:
 *              description: Succeesed delete id  
 *          404:
 *              description: The user with the given id was not found
 *                             
 *                               
 */
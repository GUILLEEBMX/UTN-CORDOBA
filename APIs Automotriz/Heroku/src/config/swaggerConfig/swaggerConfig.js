
const swaggerUI = require('swagger-ui-express');
const swaggerJsDoc = require('swagger-jsdoc');
const path = require('path');


const swaggerSpec = 
{

  definition: 

  { openapi: "3.0.1",
    info: 
    {
      title: "WEB API Automotriz LCI II",
      version: "1.0.0"

    },

    components: {
      securitySchemes: {
        ApiKeyAuth: {
          type:'apiKey',
          in: 'header',
          name:"x-token",
        },
      }
    },
    security: [{
      ApiKeyAuth: []
    }],
    
    swagger: "3.0",

    servers:
    [
      {

        url: `/`
      
      }
    
    ]

  },

  apis: [`${path.join(__dirname,"./*.js")}`]


}


module.exports = swaggerSpec;
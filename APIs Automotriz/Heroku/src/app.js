//const sequelize = require('./database/db');
const express = require('express')
const app = express();
const config = require('./config/config');
const swaggerUI = require('swagger-ui-express');
const swaggerJsDoc = require('swagger-jsdoc');
const swaggerSpec = require('./config/swaggerConfig/swaggerConfig');


const PORT = config.PORT || 3000

//Middlewares Config
app.use(express.urlencoded({ extended: false }));
app.use(express.json());


// Middlewares Routes
app.use('/api-doc', swaggerUI.serve, swaggerUI.setup(swaggerJsDoc(swaggerSpec)))
app.use('/api/users', require('./routes/usersRoutes'));
app.use('/api/paises', require('./routes/paisesRoutes'));
app.use('/api/provincias', require('./routes/provinciasRoutes'));
app.use('/api/empleados', require('./routes/empleadosRoutes'));
app.use('/api/productos', require('./routes/productsRoutes'));
app.use('/api/ciudades', require('./routes/ciudadesRoutes'));
app.use('/api/barrios', require('./routes/barriosRoutes'));
app.use('/api/proveedores', require('./routes/proveedoresRoutes'));
app.use('/api/sucursales', require('./routes/sucursalesRoutes'));
app.use('/api/entregas', require('./routes/entregasRoutes'));
app.use('/api/pedidos', require('./routes/pedidosRoutes'));
app.use('/api/tiposDocumentos', require('./routes/tiposDocumentosRoutes'));
app.use('/api/tiposRoles', require('./routes/tiposRolesRoutes'));
app.use('/api/rubros', require('./routes/rubrosRoutes'));
app.use('/api/marcas', require('./routes/marcasRoutes'));
app.use('/api/detallesPedidos', require('./routes/detallesPedidosRoutes'));
app.use('/api/query', require('./routes/queriesRoutes'));
app.use('/api/email', require('./routes/emailRoutes'));



app.get('/', (req, res) => {
  res.send('Para realizar consultas desde swagger coloque "/api-doc" al final de la direccion web');
});



app.listen(PORT, () => {
  console.log(`App listening on PORT ${PORT}`)
});

module.exports = app;
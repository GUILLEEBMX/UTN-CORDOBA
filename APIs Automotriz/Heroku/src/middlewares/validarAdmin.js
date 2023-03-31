// const { response, request } = require('express');
// const jwt = require('jsonwebtoken');
// const authconfig = require('../config/auth')
// const { Usuarios } = require('../controllers/usersControllers')



// async function ValidateAdmin(req, res, next) {

//     let existe;

//     let response = {
//         body: null
//     }

//     const token = req.header('x-token');

//     if (!token) {

//         response.body = "NO HAY TOKEN EN LA PETICION";
//         return res.json(response);

//     }

//     var decodedJwt = jwt.decode(token, { complete: true });

//     let user = decodedJwt.payload.username;

//     let usersGroups = await Usuarios.GellAllUsers("Administrator");

//     usersGroups = usersGroups.map((x) => x.name);

//     for (let index = 0; index < usersGroups.length; index++) {

//         if (user != usersGroups[index]) {

//             existe = true;
//         }

//     }

//     if (!existe) {
        
//         response.body = "EL USUARIO NO ES ADMINISTRADOR"
//         res.statusCode = 401;
//         res.json(response);
//         return response;
//     }




//     next();
// }

// module.exports = { ValidateAdmin }
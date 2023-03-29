const { response,request } = require('express');
const authconfig=require('../config/auth')
const jwt= require ('jsonwebtoken');


const validarJWT = (req= request, res= response, next) =>{

    const token=  req.header('x-token');

    if(!token){
         return res.status(401).json({
             msg: 'No hay token en la petición'
         });
    }

    try{
        jwt.verify(token, authconfig.secret);
     
        next();

    }
    catch(error){

        console.log(error),
        res.status(401).json({
            msg:'Token no válido'
        })
    }

    next;
}


module.exports= {validarJWT}
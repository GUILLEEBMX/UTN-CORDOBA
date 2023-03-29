const { response,request } = require('express');
const jwt= require ('jsonwebtoken');
const authconfig=require('../config/auth')



const validarAdmin = (req= request, res= response, next) =>{

    const token=  req.header('x-token');
    const decode= jwt.decode(token, authconfig.secret);

    if( !decode.esadmin || decode.esadmin == null)
    {
        return res.status(403).json({
            msg: 'Access denied'
        });
    }

    next();
}

module.exports= {validarAdmin}
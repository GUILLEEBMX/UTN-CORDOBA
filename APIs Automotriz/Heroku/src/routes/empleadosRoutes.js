
const express = require('express');
const router = express.Router();
const sql = require('mssql')
const sqlConfig = require('../database/db')
//const {validarJWT}= require('../middlewares/validarJWT');
//const { check, validationResult } = require('express-validator');



router.get('/', async function (req, res) 
{
    sql.connect(sqlConfig).then(pool => {

        return pool.request()
            .query('SELECT * FROM EMPLEADOS')
    }).then(result => {
        res.json(result.recordset)
    }).catch(err => {
        res.json(err);


    });
});



router.get('/:id', async function (req,res) 
{
    Employees.GetOneEmploy(req,res);   
});


module.exports = router;
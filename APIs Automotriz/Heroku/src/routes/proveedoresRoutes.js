const express = require('express');
const router = express.Router();
const sql = require('mssql')
const sqlConfig = require('../database/db')


router.get('/', async function (req, res) {

    sql.connect(sqlConfig).then(pool => {

        return pool.request()
            .query('SELECT * FROM PROVEEDORES')
    }).then(result => {
        res.json(result.recordset)
    }).catch(err => {
        res.json(err);


    });
});





module.exports = router;
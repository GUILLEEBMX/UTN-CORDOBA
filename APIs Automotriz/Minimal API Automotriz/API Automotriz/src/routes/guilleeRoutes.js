const express = require('express');
const router = express.Router();
const sql = require('mssql')
const sqlConfig = require('../database/db')


router.get('/firstquery', async function (req, res) {

    sql.connect(sqlConfig).then(pool => {

        return pool.request()
            .query('EXEC FIRST_QUERY')
    }).then(result => {
        res.json(result.recordset)
    }).catch(err => {
        res.json(err);


    });
});


router.get('/secondquery', async function (req, res) {

    sql.connect(sqlConfig).then(pool => {

        return pool.request()
            .query('EXEC SECOND_QUERY')
    }).then(result => {
        res.json(result.recordset)
    }).catch(err => {
        res.json(err);


    });
});


router.get('/thirthquery', async function (req, res) {

    sql.connect(sqlConfig).then(pool => {

        return pool.request()
            .query('EXEC THIRTH_QUERY')
    }).then(result => {
        res.json(result.recordset)
    }).catch(err => {
        res.json(err);


    });
});



module.exports = router;
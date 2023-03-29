
const express = require('express');
const router = express.Router();
const SendEmail = require('../controllers/sendEmailController');


router.get('/', async function (req, res) {

    let resultAWSSendEmail;

    resultAWSSendEmail = await SendEmail("gbritos13@gmail.com", "HOLA ESTO ES UN TEST...", "TEST TEST");

    res.json(resultAWSSendEmail);

});


module.exports = router;
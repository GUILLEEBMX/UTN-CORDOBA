const express = require('express');
const router = express.Router();
// const { check, validationResult } = require('express-validator');
// const {User} = require ('../controllers/usersControllers');
const User = require('../controllers/usersControllers');
const {ValidateAdmin} = require ('../middlewares/validarAdmin');

router.get('/', async function (req, res) {

    res.json(await User.Usuarios.GellAllUsers("Administrator"));

});



//  router.get('/:id', async (req, res) => 
//  {
//   User.GetOneUser(req,res);
//  });


router.post('/registro',[ValidateAdmin], async function (req, res) {

    res.json(await User.Usuarios.ChangePasswordAWS(req.body.email, req.body.password));



});


router.post('/login', async function (req,res) 
{

  await User.Usuarios.LoginUsers(req,res);

});



 router.post('/addadmin' ,[ValidateAdmin], async function (req,res) 
 {
    res.json(await User.Usuarios.AddToGroup(req,res,'Administrator',req.body.email));

  
 });



router.post('/removeadmin' ,[ValidateAdmin], async function (req,res) 
{

  res.json(await User.Usuarios.RemoveAdmin(req,res));

});



// router.delete('/:id', async (req, res) => {

//     await User.Usuarios.RemoveAdmin(req,res);

// });


module.exports = router;
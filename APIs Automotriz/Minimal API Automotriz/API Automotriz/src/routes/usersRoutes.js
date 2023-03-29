const express = require('express');
const router = express.Router();
// const { check, validationResult } = require('express-validator');
// const {User} = require ('../controllers/usersControllers');
const User = require ('../controllers/usersController');

//  router.get('/', async function (req,res) 
//  {
//    User.GetAllUsers(req,res);

//  });

 

//  router.get('/:id', async (req, res) => 
//  {
//   User.GetOneUser(req,res);
//  });


router.post('/registro'/*, [check('email').isEmail()]*/, async function (req,res) 
{
 
 res.json(await  User.Usuarios.ChangePasswordAWS(req.body.email,req.body.password));



});


// router.post('/login', async function (req,res) 
// {

//   User.LoginUser(req,res);
   
// });



//  router.post('/addadmin' , async function (req,res) 
//  {

//   User.AddAdmin(req,res);
//  });



// router.post('/removeadmin' , async function (req,res) 
// {

//   User.RemoveAdmin(req,res);
  
// });



// router.delete('/:id' ,async (req, res) => 
// {
//   User.DeleteUser(req,res);
// });


module.exports= router;
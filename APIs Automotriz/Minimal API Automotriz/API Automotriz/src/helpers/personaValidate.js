const Joi = require('joi');

module.exports = {

 ValidatePersona:function(persona){

    const schema= {
      nombre: Joi.string().min(1).required(),
      apellido: Joi.string().min (1).required(),
      dni: Joi.number().min(1).required(),
      telefono: Joi.string().min(1).required(),
      email:Joi.required(),
      domicilio: Joi.string().min (1).required(),
      nacimiento: Joi.date().min('01-01-1900')
    };
  
    return Joi.validate(persona, schema);
  }

};
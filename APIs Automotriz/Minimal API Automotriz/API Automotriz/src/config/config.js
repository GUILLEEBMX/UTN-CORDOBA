const dotenv = require('dotenv');


dotenv.config({
  path: `.env.${process.env.NODE_ENV}`

});

module.exports = {
  NODE_ENV: process.env.NODE_ENV || 'development',
  DB_DATABASE: process.env.DB_DATABASE,
  DB_PASSWORD:process.env.DB_PASSWORD,
  HOST: process.env.DB_HOST || '127.0.0.1',
  PORT: process.env.PORT || 3000,
  USERNAME: process.env.DB_USERNAME
}



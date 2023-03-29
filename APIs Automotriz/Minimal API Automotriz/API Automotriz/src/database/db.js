const config = require('../config/config');

const sqlConfig = {
  user: config.USERNAME,
  password: config.DB_PASSWORD,
  database: config.DB_DATABASE,
  server: config.HOST,
  pool: {
    max: 10,
    min: 0,
    idleTimeoutMillis: 30000
  },
  options: {
    encrypt: true, 
    trustServerCertificate: true 
  }
}

module.exports = sqlConfig;



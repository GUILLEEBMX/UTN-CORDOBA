const {senderAux}= require('./helper');
const fs = require ('fs');
const AWS = require('aws-sdk');
AWS.config.update({
  region: '',
  apiVersion: null,
  credentials: {
    accessKeyId: '',
    secretAccessKey: ''
  }
})

var SES = new AWS.SES();


//SendEmail("gbritos13@gmail.com","HOLA QUIERO REALIZAR UNA CONSULTA...","TP PROGRAMACION/LCI II 2022")


const html2=   senderAux.getHTML("gbritos13@gmail.com", "ESTO ES UN TES TEST", "TEST");

async function SendEmail(email, password, url) {

  let resultEmail;

  try {

    let html = html2//fs.readFileSync('./template.html', { encoding: 'utf8', flag: 'r' });

    html = html
      .replace('{{url}}', url)
      .replace('{{email}}', email)
      .replace('{{password}}', password);


    var params = {
      Destination: {
        ToAddresses: [email],
      },
      Message: {
        Body: {
          Html: {
            Data: html,
          },
          Text: {
            Charset: "UTF-8",
            Data: "This is the message body in text format.",
          },
        },
        Subject: {
          Data: "AUTOMOTRIZ UTN 2022",
        },
      },
      Source: "gbritos13@gmail.com" //process.env.SMTP_FROM_ADDRESS,
    };

    resultEmail = await new Promise((resolve, reject) => {
      SES.sendEmail(params, function (err, data) {
        if (err) reject(err);
        else {
          resolve("The email has send successfully");
        }
      });
    });

  } catch (err) {
    console.log(err);
    return err;
  }

  return resultEmail;
}

module.exports = SendEmail;




const AWS = require('aws-sdk');
const config = require('../config/config');

AWS.config.update({
    region: '',
    apiVersion: null,
    credentials: {
        accessKeyId: '',
        secretAccessKey: ''
    }
})


//ESTE ES EL QUE FUNCIONA DEPLOYADO.


const AmazonCognitoIdentity = require('amazon-cognito-identity-js');



module.exports.Usuarios = {

    RegisterUsersAWS: async function (email, password) {

        try {

            let resultRegisterAWS = {
                msg: null,
                success: false
            }


            var params = {
                UserPoolId: config.USER_POOL_ID,
                Username: email,
                ForceAliasCreation: true,
                DesiredDeliveryMediums: [
                    "EMAIL"
                ],
                MessageAction: "SUPPRESS",
                TemporaryPassword: password,
                UserAttributes: [
                    {
                        Name: 'email',
                        Value: email
                    },
                    {
                        Name: 'email_verified',
                        Value: 'true'
                    }
                ]
            }


            var cognitoidentityserviceprovider = new AWS.CognitoIdentityServiceProvider();

            let result = await (new Promise((resolve, reject) => {
                cognitoidentityserviceprovider.adminCreateUser(params, function (err, data) {
                    if (err) {
                        resolve(resultRegisterAWS.msg = err.message)
                        return resultRegisterAWS;
                    }
                    else {

                        resolve(resultRegisterAWS.success = true)
                        return resultRegisterAWS;


                    }
                })
            }
            ));


            if (result.success) {

                await this.AddToGroup("Externals", email);
            }



            return resultRegisterAWS

        } catch (error) {
            console.log(error);
        }


        return resultRegisterAWS;

    },

    ChangePasswordAWS: async function (email, password) {

        try {

            let resultChangePasswordAWS = {
                msg: "EL USUARIO NO SE PUDO REGISTRAR CON EXITO REVISAR...",
                success: false
            }


            let resultRegisterAWS = await this.RegisterUsersAWS(email, password);


            if (resultRegisterAWS.success) {

                var params = {
                    Password: password,
                    UserPoolId: config.USER_POOL_ID,
                    Username: email,
                    Permanent: true,
                };

                var cognitoidentityserviceprovider = new AWS.CognitoIdentityServiceProvider();


                await new Promise((resolve, reject) => {

                    cognitoidentityserviceprovider.adminSetUserPassword(params, function (err, data) {
                        if (err) {
                            resolve(resultChangePasswordAWS.msg = err.message)
                            return resultChangePasswordAWS;
                        } else {
                            resolve(resultChangePasswordAWS.msg = 'THE USER HAS REGISTERED SUCCESSFULLY',
                                resultChangePasswordAWS.success = true)
                            return resultChangePasswordAWS
                        }
                    });
                });


            }


            return resultChangePasswordAWS;


        } catch (error) {

            console.log(error);

        }

        return resultChangePasswordAWS;



    },

    GellAllUsers: async function (groupName) {

        try {



            const aws = new AWS.CognitoIdentityServiceProvider();

            let params = {
                UserPoolId: config.USER_POOL_ID,
                GroupName: groupName
            };



            let token = null;
            let data = { Users: [] }

            do {

                let parameters = {
                    UserPoolId: params.UserPoolId,
                    GroupName: params.GroupName,
                    NextToken: token
                };

                let datos = await (new Promise((resolve, reject) => {
                    aws.listUsersInGroup(parameters, function (err, dat) {
                        if (err) { reject(err); }
                        else {
                            resolve(dat);
                        }

                    })
                }));

                data.Users.push.apply(data.Users, datos.Users)

                token = datos.NextToken;

            } while (token);

            const users = data.Users.map(u => {

                let email;
                let email_verified = 'false';

                u.Attributes.forEach(attribute => {

                    if (attribute.Name === 'email') { email = attribute.Value }

                    if (attribute.Name === 'email_verified') { email_verified = attribute.Value }

                });

                return {
                    name: u.Username,
                    group: params.GroupName,
                    email: email,
                }
            });

            return users;

        } catch (err) {
            console.log(err);
            return err;
        }


    },
    DeleteUsers: async function (req, res) {



        let resultAWS = null;
        let response;

        try {

            response = {
                isBase64Encoded: true,
                statusCode: 400,
                headers: {
                    'Access-Control-Allow-Origin': '*',
                    'Content-Encoding': 'gzip',
                    'Content-Type': 'application/json'
                }

            };

            const userName = req.params.id;
            const userPoolId = config.USER_POOL_ID;




            if (!userName) {
                response.statusCode = 400;
                response.body = zlib.gzipSync(JSON.stringify({ error: 'Username is required.' })).toString('base64');
                return response;
            }


            var params = {
                UserPoolId: userPoolId,
                Username: userName
            };

            var cognitoidentityserviceprovider = new AWS.CognitoIdentityServiceProvider();

            resultAWS = await (new Promise((resolve, reject) => {
                cognitoidentityserviceprovider.adminDeleteUser(params, function (err, data) {
                    if (err) reject(err, err.stack);
                    else {
                        resolve("The user has been deleted succesfully ")
                    }
                })
            }
            ));

            response.statusCode = 200;
            response.body = resultAWS;
            res.json(response.body);

        }
        catch (err) {
            console.log(err);
            response.statusCode = 400;
            response.body = JSON.stringify(err.message).toString('base64');
            return res.json(response.body);
        }

        return res.json(response);


    },

    LoginUsers: async function (req, res) {



        var authenticationData = {
            Password: req.body.password,
            Username: req.body.email,

        };


        var authenticationDetails = new AmazonCognitoIdentity.AuthenticationDetails(authenticationData);

        var poolData = {
            UserPoolId: config.USER_POOL_ID,
            ClientId: config.POOL_CLIENT_ID
        };

        var userPool = new AmazonCognitoIdentity.CognitoUserPool(poolData);

        var userData = {
            Username: req.body.email,
            Pool: userPool
        };

        var cognitoUser = new AmazonCognitoIdentity.CognitoUser(userData);


        let result = new Promise((resolve, reject) => (
            cognitoUser.authenticateUser(authenticationDetails, {
                onSuccess: (result) => {

                    var resp = {
                        "accessToken": result.getAccessToken().getJwtToken(),
                       // "idToken": result.getIdToken().getJwtToken(),
                        //"refreshToken": result.getRefreshToken().getToken(),
                        //"clockDrift": result.getClockDrift(),
                        "statusCode": 200,
                        //"firstime": false
                    };

                    resolve(resp);

                    res.json(resp);
                },
                onFailure: (err) => {

                    console.log(err);

                    var resp = {
                        "resp": err,
                        "statusCode": 401,
                        "message": "Incorrect username or password."
                    };

                    resolve(resp);


                    res.statusCode = 400;
                    res.json(resp.message);



                },
            })
        ));

        return result;
    },

    AddToGroup: async function (req, res, groupName, email) {

        let resultToAddGroup;

        var params = {
            GroupName: groupName,
            UserPoolId: config.USER_POOL_ID,
            Username: email
        };

        try {


            var cognitoidentityserviceprovider = new AWS.CognitoIdentityServiceProvider();

            resultToAddGroup = await (new Promise((resolve, reject) => {
                cognitoidentityserviceprovider.adminAddUserToGroup(params, function (err, data) {
                    if (err) reject(err, err.stack);
                    else {
                        resolve("The user has added to group successfully");
                    }
                })
            }
            ));

        } catch (err) {
            console.log(err);
            res.statusCode = 400;
            return err.code;
        }

        return resultToAddGroup;




    },

    RemoveAdmin: async function (req, res) {

        let response = {
            body: null
        }

        try {

            var params = {
                GroupName: 'Administrator',
                UserPoolId: config.USER_POOL_ID,
                Username: req.body.email,
            };

            var cognitoidentityserviceprovider = new AWS.CognitoIdentityServiceProvider();

            resultToAddGroup = await (new Promise((resolve, reject) => {
                cognitoidentityserviceprovider.adminRemoveUserFromGroup(params, function (err, data) {
                    if (err) reject(err, err.stack);
                    else {
                        resolve("The user has removed successfully");
                        response.body = "THE USER HAS REMOVED SUCCESSFULLY";
                        res.statusCode = 200;
                    }
                })
            }
            ));




            return response;



        } catch (err) {
            console.log(err);
            res.statusCode = 400;
            return err.code;
        }




    }

}








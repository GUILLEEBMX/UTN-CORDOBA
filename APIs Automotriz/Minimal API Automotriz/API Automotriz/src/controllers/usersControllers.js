const AWS = require('aws-sdk');
//AWS.config.loadFromPath('./config.json');
AWS.config.update({ region: 'us-east-1' });


module.exports.Usuarios = {

    RegisterUsersAWS: async function (email, password) {

        try {

            let resultRegisterAWS = {
                msg: null,
                success: false
            }


            var params = {
                UserPoolId: "",
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

            await (new Promise((resolve, reject) => {
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

            return resultRegisterAWS

        } catch (error) {
            console.log(error);
        }


        return resultRegisterAWS;

    },

    ChangePasswordAWS: async function (email, password) {

        try {

            let resultChangePasswordAWS = {
                msg: null,
                success: false
            }


            let resultRegisterAWS = await this.RegisterUsersAWS(email, password);


            if (resultRegisterAWS.success) {

                var params = {
                    Password: password,
                    UserPoolId: "",
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



    }

}
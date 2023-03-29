
module.exports.senderAux = {

    getHTML: function (email, password, url) {

        var html = ` <!doctype html>
<html>

<head>
    <link href="https://fonts.googleapis.com/css?family=Goudy+Bookletter+1911|Share+Tech" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300&display=swap" rel="stylesheet">
</head>

<body style="margin: auto; font-size: 14px; font-family: 'Roboto', sans-serif; width: fit-content !important;">
    <div style="padding: 20px; border-radius: 20px; border: 10px solid #95B8CB;">
        <img style="max-width: 230px; display: block; margin-left: auto; margin-right: auto;"
            src="TP PROGRAMACION II / LABORATORIO II 2022" />

            <h1 style="margin: 25px 0;">
            UTN AUTOMOTRIZ 2022:
            </h1>
    
        <table style="width: 100%;">
            <tbody>
                <tr>
                    <td style="
                        padding: 10px;
                        background: #95B8CB;
                        color: #FFFFFF;
                        border-bottom: 1px solid #C1C3D1;">
                        API - 
                        REPOSITORIES
                    </td>
                    <td style="
                        padding: 10px;
                        background: #FFFFFF;
                        border-bottom: 1px solid #C1C3D1;">
                        <ul>
  <li>https://apiautomotriz.herokuapp.com/api-doc/</li>
  <li>https://gitlab.com/Guillee_Britos/tp-programacion-ii-2022</li>
  <li>https://gitlab.com/Guillee_Britos/api-automotriz</li>
</ul>
                    
                    </td>
                </tr>
                <tr>
                    <td style="
                        padding: 10px;
                        background: #95B8CB;
                        color: #FFFFFF;
                        border-bottom: 1px solid #C1C3D1;">
                        EMAIL
                    </td>
                    <td style="
                        padding: 10px;
                        background: #FFFFFF;
                        border-bottom: 1px solid #C1C3D1;">
                        ${"gbritos13@gmail.com"}  
                    </td>
                </tr>
                 <tr>
                    <td style="
                        padding: 10px;
                        background: #95B8CB;
                        color: #FFFFFF;
                        border-bottom: 1px solid #C1C3D1;">
                        MESSAGE
                    </td>
                    <td style="
                        padding: 10px;
                        background: #FFFFFF;
                        border-bottom: 1px solid #C1C3D1;">
                        ${"GRACIAS POR UTILIZAR NUESTROS PRODUCTOS!!!"}
                    </td>
                </tr>
            </tbody>
        </table>

        <div style="text-align: center; font-size:12px;">
            <p>--------------------------</p>
            <p>Guillee Britos 2022 - All rights reserved.</p>
            <p>
                This email is informative, please do not reply to this email address, since it is not enabled to
                receive
                messages.
            </p>
        </div>
    </div>
</body>


</html>`

        return html;

    }

}
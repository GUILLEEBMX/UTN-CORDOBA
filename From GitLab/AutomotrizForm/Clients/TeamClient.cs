using AutomotrizForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Clients
{
    public  class TeamClient: ITeamServices
    {
        public void LoadInfoGuille(TextBox txtGuillee)
        {
            txtGuillee.Text = "Guillermo Leonardo Britos Legajo : 112971";

        }

        public void LoadInfoAugusto(TextBox txtAugusto)
        {
            txtAugusto.Text = "Augusto Daniele  Legajo : 114194";

        }

        public void LoadInfoIgnacio(TextBox txtIgnacio)
        {
            txtIgnacio.Text = "Borghi Ignacio  Legajo : 113460";

        }

        public void LoadInfoJuan(TextBox txtJuan)
        {
            txtJuan.Text = "Juan Ignacio Escuti Legajo : 113520";

        }

        public void LoadInfoFranco(TextBox txtFranco)
        {
            txtFranco.Text = "Zabala Franco  Legajo : 113192";

        }




    }
}

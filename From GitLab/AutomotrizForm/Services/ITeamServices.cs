using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public  interface ITeamServices
    {
        public void LoadInfoGuille(TextBox txtGuillee);

        public void LoadInfoJuan(TextBox txtJuan);
        public void LoadInfoAugusto(TextBox txtAugusto);
        public void LoadInfoFranco(TextBox txtFranco);

        public void LoadInfoIgnacio(TextBox txtIgnacio);


    }
}

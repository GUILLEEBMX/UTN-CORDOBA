using AutomotrizForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizForm.Fronted
{
    public partial class TeamForm : Form
    {
        private readonly ITeamServices teamServices;
        public TeamForm(ITeamServices teamServices)
        {
            InitializeComponent();
            this.teamServices = teamServices;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            teamServices.LoadInfoIgnacio(txtIgnacio);
            teamServices.LoadInfoAugusto(txtAugusto);
            teamServices.LoadInfoFranco(txtFranco);
            teamServices.LoadInfoGuille(txtGuillee);
            teamServices.LoadInfoJuan(txtJuan);

        }

        private void txtAugusto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

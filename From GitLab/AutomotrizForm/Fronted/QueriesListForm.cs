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
    public partial class QueriesListForm : Form
    {
        private readonly IQueryServices queryServices;
        public QueriesListForm(IQueryServices queryServices)
        {
            InitializeComponent();
            this.queryServices = queryServices;
            
            
        }

        private void  cboQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void QueriesListForm_Load(object sender, EventArgs e)
        {
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await queryServices.FirstQuery(dgvQueries);
            queryServices.MessageToShow(txtEnunciados, 1);

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            await queryServices.SecondQuery(dgvQueries);
            queryServices.MessageToShow(txtEnunciados, 2);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await queryServices.ThirthQuery(dgvQueries);
            queryServices.MessageToShow(txtEnunciados,3);

        }
    }
}

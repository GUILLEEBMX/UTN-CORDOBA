using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
    public partial class PrincipalMenuForm : Form
    {
        private readonly UsersForms userForm;
        private readonly OrderForm orderForm;
        private readonly ProductForm productForm;
        private readonly QueriesListForm queriesListForm;
        private readonly ContactForm contactForm;
        private readonly TeamForm teamForm;
        public PrincipalMenuForm(UsersForms userForm, OrderForm orderForm, ProductForm productForm, QueriesListForm queriesListForm, ContactForm contactForm, TeamForm teamForm)
        {
            InitializeComponent();
            this.userForm = userForm;
            this.orderForm = orderForm;
            this.productForm = productForm;
            this.queriesListForm = queriesListForm;
            this.contactForm = contactForm;
            this.teamForm = teamForm;
        }

        private void PrincipalMenuForm_Load(object sender, EventArgs e)
        {
         

        }



        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productForm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userForm.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderForm.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            queriesListForm.ShowDialog();
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactForm.ShowDialog();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            teamForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Programacion_II.Reports;
using TP2_Programacion_II.Reports.DataSet1TableAdapters;

namespace TP2_Programacion_II.Fronted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //this.DataTable1TableAdapter.Fill(this.DataSet1.Bugs);

            //DataTable1TableAdapter

            this.DataTable1TableAdapter.Fill(this.DataTable1.Bugs);




        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.DataTable1.Bugs);

            this.DataTable1TableAdapter.Fill(this.DataSet1.Bugs);

            DataTable1TableAdapter.

        }
    }
}

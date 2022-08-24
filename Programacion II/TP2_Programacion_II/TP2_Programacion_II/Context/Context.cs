using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Programacion_II.Models;
using TP2_Programacion_II.Services;

namespace TP2_Programacion_II
{
    public class Context : IContextServices
    {
        private string connectionString;
        SqlConnection context;
        SqlCommand cmd;
        DataTable table;

        public Context()
        {
            connectionString = Properties.Resources.connectionString; ;
            context = new SqlConnection(connectionString);
        }

        public void LoaderPaymentMethods(ComboBox cboProducts)
        {
            try
            {

                DataTable table = new DataTable();
                table = ExecProcedureFromDatabase("SP_CONSULTAR_FORMAS_PAGOS");
                cboProducts.DataSource = table;
                cboProducts.ValueMember = "idFormaPago";
                cboProducts.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public DataTable ExecProcedureFromDatabase(string nameProcedure)
        {
            try
            {
                context.Open();
                cmd = new SqlCommand(nameProcedure, context);
                cmd.CommandType = CommandType.StoredProcedure;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                context.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return table;

        }

        public string NextInvoice(Label lblnumberInvoice)
        {
            try
            {
                context.Open();
                SqlCommand cmd = new SqlCommand("SP_PROXIMA_FACTURA", context);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int next = Convert.ToInt32(param.Value);
                lblnumberInvoice.Text = "Invoice Nº : " + next.ToString();
                context.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lblnumberInvoice.Text; ;
        }


        //public void CalculateTotal(TextBox txtTotal, TextBox txtDiscount, TextBox txtFinal)
        //{

        //    txtTotal.Text = budget.CalculateTotal().ToString();
        //    if (txtDiscount.Text != "")
        //    {
        //        double dto = (budget.CalculateTotal() * Convert.ToDouble(txtDiscount.Text)) / 100;
        //        txtFinal.Text = (budget.CalculateTotal() - dto).ToString();
        //    }

        //}

        public bool PostToDatabase(InvoiceModel invoice)
        {
            bool resultado = true;

            try
            {
                context.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_FACTURA", context);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", invoice.Date);
                cmd.Parameters.AddWithValue("@idFormaPago", invoice.PaymentMethod);
                cmd.Parameters.AddWithValue("@cliente", invoice.Client);
                SqlParameter param = new SqlParameter("@id_factura", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int invoiceNumber = Convert.ToInt32(param.Value);
                //int detailCount = 1;
                foreach (DetailInvoice detailInvoice in invoice.DetailListInvoice)
                {
                    SqlCommand _cmd = new SqlCommand("SP_INSERTAR_DETALLE", context);
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@id_factura", invoiceNumber);
                    _cmd.Parameters.AddWithValue("@id_articulo", detailInvoice.Article.Id);
                    _cmd.Parameters.AddWithValue("@cantidad", detailInvoice.Amount);
                    _cmd.ExecuteNonQuery();
                    //detailCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                resultado = false;
            }
            finally
            {
                if (context != null && context.State == ConnectionState.Open)
                    context.Close();
            }
            return resultado;
        }

        public void LoaderArticles(ComboBox cboProducts)
        {
            try
            {

                DataTable table = new DataTable();
                table = ExecProcedureFromDatabase("SP_CONSULTAR_ARTICULOS");
                cboProducts.DataSource = table;
                cboProducts.ValueMember = "id_articulo";
                cboProducts.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TP2_Programacion_II.Models;
using TP2_Programacion_II.Services;

namespace TP2_Programacion_II.Repository
{
    class BudgetRepository : IBudgetRepositoryServices
    {
        SqlTransaction sqlTransaction;
        SqlCommand cmd;
        DataTable table;
        Context context = Context.GetInstance();


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
                    
                Context.Connection().Open();
                cmd = new SqlCommand(nameProcedure, Context.Connection());
                cmd.CommandType = CommandType.StoredProcedure;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                Context.Connection().Close();
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
                Context.Connection().Open();
                SqlCommand cmd = new SqlCommand("SP_PROXIMA_FACTURA", Context.Connection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.Connection = Context.Connection();
                cmd.ExecuteNonQuery();
                int next = Convert.ToInt32(param.Value);
                lblnumberInvoice.Text = "Invoice Nº : " + next.ToString();
                Context.Connection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lblnumberInvoice.Text; ;
        }



        public bool PostToDatabase(InvoiceModel invoice)
        {
            bool result = true;

            try
            {
                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_FACTURA", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", invoice.Date);
                cmd.Parameters.AddWithValue("@idFormaPago", invoice.PaymentMethod);
                cmd.Parameters.AddWithValue("@cliente", invoice.Client);
                SqlParameter param = new SqlParameter("@id_factura", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int invoiceNumber = Convert.ToInt32(param.Value);

                foreach (DetailInvoice detailInvoice in invoice.DetailListInvoice)
                {
                    SqlCommand _cmd = new SqlCommand("SP_INSERTAR_DETALLE", Context.Connection());
                    _cmd.Transaction = sqlTransaction;
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@id_factura", invoiceNumber);
                    _cmd.Parameters.AddWithValue("@id_articulo", detailInvoice.Article.Id);
                    _cmd.Parameters.AddWithValue("@cantidad", detailInvoice.Amount);
                    _cmd.ExecuteNonQuery();

                }

                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }
            return result;
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




        public void DeleteFromDataBase(TextBox txtDelete)
        {
            try
            {

                int invoiceNumber = int.Parse(txtDelete.Text);

                int rowAffecteds = 0;

                DataTable table = new DataTable();
                table = ExecProcedureFromDatabase("SP_DELETE");

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("THE INVOICE THAT YOU ENTER DOES NOT EXIST IN OUR DATABASE...");
                    txtDelete.Clear();
                    return;

                }


                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (invoiceNumber != (int)table.Rows[0].ItemArray[0])
                    {
                        MessageBox.Show("THE INVOICE THAT YOU ENTER DOES NOT EXIST IN OUR DATABASE...");
                        return;

                    }
                }

                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_DELETE_DETAIL_INVOICE", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@invoice", SqlDbType.Int);
                param.Direction = ParameterDirection.Input;
                param.Value = invoiceNumber;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();


                SqlCommand cmdDeleteInvoice = new SqlCommand("SP_DELETE_INVOICE");
                cmdDeleteInvoice.CommandType = CommandType.StoredProcedure;
                SqlParameter paramInvoice = new SqlParameter("@invoice", SqlDbType.Int);
                paramInvoice.Direction = ParameterDirection.Input;
                paramInvoice.Value = invoiceNumber;
                cmdDeleteInvoice.Parameters.Add(paramInvoice);
                rowAffecteds = cmdDeleteInvoice.ExecuteNonQuery();
                Context.Connection().Close();

                sqlTransaction.Commit();

                if (rowAffecteds > 0)
                {
                    MessageBox.Show("Delete Successfully");
                }

            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }

        }




    }
}

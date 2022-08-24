using Carpinteria.Domain;
using Carpinteria.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria.Context
{
    public class Entity : IContextService
    {
        private readonly Budget budget;

        string connectionString = Properties.Resources.connectionString;
        SqlConnection context;
        SqlCommand cmd;
        DataTable table;
        public Entity(Budget _budget)
        {
            context = new SqlConnection(connectionString);
            budget = _budget;
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

        public string NextBudget(Label lblnumberBudget)
        {
            try
            {
                context.Open();
                SqlCommand cmd = new SqlCommand("SP_PROXIMO_ID", context);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int next = Convert.ToInt32(param.Value);
                lblnumberBudget.Text = "Presupuesto Nº: " + next.ToString();
                context.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lblnumberBudget.Text; ;
        }


        public void CalculateTotal(TextBox txtTotal, TextBox txtDiscount, TextBox txtFinal)
        {

            txtTotal.Text = budget.CalculateTotal().ToString();
            if (txtDiscount.Text != "")
            {
                double dto = (budget.CalculateTotal() * Convert.ToDouble(txtDiscount.Text)) / 100;
                txtFinal.Text = (budget.CalculateTotal() - dto).ToString();
            }

        }

        public bool PostToDatabase(Budget budget)
        {
            bool resultado = true;

            try
            {
                context.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_MAESTRO", context);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cliente", budget.Client);
                cmd.Parameters.AddWithValue("@dto", budget.Discount);
                cmd.Parameters.AddWithValue("@total", budget.CalculateTotal() - budget.Discount);
                SqlParameter param = new SqlParameter("@presupuesto_nro", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int presupuestoNro = Convert.ToInt32(param.Value);
                int detailCount = 1;
                foreach (DetailBudget detailBudget in budget.DetailList)
                {
                    SqlCommand _cmd = new SqlCommand("SP_INSERTAR_DETALLE", context);
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@presupuesto_nro", presupuestoNro);
                    _cmd.Parameters.AddWithValue("@detalle", detailCount);
                    _cmd.Parameters.AddWithValue("@id_producto", detailBudget.product.ProductId);
                    _cmd.Parameters.AddWithValue("@cantidad", detailBudget.Amount);
                    _cmd.ExecuteNonQuery();
                    detailCount++;
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

        public void LoaderCbo(ComboBox cboProducts)
        {
            try
            {

                DataTable table = new DataTable();
                table = ExecProcedureFromDatabase("SP_CONSULTAR_PRODUCTOS");
                cboProducts.DataSource = table;
                cboProducts.ValueMember = "id_producto";
                cboProducts.DisplayMember = "n_producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }









    }
}

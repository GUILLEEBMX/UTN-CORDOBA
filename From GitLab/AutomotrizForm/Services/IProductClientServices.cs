using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public  interface IProductClientServices
    {
        public Task LoadAllProducts(DataGridView dgvProducts);
        public Task LoadOneProduct(DataGridView dgvProducts, TextBox txtNumberProduct);
        public  Task LoadCboAreas(ComboBox cboAreas);
        public  Task LoadCboMarks(ComboBox cboMarks);
        public Task PostOrder(ComboBox cboMarks, ComboBox cboRubros, TextBox txtName, TextBox txtDescription, TextBox txtPrecio, TextBox txtStock, TextBox txtStockMinimo,DataGridView dgvProducts);
        public  Task DeleteProduct(TextBox txtDeleteProduct, DataGridView dgvProducts);
    }
}

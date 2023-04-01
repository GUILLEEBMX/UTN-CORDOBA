using AutomotrizForm.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Clients
{
    public  class ProductClient: IProductClientServices
    {
        private readonly HttpClient request;
        private readonly ProductPostDTO product;
        public ProductClient(HttpClient request,ProductPostDTO product)
        {
            this.request = request;
            this.product = product;
        }
        public async Task LoadAllProducts(DataGridView dgvProducts)
        {

            string url = "https://localhost:5001/products";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Products>>(content);

            dgvProducts.RowCount = lst.Count;

            for (int i = 0; i < dgvProducts.RowCount; i++)
            {

                dgvProducts.Rows[i].Cells[0].Value = lst[i].Nombre;
                dgvProducts.Rows[i].Cells[1].Value = lst[i].Descripcion;
                dgvProducts.Rows[i].Cells[2].Value = lst[i].Precio;
                dgvProducts.Rows[i].Cells[3].Value = lst[i].Stock;
                dgvProducts.Rows[i].Cells[4].Value = lst[i].StockMinimo;
                dgvProducts.Rows[i].Cells[5].Value = lst[i].IdProducto;

            }

        }

        public async Task LoadOneProduct(DataGridView dgvProducts,TextBox txtNumberProduct)
        {

            string url = "https://localhost:5001/api/Products/" + txtNumberProduct.Text;
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<Products>(content);

            dgvProducts.RowCount = 1;

            for (int i = 0; i < dgvProducts.RowCount; i++)
            {
                dgvProducts.Rows[i].Cells[0].Value = product.Nombre;
                dgvProducts.Rows[i].Cells[1].Value = product.Descripcion;
                dgvProducts.Rows[i].Cells[2].Value = product.Precio;
                dgvProducts.Rows[i].Cells[3].Value = product.Stock;
                dgvProducts.Rows[i].Cells[4].Value = product.StockMinimo;

            }

        }

        public  async Task PostOrder(ComboBox cboMarks,ComboBox cboRubros,TextBox txtName,TextBox txtDescription,TextBox txtPrecio,TextBox txtStock,TextBox txtStockMinimo,DataGridView dgvProducts)
        {
            product.IdMarca = int.Parse(cboMarks.SelectedValue.ToString());
            product.IdRubro = int.Parse(cboRubros.SelectedValue.ToString()); 
            product.Nombre = txtName.Text;
            product.Descripcion = txtDescription.Text;
            product.Precio = decimal.Parse(txtPrecio.Text);
            product.Stock = int.Parse(txtStock.Text);
            product.StockMinimo = int.Parse(txtStockMinimo.Text);

            string bodyContent = JsonConvert.SerializeObject(product);


            string url = "https://localhost:5001/registerProduct";

            var response = "";
            StringContent content = new StringContent(bodyContent, Encoding.UTF8, "application/json");
            var result = await request.PostAsync(url, content);
            response = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {   
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    cboMarks.SelectedIndex = -1;
                    cboRubros.SelectedIndex = -1;
                    txtName.Clear();
                    txtDescription.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();
                    txtStockMinimo.Clear();
                    await LoadAllProducts(dgvProducts);

                    
                }

            }

            else
            {
                MessageBox.Show(response);
            }

        }

        public  async Task DeleteProduct(TextBox txtDeleteProduct,DataGridView dgvProducts)
        {
            string url = "https://localhost:5001/delete?id=" + txtDeleteProduct.Text;
            var response = "";
            var result = await request.DeleteAsync(url);
            response = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    await LoadAllProducts(dgvProducts);
                }

            }
            else
            {
                MessageBox.Show(response);
            }
     
        }

        public async Task LoadCboMarks(ComboBox cboMarks)
        {

            string url = "https://apiautomotriz.herokuapp.com/api/marcas";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboMarks.DataSource = lst;
            cboMarks.DisplayMember = "MARCA";
            cboMarks.ValueMember = "ID_MARCA";
            //cboProviders.DisplayMember = "id";
            //cboProviders.ValueMember = "nombre";

        }

        public async Task LoadCboAreas(ComboBox cboAreas)
        {

            string url = "https://apiautomotriz.herokuapp.com/api/rubros";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboAreas.DataSource = lst;
            cboAreas.DisplayMember = "NOMBRE_RUBRO";
            cboAreas.ValueMember = "ID_RUBRO";
            //cboProviders.DisplayMember = "id";
            //cboProviders.ValueMember = "nombre";

        }



    }
}

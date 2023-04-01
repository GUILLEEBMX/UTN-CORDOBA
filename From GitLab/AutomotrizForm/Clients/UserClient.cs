
using AutomotrizForm.Fronted;
using AutomotrizForm.Services;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Clients
{

    public class UserClient: IUserClientServices
    {
        private readonly HttpClient request;
        private readonly UserRegisterDTO userRegister;
        private readonly UserAdminDTO userAdminRegister;
     
        public UserClient(HttpClient request,UserRegisterDTO userRegister, UserAdminDTO userAdminRegister)
        {
            this.request = request;
            this.userRegister = userRegister;
            this.userAdminRegister = userAdminRegister;
            
        }


        public  async Task LoadAllUsers(DataGridView dgvUsers)
        {

            string url = "https://localhost:5001/users";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<User_>>(content);

            dgvUsers.RowCount = lst.Count;

            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                dgvUsers.Rows[i].Cells[0].Value = lst[i].Nombre;
                dgvUsers.Rows[i].Cells[1].Value = lst[i].Email;

            }

        }




        public  async Task RegisterUsers(TextBox txtNombreRegisterUser,TextBox txtEmailRegisterUser,TextBox txtPasswordRegisterUser, DataGridView dgvUsers)
        {
           
            userRegister.Nombre = txtNombreRegisterUser.Text;
            userRegister.Email = txtEmailRegisterUser.Text;
            userRegister.Contraseña = txtPasswordRegisterUser.Text;
            userRegister.EsAdmin = false; //QUITAR ESTO

            string bodyContent = JsonConvert.SerializeObject(userRegister);


            string url = "https://localhost:5001/users/register";

            var response = "";
            StringContent content = new StringContent(bodyContent, Encoding.UTF8, "application/json");
            var result = await request.PostAsync(url, content);
            response = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    await LoadAllUsers(dgvUsers);
                }

            }
            else
            {
                MessageBox.Show(response);
                
            }

        }



        public async Task RegisterAdmin(TextBox txtEmailAdmin,DataGridView dgvUsers)
        {
        
            userAdminRegister.Email = txtEmailAdmin.Text;

            string bodyContent = JsonConvert.SerializeObject(userAdminRegister);

            string url = "https://localhost:5001/users/admin/register";

            var response = "";
            StringContent content = new StringContent(bodyContent, Encoding.UTF8, "application/json");
            var result = await request.PostAsync(url, content);
            response = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    await LoadAllUsers(dgvUsers);
                    txtEmailAdmin.Clear();
                }

            }
            else
            {
                MessageBox.Show(response);
                txtEmailAdmin.Clear();
            }
        }

        public async Task DeleteAdmin(TextBox txtDeleteAdmin,DataGridView dgvUsers)
        {
            string url = "https://localhost:5001/users/admin/delete?email=" + txtDeleteAdmin.Text;
            var response = "";
            var result = await request.DeleteAsync(url);
            response = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    await LoadAllUsers(dgvUsers);
                    txtDeleteAdmin.Clear();
                }

            }
            else
            {
                MessageBox.Show(response);
                txtDeleteAdmin.Clear();
            }
        }


        public  async Task DeleteUser(TextBox txtEmailDeleteUser,DataGridView dgvUsers)
        {
            string url = "https://localhost:5001/users/delete?email=" + txtEmailDeleteUser.Text;
            var response = "";
            var result = await request.DeleteAsync(url);
            response = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    await LoadAllUsers(dgvUsers);
                    txtEmailDeleteUser.Clear();
                }

            }
            else
            {
                MessageBox.Show(response);
                txtEmailDeleteUser.Clear();
            }
        }


        public void LoadCboAdminOrNot(ComboBox cboAdmin)
        {
            cboAdmin.Items.Add(true);
            cboAdmin.Items.Add(false);

        }




    }

}

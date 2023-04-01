using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public interface IUserClientServices
    {
      
        public  Task LoadAllUsers(DataGridView dgvUsers);

        public Task RegisterUsers(TextBox txtNombreRegisterUser, TextBox txtEmailRegisterUser, TextBox txtPasswordRegisterUser, DataGridView dgvUsers);

        public  Task RegisterAdmin(TextBox txtEmailAdmin, DataGridView dgvUsers);

        public  Task DeleteAdmin(TextBox txtDeleteAdmin, DataGridView dgvUsers);
        public  Task DeleteUser(TextBox txtEmailDeleteUser, DataGridView dgvUsers);
        public void LoadCboAdminOrNot(ComboBox cboAdmin);



    }
}

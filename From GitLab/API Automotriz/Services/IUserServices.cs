
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_Automotriz.Services
{
    public interface IUserServices
    {
        public ActionResult<List<User_>> GetAllUsers();

        public ActionResult<UserRegisterDTO> CreateUser(UserRegisterDTO user);

        public ActionResult<UserLogginDTO> LogginUser(UserLogginDTO user);

        public bool ValidateAdmin(UserLogginDTO user);

        public ActionResult DeleteUser(string email);

        public ActionResult CreateAdmin(UserAdminDTO user);

        public ActionResult DeleteAdmin(string email);
    }
}

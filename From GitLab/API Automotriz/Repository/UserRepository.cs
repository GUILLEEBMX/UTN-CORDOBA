
using API_Automotriz.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.Context;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace API_Automotriz.Repository
{
    public class UserRepository : IUserServices
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;
        private SqlTransaction sqlTransaction;
        private SqlCommand cmd;

        public UserRepository()
        {
            Context.GetConnection();

        }

        public ActionResult<List<User_>> GetAllUsers()
        {
            try
            {
                var users = Context.GetConnection().GetFromDataBase("GET_USERS");


                if (users == null)
                {
                    return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
                }

                List<User_> usuarios = new List<User_>();

                foreach (DataRow rows in users.Rows)
                {
                    User_ user = new User_();
                    user.Nombre = rows[users.Columns[1].ColumnName].ToString();
                    user.Email = rows[users.Columns[3].ColumnName].ToString();
                    usuarios.Add(user);

                }


                return usuarios;



            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");

            }




        }

        public ActionResult<UserRegisterDTO> CreateUser(UserRegisterDTO user)
        {
            int rowAffecteds;

            try
            {

                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("REGISTRAR_USUARIOS", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE", user.Nombre);
                cmd.Parameters.AddWithValue("@EMAIL", user.Email);
                cmd.Parameters.AddWithValue("@ESADMIN", user.EsAdmin);
                cmd.Parameters.AddWithValue("CONTRASEÑA", user.Contraseña);


                rowAffecteds = cmd.ExecuteNonQuery();

                if (rowAffecteds > 0)
                {
                    sqlTransaction.Commit();

                }

                return new OkObjectResult("THE USER HAS REGISTERED SUCCESSFULLY" + user.Email);

            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();

                return new BadRequestObjectResult("HA OCURRIDO UN INCONVENIENTE...");

            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }




        }

        public ActionResult<UserLogginDTO> LogginUser(UserLogginDTO user)
        {
            try
            {

                Context.Connection().Open();
                cmd = new SqlCommand("LOGGIN_USUARIOS", Context.Connection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Context.Connection();
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = user.Email;
                SqlParameter param = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                var password = param.Value.ToString();
                Context.Connection().Close();

                if (user.Contraseña != password)
                {
                    return new BadRequestObjectResult("NOMBRE DE USUARIO O PASSWORD INCORRECTOS...");
                }



                return new OkObjectResult("Bienvenido " + user.Email);

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.ToString());

            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection();

            }


        }

        public bool ValidateAdmin(UserLogginDTO user)
        {

            var users = Context.GetConnection().GetFromDataBase("GET_USERS");

            for (int i = 0; i < users.Rows.Count; i++)
            {
                if (users.Rows[i].ItemArray[3].ToString() == user.Email && (bool)users.Rows[i].ItemArray[4])
                {
                    return true;

                }

            }

            return false;


        }

        public ActionResult DeleteUser(string email)
        {
            int rowAffecteds = 0;
            var users = Context.GetConnection().GetFromDataBase("GET_USERS");
            var existe = false;

            for (int i = 0; i < users.Rows.Count; i++)
            {
                if (email != users.Rows[i].ItemArray[3].ToString())
                {
                    existe = true;
                }

            }

            if (!existe)
            {
                return new BadRequestObjectResult("ESE USUARIO NO ESTA REGISTRADO EN NUESTRA BD...");
            }



            try
            {
                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("DELETE_USERS", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@EMAIL", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Input;
                param.Value = email;
                cmd.Parameters.Add(param);
                rowAffecteds = cmd.ExecuteNonQuery();


                if (rowAffecteds > 0)
                {
                    sqlTransaction.Commit();
                    Context.Connection().Close();
                }

                return new OkObjectResult("EL USUARIO CUYO EMAIL  ERA " + email + " HA SIDO BORRADO EXITOSAMENTE...");
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR REVISAR...");
            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }






        }

        public ActionResult CreateAdmin(UserAdminDTO user)
        {
            int rowAffecteds;
            try
            {

                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("CREATE_ADMINISTRATOR", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMAIL", user.Email);
                rowAffecteds = cmd.ExecuteNonQuery();

                if (rowAffecteds > 0)
                {
                    sqlTransaction.Commit();
                    Context.Connection().Close();

                }

                return new OkObjectResult("EL ADMINISTRADOR  " + user.Email + "  HA SIDO CREADO EXITOSAMENTE...");


            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR VERIFICAR...");
            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }






        }

        public ActionResult DeleteAdmin(string email)
        {
            int rowAffecteds = 0;
            var users = Context.GetConnection().GetFromDataBase("GET_USERS");

            var existe = false;

            for (int i = 0; i < users.Rows.Count; i++)
            {
                if (email != users.Rows[i].ItemArray[3].ToString())
                {
                    existe = true;

                }

            }

            if (!existe)
            {
                return new BadRequestObjectResult("ESE USUARIO NO ESTA REGISTRADO EN NUESTRA BD...");
            }



            try
            {
                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("DELETE_ADMINISTRATOR", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@EMAIL", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Input;
                param.Value = email;
                cmd.Parameters.Add(param);
                rowAffecteds = cmd.ExecuteNonQuery();


                if (rowAffecteds > 0)
                {
                    sqlTransaction.Commit();
                    Context.Connection().Close();
                }

                return new OkObjectResult("EL ADMINISTRADOR " + email + " HA SIDO DADO DE BAJA EXITOSAMENTE...");
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR VERIFICAR...");
            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }



        }






    }
}

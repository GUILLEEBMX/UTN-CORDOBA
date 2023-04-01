using AutomotrizLibrary.Context;
using AutomotrizLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary.Repository.UserRepository
{
    public  class UserRepository
    {
        //public int RegisterUsers(UserRegisterDTO user)
        //{
        //    int rowAffecteds;
        //    try
        //    {

        //        context.Open();
        //        sqlTransaction = context.BeginTransaction();
        //        SqlCommand cmd = new SqlCommand("REGISTRAR_USUARIOS", context);
        //        cmd.Transaction = sqlTransaction;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@NOMBRE", user.Nombre);
        //        cmd.Parameters.AddWithValue("@EMAIL", user.Email);
        //        cmd.Parameters.AddWithValue("@ESADMIN", user.EsAdmin);
        //        cmd.Parameters.AddWithValue("CONTRASEÑA", user.Contraseña);


        //        rowAffecteds = cmd.ExecuteNonQuery();

        //        if (rowAffecteds > 0)
        //        {
        //            sqlTransaction.Commit();
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        sqlTransaction.Rollback();
        //        return 0;

        //    }
        //    finally
        //    {
        //        if (context != null && context.State == ConnectionState.Open)
        //            context.Close();
        //    }

        //    return rowAffecteds;
        //}

        //public bool Loggin(UserLogginDTO user)
        //{

        //    try
        //    {
        //        context.Open();
        //        cmd = new SqlCommand("LOGGIN_USUARIOS", context);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Connection = context;
        //        cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = user.Email;
        //        SqlParameter param = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 100);
        //        param.Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add(param);
        //        cmd.ExecuteNonQuery();
        //        var password = param.Value.ToString();

        //        if (user.Contraseña != password)
        //        {
        //            return false;
        //        }


        //        return true;


        //    }
        //    catch (Exception ex)
        //    {
        //        return false;

        //    }
        //    finally
        //    {
        //        if (context != null && context.State == ConnectionState.Open)
        //            context.Close();

        //    }




        //}
    }
}

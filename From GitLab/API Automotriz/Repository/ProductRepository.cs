using API_Automotriz.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.Context;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace API_Automotriz.Repository
{
    public class ProductRepository : IProductServices
    {

        private DataTable table;
        public ProductRepository()
        {
            table = new DataTable();
            Context.GetConnection();
        }
        public ActionResult<List<ProductDTO>> GetAllProducts()
        {


            var products = Context.GetConnection().GetFromDataBase("GET_PRODUCTS");


            if (products == null)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
            }

            List<Products> productos = new List<Products>();

            foreach (DataRow rows in products.Rows)
            {
                Products product = new Products();
                product.IdProducto = (int)rows[products.Columns[0].ColumnName];
                product.IdMarca = (int)rows[products.Columns[1].ColumnName];
                product.IdRubro = int.Parse(rows[products.Columns[2].ColumnName].ToString()); ;
                product.Nombre = rows[products.Columns[3].ColumnName].ToString(); ;
                product.Descripcion = rows[products.Columns[4].ColumnName].ToString();
                product.Precio = (decimal)rows[products.Columns[5].ColumnName];
                product.Stock = (int)rows[products.Columns[6].ColumnName];
                product.StockMinimo = (int)rows[products.Columns[7].ColumnName];

                productos.Add(product);

            }


            return new OkObjectResult(productos);


        }

        public ActionResult<ProductDTO> GetID(int id)
        {

            try
            {

                Context.Connection().Open();
                SqlTransaction sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("GET_PRODUCT_ID", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
                param.Direction = ParameterDirection.Input;
                param.Value = id;
                cmd.Parameters.Add(param);
                table.Load(cmd.ExecuteReader());
                Context.Connection().Close();

                if (table.Rows.Count == 0)
                {
                    return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
                }

                ProductDTO product = new ProductDTO();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    product.Nombre = table.Rows[i].ItemArray[3].ToString();
                    product.Descripcion = table.Rows[i].ItemArray[4].ToString();
                    product.Precio = (decimal)table.Rows[i].ItemArray[5];
                    product.Stock = (int)table.Rows[i].ItemArray[6];
                    product.StockMinimo = (int)table.Rows[i].ItemArray[7];

                }

                return new OkObjectResult(product);

            }
            catch (Exception ex)
            {
                Context.Connection().Close();
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR INESPERADO...");

            }



        }

        public ActionResult PostProduct(ProductPostDTO product)
        {

            SqlTransaction sqlTransaction;

            try
            {
                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("POST_PRODUCTOS", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDMARCA", product.IdMarca);
                cmd.Parameters.AddWithValue("@IDRUBRO", product.IdRubro);
                cmd.Parameters.AddWithValue("@NOMBRE", product.Nombre);
                cmd.Parameters.AddWithValue("@DESCRIPCION", product.Descripcion);
                cmd.Parameters.AddWithValue("@PRECIO", product.Precio);
                cmd.Parameters.AddWithValue("@STOCK", product.Stock);
                cmd.Parameters.AddWithValue("@STOCKMINIMO", product.StockMinimo);

                int rowAffecteds = cmd.ExecuteNonQuery();

                if (rowAffecteds > 0)
                {

                    sqlTransaction.Commit();
                }
                
                    return new OkObjectResult("EL PRODUCTO HA SIDO AÑADIDO EXITOSAMENTE...");
                

            }
            catch (Exception ex)
            {

                return new BadRequestObjectResult("HA OCURRIDO UN ERROR VERIFICAR...");

            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }

        }

        public ActionResult DeleteProduct(int id)
        {
            int rowAffecteds = 0;
            var products = Context.GetConnection().GetFromDataBase("GET_PRODUCTS");
            var existe = false;
            SqlTransaction sqlTransaction;

            for (int i = 0; i < products.Rows.Count; i++)
            {
                if (id == (int)products.Rows[i].ItemArray[0])
                {
                    existe = true;
                }

            }

            if (!existe)
            {
                return new BadRequestObjectResult("ESE PRODUCTO NO ESTA REGISTRADO EN NUESTRA BD...");
            }



            try
            {
                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("DELETE_PRODUCTS", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
                param.Direction = ParameterDirection.Input;
                param.Value = id;
                cmd.Parameters.Add(param);
                rowAffecteds = cmd.ExecuteNonQuery();


                if (rowAffecteds > 0)
                {
                    sqlTransaction.Commit();
                    Context.Connection().Close();
                }
                 
                return new OkObjectResult("EL PRODUCTO CUYO ID ERA " + id + " HA SIDO BORRADO EXITOSAMENTE...");
            }
            catch (Exception ex)
            {
        
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR REVISAR...");
            }
            finally
            {
                if (Context.Connection() != null && Context.Connection().State == ConnectionState.Open)
                    Context.Connection().Close();
            }






        }





    }

    }










    

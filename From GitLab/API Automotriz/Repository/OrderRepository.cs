using AutomotrizLibrary.Context;
using AutomotrizLibrary.DTOs;
using AutomotrizLibrary;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using API_Automotriz.Services;

namespace API_Automotriz.Repository
{
    public class OrderRepository:IOrderServices
    {
        private DataTable table;
        public OrderRepository()
        {
            table = new DataTable();
            Context.GetConnection();
        }
        public ActionResult<List<Order>> GetAllOrders()
        {


            var ordersList = Context.GetConnection().GetFromDataBase("GET_ORDERS");


            if (ordersList == null)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
            }

            List<Order> _orderList = new List<Order>();

            foreach (DataRow rows in ordersList.Rows)
            {
                Order order = new Order();
                
                order.IdPedido = (int)rows[ordersList.Columns[0].ColumnName];
                order.IdProveedor = (int)rows[ordersList.Columns[1].ColumnName];
                order.IdSucursal = int.Parse(rows[ordersList.Columns[2].ColumnName].ToString()); ;
                order.IdEntrega = (int)rows[ordersList.Columns[3].ColumnName];
                order.IdTipoSolicitud = (int)rows[ordersList.Columns[4].ColumnName];
                order.IdEmpleadoReceptor = (int)rows[ordersList.Columns[5].ColumnName];
                order.FechaPedido = (DateTime)rows[ordersList.Columns[6].ColumnName];
                order.HoraPedido = rows[ordersList.Columns[7].ColumnName].ToString();
                order.FechaEntregaPedido = (DateTime)rows[ordersList.Columns[8].ColumnName];
                order.PlazoEntregaPedido = rows[ordersList.Columns[9].ColumnName].ToString();
                order.Cliente = (int)rows[ordersList.Columns[10].ColumnName];

                _orderList.Add(order);

            }


            return new OkObjectResult(_orderList);


        }

        public ActionResult<Order> GetID(int id)
        {

            try
            {

                Context.Connection().Open();
                SqlTransaction sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("GET_ORDER_ID", Context.Connection());
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

                Order order = new Order();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    order.IdPedido = (int)table.Rows[i].ItemArray[0];
                    order.IdProveedor = (int)table.Rows[i].ItemArray[1];
                    order.IdSucursal = (int)table.Rows[i].ItemArray[2];
                    order.IdEntrega = (int)table.Rows[i].ItemArray[3];
                    order.IdTipoSolicitud = (int)table.Rows[i].ItemArray[4];
                    order.IdEmpleadoReceptor = (int)table.Rows[i].ItemArray[5];
                    order.FechaPedido = (DateTime)table.Rows[i].ItemArray[6];
                    order.HoraPedido = table.Rows[i].ItemArray[7].ToString();
                    order.FechaEntregaPedido = (DateTime)table.Rows[i].ItemArray[8];
                    order.PlazoEntregaPedido = table.Rows[i].ItemArray[9].ToString();
                    order.Cliente = (int)table.Rows[i].ItemArray[10];
                }

                return new OkObjectResult(order);

            }
            catch (Exception ex)
            {
                Context.Connection().Close();
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR INESPERADO...");

            }



        }

        public ActionResult PostOrder(OrderPostDTO order)
        {

            SqlTransaction sqlTransaction;
            int rowAffecteds = 0;

            try
            {
                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("POST_ORDER", Context.Connection());
                cmd.Transaction = sqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDPROVEEDOR", order.IdProveedor);
                cmd.Parameters.AddWithValue("@IDSUCURSAL", order.IdSucursal);
                cmd.Parameters.AddWithValue("@IDENTREGA", order.IdEntrega);
                cmd.Parameters.AddWithValue("@IDTIPOSOLICITUD", order.IdTipoSolicitud);
                cmd.Parameters.AddWithValue("@IDEMPLEADORECEPTOR", order.IdEmpleadoReceptor);
                cmd.Parameters.AddWithValue("@FECHAPEDIDO",order.FechaPedido);
                cmd.Parameters.AddWithValue("@HORAPEDIDO", order.HoraPedido);
                cmd.Parameters.AddWithValue("@FECHAENTREGAPEDIDO", order.FechaEntregaPedido );
                cmd.Parameters.AddWithValue("@PLAZOENTREGAPEDIDO", order.PlazoEntregaPedido);
                cmd.Parameters.AddWithValue("@IDCLIENTE", order.Cliente);
                SqlParameter param = new SqlParameter("@ID_PEDIDO", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int orderNumber = Convert.ToInt32(param.Value); 

                foreach (OrderDetailDTO orderDetail in order.OrderDetails)

                {
                    SqlCommand _cmd = new SqlCommand("POST_ORDER_DETAIL", Context.Connection());
                    _cmd.Transaction = sqlTransaction;
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@IDPEDIDO", orderNumber);
                    _cmd.Parameters.AddWithValue("@IDPRODUCTO", orderDetail.IdProducto);
                    _cmd.Parameters.AddWithValue("@CANTIDAD", orderDetail.Cantidad);
                    _cmd.Parameters.AddWithValue("@PRECIO", orderDetail.PrecioCompra);
           
                   rowAffecteds = _cmd.ExecuteNonQuery();

                }


                if (rowAffecteds > 0)
                {

                    sqlTransaction.Commit();
                }
                else
                {
                    sqlTransaction.Rollback();
                }

                return new OkObjectResult("EL PEDIDO HA SIDO AÑADIDO EXITOSAMENTE...");


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

        public ActionResult DeleteOrder(int id)
        {
            int rowAffecteds = 0;
            var Orders = Context.GetConnection().GetFromDataBase("");
            var existe = false;
            SqlTransaction sqlTransaction;

            for (int i = 0; i < Orders.Rows.Count; i++)
            {
                if (id == (int)Orders.Rows[i].ItemArray[0])
                {
                    existe = true;
                }

            }

            if (!existe)
            {
                return new BadRequestObjectResult("ESE OrderO NO ESTA REGISTRADO EN NUESTRA BD...");
            }



            try
            {
                Context.Connection().Open();
                sqlTransaction = Context.Connection().BeginTransaction();
                SqlCommand cmd = new SqlCommand("DELETE_OrderS", Context.Connection());
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

                return new OkObjectResult("EL OrderO CUYO ID ERA " + id + " HA SIDO BORRADO EXITOSAMENTE...");
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

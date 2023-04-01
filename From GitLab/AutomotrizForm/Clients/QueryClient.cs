using AutomotrizForm.Services;
using AutomotrizLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Clients
{
    public  class QueryClient: IQueryServices
    {

        private readonly HttpClient request;

        public QueryClient(HttpClient request)
        {
            this.request = request;
        }


        public async Task FirstQuery(DataGridView dgvQueries)
        {
            string url = "https://apiautomotriz.herokuapp.com/api/guillee/firstquery";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<object>>(content);
            dgvQueries.DataSource = lst;

        }

        public async Task SecondQuery(DataGridView dgvQueries)
        {
            string url = "https://apiautomotriz.herokuapp.com/api/guillee/secondquery";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<object>>(content);
            dgvQueries.DataSource = lst;

        }

        public async Task ThirthQuery(DataGridView dgvQueries)
        {
            string url = "https://apiautomotriz.herokuapp.com/api/guillee/thirthquery";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<object>>(content);
            dgvQueries.DataSource = lst;

         
        }

        public async Task FourthQuery(DataGridView dgvQueries)
        {
            string url = "https://apiautomotriz.herokuapp.com/api/guillee/thirthquery";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<object>>(content);
            dgvQueries.DataSource = lst;


        }

        public async Task FivethQuery(DataGridView dgvQueries)
        {
            string url = "https://apiautomotriz.herokuapp.com/api/guillee/thirthquery";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<object>>(content);
            dgvQueries.DataSource = lst;


        }

        public async Task SixthQuery(DataGridView dgvQueries)
        {
            string url = "https://apiautomotriz.herokuapp.com/api/guillee/thirthquery";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<object>>(content);
            dgvQueries.DataSource = lst;


        }
        public void MessageToShow (TextBox txtQueries,int numberQuery)
        {
            if(numberQuery == 1)
            {
                txtQueries.Text = "Emitir un listado de todos los vendedores incluyendo el nombre del barrio que vendieron, \nel nombre del producto de aquellos vendedores que vendieron más de $100000 en los últimos \r\n3 meses";
            }
            else if(numberQuery == 2)
            {
                txtQueries.Text = "Mostrar en una misma tabla de resultados los empleados que no vendieron nunca este \r\nmes (en primer lugar) y los que tuvieron más de 10 ventas este mes en segundo lugar, \r\nordenados en forma alfabética por nombre de empleado.";
            }
            else if(numberQuery == 3)
            {
                txtQueries.Text = "¿Cuánto vendió en total cada empleado en pedidos este año? ¿Cuánto fue el importe \r\npromedio y la fecha de la primera y última venta? Siempre y cuando ese promedio cobrado \r\nhaya sido superior al promedio del año pasado.";
            }
            else if(numberQuery == 4)
            {
                txtQueries.Text = "Listar Nombre, descripcion y Codigo de los prodcutos que se vendieron mas de 5 veces el año pasado, listar además la cantidad de unidades vendidas y los ingresos obtenidos por ese articulo, ordenar por articulo con mayor ingreso.";

            }
            else if (numberQuery == 5)
            {
                txtQueries.Text = "Listar los clientes que vinieron más de 3 veces en los ultimos 10 años, mostrando la cantidad de compras, fecha de su primer compra, de la última y los días que pasaron entre ambas";

            }
            else
            {
                txtQueries.Text = "Listar los clientes que han hecho al menos una compra y fecha de la iltima venta, junto a la cantidad de meses que pasaron sin comprar para ofrecerles un 2% de descuento, por cada 30 días que pasaron sin comprar  para que sean el objetivo de la acción de marketing, mostrar accion a tomar junto con medio de contacto preferido.";

            }
           
        }


        
     

    }



}

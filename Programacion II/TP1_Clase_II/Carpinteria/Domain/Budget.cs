using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria.Domain
{
    public class Budget
    {
        public int BudgetId { get; set; }

        public DateTime HighDate { get; set; }

        public string Client { get; set; }

        public double Discount { get; set; }

        public DateTime LowDate { get; set; }

        public float Total { get; set; }


        public List<DetailBudget> DetailList { get; }

        public Budget(string client, float total, float discount,int budgetId )
        {
            BudgetId = budgetId;
            HighDate = DateTime.Now;
            Client= client;
            Discount = discount;
            Total = 0;
            DetailList = new List<DetailBudget>();

        }

        public Budget()
        {
            DetailList = new List<DetailBudget>();

        }

        public void AddDetail(DetailBudget detailBudget)
        {
            if(detailBudget != null)
            {
                DetailList.Add(detailBudget);
            }
        }

        public void DeleteDetail(DetailBudget detallePresupuesto)
        {
            if (detallePresupuesto != null)
            {
                DetailList.Remove(detallePresupuesto);
            }


        }

        public double CalculateTotal()
        {
            return Total - Discount;

        }









    }
}

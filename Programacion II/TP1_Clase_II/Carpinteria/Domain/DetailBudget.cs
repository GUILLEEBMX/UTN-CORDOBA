using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria.Domain
{
    public class DetailBudget
    {
        public Product product { get; set; }
        public int BudgetId { get; set; }
        public int DetailId { get; set; }
        public int Amount  { get; set; }

        public DetailBudget(int amount, Product product)
        {
            this.Amount = amount;
            this.product = product;

        }

        public float CalcularSubTotal()
        {
            return product.Price * Amount;

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPrescription.Domain
{
    public class PrescriptionDetails
    {
        public PrescriptionDetails()
        {
            Ingredient = new Ingredient();
        }
        public Ingredient Ingredient {get;set;}
        public int Amount { get; set; }
    }
}

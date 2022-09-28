using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class DetailPrescription
    {
     
        public DetailPrescription()
        {
            Ingredient = new Ingredient();

        }

        public Ingredient Ingredient { get; set; }

        public int Amount { get; set; }


    }
}

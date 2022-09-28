using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }

        public string Name { get; set; }


        public int PrescriptionType { get; set; }


        public string Cheff { get; set; }

        public List <DetailPrescription> DetailPrescription { get; set; }  



        public void AddDetails (DetailPrescription detailPrescription)
        {
            if (DetailPrescription == null)
            {
                DetailPrescription = new List<DetailPrescription>(); 
            }

            DetailPrescription.Add(detailPrescription);
        }
    }
}

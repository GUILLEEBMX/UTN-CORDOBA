using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPrescription.Domain
{
    public class Prescription
    {

        public Prescription()
        {
            PrescriptionDetails = new List<PrescriptionDetails>();
            PrescriptionType = new PrescriptionType();
        }
        public int  PrescriptionId  {get;set;}
        public string Nombre { get; set; }

        public PrescriptionType PrescriptionType { get; set; }

        public string Cheff { get; set; }

        public List<PrescriptionDetails> PrescriptionDetails { get; set; }

        public void AddDetail(PrescriptionDetails prescriptionDetails)
        {
            PrescriptionDetails.Add(prescriptionDetails);

        }

        public void RemoveDetail(int index)
        {
            PrescriptionDetails.RemoveAt(index);
        }


    }
}

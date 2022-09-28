using RecetasSLN.Implementacion;
using RecetasSLN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Config
{
    class FactoryServiceImplementation:FactoryService
    {
        public override IPrescriptionService CreateServices()
        {
            return new PrescriptionRepository();
        }
    }
}

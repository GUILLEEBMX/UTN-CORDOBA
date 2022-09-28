using RecetasSLN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Config
{
    public abstract class FactoryService
    {

        public abstract IPrescriptionService CreateServices();

    }
}

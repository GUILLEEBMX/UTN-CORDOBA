using APIPrescription.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPrescription.FactoryConfig
{
    public abstract class FactoryService
    {
        public abstract IPrescriptionService CreateServices();
        public abstract IFormValidatorService CreateValidatorServices();
    }
}

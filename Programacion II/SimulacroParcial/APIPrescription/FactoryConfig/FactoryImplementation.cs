using APIPrescription.Repository;
using APIPrescription.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPrescription.FactoryConfig
{
    class FactoryImplementation:FactoryService 
    {
        public override IPrescriptionService CreateServices()
        {
            return new PrescriptionRepository();
        }

        public override IFormValidatorService CreateValidatorServices()
        {
            return new FormValidator();
        }
    }
}

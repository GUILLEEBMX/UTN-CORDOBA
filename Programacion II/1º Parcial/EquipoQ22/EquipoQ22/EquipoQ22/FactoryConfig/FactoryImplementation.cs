using EquipoQ22.DAO;
using EquipoQ22.Datos;
using EquipoQ22.Services;
using EquipoQ22.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoQ22.FactoryConfig
{
    public class FactoryImplementation:Factory
    {
        public override IEquipoDao CreateServices()
        {
            return new EquipoDAO();
        }

        public override IFormValidatorServices CreateValidatorServices()
        {
            return new FormValidator();
        }
    }
}

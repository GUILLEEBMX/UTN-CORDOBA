using EquipoQ22.Datos;
using EquipoQ22.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoQ22.FactoryConfig
{
    public abstract class Factory
    {
        public abstract IEquipoDao CreateServices();
        public abstract IFormValidatorServices CreateValidatorServices();
    }
}

using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace JurosRestDDDInfra.CrossCuting.IoC
{
    public class ModuleIoc : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfiguratioinIoc.Load(builder);
        }
    }
}

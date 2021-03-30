using Autofac;
using JurosRestDDDApplication;
using JurosRestDDDApplication.Interfaces;
using JurosRestDDDDomain.Core.Interfaces;
using JurosRestDDDDomain.Core.Interfaces.Services;
using JurosRestDDDDomain.Entities;
using JurosRestDDDDomain.Services;
using JurosRestDDDInfra.CrossCuting.Interface;
using JurosRestDDDInfra.CrossCuting.Mapper;
using JurosRestDDDInfra.Data.Repositories;

namespace JurosRestDDDInfra.CrossCuting.IoC
{
    public class ConfiguratioinIoc
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Ioc

            builder.RegisterType<ApplicationServiceTaxa>().As<IApplicationServiceTaxa>();
            builder.RegisterType<ApplicationServiceJuro>().As<IApplicationServiceJuro>();
            builder.RegisterType<ServiceJuro>().As<IServiceJuro>();
            builder.RegisterType<ServiceTaxa>().As<IServiceTaxa>();
            builder.RegisterType<RepositoryTaxa>().As<IRepositoryTaxa>();
            builder.RegisterType<RepositoryJuro>().As<IRepositoryJuro>();
            builder.RegisterType<MapperJuto>().As<IMapperJuro>();
            builder.RegisterType<MapperTaxa>().As<IMapperTaxa>();



            #endregion

        }
    }
}

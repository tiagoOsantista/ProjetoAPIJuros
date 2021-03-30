using JurosRestDDDApplication.DTOs;
using JurosRestDDDDomain.Core.Interfaces.Services;
using JurosRestDDDDomain.Entities;
using JurosRestDDDInfra.CrossCuting.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace JurosRestDDDApplication
{
    public class ApplicationServiceJuro : IApplicationServiceJuro
    {
        private readonly IServiceJuro serviceJuro;
        private readonly IMapperJuro mapperJuro;

        public ApplicationServiceJuro(IServiceJuro serviceJuro, IMapperJuro mapperJuro)
        {
            this.serviceJuro = serviceJuro;
            this.mapperJuro = mapperJuro;
        }
        public void Add(JuroDto juro)
        {
            serviceJuro.Add(mapperJuro.MapperDtoToEntity(juro));
        }

        public decimal Calculajuros(JuroDto juro)
        {
            return serviceJuro.CalculaJuros(mapperJuro.MapperDtoToEntity(juro));
        }

        public IEnumerable<JuroDto> getAll()
        {
            return mapperJuro.MapperListJuroDto(serviceJuro.GetAll());
        }

        public JuroDto GetById(int id)
        {
            return mapperJuro.MapperEntityToDto(serviceJuro.GetById(id));
        }

        public void Remove(JuroDto juro)
        {
            serviceJuro.Remove(mapperJuro.MapperDtoToEntity(juro));
        }

        public void Update(JuroDto juro)
        {
            serviceJuro.Update(mapperJuro.MapperDtoToEntity(juro));
        }
    }
}

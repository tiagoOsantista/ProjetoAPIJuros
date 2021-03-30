using JurosRestDDDApplication.DTOs;
using JurosRestDDDApplication.Interfaces;
using JurosRestDDDDomain.Core.Interfaces.Services;
using JurosRestDDDInfra.CrossCuting.Interface;
using System.Collections.Generic;

namespace JurosRestDDDApplication
{
    public class ApplicationServiceTaxa : IApplicationServiceTaxa
    {
        private readonly IServiceTaxa serviceTaxa;
        private readonly IMapperTaxa mapperTaxa;

        public ApplicationServiceTaxa(IServiceTaxa serviceTaxa,  IMapperTaxa mapperTaxa)
        {
            this.serviceTaxa = serviceTaxa;
            this.mapperTaxa = mapperTaxa;
        }
        public void Add(TaxaDto taxa)
        {
            serviceTaxa.Add(mapperTaxa.MapperDtoToEntity(taxa));
        }

        public IEnumerable<TaxaDto> getAll()
        {
            return mapperTaxa.MapperListTaxaDto(serviceTaxa.GetAll());
        }

        public TaxaDto GetById(int id)
        {
            return mapperTaxa.MapperEntityToDto(serviceTaxa.GetById(id));
        }

        public TaxaDto GetTaxaFixa()
        {
            return mapperTaxa.MapperEntityToDto(serviceTaxa.GetTaxaFixa());
        }

        public void Remove(TaxaDto taxa)
        {
            serviceTaxa.Remove(mapperTaxa.MapperDtoToEntity(taxa));
        }

        public void Update(TaxaDto taxa)
        {
            serviceTaxa.Update(mapperTaxa.MapperDtoToEntity(taxa));
        }
    }
}

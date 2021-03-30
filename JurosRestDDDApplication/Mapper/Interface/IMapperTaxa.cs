using JurosRestDDDApplication.DTOs;
using JurosRestDDDDomain.Entities;
using System.Collections.Generic;

namespace JurosRestDDDInfra.CrossCuting.Interface
{
    public interface IMapperTaxa
    {
        Taxa MapperDtoToEntity(TaxaDto taxaDto);
        IEnumerable<TaxaDto> MapperListTaxaDto(IEnumerable<Taxa> taxas);

        TaxaDto MapperEntityToDto(Taxa taxa);
    }
}

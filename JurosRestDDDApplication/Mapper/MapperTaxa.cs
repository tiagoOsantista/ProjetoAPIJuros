using JurosRestDDDApplication.DTOs;
using JurosRestDDDDomain.Entities;
using JurosRestDDDInfra.CrossCuting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace JurosRestDDDInfra.CrossCuting.Mapper
{
    public class MapperTaxa : IMapperTaxa
    {
        public Taxa MapperDtoToEntity(TaxaDto taxaDto)
        {
            return new Taxa
            {
                Valor = taxaDto.Valor,
                Ativo = taxaDto.Ativo,
                Nome = taxaDto.Nome,
                TaxaId = taxaDto.TaxaId
            };
        }

        public TaxaDto MapperEntityToDto(Taxa taxa)
        {
            return new TaxaDto
            {
                Valor = taxa.Valor,
                Ativo = taxa.Ativo,
                Nome = taxa.Nome,
                TaxaId = taxa.TaxaId
            };
        }

        public IEnumerable<TaxaDto> MapperListTaxaDto(IEnumerable<Taxa> taxas)
        {
            return taxas.Select(t => new TaxaDto
            {
                TaxaId = t.TaxaId,
                Ativo = t.Ativo,
                Nome = t.Nome,
                Valor = t.Valor
            });
        }
    }
}

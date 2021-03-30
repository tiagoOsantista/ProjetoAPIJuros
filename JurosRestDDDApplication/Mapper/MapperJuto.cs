using JurosRestDDDApplication.DTOs;
using JurosRestDDDDomain.Entities;
using JurosRestDDDInfra.CrossCuting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace JurosRestDDDInfra.CrossCuting.Mapper
{
    public class MapperJuto : IMapperJuro
    {
        public Juro MapperDtoToEntity(JuroDto juroDto)
        {
            return new Juro
            {
                Tempo = juroDto.Tempo,
                ValorInicial = juroDto.ValorInicial,
                ValorJuros = juroDto.ValorJuros
            };
        }

        public JuroDto MapperEntityToDto(Juro juro)
        {
            return new JuroDto
            {
                Tempo = juro.Tempo,
                ValorInicial = juro.ValorInicial,
                ValorJuros = juro.ValorJuros
            };
        }

        public IEnumerable<JuroDto> MapperListJuroDto(IEnumerable<Juro> juros)
        {
            return juros.Select(t => new JuroDto
            {
                Tempo = t.Tempo,
                ValorJuros = t.ValorJuros,
                ValorInicial = t.ValorInicial
                
            });
        }
    }
}

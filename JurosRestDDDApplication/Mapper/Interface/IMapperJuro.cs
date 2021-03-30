using JurosRestDDDApplication.DTOs;
using JurosRestDDDDomain.Entities;
using System.Collections.Generic;

namespace JurosRestDDDInfra.CrossCuting.Interface
{
    public interface IMapperJuro
    {
        Juro MapperDtoToEntity(JuroDto juroDto);
        IEnumerable<JuroDto> MapperListJuroDto(IEnumerable<Juro> juros);

        JuroDto MapperEntityToDto(Juro juro);
    }
}

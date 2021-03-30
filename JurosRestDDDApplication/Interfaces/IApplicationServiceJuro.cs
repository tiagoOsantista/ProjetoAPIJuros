using JurosRestDDDApplication.DTOs;
using System.Collections.Generic;

namespace JurosRestDDDDomain.Entities
{
    public interface IApplicationServiceJuro
    {
        void Add(JuroDto juro);
        void Update(JuroDto juro);
        void Remove(JuroDto juro);
        IEnumerable<JuroDto> getAll();
        JuroDto GetById(int id);
        decimal Calculajuros(JuroDto juro);
    }
}

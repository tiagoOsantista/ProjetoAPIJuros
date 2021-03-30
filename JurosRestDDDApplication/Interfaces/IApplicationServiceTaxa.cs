using JurosRestDDDApplication.DTOs;
using System.Collections.Generic;

namespace JurosRestDDDApplication.Interfaces
{
    public interface IApplicationServiceTaxa
    {
        void Add(TaxaDto taxa);
        void Update(TaxaDto taxa);
        void Remove(TaxaDto taxa);
        IEnumerable<TaxaDto> getAll();
        TaxaDto GetById(int id);
        TaxaDto GetTaxaFixa();
    }
}

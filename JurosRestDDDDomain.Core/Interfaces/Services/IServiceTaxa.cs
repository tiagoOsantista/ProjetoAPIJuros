using JurosRestDDDDomain.Entities;

namespace JurosRestDDDDomain.Core.Interfaces.Services
{
    public interface IServiceTaxa : IServiceBase<Taxa> 
    {
        Taxa GetTaxaFixa();
    }
}

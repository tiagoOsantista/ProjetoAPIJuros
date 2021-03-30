using JurosRestDDDDomain.Core.Interfaces;
using JurosRestDDDDomain.Core.Interfaces.Services;
using JurosRestDDDDomain.Entities;
using System;

namespace JurosRestDDDDomain.Services
{

    public class ServiceTaxa : ServiceBase<Taxa>, IServiceTaxa
    {
        private readonly IRepositoryTaxa repositoryTaxa;

        public ServiceTaxa(IRepositoryTaxa repositoryTaxa)
            : base(repositoryTaxa)
        {
            this.repositoryTaxa = repositoryTaxa;
        }

        public Taxa GetTaxaFixa()
        {
            return new Taxa
            {
                Ativo = true,
                Nome = "Juros",
                TaxaId = 1,
                Valor = Decimal.Parse("0,01")
            };
        }


    }
}

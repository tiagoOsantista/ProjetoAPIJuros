using JurosRestDDDDomain.Core.Interfaces;
using JurosRestDDDDomain.Core.Interfaces.Services;
using JurosRestDDDDomain.Entities;
using System;

namespace JurosRestDDDDomain.Services
{
    public class ServiceJuro : ServiceBase<Juro>, IServiceJuro
    {
        private readonly IRepositoryJuro repositoryJuro;
        public ServiceJuro(IRepositoryJuro repositoryJuro)
            : base(repositoryJuro)
        {
            this.repositoryJuro = repositoryJuro;
        }

        /// <summary>
        /// Valor Inicial * (1 + juros) ^ Tempo
        /// </summary>
        /// <param name="juro"></param>
        /// <returns></returns>
        public decimal CalculaJuros(Juro juro)
        {
            return decimal.Round(juro.ValorInicial * (decimal)Math.Pow(1.0 + (double)juro.ValorJuros, juro.Tempo), 2);
        }


    }
}

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
            return  (decimal)Math.Pow((double)(juro.ValorInicial * (1 + juro.ValorJuros)), (double)juro.Tempo);
        }


    }
}

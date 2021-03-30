using JurosRestDDDDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JurosRestDDDDomain.Core.Interfaces.Services
{
    public interface IServiceJuro : IServiceBase<Juro>
    {
        decimal CalculaJuros(Juro juro);
    }
}

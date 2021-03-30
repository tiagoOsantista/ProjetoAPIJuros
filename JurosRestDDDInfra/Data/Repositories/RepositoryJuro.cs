using JurosRestDDDDomain.Core.Interfaces;
using JurosRestDDDDomain.Entities;

namespace JurosRestDDDInfra.Data.Repositories
{
    public class RepositoryJuro : RepositoryBase<Juro>, IRepositoryJuro
    {
        private readonly SqlContext sqlContext;

        public RepositoryJuro(/*SqlContext sqlContext*/)
            : base(/*sqlContext*/)
        {
            //this.sqlContext = sqlContext;
        }
    }
}

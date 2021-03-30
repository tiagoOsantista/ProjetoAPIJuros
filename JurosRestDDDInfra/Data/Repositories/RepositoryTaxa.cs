using JurosRestDDDDomain.Core.Interfaces;
using JurosRestDDDDomain.Entities;

namespace JurosRestDDDInfra.Data.Repositories
{
    public class RepositoryTaxa : RepositoryBase<Taxa>, IRepositoryTaxa
    {
        private readonly SqlContext sqlContext;

        public RepositoryTaxa(/*SqlContext sqlContext*/)
            : base(/*sqlContext*/)
        {
            //this.sqlContext = sqlContext;
        }
    }
}

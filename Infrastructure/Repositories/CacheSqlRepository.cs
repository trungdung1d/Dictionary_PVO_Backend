using Core.Interfaces.Repository;
using Core.Models.Entity;
using Core.Utils;

namespace Infrastructure.Repositories
{
    public class CacheSqlRepository : BaseRepository<cache_sql>, ICacheSqlRepository
    {
        #region Constructors
        public CacheSqlRepository(IHustServiceCollection serviceCollection) : base(serviceCollection)
        {

        }

        #endregion

        #region Methods
        #endregion

    }
}

using Core.Interfaces.Repository;
using Core.Models.Entity;
using Core.Utils;

namespace Infrastructure.Repositories
{
    public class CacheExternalWordApiRepository : BaseRepository<cache_external_word_api>, ICacheExternalWordApiRepository
    {
        #region Constructors
        public CacheExternalWordApiRepository(IHustServiceCollection serviceCollection) : base(serviceCollection)
        {

        }

        #endregion

        #region Methods
        #endregion

    }
}

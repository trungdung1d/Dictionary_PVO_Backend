using Dapper;
using Core.Interfaces.Repository;
using Core.Models.DTO;
using Core.Models.Entity;
using Core.Utils;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ConceptRelationshipRepository : BaseRepository<concept_relationship>, IConceptRelationshipRepository
    {
        #region Constructors
        public ConceptRelationshipRepository(IHustServiceCollection serviceCollection) : base(serviceCollection)
        {

        }

        #endregion

        #region Methods
        #endregion

    }
}

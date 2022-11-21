using System.Collections.Generic;
using HotChocolate;
using HotChocolate.Types;
using Wingspan.Model;
using Wingspan.Services;

namespace Wingspan.GraphQL.Schema
{
    public class Query
    {
        private IBirdServices _services;

        public Query(IBirdServices services)
        {
            _services = services;
        }

        [UsePaging(IncludeTotalCount = true, DefaultPageSize = 20)]
        public IEnumerable<Bird> GetBirds()
        {
            return _services.GetAllBirds();
        }
    }
}

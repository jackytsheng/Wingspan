using System.Collections.Generic;
using HotChocolate;
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

        public IEnumerable<Bird> GetBirds()
        {
            return _services.GetAllBirds();
        }
    }
}

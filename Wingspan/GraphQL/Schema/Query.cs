

using System.Collections.Generic;
using HotChocolate;
using Wingspan.DB;
using Wingspan.Model;

namespace Wingspan.GraphQL.Schema
{
    public class Query
    {
        // private readonly IBirdsDB _db;
        //
        // public Query (IBirdsDB db)
        // {
        //     _db = db;
        // }

        public string Instruction => "Hello";
        // public List<Bird> Birds => _db.GetBirds();
    }
}

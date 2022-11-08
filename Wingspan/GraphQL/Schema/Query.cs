

using HotChocolate;

namespace Wingspan.GraphQL.Schema
{
    public class Query
    {
        [GraphQLDeprecated("This is a test demo query")]
        public string Instruction => "Hello Jacky!";
    }
}

using System;
using System.Text;
using HotChocolate.Types.Descriptors;

namespace Wingspan.GraphQL;

public class SnakeCaseNamingConvention : DefaultNamingConventions
{
    public override string GetEnumValueName(object value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        return new NamingHelper().ToSnakeCase(value.ToString());
    }
}

using System.Text;
using HotChocolate.Types.Descriptors;
using Wingspan.GraphQL;
using Xunit;

namespace WingspanTests.GraphQL;

public class SnakeCaseNamingConventionTests
{
    [Theory]
    [InlineData("sEsE", "s_es_e")]
    [InlineData("ADbDS", "a_db_d_s")]
    [InlineData("bac-bDS", "bac-b_d_s")]
    public void GivenInput_WhenToSnakeCaseIsCalled_ExpectedCorrectOutput(string input, string expected)
    {
        var coventsion = new SnakeCaseNamingConvention();
        Assert.Equal(expected, coventsion.ToSnakeCase(input));
    }
}

using Wingspan;
using Xunit;

namespace WingspanTests.Helper;

public class HelperTests
{
    [Theory]
    [InlineData("sEsE", "s_es_e")]
    [InlineData("ADbDS", "a_db_d_s")]
    [InlineData("bac-bDS", "bac-b_d_s")]
    public void GivenInput_WhenToSnakeCaseIsCalled_ExpectedCorrectOutput(string input, string expected)
    {
        var helper = new NamingHelper();
        Assert.Equal(expected, helper.ToSnakeCase(input));
    }
}

using Wingspan.DB;
using Xunit;

namespace WingspanTests;
public class LocalBirdsDbTests
{
    [Fact]
    public void WhenGetBirdsIsCalled_ReturnBirds()
    {
        var localDb = new LocalBirdsDb();
        var birds = localDb.GetBirds();

        Assert.NotEmpty(birds);
    }
}

using Wingspan.DB;
using Wingspan.Model;
using Xunit;

namespace WingspanTests;
public class LocalBirdsDbTests
{
    [Fact]
    public void WhenGetBirdsIsCalled_ReturnBirds()
    {
        var testBirds = new List<Bird>
        {
            new()
            {
                CommonName = "bird1",
                ScientificName = "bird2",
                GameSet = "core",
                AbilityColor = "white",
                AbilityDescription = "hello",
            },
            new()
            {
                CommonName = "bird1",
                ScientificName = "bird2",
                GameSet = "core",
                AbilityColor = "white",
                AbilityDescription = "hello",
            }
        };

        var localDb = new LocalBirdsDb(testBirds);
        var birds = localDb.GetBirds();

        Assert.Equal(2,birds.Count);
    }
}

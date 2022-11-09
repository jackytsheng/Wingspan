using Moq;
using Wingspan.DB;
using Wingspan.Model;
using Wingspan.Services;
using Xunit;

namespace WingspanTests.Services;

public class BirdServicesTests
{
    [Fact]
    public void WhenGetAllBirdsIsCalled_ReturnAllBirds()
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

        var mockDb = new Mock<IBirdsDB>();

        mockDb.Setup(db => db.GetBirds()).Returns(testBirds);

        var services = new BirdServices(mockDb.Object);
        var birds = services.GetAllBirds();

        Assert.Equal(2, birds.Count);
    }
}

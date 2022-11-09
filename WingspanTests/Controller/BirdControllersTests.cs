using Moq;
using Wingspan.Controller;
using Wingspan.DB;
using Wingspan.Model;
using Wingspan.Services;
using Xunit;

namespace WingspanTests.Controller;

public class BirdControllersTests
{
    [Fact]
    public void WhenGetBirdsIsCalled_ReturnCorrectResponse()
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

        var mockServices = new Mock<IBirdServices>();

        mockServices.Setup(s => s.GetAllBirds()).Returns(testBirds);

        var services = new BirdsController(mockServices.Object);
        var birds = services.GetAllBirds();

        Assert.Equal(2, birds.Count);
    }
}

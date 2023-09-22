namespace Tests;

public class OlievatTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DefaultCapacityIs159()
    {
        Olievat olievat = new Olievat();
        Assert.That(olievat.Capaciteit, Is.EqualTo(159), "Capacity should always be 159");
    }
}

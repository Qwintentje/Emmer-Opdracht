namespace Tests;

public class EmmerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CapacityAbove2500ThrowsException()
    {
        Assert.Throws<InvalidCapacityException>(() => new Emmer(2501), "Capacity should not exceed 2500");
    }

    [Test]
    public void CapacityBelow10DefaultsTo10()
    {
        var emmer = new Emmer(5);
        Assert.That(emmer.Capaciteit, Is.EqualTo(10), "Capacity should be set to 10 when a lower amount is given");
    }

    [Test]
    public void DefaultCapacityIs12()
    {
        var emmer = new Emmer();
        Assert.That(emmer.Capaciteit, Is.EqualTo(12), "Capacity should default to 12 when not specified");
    }

    [Test]
    public void GietOverShouldChangeBothEmmersCorrectly()
    {
        var emmer1 = new Emmer(2500);
        var emmer2 = new Emmer(2500);

        emmer1.UpdateInhoud(100);

        emmer1.GietOver(emmer2);

        Assert.That(emmer1.Inhoud, Is.EqualTo(0), "Emmer1 should have 0 content after pouring");

        Assert.That(emmer2.Inhoud, Is.EqualTo(100), "Emmer2 should have the poured content");
    }

    [Test]
    public void UpdateInhoudShouldChangeInhoud()
    {
        var emmer = new Emmer(2500);
        Assert.That(emmer.Inhoud, Is.EqualTo(0), "Emmer should have 0 content");
        emmer.UpdateInhoud(100);
        Assert.That(emmer.Inhoud, Is.EqualTo(100), "Emmer should have 100 content");
    }

    [Test]
    public void InhoudCannotBeNegative()
    {
        var emmer = new Emmer();
        Assert.Throws<Exception>(() => emmer.UpdateInhoud(-10), "Content should not be allowed to be negative");
    }

    //Can not be tested because of the new events
    /*    [Test]
        public void InhoudCannotExceedCapacity()
        {
            var emmer = new Emmer(100);
            Assert.Throws<Exception>(() => emmer.UpdateInhoud(500), "Content should not be allowed to be negative");
        }*/

    [Test]
    public void LeegInhoudShouldEmpty()
    {
        var emmer = new Emmer(500);
        emmer.UpdateInhoud(200);
        Assert.That(emmer.Inhoud, Is.EqualTo(200), "Emmer should have 200 content");
        emmer.LeegInhoud();
        Assert.That(emmer.Inhoud, Is.EqualTo(0), "Emmer should be empty");
    }
}
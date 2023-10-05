using Emmer_Opdracht.Exceptions;

namespace Tests;

public class RegentonTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RegentonConstructor_AllowedCapacities()
    {
        // Try to create a Regenton with allowed capacities
        Assert.DoesNotThrow(() => new Regenton(80), "Should allow capacity 80");
        Assert.DoesNotThrow(() => new Regenton(100), "Should allow capacity 100");
        Assert.DoesNotThrow(() => new Regenton(120), "Should allow capacity 120");
        Assert.Throws<InvalidCapacityException>(() => new Regenton(90), "Should throw InvalidCapacityException for capacity 90");
    }
}

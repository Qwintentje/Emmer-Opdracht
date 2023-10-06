namespace Tests;

public class EventTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EmmerFullShouldTriggerEvent()
    {
        Emmer emmer = new Emmer(500);
        bool eventHandlerCalled = false;
        emmer.ContainerVol += (sender, args) => eventHandlerCalled = true;
        emmer.UpdateInhoud(500);
        Assert.IsTrue(eventHandlerCalled, "ContainerVol event should be triggered");
    }

    [Test]
    public void EmmerOverflowShouldTrigger2Events()
    {
        Emmer emmer = new Emmer(500);
        bool onContainerOverstroomCalled = false;
        bool onBijnaOverstroomCalled = false;
        emmer.ContainerOverstroom += (sender, args) => onContainerOverstroomCalled = true;
        emmer.BijnaOverstroom += (sender, args) => onBijnaOverstroomCalled = true;

        string userInput = "1\n";
        using (StringReader sr = new StringReader(userInput))
        {
            Console.SetIn(sr);
            emmer.UpdateInhoud(501);
            Assert.IsTrue(onContainerOverstroomCalled, "ContainerOverstroom event should be triggered");
            Assert.IsTrue(onBijnaOverstroomCalled, "ContainerOverstroom event should be triggered");
        }
    }
}

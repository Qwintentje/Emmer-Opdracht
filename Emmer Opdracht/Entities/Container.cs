namespace Emmer_Opdracht.Entities;

public abstract class Container
{
    private int capaciteit;
    private int inhoud;
    private ContainerService containerService = new ContainerService();

    //PUBLIC for testing, should be set to private in production
    public event EventHandler ContainerVol;

    public delegate void OverstroomEventHandler(object sender, OverstroomEventArgs e);
    public event OverstroomEventHandler ContainerOverstroom;

    public delegate void BijnaOverstroomEventHandler(object sender, OverstroomEventArgs e);
    public event BijnaOverstroomEventHandler BijnaOverstroom;

    private ContainerType _cType = ContainerType.Onbekend;
    public ContainerType CType
    {
        get => _cType;
        protected set { _cType = value; }
    }
    public int Capaciteit
    {
        get => capaciteit;
        protected set
        {
            if (value >= 0)
            {
                capaciteit = value;
            }
            else throw new InvalidCapacityException(value, "Groter dan 0");
        }
    }
    public int Inhoud
    {
        get => inhoud;
        set
        {
            if (value < 0) throw new Exception("Inhoud kan niet negatief zijn.");
            //If container is exactly full trigger ContainerVol event
            if (value == capaciteit && ContainerVol != null) ContainerVol(this, new EventArgs());
            if (value > capaciteit && Inhoud == Capaciteit)
            {
                if (ContainerOverstroom != null) ContainerOverstroom(this, new OverstroomEventArgs { OverstroomAmount = value - capaciteit });
            }
            //If container is overflowing
            else if (value > capaciteit)
            {
                if (this is Container container)
                {
                    //Trigger BijnaOverstroom event, where you can set the amount that overflows or cancel it
                    if (BijnaOverstroom != null) BijnaOverstroom(container, new OverstroomEventArgs { OverstroomAmount = value - capaciteit });
                }
            }
            else inhoud = value;
        }
    }

    public Container()
    {
        ContainerVol += containerService.OnContainerVol;
        ContainerOverstroom += containerService.OnContainerOverstroom;
        BijnaOverstroom += containerService.OnBijnaOverstroom;
    }

    public void UpdateInhoud(int amount)
    {
        Console.WriteLine("UpdateInhoud");
        Inhoud += amount;
    }

    public void LeegInhoud()
    {
        Console.WriteLine("LeegInhoud");
        Inhoud = 0;
    }

    public void Print()
    {
        Console.WriteLine($"{CType}, Capaciteit: {Capaciteit} Inhoud: {Inhoud}");

    }
}

public enum ContainerType
{
    Onbekend,
    Emmer,
    Olievat,
    Regenton
}


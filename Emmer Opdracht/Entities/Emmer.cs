namespace Emmer_Opdracht.Entities;

public class Emmer : Container
{
    public new int Capaciteit
    {
        get => base.Capaciteit;
        set
        {
            if (value > 2500) throw new InvalidCapacityException(value, "kleiner of gelijk aan 2500");
            if (value < 10) base.Capaciteit = 10;
            else base.Capaciteit = value;
        }
    }

    public Emmer() : base()
    {
        CType = ContainerType.Emmer;
        Capaciteit = 12;
    }

    public Emmer(int capacitieit) : base()
    {
        CType = ContainerType.Emmer;
        Capaciteit = capacitieit;
    }

    public void GietOver(Emmer NieuweEmmer)
    {
        Console.WriteLine("GietOver");
        NieuweEmmer.Inhoud += Inhoud;
        Inhoud = 0;
    }
}

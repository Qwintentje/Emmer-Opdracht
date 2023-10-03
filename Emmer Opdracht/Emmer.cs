namespace Emmer_Opdracht;

public class Emmer : Container
{

    public new int Capaciteit
    {
        get
        {
            return base.Capaciteit;
        }
        set
        {
            if (value > 2500)
            {
                throw new InvalidCapacityException(value, "kleiner of gelijk aan 2500");
            }
            if (value < 10)
            {
                base.Capaciteit = 10;
            }
            else
            {
                base.Capaciteit = value;
            }
        }
    }

    public Emmer()
    {
        Capaciteit = 12;
    }

    public Emmer(int capacitieit)
    {
        Capaciteit = capacitieit;
    }

    public void GietOver(Emmer NieuweEmmer)
    {
        Console.WriteLine("GietOver");
        NieuweEmmer.Inhoud += Inhoud;
        Inhoud = 0;
    }

    public void Print()
    {
        Console.WriteLine($"{Naam}, Capaciteit: {Capaciteit} Inhoud: {Inhoud}");
    }
}

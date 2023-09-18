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
                throw new Exception("De capaciteit van een emmer mag niet boven 2500 zijn.");
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
        NieuweEmmer.Inhoud += Inhoud;
        Inhoud = 0;
    }

    public void Print()
    {
        Console.WriteLine("Emmer, Capaciteit: " + Capaciteit + " Inhoud: " + Inhoud);
    }
}

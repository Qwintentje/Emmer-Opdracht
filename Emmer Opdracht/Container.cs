namespace Emmer_Opdracht;

public class Container
{
    private int capaciteit;
    private int inhoud;
    public int Capaciteit
    {
        get
        {
            return capaciteit;
        }
        set
        {
            if (value >= 0) { capaciteit = value; } else throw new Exception("Capaciteit kan niet negatief zijn.");
        }
    }
    public int Inhoud
    {
        get
        {
            return inhoud;
        }
        set
        {
            if (value >= 0) { inhoud = value; } else throw new Exception("Inhoud kan niet negatief zijn.");
        }
    }

    public void UpdateInhoud(int amount)
    {
        Inhoud += amount;
    }

    public void Empty()
    {
        Inhoud = 0;
    }
}


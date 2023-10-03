namespace Emmer_Opdracht;

public abstract class Container
{
    public string Naam { get; set; } = "";
    private int capaciteit;
    private int inhoud;
    public int Capaciteit
    {
        get
        {
            return capaciteit;
        }
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
        get
        {
            return inhoud;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Inhoud kan niet negatief zijn.");
            }
            else if (inhoud + value > capaciteit)
            {
                throw new Exception("Inhoud kan niet groter zijn dan de capaciteit");
            }
            {
                inhoud = value;
            }
        }
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


}


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
        protected set
        {
            if (value >= 0)
            {
                capaciteit = value;
            }
            else throw new Exception("Capaciteit kan niet negatief zijn.");
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
        Inhoud += amount;
    }

    public void LeegInhoud()
    {
        Inhoud = 0;
    }


}


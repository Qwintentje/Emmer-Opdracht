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
            if (value <= 2500)
            {
                base.Capaciteit = value;
            }
            else
            {
                throw new Exception("De capaciteit van een emmer mag niet boven 2500 zijn.");
            }
        }
    }
}

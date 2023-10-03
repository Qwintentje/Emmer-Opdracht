namespace Emmer_Opdracht;

public class Regenton : Container
{
    private static readonly int[] AllowedCapacities = { 80, 100, 120 };

    public Regenton(int capaciteit)
    {
        if (AllowedCapacities.Contains(capaciteit))
        {
            Capaciteit = capaciteit;
        }
        else
        {
            throw new InvalidCapacityException(capaciteit, "80, 100 of 120.");
        }
    }

    public void Print()
    {
        Console.WriteLine("# Regenton, Capaciteit: " + Capaciteit + " Inhoud: " + Inhoud);
    }
}

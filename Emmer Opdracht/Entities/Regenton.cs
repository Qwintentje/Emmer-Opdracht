namespace Emmer_Opdracht.Entities;

public class Regenton : Container
{
    private static readonly int[] AllowedCapacities = { 80, 100, 120 };

    public Regenton(int capaciteit)
    {
        if (AllowedCapacities.Contains(capaciteit))
        {
            CType = ContainerType.Regenton;
            Capaciteit = capaciteit;
        }
        else throw new InvalidCapacityException(capaciteit, "80, 100 of 120.");
    }
}

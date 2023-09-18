namespace Emmer_Opdracht;

public class InvalidCapacityException : Exception
{
    public InvalidCapacityException(int onjuisteCapaciteit, string juisteCapaciteitMessage)
        : base($"Ongeldige capaciteit. Onjuiste capaciteit: {onjuisteCapaciteit}, Juiste capaciteit: {juisteCapaciteitMessage}")
    {
    }
}

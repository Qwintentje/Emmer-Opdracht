namespace Emmer_Opdracht;

public class InvalidCapacityException : Exception
{
    public int OnjuisteCapaciteit { get; }
    public string JuisteCapaciteit { get; }

    public InvalidCapacityException(int onjuisteCapaciteit, string juisteCapaciteit)
        : base($"Ongeldige capaciteit. Onjuiste capaciteit: {onjuisteCapaciteit}, Juiste capaciteit: {juisteCapaciteit}")
    {
        OnjuisteCapaciteit = onjuisteCapaciteit;
        JuisteCapaciteit = juisteCapaciteit;
    }
}

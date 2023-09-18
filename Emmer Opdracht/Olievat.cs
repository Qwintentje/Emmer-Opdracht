namespace Emmer_Opdracht;

public class Olievat : Container
{
    public Olievat()
    {
        Capaciteit = 159;
    }

    public void Print()
    {
        Console.WriteLine("Olievat, Capaciteit: " + Capaciteit + " Inhoud: " + Inhoud);
    }
}

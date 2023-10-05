﻿namespace Emmer_Opdracht.Services;

public class ContainerService
{
    public void OnContainerVol(object sender, EventArgs e)
    {
        Console.WriteLine("Emmer is vol");
    }

    public void OnContainerOverstroom(object sender, OverstroomEventArgs e)
    {
        Console.WriteLine($"Container overstroomd met {e.OverstroomAmount}");
    }

    public void OnBijnaOverstroom(object sender, BijnaOverstroomEventArgs e)
    {
        if (sender is Container container)
        {
            bool isValidChoice = false;
            do
            {
                Console.WriteLine($"{container.CType} is aan het overstromen met {e.OverstroomAmount} liter! Oh nee!");
                Console.WriteLine("1. Overstromen laten stoppen\n2. Overstromen met bepaalde hoeveelheid");
                Console.WriteLine("Maak een keuze...");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Overstromen gestopt!");
                        isValidChoice = true; // Exit the loop
                        break;
                    case "2":
                        Console.WriteLine("Voer de hoeveelheid in:");
                        var amountInput = Console.ReadLine();
                        if (int.TryParse(amountInput, out int amount))
                        {
                            if (amount > e.OverstroomAmount || amount < 0) break;
                            Console.WriteLine($"Overstromen met {amount} hoeveelheid!");
                            isValidChoice = true;
                        }
                        else
                        {
                            Console.WriteLine("Ongeldige invoer voor hoeveelheid. Probeer opnieuw.");
                        }
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                        break;
                }
            } while (!isValidChoice);
        }
    }
}
using Emmer_Opdracht;

Emmer emmer = new Emmer();
emmer.Capaciteit = 5;

Olievat olievat = new Olievat();
olievat.Inhoud = 100;
olievat.Capaciteit = 50;

Regenton regenton = new Regenton();
regenton.Inhoud = 105;
regenton.Capaciteit = 500;

Console.WriteLine(regenton.Inhoud + " " + olievat.Capaciteit + " " + emmer.Capaciteit);

regenton.UpdateInhoud(10);
Console.WriteLine(regenton.Inhoud + " " + olievat.Capaciteit + " " + emmer.Capaciteit);

regenton.Empty();

Console.WriteLine(regenton.Inhoud + " " + olievat.Capaciteit + " " + emmer.Capaciteit);

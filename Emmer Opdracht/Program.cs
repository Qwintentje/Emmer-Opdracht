using Emmer_Opdracht;

Emmer emmer1 = new Emmer(2500);
emmer1.Naam = "Emmer 1";
emmer1.Print();
emmer1.UpdateInhoud(100);
emmer1.Print();

Emmer emmer2 = new Emmer(300);
emmer2.Naam = "Emmer 2";
emmer2.Print();
emmer2.UpdateInhoud(1);
emmer2.Print();

emmer1.GietOver(emmer2);
emmer1.Print();
emmer2.Print();

emmer2.GietOver(emmer1);
emmer1.Print();
emmer2.Print();








using Emmer_Opdracht;

Emmer emmer1 = new Emmer(2500);
emmer1.UpdateInhoud(2000);
emmer1.Print();

Emmer emmer2 = new Emmer(2500);
emmer2.UpdateInhoud(0);
emmer2.Print();

emmer1.GietOver(emmer2);
emmer1.Print();
emmer2.Print();

emmer2.GietOver(emmer1);
emmer1.Print();
emmer2.Print();








/*Emmer emmer1 = new Emmer(500);
emmer1.UpdateInhoud(499);
emmer1.UpdateInhoud(1); //Triggers full event

emmer1.UpdateInhoud(5);

Olievat olievat = new Olievat();
olievat.UpdateInhoud(150);
olievat.UpdateInhoud(9);
olievat.UpdateInhoud(100); //Triggers overflow event



*/

Emmer emmer = new Emmer(100);
emmer.UpdateInhoud(105);
emmer.Print();

emmer.UpdateInhoud(10);
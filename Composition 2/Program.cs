using Composition_2;

Otoldirgich avtomobilOtoldirgich = new Otoldirgich();
Gildirak avtomobilGildirak = new Gildirak();

Avtomobil meningAvtomobilim = new Avtomobil(avtomobilOtoldirgich, avtomobilGildirak);

meningAvtomobilim.Start();
Console.WriteLine("Uzoq yuraman");
meningAvtomobilim.Stop();

using csharp_geometria;

/*
2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console,
i valori di base e di altezza con cui istanziare un nuovo Rettangolo.
Dopo averlo istanziato, stampate a video il perimetro e l’area.

3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi
(baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad
esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:

 —— Rettangolo1 ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2
*/

Console.WriteLine("Creiamo un quadrato");

Console.Write("Quanti cm misura la base? ");
int laBase = Int32.Parse(Console.ReadLine());
Console.Write("QUanti cm misura l'altezza? ");
int altezza = Int32.Parse(Console.ReadLine());

Rettangolo primoRettangolo = new Rettangolo(laBase, altezza);

primoRettangolo.Risultato();



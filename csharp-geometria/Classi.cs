using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    public class Rettangolo
    {
        private int laBase;
        private int altezza;


        //costruttore
        public Rettangolo(int laBase, int altezza)
        {
            this.laBase = laBase;
            this.altezza = altezza;
        }


        //calcolaArea
        private int Area()
        {
            return laBase * altezza;
        }


        //calcolaPerimetro

        private int Perimetro()
        {
            return (laBase + altezza) * 2;
        }


        //visualizza risultati
        public void Risultato()
        {
            Console.WriteLine("La base misura " + laBase + "cm. L'altezza misura " + altezza + "cm.");
            Console.WriteLine("L'area è di " + Area() + "cm quadri e il perimetro è di " + Perimetro() + "cm");
        }





    }

}



/*
 * 1. Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
Aggiungere un opportuno costruttore con parametri.
Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano
e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
*/
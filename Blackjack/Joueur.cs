using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Joueur
    {
        private int SommeArgent;
        private MainJoueur main;
        private MainJoueur main2;
        private Paquet paquet;
        private bool estDealer;
        private int pot = 0;


        public int SommeArgent1
        {
            get
            {
                return SommeArgent;
            }

            set
            {
                SommeArgent = value;
            }
        }

        internal MainJoueur Main
        {
            get
            {
                return main;
            }

            set
            {
                main = value;
            }
        }

        public int Pot
        {
            get
            {
                return pot;
            }

            set
            {
                pot = value;
            }
        }

        internal MainJoueur Main2
        {
            get
            {
                return main2;
            }

            set
            {
                main2 = value;
            }
        }

        public Joueur(MainJoueur main, Paquet paquet, bool estDealer)
        {
            this.main = main;
            this.paquet = paquet;
            this.estDealer = estDealer;


        }
        public void piocher()
        {
          
            if (estDealer)
            {
                if (main.CarteMainJoueur1.Count <2)
                {
                    //poiohce une carte face caché 
                    main.ajouterCarteDansMains(paquet.DistribuerCarte());
                    main.premiereCarteAjouter().GetimageCache();
                    main.CalculerValeurMain(true);
                    //piocher une deuxième carte 
                    main.ajouterCarteDansMains(paquet.DistribuerCarte());
                    main.CalculerValeurMain(true);                  
                }

              
            }else
            {
                
                main.ajouterCarteDansMains(paquet.DistribuerCarte());
                
                main.CalculerValeurMain(true);
            }
               

        }

        public void dealerPiocheEncore()
        {
            main.premiereCarteAjouter().GetImage(true);

            while (main.ValeurMain1 <= 16)
            {
                main.ajouterCarteDansMains(paquet.DistribuerCarte());
                main.CalculerValeurMain(true);
            }

        }

        public bool miser (int mise)
        {
            bool peutmiser = true;

            if (SommeArgent - mise < 0)
            {
                peutmiser = false;
                return peutmiser;
            }

            peutmiser = true;
            SommeArgent1 -= mise;
            pot += mise;
            return peutmiser;


            
        }

        public void changerSomme (bool gagner)
        {
           if(gagner)
            {
                SommeArgent1 += Pot * 2;
            }
        }

        public bool isBusted()
        {
            bool busted = false;

            if ( main.ValeurMain1 > 21)
            {
                busted = true;
            }

            return busted;

        }

        public bool isSplit()
        {
            bool split = false;

            if (main.CarteMainJoueur1.Count == 2 && main.CarteMainJoueur1[0].Valeur == main.CarteMainJoueur1[1].Valeur)
            {
                split = true;
                return split;
           }

            return split;
       
        }

        public void SplitDeck()
        {

            MainJoueur newMain1 = new MainJoueur();
            MainJoueur newMain2 = new MainJoueur();

            newMain1.ajouterCarteDansMains(main.CarteMainJoueur1[0]);
            newMain2.ajouterCarteDansMains(main.CarteMainJoueur1[1]);

            main.resetMain();
            main.resetMain();

            main2 = newMain2;
            main = newMain1;
            
        }
        

    }
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blackjack
{
    class JeuBlackJack

      
    {
        
        Paquet paqueCarte = new Paquet();

        MainJoueur mainJoueur = new MainJoueur();
        MainJoueur mainDealer = new MainJoueur();

        Joueur J1;
        Joueur J2dealer;
        int SOMMEDEPART = 500;

        internal Joueur Joueur1
        {
            get
            {
                return J1;
            }

            set
            {
                J1 = value;
            }
        }

        internal Joueur JoueurDealer
        {
            get
            {
                return J2dealer;
            }

            set
            {
                J2dealer = value;
            }
        }

        internal Paquet PaqueCarte
        {
            get
            {
                return paqueCarte;
            }

            set
            {
                paqueCarte = value;
            }
        }

        public void StartNewGame(int nombreDepaquet)
        {
            for (int i = 0;i< nombreDepaquet;i++)
            {
                paqueCarte.MelangePaquet();
            }
  
            Joueur1 = new Joueur(mainJoueur, paqueCarte, false);
            JoueurDealer = new Joueur(mainDealer, paqueCarte, true);
                      
            Joueur1.SommeArgent1 = SOMMEDEPART;

            

        }

        public void NouvellePartie()
        {

            Joueur1.Main.resetMain();
            JoueurDealer.Main.resetMain();
            Joueur1.Pot = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GameOver()
        {
            string msg = "null";

            if (J2dealer.Main.ValeurMain1 > 17 && J2dealer.Main.ValeurMain1 <= 21 && J2dealer.Main.ValeurMain1 > J1.Main.ValeurMain1)
            {
                msg = "Tu perds snif";
                J1.changerSomme(false);
               
            }

            else if (J1.Main.ValeurMain1 > J2dealer.Main.ValeurMain1 || J1.Main.ValeurMain1 <=21)
            {
                msg = "Yeah tu gagne cette manche";
                J1.changerSomme(true);

            }
                
            else if (J1.Main.ValeurMain1 == J2dealer.Main.ValeurMain1)
            {
                msg = "Equalite";
            }
            return msg;
           

        }

       


    }

   
}

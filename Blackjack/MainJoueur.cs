using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Blackjack
{
    class MainJoueur
    {

        private List<Carte> CarteMainJoueur;
        private int ValeurMain;
        // evenement pour indiquer changement de valeur
        public event EventHandler Changement;


        public int ValeurMain1
        {
            get
            {
                return ValeurMain;
            }

            set
            {
                ValeurMain = value;

            }
        }

        internal List<Carte> CarteMainJoueur1
        {
            get
            {
                return CarteMainJoueur;
            }

            set
            {
                CarteMainJoueur = value;
            }
        }
        public MainJoueur()
        {
            CarteMainJoueur = new List<Carte>();
        }

        public void ajouterCarteDansMains(Carte carte)
        {
            CarteMainJoueur.Add(carte);
        }
        

        public Carte premiereCarteAjouter()

        {
            return CarteMainJoueur[0];

        }

        public void resetMain()
        {

            CarteMainJoueur1.Clear();
            ValeurMain = 0;
        }


        public void CalculerValeurMain(bool ValBlackjack)
        {
            int newValueMain = 0;

            foreach (Carte carte in CarteMainJoueur)
            {
                if (carte.Valeur == Valeur.Dame || carte.Valeur == Valeur.Roi || carte.Valeur == Valeur.Vallet)
                {
                    newValueMain += 10;
                }
                else if (carte.Valeur == Valeur.As)
                {
                    if (ValeurMain + 11 > 21)
                    {
                        newValueMain += 1;
                    }
                    else
                    {
                        newValueMain += 11;
                    }
                    
                }
                else
                {
                    newValueMain += (int)carte.Valeur;
                }

            }

            ValeurMain = newValueMain;

        }

   





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Paquet
    {
        private List<Carte> ListeCarte;
        private Random aleatoire = new Random();


        internal List<Carte> ListeCarte1
        {
            get
            {
                return ListeCarte;
            }

            set
            {
                ListeCarte = value;
            }
        }
        public Paquet()
        {
            ListeCarte1 = new List<Carte>();
        }

        public void MelangePaquet()
        {

            //création object carte et ajout dans la liste plus mélange du paquet

            //parcour la valeur de la carte

            for (int compteurCouleur = 1; compteurCouleur < 5; compteurCouleur++)
            {
                for (int compteurValeur = 1; compteurValeur < 14; compteurValeur++)
                {

                    Carte carte = new Carte();

                    carte.Valeur = (Valeur)4;
                    carte.Couleur = (Couleur)4;
                    carte.GetImage(true);

                    ListeCarte.Add(carte);


                    //Mélager selon algo de FisherYates


                    MelangeurfisherYates(ListeCarte);

                }

            }
        }
        public void MelangeurfisherYates(List<Carte> listAtrier)
        {


            for (int i = listAtrier.Count - 1; i > 0; i--)
            {
                int index2 = aleatoire.Next(i + 1);
                Carte temp = listAtrier[i];
                listAtrier[i] = listAtrier[index2];
                listAtrier[index2] = temp;
            }

        }

        public Carte DistribuerCarte()
        {
            Carte cartePiocher = new Carte();

            if (ListeCarte != null)
            {
                cartePiocher = ListeCarte[ListeCarte.Count - 1];
                ListeCarte.Remove(cartePiocher);

            }
            else
            {
                throw new ArgumentNullException("le paquet est vide ");

            }

            return cartePiocher;
        }



    }
}
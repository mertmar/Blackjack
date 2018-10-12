using Blackjack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace Blackjack
{
    class Carte
    {
        private Couleur couleur;
        private Valeur valeur;
        private Image image;
   
        public Valeur Valeur
        {
            get
            {
                return this.valeur;
            }

            set
            {
                this.valeur = value;
                
            }
        }

        public Couleur Couleur
        {
            get
            {
                return this.couleur;
            }

            set
            {
                this.couleur = value;
                

            }
        }

        public Image Image1 
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public void GetimageCache()
        {
            
            Bitmap img2 = new Bitmap(240, 98);
            img2 = Resources.dodecarte;
            Image1 = img2;

        }


     
        /// <summary>
        /// Génère une image en fonction de sa couleur et de sa valeur
        /// </summary>
        public void GetImage(bool recto)
        {
                    
                int x = 0;//depuis la droite
                int y = 0;//
                int height = 240; // 140
                int width = 98;  //198

                switch (this.couleur)
                {
                    case Couleur.Coeur:
                    y = 35;
                        break;
                    case Couleur.Pique:
                        y = 466;
                        break;
                    case Couleur.Trefle:
                        y = 320;
                        break;
                    case Couleur.Carreau:
                        y = 180;
                        break;
                }


                x = width * ((int)this.Valeur - 1); //-1 car le départ est égale à zéro
                Bitmap source = Resources.imgCarte;
                Bitmap img = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0,0,width,height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);//couper l'image principal pour obetenir une seul carte

            //libérer les ressoruces



            Image1 = img;

        }
        }
    }

    enum Couleur
    {
        Coeur = 1,
        Carreau =2,
        Pique = 3,
        Trefle = 4,

    }

    enum Valeur
    {
        As = 1,
        Deux = 2,
        Trois = 3,
        Quatre = 4,
        Cinq = 5,
        Six = 6,
        Sept = 7,
        Huit = 8,
        Neuf = 9,
        Dix = 10,
        Vallet =11,
        Dame = 12,
        Roi =13,
    }


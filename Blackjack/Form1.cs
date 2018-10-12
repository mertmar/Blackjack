using Blackjack.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {

        PictureBox[] pics = new PictureBox[52];
        FlowLayoutPanel[] layoutPanel = new FlowLayoutPanel[50];

        Paquet paqueCarte1 = new Paquet();

        Form2 miseVue = new Form2();
        JeuBlackJack blackjackGame = new JeuBlackJack();

        PictureBox pictureCarte;
        Stopwatch chrono = new Stopwatch();

        Random random = new Random();
        bool bPushingPicOne = false;


        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            chrono.Start();
            timer2.Start();
            
            blackjackGame.StartNewGame(2);
            NewGame();
            labelArgentJoueur.Text = blackjackGame.Joueur1.SommeArgent1.ToString();
            
           
        }
       

        private void buttonHit_Click(object sender, EventArgs e)
        {

            int valmainJoueur = 0;
            bPushingPicOne = !bPushingPicOne;

            
            // blackjackGame.JoueurDealer.Main.CalculerValeurMain(true);

            //  valmainJoueur = blackjackGame.Joueur1.Main.ValeurMain1;

            playerDealerPioche();

            if (blackjackGame.Joueur1.isBusted())
            {
                messageBox("c'est perdu");
            }
            
        }


        private void playerDealerPioche()
        {
           
            blackjackGame.Joueur1.piocher();

            if (blackjackGame.Joueur1.isSplit())
            {
                buttonSplit.Enabled = true;

            }
            afficherCarte(blackjackGame.Joueur1.Main, panel1, false);

            blackjackGame.JoueurDealer.piocher();
            afficherCarte(blackjackGame.JoueurDealer.Main, panel2, true);

            labelValueDealer.Text = blackjackGame.JoueurDealer.Main.ValeurMain1.ToString();
            labelValueJoueur.Text = blackjackGame.Joueur1.Main.ValeurMain1.ToString();
            labelNombreCarteDeck.Text = blackjackGame.PaqueCarte.ListeCarte1.Count.ToString();
        }

        private void dealerPiocheEncore()
        {

            blackjackGame.JoueurDealer.dealerPiocheEncore();
            afficherCarte(blackjackGame.JoueurDealer.Main, panel2, true);
            labelValueDealer.Text = blackjackGame.JoueurDealer.Main.ValeurMain1.ToString();
            labelNombreCarteDeck.Text = blackjackGame.PaqueCarte.ListeCarte1.Count.ToString();
        }

       

        private void afficherCarte(MainJoueur mainJoueur, Panel panel, bool dealer)
        {
            Size size = new Size(104, 136);
            int decalage = 100;
            
            mainJoueur.CarteMainJoueur1.Count();
            // affiche les carte des la main du joueur quand il décide de piocher

            panel.Controls.Clear();


            for (int i = 0; i < mainJoueur.CarteMainJoueur1.Count(); i++)
            {
                
                pictureCarte = new PictureBox();
               
                pictureCarte.Size = size;
               
                pictureCarte.Name = i.ToString();

                pictureCarte.Image = mainJoueur.CarteMainJoueur1[i].Image1;                   
                pictureCarte.Location = new System.Drawing.Point(50+decalage, 50);
                pictureCarte.Invalidate();
                panel.Controls.Add(pictureCarte);
                decalage += 100;
                
                

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          int mise = 0;          
          miseVue.ShowDialog();
          

        }



        private void buttonStand_Click(object sender, EventArgs e)
        {
            dealerPiocheEncore();
            messageBox(blackjackGame.GameOver());
        }
           
        public void SupprimerCarte(Panel panel)
        {

            foreach (Control p in panel.Controls)
            {
                if (p is PictureBox)
                {
                    this.Controls.Remove(p);
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void bankGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void bankrollLabel_Click(object sender, EventArgs e)
        {

        }

        private void betAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void dealButton_Click(object sender, EventArgs e)
        {

            int value = 0;

           if( blackjackGame.Joueur1.miser(value = Convert.ToInt32(betListe.Value)) == false)
            { MessageBox.Show("plus petite vlaue "); }

            labelArgentMise.Text = blackjackGame.Joueur1.Pot.ToString();
            labelArgentJoueur.Text = blackjackGame.Joueur1.SommeArgent1.ToString();

            debloquebouton();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void NewGame()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            blackjackGame.NouvellePartie();
            labelValueDealer.Text = "0";
            labelValueJoueur.Text = "0";
            labelArgentMise.Text = "0";
            labelArgentJoueur.Text = blackjackGame.Joueur1.SommeArgent1.ToString();
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
            buttonSplit.Enabled = false;

        }

        public void debloquebouton()
        {
            if ( labelArgentMise.Text != "0")
            {
                buttonHit.Enabled = true;
                buttonStand.Enabled = true;
            }

        }

        private void messageBox(string messageDesortie)
        {
        

            DialogResult result = MessageBox.Show(messageDesortie, "Voulez vous rejouer ? ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NewGame();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void labelArgentMise_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lableCarteDeck_Click(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            Carte test = new Carte();

            test = blackjackGame.Joueur1.Main.premiereCarteAjouter();
            test.GetimageCache();
            

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan temps = chrono.Elapsed;
            labelTemps.Text = string.Format("{0:00}:{1:00}:{2:00}", temps.Hours, temps.Minutes,temps.Seconds);

        }

        private void labelValueDealer_Click(object sender, EventArgs e)
        {

        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            
     

        }

        private void buttonSplit_Click_1(object sender, EventArgs e)
        {
            blackjackGame.Joueur1.SplitDeck();
            afficherCarte(blackjackGame.Joueur1.Main, panel1, false);
            afficherCarte(blackjackGame.Joueur1.Main2, panel3, false);
        }
    }
}
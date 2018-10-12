namespace Blackjack
{
    partial class Form1


    {
        
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelValueJoueur = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelValueDealer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelArgentJoueur = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.betListe = new System.Windows.Forms.NumericUpDown();
            this.labelArgentMise = new System.Windows.Forms.Label();
            this.labelNombreCarteDeck = new System.Windows.Forms.Label();
            this.btTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelTemps = new System.Windows.Forms.Label();
            this.lablesommeicone = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSplit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.betListe)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(284, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 201);
            this.panel1.TabIndex = 15;
            // 
            // labelValueJoueur
            // 
            this.labelValueJoueur.AutoSize = true;
            this.labelValueJoueur.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueJoueur.ForeColor = System.Drawing.Color.Black;
            this.labelValueJoueur.Location = new System.Drawing.Point(459, 301);
            this.labelValueJoueur.Name = "labelValueJoueur";
            this.labelValueJoueur.Size = new System.Drawing.Size(22, 25);
            this.labelValueJoueur.TabIndex = 21;
            this.labelValueJoueur.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(249, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Valeur des carte du joueur";
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(332, 554);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(96, 59);
            this.buttonHit.TabIndex = 5;
            this.buttonHit.Text = "HIT";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // buttonStand
            // 
            this.buttonStand.Location = new System.Drawing.Point(434, 554);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(96, 59);
            this.buttonStand.TabIndex = 7;
            this.buttonStand.Text = "STAND";
            this.buttonStand.UseVisualStyleBackColor = true;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(304, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 239);
            this.panel2.TabIndex = 5;
            // 
            // labelValueDealer
            // 
            this.labelValueDealer.AutoSize = true;
            this.labelValueDealer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueDealer.ForeColor = System.Drawing.Color.Black;
            this.labelValueDealer.Location = new System.Drawing.Point(459, 6);
            this.labelValueDealer.Name = "labelValueDealer";
            this.labelValueDealer.Size = new System.Drawing.Size(22, 25);
            this.labelValueDealer.TabIndex = 19;
            this.labelValueDealer.Text = "0";
            this.labelValueDealer.Click += new System.EventHandler(this.labelValueDealer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(231, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Valeur des carte du dealeur";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bet :";
            // 
            // labelArgentJoueur
            // 
            this.labelArgentJoueur.AutoSize = true;
            this.labelArgentJoueur.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArgentJoueur.ForeColor = System.Drawing.Color.Black;
            this.labelArgentJoueur.Location = new System.Drawing.Point(128, 359);
            this.labelArgentJoueur.Name = "labelArgentJoueur";
            this.labelArgentJoueur.Size = new System.Drawing.Size(22, 25);
            this.labelArgentJoueur.TabIndex = 17;
            this.labelArgentJoueur.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Somme :";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(536, 554);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(96, 59);
            this.buttonNewGame.TabIndex = 19;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // dealButton
            // 
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dealButton.Location = new System.Drawing.Point(51, 554);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(99, 55);
            this.dealButton.TabIndex = 6;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // betListe
            // 
            this.betListe.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.betListe.Location = new System.Drawing.Point(116, 441);
            this.betListe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betListe.Name = "betListe";
            this.betListe.Size = new System.Drawing.Size(61, 20);
            this.betListe.TabIndex = 5;
            this.betListe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.betListe.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelArgentMise
            // 
            this.labelArgentMise.AutoSize = true;
            this.labelArgentMise.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArgentMise.ForeColor = System.Drawing.Color.Black;
            this.labelArgentMise.Location = new System.Drawing.Point(663, 291);
            this.labelArgentMise.Name = "labelArgentMise";
            this.labelArgentMise.Size = new System.Drawing.Size(22, 25);
            this.labelArgentMise.TabIndex = 23;
            this.labelArgentMise.Text = "0";
            this.labelArgentMise.Click += new System.EventHandler(this.labelArgentMise_Click);
            // 
            // labelNombreCarteDeck
            // 
            this.labelNombreCarteDeck.AutoSize = true;
            this.labelNombreCarteDeck.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCarteDeck.ForeColor = System.Drawing.Color.Black;
            this.labelNombreCarteDeck.Location = new System.Drawing.Point(24, 41);
            this.labelNombreCarteDeck.Name = "labelNombreCarteDeck";
            this.labelNombreCarteDeck.Size = new System.Drawing.Size(19, 23);
            this.labelNombreCarteDeck.TabIndex = 25;
            this.labelNombreCarteDeck.Text = "0";
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(1071, 570);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(61, 114);
            this.btTest.TabIndex = 27;
            this.btTest.Text = "button1";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelTemps);
            this.groupBoxInfo.Controls.Add(this.lablesommeicone);
            this.groupBoxInfo.Controls.Add(this.pictureBox4);
            this.groupBoxInfo.Controls.Add(this.pictureBox1);
            this.groupBoxInfo.Controls.Add(this.pictureBox3);
            this.groupBoxInfo.Controls.Add(this.labelNombreCarteDeck);
            this.groupBoxInfo.Location = new System.Drawing.Point(937, 57);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(178, 466);
            this.groupBoxInfo.TabIndex = 29;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info de la partie";
            this.groupBoxInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelTemps
            // 
            this.labelTemps.AutoSize = true;
            this.labelTemps.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemps.ForeColor = System.Drawing.Color.Black;
            this.labelTemps.Location = new System.Drawing.Point(24, 205);
            this.labelTemps.Name = "labelTemps";
            this.labelTemps.Size = new System.Drawing.Size(52, 23);
            this.labelTemps.TabIndex = 32;
            this.labelTemps.Text = "label2";
            // 
            // lablesommeicone
            // 
            this.lablesommeicone.AutoSize = true;
            this.lablesommeicone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablesommeicone.ForeColor = System.Drawing.Color.Black;
            this.lablesommeicone.Location = new System.Drawing.Point(24, 128);
            this.lablesommeicone.Name = "lablesommeicone";
            this.lablesommeicone.Size = new System.Drawing.Size(19, 23);
            this.lablesommeicone.TabIndex = 31;
            this.lablesommeicone.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Blackjack.Properties.Resources.hourglass;
            this.pictureBox4.Location = new System.Drawing.Point(127, 195);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blackjack.Properties.Resources.wallet;
            this.pictureBox1.Location = new System.Drawing.Point(127, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Blackjack.Properties.Resources.poker_game;
            this.pictureBox3.Location = new System.Drawing.Point(131, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 30);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(580, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mise: ";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 201);
            this.panel3.TabIndex = 31;
            // 
            // buttonSplit
            // 
            this.buttonSplit.Location = new System.Drawing.Point(638, 554);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(96, 59);
            this.buttonSplit.TabIndex = 31;
            this.buttonSplit.Text = "SPLIT";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1127, 647);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.labelArgentMise);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.labelValueJoueur);
            this.Controls.Add(this.betListe);
            this.Controls.Add(this.labelValueDealer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelArgentJoueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betListe)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelArgentJoueur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelValueJoueur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelValueDealer;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.NumericUpDown betListe;
        private System.Windows.Forms.Label labelArgentMise;
        private System.Windows.Forms.Label labelNombreCarteDeck;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelTemps;
        private System.Windows.Forms.Label lablesommeicone;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSplit;
    }
}


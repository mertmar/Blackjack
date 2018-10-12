using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form2 : Form
    {

        private string SommeMisée;

        public string SommeMisée1
        {
            get
            {
                return SommeMisée;
            }

            set
            {
                SommeMisée = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "0";
        
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SommeMisée = textBox1.Text;
            Application.Exit();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Affiche(string Somme)

        {
            

        }
    }
}

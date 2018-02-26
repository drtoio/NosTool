using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NosTool
{
    public partial class benefCalc : Form
    {

        private int prixNb1;
        private int nbGeante1 = 30;
        private int nbFlacon1 = 20 ;
        private int nbPotion1 = 20 ;
        private int nbMaquereau1 = 3 ;
        private int quantite;
        private int prixGeant;
        private int prixMaquerea;
        private int coutProd;
        private int benef;
        public benefCalc()
        {
            InitializeComponent();
        }

        private void full4_TextChanged(object sender, EventArgs e)
        {

        }

        private void full3_TextChanged(object sender, EventArgs e)
        {

        }

        private void full2_TextChanged(object sender, EventArgs e)
        {

        }

        private void full1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcul_Click(object sender, EventArgs e)
        {
            prixNb1 = Convert.ToInt32(fullDepart.Text);
            quantite = Convert.ToInt32(quantiteProd.Text);
            prixGeant = Convert.ToInt32(prixGeante.Text);
            prixMaquerea = Convert.ToInt32(prixMaquereau.Text);
            coutProd = ((prixGeant * nbGeante1 * quantite) + (nbFlacon1 * quantite * 500) + (nbPotion1 * quantite * 100) + (prixMaquerea * nbMaquereau1 * quantite));
            benef = (prixNb1*10*quantite) - coutProd;
            benefFinal.Text = Convert.ToString(benef);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

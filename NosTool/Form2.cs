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
    public partial class parfum : Form
    {
        private int rParfum;
        private int lvlParfum;
        private int amountParfum;
        public parfum()
        {
            InitializeComponent();
            //this.Cursor = new Cursor(GetType(), "dague2.cur");

        }

        private int CalculateParfum(int lvlParfum,int rParfum)
        {
            int nbParfum = 0;

            //lvl 1 - 24
            if (this.lvlParfum == 0)
            {
                if (this.rParfum == 0 || this.rParfum == 1 || this.rParfum == 2 || this.rParfum == 3 || this.rParfum == 4 || this.rParfum == 5 || this.rParfum == 6 || this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }

            }


            //lvl 25-39
            else if (this.rParfum == 1)
            {
                if (this.rParfum == 0 || this.rParfum == 1 || this.rParfum == 2 || this.rParfum == 3 || this.rParfum == 4 || this.rParfum == 7)
                    this.amountParfum = 0;
            }

            else if (this.lvlParfum == 1 && this.rParfum == 5)
            {
                this.amountParfum = 5;
            }

            else if (this.lvlParfum == 1 && this.rParfum == 6)
            {
                this.amountParfum = 10;
            }

            //lvl 40-49
            else if (this.lvlParfum == 2)
            {
                if (this.rParfum == 1 || this.rParfum == 7 || this.rParfum == 0)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 2 && this.rParfum == 2) this.amountParfum = 5;
                else if (this.lvlParfum == 2 && this.rParfum == 3) this.amountParfum = 5;
                else if (this.lvlParfum == 2 && this.rParfum == 4) this.amountParfum = 10;
                else if (this.lvlParfum == 2 && this.rParfum == 5) this.amountParfum = 20;
                else if (this.lvlParfum == 2 && this.rParfum == 6) this.amountParfum = 40;
            }
            //lvl 50-59

            else if (this.lvlParfum == 3)
            {
                if (this.rParfum == 0 || this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 3 && this.rParfum == 1) this.amountParfum = 5;
                else if (this.lvlParfum == 3 && this.rParfum == 2) this.amountParfum = 10;
                else if (this.lvlParfum == 3 && this.rParfum == 3) this.amountParfum = 10;
                else if (this.lvlParfum == 3 && this.rParfum == 4) this.amountParfum = 20;
                else if (this.lvlParfum == 3 && this.rParfum == 5) this.amountParfum = 40;
                else if (this.lvlParfum == 3 && this.rParfum == 6) this.amountParfum = 80;
            }

            //lvl 60-69
            else if (this.lvlParfum == 4)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 4 && this.rParfum == 0) this.amountParfum = 5;
                else if (this.lvlParfum == 4 && this.rParfum == 1) this.amountParfum = 10;
                else if (this.lvlParfum == 4 && this.rParfum == 2) this.amountParfum = 10;
                else if (this.lvlParfum == 4 && this.rParfum == 3) this.amountParfum = 20;
                else if (this.lvlParfum == 4 && this.rParfum == 4) this.amountParfum = 40;
                else if (this.lvlParfum == 4 && this.rParfum == 5) this.amountParfum = 80;
                else if (this.lvlParfum == 4 && this.rParfum == 6) this.amountParfum = 120;
            }

            //lvl 70-79
            else if (this.lvlParfum == 5)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 5 && this.rParfum == 0) this.amountParfum = 10;
                else if (this.lvlParfum == 5 && this.rParfum == 1) this.amountParfum = 10;
                else if (this.lvlParfum == 5 && this.rParfum == 2) this.amountParfum = 20;
                else if (this.lvlParfum == 5 && this.rParfum == 3) this.amountParfum = 40;
                else if (this.lvlParfum == 5 && this.rParfum == 4) this.amountParfum = 80;
                else if (this.lvlParfum == 5 && this.rParfum == 5) this.amountParfum = 120;
                else if (this.lvlParfum == 5 && this.rParfum == 6) this.amountParfum = 160;
            }

            //lvl 80-89
            else if (this.lvlParfum == 6)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 6 && this.rParfum == 0) this.amountParfum = 10;
                else if (this.lvlParfum == 6 && this.rParfum == 1) this.amountParfum = 20;
                else if (this.lvlParfum == 6 && this.rParfum == 2) this.amountParfum = 40;
                else if (this.lvlParfum == 6 && this.rParfum == 3) this.amountParfum = 80;
                else if (this.lvlParfum == 6 && this.rParfum == 4) this.amountParfum = 120;
                else if (this.lvlParfum == 6 && this.rParfum == 5) this.amountParfum = 160;
                else if (this.lvlParfum == 6 && this.rParfum == 6) this.amountParfum = 200;
            }

            //lvl 90-99
            else if (this.lvlParfum == 7)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 7 && this.rParfum == 0) this.amountParfum = 20;
                else if (this.lvlParfum == 7 && this.rParfum == 1) this.amountParfum = 40;
                else if (this.lvlParfum == 7 && this.rParfum == 2) this.amountParfum = 80;
                else if (this.lvlParfum == 7 && this.rParfum == 3) this.amountParfum = 120;
                else if (this.lvlParfum == 7 && this.rParfum == 4) this.amountParfum = 160;
                else if (this.lvlParfum == 7 && this.rParfum == 5) this.amountParfum = 200;
                else if (this.lvlParfum == 7 && this.rParfum == 6) this.amountParfum = 300;
            }

            //lvl +25
            else if (this.lvlParfum == 8)
            {

                if (this.lvlParfum == 8 && this.rParfum == 0) this.amountParfum = 65;
                else if (this.lvlParfum == 8 && this.rParfum == 1) this.amountParfum = 105;
                else if (this.lvlParfum == 8 && this.rParfum == 2) this.amountParfum = 145;
                else if (this.lvlParfum == 8 && this.rParfum == 3) this.amountParfum = 185;
                else if (this.lvlParfum == 8 && this.rParfum == 4) this.amountParfum = 225;
                else if (this.lvlParfum == 8 && this.rParfum == 5) this.amountParfum = 265;
                else if (this.lvlParfum == 8 && this.rParfum == 6) this.amountParfum = 305;
                else if (this.lvlParfum == 8 && this.rParfum == 7) this.amountParfum = 345;
            }

            //lvl +28
            else if (this.lvlParfum == 9)
            {

                if (this.lvlParfum == 9 && this.rParfum == 0) this.amountParfum = 68;
                else if (this.lvlParfum == 9 && this.rParfum == 1) this.amountParfum = 108;
                else if (this.lvlParfum == 9 && this.rParfum == 2) this.amountParfum = 148;
                else if (this.lvlParfum == 9 && this.rParfum == 3) this.amountParfum = 188;
                else if (this.lvlParfum == 9 && this.rParfum == 4) this.amountParfum = 228;
                else if (this.lvlParfum == 9 && this.rParfum == 5) this.amountParfum = 268;
                else if (this.lvlParfum == 9 && this.rParfum == 6) this.amountParfum = 308;
                else if (this.lvlParfum == 9 && this.rParfum == 7) this.amountParfum = 348;
            }

            //lvl +45 et +48

            else if (this.lvlParfum == 10 || this.lvlParfum == 11)
            {
                this.amountParfum = 999;
            }

            return amountParfum;
        }

        private void rare_parfum_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (this.rare_parfum.SelectedIndex)
            {
                case 0:
                    this.rParfum = 0;
                    break;

                case 1:
                    this.rParfum = 1;
                    break;

                case 2:
                    this.rParfum = 2;
                    break;

                case 3:
                    this.rParfum = 3;
                    break;

                case 4:
                    this.rParfum = 4;
                    break;

                case 5:
                    this.rParfum = 5;
                    break;

                case 6:
                    this.rParfum = 6;
                    break;

                case 7:
                    this.rParfum = 7;
                    break;
            }

            nb_parfum.Text = Convert.ToString(CalculateParfum(lvlParfum,rParfum));
               

         }

        private void lvl_parfum_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (this.lvl_parfum.SelectedIndex)
            {
                case 0:
                    this.lvlParfum = 0;
                    break;

                case 1:
                    this.lvlParfum = 1;
                    break;

                case 2:
                    this.lvlParfum = 2;
                    break;

                case 3:
                    this.lvlParfum = 3;
                    break;

                case 4:
                    this.lvlParfum = 4;
                    break;

                case 5:
                    this.lvlParfum = 5;
                    break;

                case 6:
                    this.lvlParfum = 6;
                    break;

                case 7:
                    this.lvlParfum = 7;
                    break;

                case 8:
                    this.lvlParfum = 8;
                    break;

                case 9:
                    this.lvlParfum = 9;
                    break;

                case 10:
                    this.lvlParfum = 10;
                    break;

                case 11:
                    this.lvlParfum = 11;
                    break;
            }

            nb_parfum.Text = Convert.ToString(CalculateParfum(lvlParfum, rParfum));
                     
            
        }

        private void nb_parfum_TextChanged(object sender, EventArgs e)
        {
            
        }

        /*private void calculer_parfum_Click(object sender, EventArgs e)
        {
            /*
            //lvl 1 - 24
            if (this.lvlParfum == 0)
            {
                if (this.rParfum == 0 || this.rParfum == 1 || this.rParfum == 2 || this.rParfum == 3 || this.rParfum == 4 || this.rParfum == 5 || this.rParfum == 6 || this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }

            }


            //lvl 25-39
            else if (this.rParfum == 1)
            {
                if (this.rParfum == 0 || this.rParfum == 1 || this.rParfum == 2 || this.rParfum == 3 || this.rParfum == 4 || this.rParfum == 7)
                    this.amountParfum = 0;
            }

            else if (this.lvlParfum == 1 && this.rParfum == 5)
            {
                this.amountParfum = 5;
            }

            else if (this.lvlParfum == 1 && this.rParfum == 6)
            {
                this.amountParfum = 10;
            }

            //lvl 40-49
            else if (this.lvlParfum == 2)
            {
                if (this.rParfum == 1 || this.rParfum == 7 || this.rParfum == 0)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 2 && this.rParfum == 2) this.amountParfum = 5;
                else if (this.lvlParfum == 2 && this.rParfum == 3) this.amountParfum = 5;
                else if (this.lvlParfum == 2 && this.rParfum == 4) this.amountParfum = 10;
                else if (this.lvlParfum == 2 && this.rParfum == 5) this.amountParfum = 20;
                else if (this.lvlParfum == 2 && this.rParfum == 6) this.amountParfum = 40;
            }
            //lvl 50-59

            else if (this.lvlParfum == 3)
            {
                if (this.rParfum == 0 || this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 3 && this.rParfum == 1) this.amountParfum = 5;
                else if (this.lvlParfum == 3 && this.rParfum == 2) this.amountParfum = 10;
                else if (this.lvlParfum == 3 && this.rParfum == 3) this.amountParfum = 10;
                else if (this.lvlParfum == 3 && this.rParfum == 4) this.amountParfum = 20;
                else if (this.lvlParfum == 3 && this.rParfum == 5) this.amountParfum = 40;
                else if (this.lvlParfum == 3 && this.rParfum == 6) this.amountParfum = 80;
            }

            //lvl 60-69
            else if (this.lvlParfum == 4)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 4 && this.rParfum == 0) this.amountParfum = 5;
                else if (this.lvlParfum == 4 && this.rParfum == 1) this.amountParfum = 10;
                else if (this.lvlParfum == 4 && this.rParfum == 2) this.amountParfum = 10;
                else if (this.lvlParfum == 4 && this.rParfum == 3) this.amountParfum = 20;
                else if (this.lvlParfum == 4 && this.rParfum == 4) this.amountParfum = 40;
                else if (this.lvlParfum == 4 && this.rParfum == 5) this.amountParfum = 80;
                else if (this.lvlParfum == 4 && this.rParfum == 6) this.amountParfum = 120;
            }

            //lvl 70-79
            else if (this.lvlParfum == 5)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 5 && this.rParfum == 0) this.amountParfum = 10;
                else if (this.lvlParfum == 5 && this.rParfum == 1) this.amountParfum = 10;
                else if (this.lvlParfum == 5 && this.rParfum == 2) this.amountParfum = 20;
                else if (this.lvlParfum == 5 && this.rParfum == 3) this.amountParfum = 40;
                else if (this.lvlParfum == 5 && this.rParfum == 4) this.amountParfum = 80;
                else if (this.lvlParfum == 5 && this.rParfum == 5) this.amountParfum = 120;
                else if (this.lvlParfum == 5 && this.rParfum == 6) this.amountParfum = 160;
            }

            //lvl 80-89
            else if (this.lvlParfum == 6)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 6 && this.rParfum == 0) this.amountParfum = 10;
                else if (this.lvlParfum == 6 && this.rParfum == 1) this.amountParfum = 20;
                else if (this.lvlParfum == 6 && this.rParfum == 2) this.amountParfum = 40;
                else if (this.lvlParfum == 6 && this.rParfum == 3) this.amountParfum = 80;
                else if (this.lvlParfum == 6 && this.rParfum == 4) this.amountParfum = 120;
                else if (this.lvlParfum == 6 && this.rParfum == 5) this.amountParfum = 160;
                else if (this.lvlParfum == 6 && this.rParfum == 6) this.amountParfum = 200;
            }

            //lvl 90-99
            else if (this.lvlParfum == 7)
            {
                if (this.rParfum == 7)
                {
                    this.amountParfum = 0;
                }
                else if (this.lvlParfum == 7 && this.rParfum == 0) this.amountParfum = 20;
                else if (this.lvlParfum == 7 && this.rParfum == 1) this.amountParfum = 40;
                else if (this.lvlParfum == 7 && this.rParfum == 2) this.amountParfum = 80;
                else if (this.lvlParfum == 7 && this.rParfum == 3) this.amountParfum = 120;
                else if (this.lvlParfum == 7 && this.rParfum == 4) this.amountParfum = 160;
                else if (this.lvlParfum == 7 && this.rParfum == 5) this.amountParfum = 200;
                else if (this.lvlParfum == 7 && this.rParfum == 6) this.amountParfum = 300;
            }

            //lvl +25
            else if (this.lvlParfum == 8)
            {
                
                if (this.lvlParfum == 8 && this.rParfum == 0) this.amountParfum = 65;
                else if (this.lvlParfum == 8 && this.rParfum == 1) this.amountParfum = 105;
                else if (this.lvlParfum == 8 && this.rParfum == 2) this.amountParfum = 145;
                else if (this.lvlParfum == 8 && this.rParfum == 3) this.amountParfum = 185;
                else if (this.lvlParfum == 8 && this.rParfum == 4) this.amountParfum = 225;
                else if (this.lvlParfum == 8 && this.rParfum == 5) this.amountParfum = 265;
                else if (this.lvlParfum == 8 && this.rParfum == 6) this.amountParfum = 305;
                else if (this.lvlParfum == 8 && this.rParfum == 7) this.amountParfum = 345;
            }

            //lvl +28
            else if (this.lvlParfum == 9)
            {

                if (this.lvlParfum == 9 && this.rParfum == 0) this.amountParfum = 68;
                else if (this.lvlParfum == 9 && this.rParfum == 1) this.amountParfum = 108;
                else if (this.lvlParfum == 9 && this.rParfum == 2) this.amountParfum = 148;
                else if (this.lvlParfum == 9 && this.rParfum == 3) this.amountParfum = 188;
                else if (this.lvlParfum == 9 && this.rParfum == 4) this.amountParfum = 228;
                else if (this.lvlParfum == 9 && this.rParfum == 5) this.amountParfum = 268;
                else if (this.lvlParfum == 9 && this.rParfum == 6) this.amountParfum = 308;
                else if (this.lvlParfum == 9 && this.rParfum == 7) this.amountParfum = 348;
            }

            //lvl +45 et +48

        else if(this.lvlParfum == 10 || this.lvlParfum == 11)
            {
                this.amountParfum = 999;                    
            }

            nb_parfum.Text = Convert.ToString(this.amountParfum);
            this.amountParfum = 0;
            */

        //}
        

        private void parfum_Load(object sender, EventArgs e)
        {

        }
    }
}

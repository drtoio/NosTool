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
    public partial class upsp2 : Form
    {
        public upsp2()
        {
            InitializeComponent();
        }

        int augmenteAtkAtk = 0;
        int augmentePreci = 0;
        int augmenteChanceCc = 0;
        int augmenteDegatsCc = 0;
        int augmenteHpAtk = 0;
        int augmenteMpAtk = 0;

        int augmenteHpDef = 0;
        int augmenteResistsDef = 0;
        int augmenteEsquiDef = 0;
        int reduitDegatsCc = 0;

        int augmenteElem = 0;
        int augmenteMpElem = 0;
        int augmenteResistsElem = 0;

        int augmenteAtkHp = 0;
        int augmenteDef = 0;
        int augmenteResistsHp = 0;
        int augmenteEsquiHp = 0;
        int reduitCc = 0;


        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void pointsAttaque_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvlSp_TextChanged(object sender, EventArgs e)
        {

        }

        private void upsp2_Load(object sender, EventArgs e)
        {

        }

        private void timerSp_Tick(object sender, EventArgs e)
        {
            int lvlsp;
            if(int.TryParse(lvlSp.Text,out lvlsp))
            {

            }
            else
            {

            }


            int plussp;
            if (int.TryParse(plusSp.Text, out plussp))
            {

            }
            else
            {

            }

            if (plussp > 15)
            {
                plussp = 15;
                plusSp.Text = Convert.ToString(plussp);
            }

            int pointsAtk;            
            if (int.TryParse(pointsAttaque.Text, out pointsAtk))
            {

            }
            else
            {

            }

            if (pointsAtk > 100)
            {
                pointsAtk = 100;
                pointsAttaque.Text = Convert.ToString(pointsAtk);
            }

            int pointsDef;
            if (int.TryParse(pointsDefense.Text, out pointsDef))
            {

            }
            else
            {

            }

            if (pointsDef > 100)
            {
                pointsDef = 100;
                pointsDefense.Text = Convert.ToString(pointsDef);
            }

            int pointsElem;
            if (int.TryParse(pointsElement.Text, out pointsElem))
            {

            }
            else
            {

            }

            if (pointsElem > 100)
            {
                pointsElem = 100;
                pointsElement.Text = Convert.ToString(pointsElem);
            }

            int pointsHp;
            if (int.TryParse(pointsHPMP.Text, out pointsHp))
            {

            }
            else
            {

            }

            if (pointsHp > 100)
            {
                pointsHp = 100;
                pointsHPMP.Text = Convert.ToString(pointsHp);
            }

            int slAtk;
            if (int.TryParse(slAttaque.Text, out slAtk))
            {

            }
            else
            {

            }

            int slDef;
            if (int.TryParse(slDefense.Text, out slDef))
            {

            }
            else
            {

            }

            int slElem;
            if (int.TryParse(slEelement.Text, out slElem))
            {

            }
            else
            {

            }

            int slHp;
            if (int.TryParse(slHPMP.Text, out slHp))
            {

            }
            else
            {

            }

            int slGene;
            if (int.TryParse(slGenerale.Text, out slGene))
            {

            }
            else
            {

            }

            


            int pointsRestantsUp = 0;
            int pointsRestantsSp=0;
            if (lvlsp > 20)
            {
                pointsRestantsSp = (lvlsp - 20) * 3;
            }
            else pointsRestantsSp = 0;

            int coutPointAtk=0;
            int bonusAtk = 0;
            switch(pointsAtk)
            {
                case 0:
                    coutPointAtk = 0;
                    bonusAtk = 0;
                    augmenteAtkAtk = 0;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 1:
                    coutPointAtk = 1;
                    bonusAtk = 5;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 2:
                    coutPointAtk = 2;
                    bonusAtk = 10;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 3:
                    coutPointAtk = 3;
                    bonusAtk = 15;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 4:
                    coutPointAtk = 4;
                    bonusAtk = 20;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 5:
                    coutPointAtk = 5;
                    bonusAtk = 25;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 6:
                    coutPointAtk = 6;
                    bonusAtk = 30;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 7:
                    coutPointAtk = 7;
                    bonusAtk = 35;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 8:
                    coutPointAtk = 8;
                    bonusAtk = 40;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 9:
                    coutPointAtk = 9;
                    bonusAtk = 45;
                    augmenteAtkAtk = 5;
                    augmentePreci = 0;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 10:
                    coutPointAtk = 10;
                    bonusAtk = 50;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 11:
                    coutPointAtk = 12;
                    bonusAtk = 56;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 12:
                    coutPointAtk = 14;
                    bonusAtk = 62;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 13:
                    coutPointAtk = 16;
                    bonusAtk = 68;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 14:
                    coutPointAtk = 18;
                    bonusAtk = 74;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 15:
                    coutPointAtk = 20;
                    bonusAtk = 80;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 16:
                    coutPointAtk = 22;
                    bonusAtk = 86;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 17:
                    coutPointAtk = 24;
                    bonusAtk = 92;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 18:
                    coutPointAtk = 26;
                    bonusAtk = 98;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 19:
                    coutPointAtk = 28;
                    bonusAtk = 104;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 0;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 20:
                    coutPointAtk = 31;
                    bonusAtk = 110;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 21:
                    coutPointAtk = 34;
                    bonusAtk = 117;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 22:
                    coutPointAtk = 37;
                    bonusAtk = 124;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 23:
                    coutPointAtk = 40;
                    bonusAtk = 131;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 24:
                    coutPointAtk = 43;
                    bonusAtk = 138;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 25:
                    coutPointAtk = 46;
                    bonusAtk = 145;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 26:
                    coutPointAtk = 49;
                    bonusAtk = 152;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 27:
                    coutPointAtk = 52;
                    bonusAtk = 159;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 28:
                    coutPointAtk = 55;
                    bonusAtk = 166;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 29:
                    coutPointAtk = 58;
                    bonusAtk = 173;
                    augmenteAtkAtk = 5;
                    augmentePreci = 10;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 30:
                    coutPointAtk = 61;
                    bonusAtk = 180;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 31:
                    coutPointAtk = 64;
                    bonusAtk = 188;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 32:
                    coutPointAtk = 67;
                    bonusAtk = 196;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 33:
                    coutPointAtk = 70;
                    bonusAtk = 204;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 34:
                    coutPointAtk = 73;
                    bonusAtk = 212;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 35:
                    coutPointAtk = 76;
                    bonusAtk = 220;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 36:
                    coutPointAtk = 79;
                    bonusAtk = 228;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 37:
                    coutPointAtk = 82;
                    bonusAtk = 236;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 38:
                    coutPointAtk = 85;
                    bonusAtk = 244;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 39:
                    coutPointAtk = 88;
                    bonusAtk = 252;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 0;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 40:
                    coutPointAtk = 92;
                    bonusAtk = 260;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 41:
                    coutPointAtk = 96;
                    bonusAtk = 269;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 42:
                    coutPointAtk = 100;
                    bonusAtk = 278;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 43:
                    coutPointAtk = 104;
                    bonusAtk = 287;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 44:
                    coutPointAtk = 108;
                    bonusAtk = 296;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 45:
                    coutPointAtk = 112;
                    bonusAtk = 305;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 46:
                    coutPointAtk = 116;
                    bonusAtk = 314;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 47:
                    coutPointAtk = 120;
                    bonusAtk = 323;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 48:
                    coutPointAtk = 124;
                    bonusAtk = 332;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 49:
                    coutPointAtk = 128;
                    bonusAtk = 341;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 0;
                    augmenteMpAtk = 0;
                    break;
                case 50:
                    coutPointAtk = 132;
                    bonusAtk = 350;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 51:
                    coutPointAtk = 136;
                    bonusAtk = 360;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 52:
                    coutPointAtk = 140;
                    bonusAtk = 370;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 53:
                    coutPointAtk = 144;
                    bonusAtk = 380;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 54:
                    coutPointAtk = 148;
                    bonusAtk = 390;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;                
                case 55:
                    coutPointAtk = 152;
                    bonusAtk = 400;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 56:
                    coutPointAtk = 156;
                    bonusAtk = 410;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 57:
                    coutPointAtk = 160;
                    bonusAtk = 420;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 58:
                    coutPointAtk = 164;
                    bonusAtk = 430;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 59:
                    coutPointAtk = 168;
                    bonusAtk = 440;
                    augmenteAtkAtk = 10;
                    augmentePreci = 20;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 60:
                    coutPointAtk = 173;
                    bonusAtk = 450;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 61:
                    coutPointAtk = 178;
                    bonusAtk = 461;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 62:
                    coutPointAtk = 183;
                    bonusAtk = 472;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 63:
                    coutPointAtk = 188;
                    bonusAtk = 483;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 64:
                    coutPointAtk = 193;
                    bonusAtk = 494;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 65:
                    coutPointAtk = 198;
                    bonusAtk = 505;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 66:
                    coutPointAtk = 203;
                    bonusAtk = 516;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 67:
                    coutPointAtk = 208;
                    bonusAtk = 527;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 68:
                    coutPointAtk = 213;
                    bonusAtk = 538;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 69:
                    coutPointAtk = 218;
                    bonusAtk = 549;
                    augmenteAtkAtk = 10;
                    augmentePreci = 35;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 70:
                    coutPointAtk = 223;
                    bonusAtk = 560;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 71:
                    coutPointAtk = 228;
                    bonusAtk = 573;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 72:
                    coutPointAtk = 233;
                    bonusAtk = 586;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 73:
                    coutPointAtk = 238;
                    bonusAtk = 599;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 74:
                    coutPointAtk = 243;
                    bonusAtk = 612;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 75:
                    coutPointAtk = 248;
                    bonusAtk = 625;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 76:
                    coutPointAtk = 253;
                    bonusAtk = 638;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 77:
                    coutPointAtk = 258;
                    bonusAtk = 651;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 78:
                    coutPointAtk = 263;
                    bonusAtk = 664;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 79:
                    coutPointAtk = 268;
                    bonusAtk = 677;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 2;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 80:
                    coutPointAtk = 274;
                    bonusAtk = 690;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 81:
                    coutPointAtk = 280;
                    bonusAtk = 704;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 82:
                    coutPointAtk = 286;
                    bonusAtk = 718;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 83:
                    coutPointAtk = 292;
                    bonusAtk = 732;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 84:
                    coutPointAtk = 298;
                    bonusAtk = 746;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 85:
                    coutPointAtk = 304;
                    bonusAtk = 760;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 86:
                    coutPointAtk = 310;
                    bonusAtk = 774;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 87:
                    coutPointAtk = 316;
                    bonusAtk = 788;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 88:
                    coutPointAtk = 322;
                    bonusAtk = 802;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 89:
                    coutPointAtk = 328;
                    bonusAtk = 816;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 10;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 90:
                    coutPointAtk = 334;
                    bonusAtk = 830;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 91:
                    coutPointAtk = 341;
                    bonusAtk = 845;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 92:
                    coutPointAtk = 348;
                    bonusAtk = 860;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 93:
                    coutPointAtk = 355;
                    bonusAtk = 875;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 94:
                    coutPointAtk = 362;
                    bonusAtk = 890;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 95:
                    coutPointAtk = 369;
                    bonusAtk = 906;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 96:
                    coutPointAtk = 376;
                    bonusAtk = 923;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 97:
                    coutPointAtk = 383;
                    bonusAtk = 940;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 98:
                    coutPointAtk = 391;
                    bonusAtk = 960;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 99:
                    coutPointAtk = 400;
                    bonusAtk = 960;
                    augmenteAtkAtk = 15;
                    augmentePreci = 50;
                    augmenteChanceCc = 5;
                    augmenteDegatsCc = 30;
                    augmenteHpAtk = 200;
                    augmenteMpAtk = 200;
                    break;
                case 100:
                    coutPointAtk = 410;
                    bonusAtk = 1000;
                    augmenteAtkAtk = 20;
                    augmentePreci = 70;
                    augmenteChanceCc = 8;
                    augmenteDegatsCc = 50;
                    augmenteHpAtk = 400;
                    augmenteMpAtk = 400;
                    break;
            }

            
            int coutPointDef=0;
            int bonusDef = 0;
            switch (pointsDef)
            {
                case 0:
                    coutPointDef = 0;
                    bonusDef = 0;
                    augmenteEsquiDef = 0;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;                    
                    augmenteResistsDef = 0;
                    break;
                case 1:
                    coutPointDef = 1;
                    bonusDef = 1;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 2:
                    coutPointDef = 2;
                    bonusDef = 2;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 3:
                    coutPointDef = 3;
                    bonusDef = 3;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 4:
                    coutPointDef = 4;
                    bonusDef = 4;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 5:
                    coutPointDef = 5;
                    bonusDef = 5;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 6:
                    coutPointDef = 6;
                    bonusDef = 6;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 7:
                    coutPointDef = 7;
                    bonusDef = 7;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 8:
                    coutPointDef = 8;
                    bonusDef = 8;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 9:
                    coutPointDef = 9;
                    bonusDef = 9;
                    
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    augmenteEsquiDef = 0;
                    augmenteResistsDef = 0;
                    break;
                case 10:
                    coutPointDef = 10;
                    bonusDef = 10;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 11:
                    coutPointDef = 12;
                    bonusDef = 12;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 12:
                    coutPointDef = 14;
                    bonusDef = 14;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 13:
                    coutPointDef = 16;
                    bonusDef = 16;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 14:
                    coutPointDef = 18;
                    bonusDef = 18;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 15:
                    coutPointDef = 20;
                    bonusDef = 20;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 16:
                    coutPointDef = 22;
                    bonusDef = 22;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 17:
                    coutPointDef = 24;
                    bonusDef = 24;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 18:
                    coutPointDef = 26;
                    bonusDef = 26;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 19:
                    coutPointDef = 28;
                    bonusDef = 28;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 0;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 20:
                    coutPointDef = 30;
                    bonusDef = 30;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 21:
                    coutPointDef = 32;
                    bonusDef = 33;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 22:
                    coutPointDef = 34;
                    bonusDef = 36;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 23:
                    coutPointDef = 36;
                    bonusDef = 39;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 24:
                    coutPointDef = 38;
                    bonusDef = 42;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 25:
                    coutPointDef = 40;
                    bonusDef = 45;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 26:
                    coutPointDef = 42;
                    bonusDef = 48;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 27:
                    coutPointDef = 44;
                    bonusDef = 51;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 28:
                    coutPointDef = 46;
                    bonusDef = 54;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 29:
                    coutPointDef = 48;
                    bonusDef = 57;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 0;
                    
                    augmenteResistsDef = 0;
                    break;
                case 30:
                    coutPointDef = 51;
                    bonusDef = 60;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 31:
                    coutPointDef = 54;
                    bonusDef = 64;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 32:
                    coutPointDef = 57;
                    bonusDef = 68;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 33:
                    coutPointDef = 60;
                    bonusDef = 72;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 34:
                    coutPointDef = 63;
                    bonusDef = 76;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 35:
                    coutPointDef = 66;
                    bonusDef = 80;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 36:
                    coutPointDef = 69;
                    bonusDef = 84;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 37:
                    coutPointDef = 72;
                    bonusDef = 88;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 38:
                    coutPointDef = 75;
                    bonusDef = 92;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 39:
                    coutPointDef = 78;
                    bonusDef = 96;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 2;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 40:
                    coutPointDef = 81;
                    bonusDef = 100;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 41:
                    coutPointDef = 85;
                    bonusDef = 105;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 42:
                    coutPointDef = 89;
                    bonusDef = 110;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 43:
                    coutPointDef = 93;
                    bonusDef = 115;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 44:
                    coutPointDef = 97;
                    bonusDef = 120;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 45:
                    coutPointDef = 101;
                    bonusDef = 125;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 46:
                    coutPointDef = 105;
                    bonusDef = 130;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 47:
                    coutPointDef = 109;
                    bonusDef = 135;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 48:
                    coutPointDef = 113;
                    bonusDef = 140;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 49:
                    coutPointDef = 117;
                    bonusDef = 145;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    
                    augmenteResistsDef = 0;
                    break;
                case 50:
                    coutPointDef = 121;
                    bonusDef = 150;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 51:
                    coutPointDef = 125;
                    bonusDef = 156;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 52:
                    coutPointDef = 129;
                    bonusDef = 162;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 53:
                    coutPointDef = 133;
                    bonusDef = 168;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 54:
                    coutPointDef = 137;
                    bonusDef = 174;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 55:
                    coutPointDef = 141;
                    bonusDef = 180;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 56:
                    coutPointDef = 145;
                    bonusDef = 186;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 57:
                    coutPointDef = 149;
                    bonusDef = 192;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 58:
                    coutPointDef = 153;
                    bonusDef = 198;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 59:
                    coutPointDef = 157;
                    bonusDef = 204;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 100;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 60:
                    coutPointDef = 161;
                    bonusDef = 210;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 61:
                    coutPointDef = 166;
                    bonusDef = 217;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 62:
                    coutPointDef = 171;
                    bonusDef = 224;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 63:
                    coutPointDef = 176;
                    bonusDef = 231;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 64:
                    coutPointDef = 181;
                    bonusDef = 238;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 65:
                    coutPointDef = 186;
                    bonusDef = 245;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 66:
                    coutPointDef = 191;
                    bonusDef = 252;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 67:
                    coutPointDef = 196;
                    bonusDef = 259;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 68:
                    coutPointDef = 201;
                    bonusDef = 266;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 69:
                    coutPointDef = 206;
                    bonusDef = 273;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 4;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 70:
                    coutPointDef = 211;
                    bonusDef = 280;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 71:
                    coutPointDef = 216;
                    bonusDef = 288;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 72:
                    coutPointDef = 221;
                    bonusDef = 296;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 73:
                    coutPointDef = 226;
                    bonusDef = 304;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 74:
                    coutPointDef = 231;
                    bonusDef = 312;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 75:
                    coutPointDef = 236;
                    bonusDef = 320;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 0;
                    break;
                case 76:
                    coutPointDef = 242;
                    bonusDef = 328;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 2;
                    break;
                case 77:
                    coutPointDef = 248;
                    bonusDef = 336;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 2;
                    break;
                case 78:
                    coutPointDef = 254;
                    bonusDef = 344;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 2;
                    break;
                case 79:
                    coutPointDef = 260;
                    bonusDef = 352;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 7;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 10;
                    augmenteResistsDef = 2;
                    break;
                case 80:
                    coutPointDef = 266;
                    bonusDef = 360;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 81:
                    coutPointDef = 272;
                    bonusDef = 369;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 82:
                    coutPointDef = 278;
                    bonusDef = 378;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 83:
                    coutPointDef = 284;
                    bonusDef = 387;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 84:
                    coutPointDef = 290;
                    bonusDef = 396;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 85:
                    coutPointDef = 297;
                    bonusDef = 405;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 86:
                    coutPointDef = 304;
                    bonusDef = 414;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 87:
                    coutPointDef = 311;
                    bonusDef = 423;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 88:
                    coutPointDef = 318;
                    bonusDef = 432;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 89:
                    coutPointDef = 325;
                    bonusDef = 441;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 2;
                    break;
                case 90:
                    coutPointDef = 332;
                    bonusDef = 450;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 91:
                    coutPointDef = 339;
                    bonusDef = 460;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 92:
                    coutPointDef = 346;
                    bonusDef = 470;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 93:
                    coutPointDef = 353;
                    bonusDef = 480;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 94:
                    coutPointDef = 360;
                    bonusDef = 490;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 300;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 95:
                    coutPointDef = 368;
                    bonusDef = 500;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 600;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 96:
                    coutPointDef = 376;
                    bonusDef = 510;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 600;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 97:
                    coutPointDef = 384;
                    bonusDef = 520;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 600;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 98:
                    coutPointDef = 392;
                    bonusDef = 530;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 600;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 99:
                    coutPointDef = 400;
                    bonusDef = 540;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 600;
                    augmenteEsquiDef = 20;
                    augmenteResistsDef = 5;
                    break;
                case 100:
                    coutPointDef = 410;
                    bonusDef = 550;
                    augmenteEsquiDef = 5;
                    reduitDegatsCc = 10;
                    augmenteHpDef = 600;
                    augmenteEsquiDef = 40;
                    augmenteResistsDef = 10;
                    break;
            }

            int coutPointElem=0;
            int bonusElem = 0;
            switch (pointsElem)
            {
                case 0:
                    coutPointElem = 0;
                    bonusElem = 0;
                    augmenteElem = 0;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 1:
                    coutPointElem = 1;
                    bonusElem = 1;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 2:
                    coutPointElem = 2;
                    bonusElem = 2;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 3:
                    coutPointElem = 3;
                    bonusElem = 3;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 4:
                    coutPointElem = 4;
                    bonusElem = 4;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 5:
                    coutPointElem = 5;
                    bonusElem = 5;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 6:
                    coutPointElem = 6;
                    bonusElem = 6;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 7:
                    coutPointElem = 7;
                    bonusElem = 7;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 8:
                    coutPointElem = 8;
                    bonusElem = 8;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 9:
                    coutPointElem = 9;
                    bonusElem = 9;
                    augmenteElem = 2;
                    augmenteMpElem = 0;
                    augmenteResistsElem = 0;
                    break;
                case 10:
                    coutPointElem = 10;
                    bonusElem = 10;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 11:
                    coutPointElem = 11;
                    bonusElem = 11;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 12:
                    coutPointElem = 12;
                    bonusElem = 12;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 13:
                    coutPointElem = 13;
                    bonusElem = 13;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 14:
                    coutPointElem = 14;
                    bonusElem = 14;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 15:
                    coutPointElem = 15;
                    bonusElem = 15;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 16:
                    coutPointElem = 16;
                    bonusElem = 16;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 17:
                    coutPointElem = 17;
                    bonusElem = 17;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 18:
                    coutPointElem = 18;
                    bonusElem = 18;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 19:
                    coutPointElem = 19;
                    bonusElem = 19;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 20:
                    coutPointElem = 20;
                    bonusElem = 20;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 21:
                    coutPointElem = 22;
                    bonusElem = 21;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 22:
                    coutPointElem = 24;
                    bonusElem = 22;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 23:
                    coutPointElem = 26;
                    bonusElem = 23;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 24:
                    coutPointElem = 28;
                    bonusElem = 24;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 25:
                    coutPointElem = 30;
                    bonusElem = 25;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 26:
                    coutPointElem = 32;
                    bonusElem = 26;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 27:
                    coutPointElem = 34;
                    bonusElem = 27;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 28:
                    coutPointElem = 36;
                    bonusElem = 28;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 29:
                    coutPointElem = 38;
                    bonusElem = 29;
                    augmenteElem = 2;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 0;
                    break;
                case 30:
                    coutPointElem = 40;
                    bonusElem = 30;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 31:
                    coutPointElem = 43;
                    bonusElem = 31;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 32:
                    coutPointElem = 46;
                    bonusElem = 32;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 33:
                    coutPointElem = 49;
                    bonusElem = 33;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 34:
                    coutPointElem = 52;
                    bonusElem = 34;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 35:
                    coutPointElem = 55;
                    bonusElem = 35;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 36:
                    coutPointElem = 58;
                    bonusElem = 36;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 37:
                    coutPointElem = 61;
                    bonusElem = 37;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 38:
                    coutPointElem = 64;
                    bonusElem = 38;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 39:
                    coutPointElem = 67;
                    bonusElem = 39;
                    augmenteElem = 4;
                    augmenteMpElem = 100;
                    augmenteResistsElem = 2;
                    break;
                case 40:
                    coutPointElem = 70;
                    bonusElem = 40;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 41:
                    coutPointElem = 74;
                    bonusElem = 41;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 42:
                    coutPointElem = 78;
                    bonusElem = 42;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 43:
                    coutPointElem = 82;
                    bonusElem = 43;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 44:
                    coutPointElem = 86;
                    bonusElem = 44;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 45:
                    coutPointElem = 90;
                    bonusElem = 45;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 46:
                    coutPointElem = 94;
                    bonusElem = 46;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 47:
                    coutPointElem = 98;
                    bonusElem = 47;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 48:
                    coutPointElem = 102;
                    bonusElem = 48;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 49:
                    coutPointElem = 106;
                    bonusElem = 49;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 50:
                    coutPointElem = 110;
                    bonusElem = 50;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 51:
                    coutPointElem = 115;
                    bonusElem = 52;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 52:
                    coutPointElem = 120;
                    bonusElem = 54;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 53:
                    coutPointElem = 125;
                    bonusElem = 56;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 54:
                    coutPointElem = 130;
                    bonusElem = 58;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 55:
                    coutPointElem = 135;
                    bonusElem = 60;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 56:
                    coutPointElem = 140;
                    bonusElem = 62;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 57:
                    coutPointElem = 145;
                    bonusElem = 64;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 58:
                    coutPointElem = 150;
                    bonusElem = 66;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 59:
                    coutPointElem = 155;
                    bonusElem = 68;
                    augmenteElem = 4;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 2;
                    break;
                case 60:
                    coutPointElem = 160;
                    bonusElem = 70;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 61:
                    coutPointElem = 165;
                    bonusElem = 72;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 62:
                    coutPointElem = 170;
                    bonusElem = 74;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 63:
                    coutPointElem = 175;
                    bonusElem = 76;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 64:
                    coutPointElem = 180;
                    bonusElem = 78;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 65:
                    coutPointElem = 185;
                    bonusElem = 80;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 66:
                    coutPointElem = 190;
                    bonusElem = 82;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 67:
                    coutPointElem = 195;
                    bonusElem = 84;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 68:
                    coutPointElem = 200;
                    bonusElem = 86;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 69:
                    coutPointElem = 205;
                    bonusElem = 88;
                    augmenteElem = 6;
                    augmenteMpElem = 200;
                    augmenteResistsElem = 5;
                    break;
                case 70:
                    coutPointElem = 210;
                    bonusElem = 90;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 71:
                    coutPointElem = 216;
                    bonusElem = 92;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 72:
                    coutPointElem = 222;
                    bonusElem = 94;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 73:
                    coutPointElem = 228;
                    bonusElem = 96;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 74:
                    coutPointElem = 234;
                    bonusElem = 98;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 75:
                    coutPointElem = 240;
                    bonusElem = 100;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 76:
                    coutPointElem = 246;
                    bonusElem = 102;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 77:
                    coutPointElem = 252;
                    bonusElem = 104;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 78:
                    coutPointElem = 258;
                    bonusElem = 106;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 79:
                    coutPointElem = 264;
                    bonusElem = 108;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 80:
                    coutPointElem = 270;
                    bonusElem = 110;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 81:
                    coutPointElem = 277;
                    bonusElem = 112;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 82:
                    coutPointElem = 284;
                    bonusElem = 114;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 83:
                    coutPointElem = 291;
                    bonusElem = 116;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 84:
                    coutPointElem = 298;
                    bonusElem = 118;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 85:
                    coutPointElem = 305;
                    bonusElem = 120;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 86:
                    coutPointElem = 312;
                    bonusElem = 122;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 87:
                    coutPointElem = 319;
                    bonusElem = 124;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 88:
                    coutPointElem = 326;
                    bonusElem = 126;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 89:
                    coutPointElem = 333;
                    bonusElem = 128;
                    augmenteElem = 6;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 5;
                    break;
                case 90:
                    coutPointElem = 340;
                    bonusElem = 130;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 91:
                    coutPointElem = 347;
                    bonusElem = 132;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 92:
                    coutPointElem = 354;
                    bonusElem = 134;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 93:
                    coutPointElem = 361;
                    bonusElem = 136;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 94:
                    coutPointElem = 368;
                    bonusElem = 138;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 95:
                    coutPointElem = 375;
                    bonusElem = 140;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 96:
                    coutPointElem = 382;
                    bonusElem = 142;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 97:
                    coutPointElem = 389;
                    bonusElem = 144;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 98:
                    coutPointElem = 396;
                    bonusElem = 146;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 99:
                    coutPointElem = 403;
                    bonusElem = 148;
                    augmenteElem = 8;
                    augmenteMpElem = 300;
                    augmenteResistsElem = 9;
                    break;
                case 100:
                    coutPointElem = 410;
                    bonusElem = 150;
                    augmenteElem = 10;
                    augmenteMpElem = 500;
                    augmenteResistsElem = 15;
                    break;
            }

            int coutPointHP=0;
            int bonusHp=0;
            switch (pointsHp)
            {
                case 0:
                    coutPointHP = 0;
                    bonusHp = 0;
                    augmenteAtkHp = 0;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 1:
                    coutPointHP = 1;
                    bonusHp = 1;
                    augmenteAtkHp = 0;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 2:
                    coutPointHP = 2;
                    bonusHp = 2;
                    augmenteAtkHp = 0;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 3:
                    coutPointHP = 3;
                    bonusHp = 3;
                    augmenteAtkHp = 0;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 4:
                    coutPointHP = 4;
                    bonusHp = 4;
                    augmenteAtkHp = 0;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 5:
                    coutPointHP = 5;
                    bonusHp = 5;
                    augmenteAtkHp = 5;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 6:
                    coutPointHP = 6;
                    bonusHp = 6;
                    augmenteAtkHp = 5;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 7:
                    coutPointHP = 7;
                    bonusHp = 7;
                    augmenteAtkHp = 5;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 8:
                    coutPointHP = 8;
                    bonusHp = 8;
                    augmenteAtkHp = 5;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 9:
                    coutPointHP = 9;
                    bonusHp = 9;
                    augmenteAtkHp = 5;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 10:
                    coutPointHP = 10;
                    bonusHp = 10;
                    augmenteAtkHp = 10;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 11:
                    coutPointHP = 12;
                    bonusHp = 11;
                    augmenteAtkHp = 10;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 12:
                    coutPointHP = 14;
                    bonusHp = 12;
                    augmenteAtkHp = 10;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 13:
                    coutPointHP = 16;
                    bonusHp = 13;
                    augmenteAtkHp = 10;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 14:
                    coutPointHP = 18;
                    bonusHp = 14;
                    augmenteAtkHp = 10;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 15:
                    coutPointHP = 20;
                    bonusHp = 15;
                    augmenteAtkHp = 15;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 16:
                    coutPointHP = 22;
                    bonusHp = 16;
                    augmenteAtkHp = 15;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 17:
                    coutPointHP = 24;
                    bonusHp = 17;
                    augmenteAtkHp = 15;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 18:
                    coutPointHP = 26;
                    bonusHp = 18;
                    augmenteAtkHp = 15;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 19:
                    coutPointHP = 28;
                    bonusHp = 19;
                    augmenteAtkHp = 15;
                    augmenteDef = 0;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 20:
                    coutPointHP = 30;
                    bonusHp = 20;
                    augmenteAtkHp = 20;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 21:
                    coutPointHP = 32;
                    bonusHp = 21;
                    augmenteAtkHp = 20;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 22:
                    coutPointHP = 34;
                    bonusHp = 22;
                    augmenteAtkHp = 20;
                    augmenteDef = 10;
                    break;
                case 23:
                    coutPointHP = 36;
                    bonusHp = 23;
                    augmenteAtkHp = 20;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 24:
                    coutPointHP = 38;
                    bonusHp = 24;
                    augmenteAtkHp = 20;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 25:
                    coutPointHP = 40;
                    bonusHp = 25;
                    augmenteAtkHp = 25;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 26:
                    coutPointHP = 42;
                    bonusHp = 26;
                    augmenteAtkHp = 25;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 27:
                    coutPointHP = 44;
                    bonusHp = 27;
                    augmenteAtkHp = 25;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 28:
                    coutPointHP = 46;
                    bonusHp = 28;
                    augmenteAtkHp = 25;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 29:
                    coutPointHP = 48;
                    bonusHp = 29;
                    augmenteAtkHp = 25;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 30:
                    coutPointHP = 50;
                    bonusHp = 30;
                    augmenteAtkHp = 30;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 31:
                    coutPointHP = 53;
                    bonusHp = 31;
                    augmenteAtkHp = 30;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 32:
                    coutPointHP = 56;
                    bonusHp = 32;
                    augmenteAtkHp = 30;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 33:
                    coutPointHP = 59;
                    bonusHp = 33;
                    augmenteAtkHp = 30;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 34:
                    coutPointHP = 62;
                    bonusHp = 34;
                    augmenteAtkHp = 30;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 35:
                    coutPointHP = 65;
                    bonusHp = 35;
                    augmenteAtkHp = 35;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 36:
                    coutPointHP = 68;
                    bonusHp = 36;
                    augmenteAtkHp = 35;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 37:
                    coutPointHP = 71;
                    bonusHp = 37;
                    augmenteAtkHp = 35;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 38:
                    coutPointHP = 74;
                    bonusHp = 38;
                    augmenteAtkHp = 35;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 39:
                    coutPointHP = 77;
                    bonusHp = 39;
                    augmenteAtkHp = 35;
                    augmenteDef = 10;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 40:
                    coutPointHP = 80;
                    bonusHp = 40;
                    augmenteAtkHp = 40;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 41:
                    coutPointHP = 83;
                    bonusHp = 41;
                    augmenteAtkHp = 40;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 42:
                    coutPointHP = 86;
                    bonusHp = 42;
                    augmenteAtkHp = 40;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 43:
                    coutPointHP = 89;
                    bonusHp = 43;
                    augmenteAtkHp = 40;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 44:
                    coutPointHP = 92;
                    bonusHp = 44;
                    augmenteAtkHp = 40;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 45:
                    coutPointHP = 95;
                    bonusHp = 45;
                    augmenteAtkHp = 50;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 46:
                    coutPointHP = 98;
                    bonusHp = 46;
                    augmenteAtkHp = 50;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 47:
                    coutPointHP = 101;
                    bonusHp = 47;
                    augmenteAtkHp = 50;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 48:
                    coutPointHP = 104;
                    bonusHp = 48;
                    augmenteAtkHp = 50;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 49:
                    coutPointHP = 107;
                    bonusHp = 49;
                    augmenteAtkHp = 50;
                    augmenteDef = 25;
                    augmenteResistsHp = 0;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 50:
                    coutPointHP = 110;
                    bonusHp = 50;
                    augmenteAtkHp = 60;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 51:
                    coutPointHP = 114;
                    bonusHp = 52;
                    augmenteAtkHp = 60;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 52:
                    coutPointHP = 118;
                    bonusHp = 54;
                    augmenteAtkHp = 60;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 53:
                    coutPointHP = 122;
                    bonusHp = 56;
                    augmenteAtkHp = 60;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 54:
                    coutPointHP = 126;
                    bonusHp = 58;
                    augmenteAtkHp = 60;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 55:
                    coutPointHP = 130;
                    bonusHp = 60;
                    augmenteAtkHp = 70;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 56:
                    coutPointHP = 134;
                    bonusHp = 62;
                    augmenteAtkHp = 70;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 57:
                    coutPointHP = 138;
                    bonusHp = 64;
                    augmenteAtkHp = 70;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 58:
                    coutPointHP = 142;
                    bonusHp = 66;
                    augmenteAtkHp = 70;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 59:
                    coutPointHP = 146;
                    bonusHp = 68;
                    augmenteAtkHp = 70;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 60:
                    coutPointHP = 150;
                    bonusHp = 70;
                    augmenteAtkHp = 80;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 61:
                    coutPointHP = 155;
                    bonusHp = 72;
                    augmenteAtkHp = 80;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 62:
                    coutPointHP = 160;
                    bonusHp = 74;
                    augmenteAtkHp = 80;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 63:
                    coutPointHP = 165;
                    bonusHp = 76;
                    augmenteAtkHp = 80;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 64:
                    coutPointHP = 170;
                    bonusHp = 78;
                    augmenteAtkHp = 80;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 65:
                    coutPointHP = 175;
                    bonusHp = 80;
                    augmenteAtkHp = 90;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 66:
                    coutPointHP = 180;
                    bonusHp = 82;
                    augmenteAtkHp = 90;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 67:
                    coutPointHP = 185;
                    bonusHp = 84;
                    augmenteAtkHp = 90;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 68:
                    coutPointHP = 190;
                    bonusHp = 86;
                    augmenteAtkHp = 90;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 69:
                    coutPointHP = 195;
                    bonusHp = 88;
                    augmenteAtkHp = 90;
                    augmenteDef = 25;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 70:
                    coutPointHP = 200;
                    bonusHp = 90;
                    augmenteAtkHp = 100;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 71:
                    coutPointHP = 206;
                    bonusHp = 92;
                    augmenteAtkHp = 100;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 72:
                    coutPointHP = 212;
                    bonusHp = 94;
                    augmenteAtkHp = 100;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 73:
                    coutPointHP = 218;
                    bonusHp = 96;
                    augmenteAtkHp = 100;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 74:
                    coutPointHP = 224;
                    bonusHp = 98;
                    augmenteAtkHp = 100;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 75:
                    coutPointHP = 230;
                    bonusHp = 100;
                    augmenteAtkHp = 115;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 76:
                    coutPointHP = 236;
                    bonusHp = 102;
                    augmenteAtkHp = 115;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 77:
                    coutPointHP = 242;
                    bonusHp = 104;
                    augmenteAtkHp = 115;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 78:
                    coutPointHP = 248;
                    bonusHp = 106;
                    augmenteAtkHp = 115;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 79:
                    coutPointHP = 254;
                    bonusHp = 108;
                    augmenteAtkHp = 115;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 80:
                    coutPointHP = 260;
                    bonusHp = 110;
                    augmenteAtkHp = 130;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 81:
                    coutPointHP = 267;
                    bonusHp = 112;
                    augmenteAtkHp = 130;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 82:
                    coutPointHP = 274;
                    bonusHp = 114;
                    augmenteAtkHp = 130;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 83:
                    coutPointHP = 281;
                    bonusHp = 116;
                    augmenteAtkHp = 130;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 84:
                    coutPointHP = 288;
                    bonusHp = 118;
                    augmenteAtkHp = 130;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 85:
                    coutPointHP = 295;
                    bonusHp = 120;
                    augmenteAtkHp = 145;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 86:
                    coutPointHP = 302;
                    bonusHp = 122;
                    augmenteAtkHp = 145;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 87:
                    coutPointHP = 309;
                    bonusHp = 124;
                    augmenteAtkHp = 145;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 88:
                    coutPointHP = 316;
                    bonusHp = 126;
                    augmenteAtkHp = 145;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 89:
                    coutPointHP = 323;
                    bonusHp = 128;
                    augmenteAtkHp = 145;
                    augmenteDef = 45;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 90:
                    coutPointHP = 330;
                    bonusHp = 130;
                    augmenteAtkHp = 160;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 0;
                    reduitCc = 0;
                    break;
                case 91:
                    coutPointHP = 338;
                    bonusHp = 132;
                    augmenteAtkHp = 160;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 2;
                    reduitCc = 0;
                    break;
                case 92:
                    coutPointHP = 346;
                    bonusHp = 134;
                    augmenteAtkHp = 160;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 4;
                    reduitCc = 0;
                    break;
                case 93:
                    coutPointHP = 354;
                    bonusHp = 136;
                    augmenteAtkHp = 160;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 6;
                    reduitCc = 0;
                    break;
                case 94:
                    coutPointHP = 362;
                    bonusHp = 138;
                    augmenteAtkHp = 160;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 8;
                    reduitCc = 0;
                    break;
                case 95:
                    coutPointHP = 370;
                    bonusHp = 140;
                    augmenteAtkHp = 180;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 10;
                    reduitCc = 0;
                    break;
                case 96:
                    coutPointHP = 378;
                    bonusHp = 142;
                    augmenteAtkHp = 180;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 12;
                    reduitCc = 0;
                    break;
                case 97:
                    coutPointHP = 386;
                    bonusHp = 144;
                    augmenteAtkHp = 180;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 14;
                    reduitCc = 0;
                    break;
                case 98:
                    coutPointHP = 394;
                    bonusHp = 146;
                    augmenteAtkHp = 180;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 16;
                    reduitCc = 0;
                    break;
                case 99:
                    coutPointHP = 402;
                    bonusHp = 148;
                    augmenteAtkHp = 180;
                    augmenteDef = 70;
                    augmenteResistsHp = 2;
                    augmenteEsquiHp = 18;
                    reduitCc = 0;
                    break;
                case 100:
                    coutPointHP = 410;
                    bonusHp = 150;
                    augmenteAtkHp = 200;
                    augmenteDef = 100;
                    augmenteResistsHp = 5;
                    augmenteEsquiHp = 20;
                    reduitCc = 5;
                    break;
            }



            switch (plussp)
            {
                case 0:
                    pointsRestantsUp = 0;
                    break;
                case 1:
                    pointsRestantsUp = 5;
                    break;
                case 2:
                    pointsRestantsUp = 10;
                    break;
                case 3:
                    pointsRestantsUp = 15;
                    break;
                case 4:
                    pointsRestantsUp = 20;
                    break;
                case 5:
                    pointsRestantsUp = 28;
                    break;
                case 6:
                    pointsRestantsUp = 36;
                    break;
                case 7:
                    pointsRestantsUp = 46;
                    break;
                case 8:
                    pointsRestantsUp = 56;
                    break;
                case 9:
                    pointsRestantsUp = 68;
                    break;
                case 10:
                    pointsRestantsUp = 80;
                    break;
                case 11:
                    pointsRestantsUp = 95;
                    break;
                case 12:
                    pointsRestantsUp = 110;
                    break;
                case 13:
                    pointsRestantsUp = 128;
                    break;
                case 14:
                    pointsRestantsUp = 148;
                    break;
                case 15:
                    pointsRestantsUp = 173;
                    break;

            }

            int totalAtk = slGene + slAtk + pointsAtk;
            int totalDef = slGene + slDef + pointsDef;
            int totalElem = slGene + slElem + pointsElem;
            int totalHpmp = slGene + slHp + pointsHp;

            totalAttaque.Text = Convert.ToString(totalAtk);
            totalDefense.Text = Convert.ToString(totalDef);
            totalElement.Text = Convert.ToString(totalElem);
            totalHPMP.Text = Convert.ToString(totalHpmp);

            int pointsRestantsTotal = pointsRestantsUp + pointsRestantsSp - coutPointAtk - coutPointDef - coutPointElem - coutPointHP;
            pointsRestants.Text = Convert.ToString(pointsRestantsTotal);

            bonusAttaque.Text = '+'+Convert.ToString(bonusAtk);
            bonusDefense.Text = '+'+Convert.ToString(bonusDef);
            bonusElement.Text = '+' + Convert.ToString(bonusElem);
            bonusHPMP.Text = '+' + Convert.ToString(bonusHp) + '%';



            int augmenteAtkTotal = augmenteAtkAtk + augmenteAtkHp;

            int augmenteHpTotal = augmenteHpAtk + augmenteHpDef;

            int augmenteMpTotal = augmenteMpAtk + augmenteMpElem;

            int augmenteResistsTotal = augmenteResistsDef + augmenteResistsElem + augmenteResistsHp;

            int augmenteEsquiTotal = augmenteEsquiDef + augmenteEsquiHp;

            augmenteAttaque.Text = Convert.ToString(augmenteAtkTotal);
            augmenteElement.Text = Convert.ToString(augmenteElem);
            augmentePrecision.Text = Convert.ToString(augmentePreci);
            augmenteCC.Text = Convert.ToString(augmenteChanceCc);
            augmenteDegatsCC.Text = Convert.ToString(augmenteDegatsCc);
            augmenteDefense.Text = Convert.ToString(augmenteDef);
            augmenteHP.Text = Convert.ToString(augmenteHpTotal);
            augmenteMP.Text = Convert.ToString(augmenteMpTotal);
            augmenteResistances.Text = Convert.ToString(augmenteResistsTotal);
            augmenteEsquive.Text = Convert.ToString(augmenteEsquiTotal);
            reduitCC.Text = Convert.ToString(reduitCc);
            reduitDegatsCC.Text = Convert.ToString(reduitDegatsCc);



        }

        private void lvlSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void pointsAttaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void pointsDefense_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void pointsElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void pointsHPMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void slAttaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void slDefense_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void slEelement_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void slHPMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }

        private void slGenerale_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) e.Handled = true;
        }
    }
}

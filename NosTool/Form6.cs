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

            int pointsDef;
            if (int.TryParse(pointsDefense.Text, out pointsDef))
            {

            }
            else
            {

            }

            int pointsElem;
            if (int.TryParse(pointsElement.Text, out pointsElem))
            {

            }
            else
            {

            }

            int pointsHp;
            if (int.TryParse(pointsHPMP.Text, out pointsHp))
            {

            }
            else
            {

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
                    break;
                case 1:
                    coutPointAtk = 1;
                    bonusAtk = 5;
                    break;
                case 2:
                    coutPointAtk = 2;
                    bonusAtk = 10;
                    break;
                case 3:
                    coutPointAtk = 3;
                    bonusAtk = 15;
                    break;
                case 4:
                    coutPointAtk = 4;
                    bonusAtk = 20;
                    break;
                case 5:
                    coutPointAtk = 5;
                    bonusAtk = 25;
                    break;
                case 6:
                    coutPointAtk = 6;
                    bonusAtk = 30;
                    break;
                case 7:
                    coutPointAtk = 7;
                    bonusAtk = 35;
                    break;
                case 8:
                    coutPointAtk = 8;
                    bonusAtk = 40;
                    break;
                case 9:
                    coutPointAtk = 9;
                    bonusAtk = 45;
                    break;
                case 10:
                    coutPointAtk = 10;
                    bonusAtk = 50;
                    break;
                case 11:
                    coutPointAtk = 12;
                    bonusAtk = 56;
                    break;
                case 12:
                    coutPointAtk = 14;
                    bonusAtk = 62;
                    break;
                case 13:
                    coutPointAtk = 16;
                    bonusAtk = 68;
                    break;
                case 14:
                    coutPointAtk = 18;
                    bonusAtk = 74;
                    break;
                case 15:
                    coutPointAtk = 20;
                    bonusAtk = 80;
                    break;
                case 16:
                    coutPointAtk = 22;
                    bonusAtk = 86;
                    break;
                case 17:
                    coutPointAtk = 24;
                    bonusAtk = 92;
                    break;
                case 18:
                    coutPointAtk = 26;
                    bonusAtk = 98;
                    break;
                case 19:
                    coutPointAtk = 28;
                    bonusAtk = 104;
                    break;
                case 20:
                    coutPointAtk = 31;
                    bonusAtk = 110;
                    break;
                case 21:
                    coutPointAtk = 34;
                    bonusAtk = 117;
                    break;
                case 22:
                    coutPointAtk = 37;
                    bonusAtk = 124;
                    break;
                case 23:
                    coutPointAtk = 40;
                    bonusAtk = 131;
                    break;
                case 24:
                    coutPointAtk = 43;
                    bonusAtk = 138;
                    break;
                case 25:
                    coutPointAtk = 46;
                    bonusAtk = 145;
                    break;
                case 26:
                    coutPointAtk = 49;
                    bonusAtk = 152;
                    break;
                case 27:
                    coutPointAtk = 52;
                    bonusAtk = 159;
                    break;
                case 28:
                    coutPointAtk = 55;
                    bonusAtk = 166;
                    break;
                case 29:
                    coutPointAtk = 58;
                    bonusAtk = 173;
                    break;
                case 30:
                    coutPointAtk = 61;
                    bonusAtk = 180;
                    break;
                case 31:
                    coutPointAtk = 64;
                    bonusAtk = 188;
                    break;
                case 32:
                    coutPointAtk = 67;
                    bonusAtk = 196;
                    break;
                case 33:
                    coutPointAtk = 70;
                    bonusAtk = 204;
                    break;
                case 34:
                    coutPointAtk = 73;
                    bonusAtk = 212;
                    break;
                case 35:
                    coutPointAtk = 76;
                    bonusAtk = 220;
                    break;
                case 36:
                    coutPointAtk = 79;
                    bonusAtk = 228;
                    break;
                case 37:
                    coutPointAtk = 82;
                    bonusAtk = 236;
                    break;
                case 38:
                    coutPointAtk = 85;
                    bonusAtk = 244;
                    break;
                case 39:
                    coutPointAtk = 88;
                    bonusAtk = 252;
                    break;
                case 40:
                    coutPointAtk = 92;
                    bonusAtk = 260;
                    break;
                case 41:
                    coutPointAtk = 96;
                    bonusAtk = 269;
                    break;
                case 42:
                    coutPointAtk = 100;
                    bonusAtk = 278;
                    break;
                case 43:
                    coutPointAtk = 104;
                    bonusAtk = 287;
                    break;
                case 44:
                    coutPointAtk = 108;
                    bonusAtk = 296;
                    break;
                case 45:
                    coutPointAtk = 112;
                    bonusAtk = 305;
                    break;
                case 46:
                    coutPointAtk = 116;
                    bonusAtk = 314;
                    break;
                case 47:
                    coutPointAtk = 120;
                    bonusAtk = 323;
                    break;
                case 48:
                    coutPointAtk = 124;
                    bonusAtk = 332;
                    break;
                case 49:
                    coutPointAtk = 128;
                    bonusAtk = 341;
                    break;
                case 50:
                    coutPointAtk = 132;
                    bonusAtk = 350;
                    break;
                case 51:
                    coutPointAtk = 136;
                    bonusAtk = 360;
                    break;
                case 52:
                    coutPointAtk = 140;
                    bonusAtk = 370;
                    break;
                case 53:
                    coutPointAtk = 144;
                    bonusAtk = 380;
                    break;
                case 54:
                    coutPointAtk = 148;
                    bonusAtk = 390;
                    break;                
                case 55:
                    coutPointAtk = 152;
                    bonusAtk = 400;
                    break;
                case 56:
                    coutPointAtk = 156;
                    bonusAtk = 410;
                    break;
                case 57:
                    coutPointAtk = 160;
                    bonusAtk = 420;
                    break;
                case 58:
                    coutPointAtk = 164;
                    bonusAtk = 430;
                    break;
                case 59:
                    coutPointAtk = 168;
                    bonusAtk = 440;
                    break;
                case 60:
                    coutPointAtk = 173;
                    bonusAtk = 450;
                    break;
                case 61:
                    coutPointAtk = 178;
                    bonusAtk = 461;
                    break;
                case 62:
                    coutPointAtk = 183;
                    bonusAtk = 472;
                    break;
                case 63:
                    coutPointAtk = 188;
                    bonusAtk = 483;
                    break;
                case 64:
                    coutPointAtk = 193;
                    bonusAtk = 494;
                    break;
                case 65:
                    coutPointAtk = 198;
                    bonusAtk = 505;
                    break;
                case 66:
                    coutPointAtk = 203;
                    bonusAtk = 516;
                    break;
                case 67:
                    coutPointAtk = 208;
                    bonusAtk = 527;
                    break;
                case 68:
                    coutPointAtk = 213;
                    bonusAtk = 538;
                    break;
                case 69:
                    coutPointAtk = 218;
                    bonusAtk = 549;
                    break;
                case 70:
                    coutPointAtk = 223;
                    bonusAtk = 560;
                    break;
                case 71:
                    coutPointAtk = 228;
                    bonusAtk = 573;
                    break;
                case 72:
                    coutPointAtk = 233;
                    bonusAtk = 586;
                    break;
                case 73:
                    coutPointAtk = 238;
                    bonusAtk = 599;
                    break;
                case 74:
                    coutPointAtk = 243;
                    bonusAtk = 612;
                    break;
                case 75:
                    coutPointAtk = 248;
                    bonusAtk = 625;
                    break;
                case 76:
                    coutPointAtk = 253;
                    bonusAtk = 638;
                    break;
                case 77:
                    coutPointAtk = 258;
                    bonusAtk = 651;
                    break;
                case 78:
                    coutPointAtk = 263;
                    bonusAtk = 664;
                    break;
                case 79:
                    coutPointAtk = 268;
                    bonusAtk = 677;
                    break;
                case 80:
                    coutPointAtk = 274;
                    bonusAtk = 690;
                    break;
                case 81:
                    coutPointAtk = 280;
                    bonusAtk = 704;
                    break;
                case 82:
                    coutPointAtk = 286;
                    bonusAtk = 718;
                    break;
                case 83:
                    coutPointAtk = 292;
                    bonusAtk = 732;
                    break;
                case 84:
                    coutPointAtk = 298;
                    bonusAtk = 746;
                    break;
                case 85:
                    coutPointAtk = 304;
                    bonusAtk = 760;
                    break;
                case 86:
                    coutPointAtk = 310;
                    bonusAtk = 774;
                    break;
                case 87:
                    coutPointAtk = 316;
                    bonusAtk = 788;
                    break;
                case 88:
                    coutPointAtk = 322;
                    bonusAtk = 802;
                    break;
                case 89:
                    coutPointAtk = 328;
                    bonusAtk = 816;
                    break;
                case 90:
                    coutPointAtk = 334;
                    bonusAtk = 830;
                    break;
                case 91:
                    coutPointAtk = 341;
                    bonusAtk = 845;
                    break;
                case 92:
                    coutPointAtk = 348;
                    bonusAtk = 860;
                    break;
                case 93:
                    coutPointAtk = 355;
                    bonusAtk = 875;
                    break;
                case 94:
                    coutPointAtk = 362;
                    bonusAtk = 890;
                    break;
                case 95:
                    coutPointAtk = 369;
                    bonusAtk = 906;
                    break;
                case 96:
                    coutPointAtk = 376;
                    bonusAtk = 923;
                    break;
                case 97:
                    coutPointAtk = 383;
                    bonusAtk = 940;
                    break;
                case 98:
                    coutPointAtk = 391;
                    bonusAtk = 960;
                    break;
                case 99:
                    coutPointAtk = 400;
                    bonusAtk = 960;
                    break;
                case 100:
                    coutPointAtk = 410;
                    bonusAtk = 1000;
                    break;
            }

            
            int coutPointDef=0;
            switch (pointsDef)
            {
                case 0:
                    coutPointDef = 0;
                    break;
                case 1:
                    coutPointDef = 1;
                    break;
                case 2:
                    coutPointDef = 2;
                    break;
                case 3:
                    coutPointDef = 3;
                    break;
                case 4:
                    coutPointDef = 4;
                    break;
                case 5:
                    coutPointDef = 5;
                    break;
                case 6:
                    coutPointDef = 6;
                    break;
                case 7:
                    coutPointDef = 7;
                    break;
                case 8:
                    coutPointDef = 8;
                    break;
                case 9:
                    coutPointDef = 9;
                    break;
                case 10:
                    coutPointDef = 10;
                    break;
                case 11:
                    coutPointDef = 12;
                    break;
                case 12:
                    coutPointDef = 14;
                    break;
                case 13:
                    coutPointDef = 16;
                    break;
                case 14:
                    coutPointDef = 18;
                    break;
                case 15:
                    coutPointDef = 20;
                    break;
                case 16:
                    coutPointDef = 22;
                    break;
                case 17:
                    coutPointDef = 24;
                    break;
                case 18:
                    coutPointDef = 26;
                    break;
                case 19:
                    coutPointDef = 28;
                    break;
                case 20:
                    coutPointDef = 30;
                    break;
                case 21:
                    coutPointDef = 32;
                    break;
                case 22:
                    coutPointDef = 34;
                    break;
                case 23:
                    coutPointDef = 36;
                    break;
                case 24:
                    coutPointDef = 38;
                    break;
                case 25:
                    coutPointDef = 40;
                    break;
                case 26:
                    coutPointDef = 42;
                    break;
                case 27:
                    coutPointDef = 44;
                    break;
                case 28:
                    coutPointDef = 46;
                    break;
                case 29:
                    coutPointDef = 48;
                    break;
                case 30:
                    coutPointDef = 51;
                    break;
                case 31:
                    coutPointDef = 54;
                    break;
                case 32:
                    coutPointDef = 57;
                    break;
                case 33:
                    coutPointDef = 60;
                    break;
                case 34:
                    coutPointDef = 63;
                    break;
                case 35:
                    coutPointDef = 66;
                    break;
                case 36:
                    coutPointDef = 69;
                    break;
                case 37:
                    coutPointDef = 72;
                    break;
                case 38:
                    coutPointDef = 75;
                    break;
                case 39:
                    coutPointDef = 78;
                    break;
                case 40:
                    coutPointDef = 81;
                    break;
                case 41:
                    coutPointDef = 85;
                    break;
                case 42:
                    coutPointDef = 89;
                    break;
                case 43:
                    coutPointDef = 93;
                    break;
                case 44:
                    coutPointDef = 97;
                    break;
                case 45:
                    coutPointDef = 101;
                    break;
                case 46:
                    coutPointDef = 105;
                    break;
                case 47:
                    coutPointDef = 109;
                    break;
                case 48:
                    coutPointDef = 113;
                    break;
                case 49:
                    coutPointDef = 117;
                    break;
                case 50:
                    coutPointDef = 121;
                    break;
                case 51:
                    coutPointDef = 125;
                    break;
                case 52:
                    coutPointDef = 129;
                    break;
                case 53:
                    coutPointDef = 133;
                    break;
                case 54:
                    coutPointDef = 137;
                    break;
                case 55:
                    coutPointDef = 141;
                    break;
                case 56:
                    coutPointDef = 145;
                    break;
                case 57:
                    coutPointDef = 149;
                    break;
                case 58:
                    coutPointDef = 153;
                    break;
                case 59:
                    coutPointDef = 157;
                    break;
                case 60:
                    coutPointDef = 161;
                    break;
                case 61:
                    coutPointDef = 166;
                    break;
                case 62:
                    coutPointDef = 171;
                    break;
                case 63:
                    coutPointDef = 176;
                    break;
                case 64:
                    coutPointDef = 181;
                    break;
                case 65:
                    coutPointDef = 186;
                    break;
                case 66:
                    coutPointDef = 191;
                    break;
                case 67:
                    coutPointDef = 196;
                    break;
                case 68:
                    coutPointDef = 201;
                    break;
                case 69:
                    coutPointDef = 206;
                    break;
                case 70:
                    coutPointDef = 211;
                    break;
                case 71:
                    coutPointDef = 216;
                    break;
                case 72:
                    coutPointDef = 221;
                    break;
                case 73:
                    coutPointDef = 226;
                    break;
                case 74:
                    coutPointDef = 231;
                    break;
                case 75:
                    coutPointDef = 236;
                    break;
                case 76:
                    coutPointDef = 242;
                    break;
                case 77:
                    coutPointDef = 248;
                    break;
                case 78:
                    coutPointDef = 254;
                    break;
                case 79:
                    coutPointDef = 260;
                    break;
                case 80:
                    coutPointDef = 266;
                    break;
                case 81:
                    coutPointDef = 272;
                    break;
                case 82:
                    coutPointDef = 278;
                    break;
                case 83:
                    coutPointDef = 284;
                    break;
                case 84:
                    coutPointDef = 290;
                    break;
                case 85:
                    coutPointDef = 297;
                    break;
                case 86:
                    coutPointDef = 304;
                    break;
                case 87:
                    coutPointDef = 311;
                    break;
                case 88:
                    coutPointDef = 318;
                    break;
                case 89:
                    coutPointDef = 325;
                    break;
                case 90:
                    coutPointDef = 332;
                    break;
                case 91:
                    coutPointDef = 339;
                    break;
                case 92:
                    coutPointDef = 346;
                    break;
                case 93:
                    coutPointDef = 353;
                    break;
                case 94:
                    coutPointDef = 360;
                    break;
                case 95:
                    coutPointDef = 368;
                    break;
                case 96:
                    coutPointDef = 376;
                    break;
                case 97:
                    coutPointDef = 384;
                    break;
                case 98:
                    coutPointDef = 392;
                    break;
                case 99:
                    coutPointDef = 400;
                    break;
                case 100:
                    coutPointDef = 410;
                    break;
            }

            int coutPointElem=0;
            switch (pointsElem)
            {
                case 0:
                    coutPointElem = 0;
                    break;
                case 1:
                    coutPointElem = 1;
                    break;
                case 2:
                    coutPointElem = 2;
                    break;
                case 3:
                    coutPointElem = 3;
                    break;
                case 4:
                    coutPointElem = 4;
                    break;
                case 5:
                    coutPointElem = 5;
                    break;
                case 6:
                    coutPointElem = 6;
                    break;
                case 7:
                    coutPointElem = 7;
                    break;
                case 8:
                    coutPointElem = 8;
                    break;
                case 9:
                    coutPointElem = 9;
                    break;
                case 10:
                    coutPointElem = 10;
                    break;
                case 11:
                    coutPointElem = 11;
                    break;
                case 12:
                    coutPointElem = 12;
                    break;
                case 13:
                    coutPointElem = 13;
                    break;
                case 14:
                    coutPointElem = 14;
                    break;
                case 15:
                    coutPointElem = 15;
                    break;
                case 16:
                    coutPointElem = 16;
                    break;
                case 17:
                    coutPointElem = 17;
                    break;
                case 18:
                    coutPointElem = 18;
                    break;
                case 19:
                    coutPointElem = 19;
                    break;
                case 20:
                    coutPointElem = 20;
                    break;
                case 21:
                    coutPointElem = 22;
                    break;
                case 22:
                    coutPointElem = 24;
                    break;
                case 23:
                    coutPointElem = 26;
                    break;
                case 24:
                    coutPointElem = 28;
                    break;
                case 25:
                    coutPointElem = 30;
                    break;
                case 26:
                    coutPointElem = 32;
                    break;
                case 27:
                    coutPointElem = 34;
                    break;
                case 28:
                    coutPointElem = 36;
                    break;
                case 29:
                    coutPointElem = 38;
                    break;
                case 30:
                    coutPointElem = 40;
                    break;
                case 31:
                    coutPointElem = 43;
                    break;
                case 32:
                    coutPointElem = 46;
                    break;
                case 33:
                    coutPointElem = 49;
                    break;
                case 34:
                    coutPointElem = 52;
                    break;
                case 35:
                    coutPointElem = 55;
                    break;
                case 36:
                    coutPointElem = 58;
                    break;
                case 37:
                    coutPointElem = 61;
                    break;
                case 38:
                    coutPointElem = 64;
                    break;
                case 39:
                    coutPointElem = 67;
                    break;
                case 40:
                    coutPointElem = 70;
                    break;
                case 41:
                    coutPointElem = 74;
                    break;
                case 42:
                    coutPointElem = 78;
                    break;
                case 43:
                    coutPointElem = 82;
                    break;
                case 44:
                    coutPointElem = 86;
                    break;
                case 45:
                    coutPointElem = 90;
                    break;
                case 46:
                    coutPointElem = 94;
                    break;
                case 47:
                    coutPointElem = 98;
                    break;
                case 48:
                    coutPointElem = 102;
                    break;
                case 49:
                    coutPointElem = 106;
                    break;
                case 50:
                    coutPointElem = 110;
                    break;
                case 51:
                    coutPointElem = 115;
                    break;
                case 52:
                    coutPointElem = 120;
                    break;
                case 53:
                    coutPointElem = 125;
                    break;
                case 54:
                    coutPointElem = 130;
                    break;
                case 55:
                    coutPointElem = 135;
                    break;
                case 56:
                    coutPointElem = 140;
                    break;
                case 57:
                    coutPointElem = 145;
                    break;
                case 58:
                    coutPointElem = 150;
                    break;
                case 59:
                    coutPointElem = 155;
                    break;
                case 60:
                    coutPointElem = 160;
                    break;
                case 61:
                    coutPointElem = 165;
                    break;
                case 62:
                    coutPointElem = 170;
                    break;
                case 63:
                    coutPointElem = 175;
                    break;
                case 64:
                    coutPointElem = 180;
                    break;
                case 65:
                    coutPointElem = 185;
                    break;
                case 66:
                    coutPointElem = 190;
                    break;
                case 67:
                    coutPointElem = 195;
                    break;
                case 68:
                    coutPointElem = 200;
                    break;
                case 69:
                    coutPointElem = 205;
                    break;
                case 70:
                    coutPointElem = 210;
                    break;
                case 71:
                    coutPointElem = 216;
                    break;
                case 72:
                    coutPointElem = 222;
                    break;
                case 73:
                    coutPointElem = 228;
                    break;
                case 74:
                    coutPointElem = 234;
                    break;
                case 75:
                    coutPointElem = 240;
                    break;
                case 76:
                    coutPointElem = 246;
                    break;
                case 77:
                    coutPointElem = 252;
                    break;
                case 78:
                    coutPointElem = 258;
                    break;
                case 79:
                    coutPointElem = 264;
                    break;
                case 80:
                    coutPointElem = 270;
                    break;
                case 81:
                    coutPointElem = 277;
                    break;
                case 82:
                    coutPointElem = 284;
                    break;
                case 83:
                    coutPointElem = 291;
                    break;
                case 84:
                    coutPointElem = 298;
                    break;
                case 85:
                    coutPointElem = 305;
                    break;
                case 86:
                    coutPointElem = 312;
                    break;
                case 87:
                    coutPointElem = 319;
                    break;
                case 88:
                    coutPointElem = 326;
                    break;
                case 89:
                    coutPointElem = 333;
                    break;
                case 90:
                    coutPointElem = 340;
                    break;
                case 91:
                    coutPointElem = 347;
                    break;
                case 92:
                    coutPointElem = 354;
                    break;
                case 93:
                    coutPointElem = 361;
                    break;
                case 94:
                    coutPointElem = 368;
                    break;
                case 95:
                    coutPointElem = 375;
                    break;
                case 96:
                    coutPointElem = 382;
                    break;
                case 97:
                    coutPointElem = 389;
                    break;
                case 98:
                    coutPointElem = 396;
                    break;
                case 99:
                    coutPointElem = 403;
                    break;
                case 100:
                    coutPointElem = 410;
                    break;
            }

            int coutPointHP=0;
            switch (pointsHp)
            {
                case 0:
                    coutPointHP = 0;
                    break;
                case 1:
                    coutPointHP = 1;
                    break;
                case 2:
                    coutPointHP = 2;
                    break;
                case 3:
                    coutPointHP = 3;
                    break;
                case 4:
                    coutPointHP = 4;
                    break;
                case 5:
                    coutPointHP = 5;
                    break;
                case 6:
                    coutPointHP = 6;
                    break;
                case 7:
                    coutPointHP = 7;
                    break;
                case 8:
                    coutPointHP = 8;
                    break;
                case 9:
                    coutPointHP = 9;
                    break;
                case 10:
                    coutPointHP = 10;
                    break;
                case 11:
                    coutPointHP = 12;
                    break;
                case 12:
                    coutPointHP = 14;
                    break;
                case 13:
                    coutPointHP = 16;
                    break;
                case 14:
                    coutPointHP = 18;
                    break;
                case 15:
                    coutPointHP = 20;
                    break;
                case 16:
                    coutPointHP = 22;
                    break;
                case 17:
                    coutPointHP = 24;
                    break;
                case 18:
                    coutPointHP = 26;
                    break;
                case 19:
                    coutPointHP = 28;
                    break;
                case 20:
                    coutPointHP = 30;
                    break;
                case 21:
                    coutPointHP = 32;
                    break;
                case 22:
                    coutPointHP = 34;
                    break;
                case 23:
                    coutPointHP = 36;
                    break;
                case 24:
                    coutPointHP = 38;
                    break;
                case 25:
                    coutPointHP = 40;
                    break;
                case 26:
                    coutPointHP = 42;
                    break;
                case 27:
                    coutPointHP = 44;
                    break;
                case 28:
                    coutPointHP = 46;
                    break;
                case 29:
                    coutPointHP = 48;
                    break;
                case 30:
                    coutPointHP = 50;
                    break;
                case 31:
                    coutPointHP = 53;
                    break;
                case 32:
                    coutPointHP = 56;
                    break;
                case 33:
                    coutPointHP = 59;
                    break;
                case 34:
                    coutPointHP = 62;
                    break;
                case 35:
                    coutPointHP = 65;
                    break;
                case 36:
                    coutPointHP = 68;
                    break;
                case 37:
                    coutPointHP = 71;
                    break;
                case 38:
                    coutPointHP = 74;
                    break;
                case 39:
                    coutPointHP = 77;
                    break;
                case 40:
                    coutPointHP = 80;
                    break;
                case 41:
                    coutPointHP = 83;
                    break;
                case 42:
                    coutPointHP = 86;
                    break;
                case 43:
                    coutPointHP = 89;
                    break;
                case 44:
                    coutPointHP = 92;
                    break;
                case 45:
                    coutPointHP = 95;
                    break;
                case 46:
                    coutPointHP = 98;
                    break;
                case 47:
                    coutPointHP = 101;
                    break;
                case 48:
                    coutPointHP = 104;
                    break;
                case 49:
                    coutPointHP = 107;
                    break;
                case 50:
                    coutPointHP = 110;
                    break;
                case 51:
                    coutPointHP = 114;
                    break;
                case 52:
                    coutPointHP = 118;
                    break;
                case 53:
                    coutPointHP = 122;
                    break;
                case 54:
                    coutPointHP = 126;
                    break;
                case 55:
                    coutPointHP = 130;
                    break;
                case 56:
                    coutPointHP = 134;
                    break;
                case 57:
                    coutPointHP = 138;
                    break;
                case 58:
                    coutPointHP = 142;
                    break;
                case 59:
                    coutPointHP = 146;
                    break;
                case 60:
                    coutPointHP = 150;
                    break;
                case 61:
                    coutPointHP = 155;
                    break;
                case 62:
                    coutPointHP = 160;
                    break;
                case 63:
                    coutPointHP = 165;
                    break;
                case 64:
                    coutPointHP = 170;
                    break;
                case 65:
                    coutPointHP = 175;
                    break;
                case 66:
                    coutPointHP = 180;
                    break;
                case 67:
                    coutPointHP = 185;
                    break;
                case 68:
                    coutPointHP = 190;
                    break;
                case 69:
                    coutPointHP = 195;
                    break;
                case 70:
                    coutPointHP = 200;
                    break;
                case 71:
                    coutPointHP = 206;
                    break;
                case 72:
                    coutPointHP = 212;
                    break;
                case 73:
                    coutPointHP = 218;
                    break;
                case 74:
                    coutPointHP = 224;
                    break;
                case 75:
                    coutPointHP = 230;
                    break;
                case 76:
                    coutPointHP = 236;
                    break;
                case 77:
                    coutPointHP = 242;
                    break;
                case 78:
                    coutPointHP = 248;
                    break;
                case 79:
                    coutPointHP = 254;
                    break;
                case 80:
                    coutPointHP = 260;
                    break;
                case 81:
                    coutPointHP = 267;
                    break;
                case 82:
                    coutPointHP = 274;
                    break;
                case 83:
                    coutPointHP = 281;
                    break;
                case 84:
                    coutPointHP = 288;
                    break;
                case 85:
                    coutPointHP = 295;
                    break;
                case 86:
                    coutPointHP = 302;
                    break;
                case 87:
                    coutPointHP = 309;
                    break;
                case 88:
                    coutPointHP = 316;
                    break;
                case 89:
                    coutPointHP = 323;
                    break;
                case 90:
                    coutPointHP = 330;
                    break;
                case 91:
                    coutPointHP = 338;
                    break;
                case 92:
                    coutPointHP = 346;
                    break;
                case 93:
                    coutPointHP = 354;
                    break;
                case 94:
                    coutPointHP = 362;
                    break;
                case 95:
                    coutPointHP = 370;
                    break;
                case 96:
                    coutPointHP = 378;
                    break;
                case 97:
                    coutPointHP = 386;
                    break;
                case 98:
                    coutPointHP = 394;
                    break;
                case 99:
                    coutPointHP = 402;
                    break;
                case 100:
                    coutPointHP = 410;
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

            bonusAttaque.Text = Convert.ToString(bonusAtk);


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

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
    public partial class bateau : Form
    {
        public bateau()
        {
            InitializeComponent();
        }

        private void bateauTimer_Tick(object sender, EventArgs e)
        {                 
            int minuteProchain=0;
            int minuteNow = DateTime.Now.Minute;
            int heureProchain=0;
            int heureNow = DateTime.Now.Hour;
            
            switch(minuteNow)
            {
                case 0:
                    minuteProchain = 5;
                    heureProchain = heureNow;
                    break;
                case 1:
                    minuteProchain = 5;
                    heureProchain = heureNow;
                    break;
                case 2:
                    minuteProchain = 5;
                    heureProchain = heureNow;
                    break;
                case 3:
                    minuteProchain = 5;
                    heureProchain = heureNow;
                    break;
                case 4:
                    minuteProchain = 5;
                    heureProchain = heureNow;
                    break;
                case 5:
                    minuteProchain = 10;
                    heureProchain = heureNow;
                    break;
                case 6:
                    minuteProchain = 10;
                    heureProchain = heureNow;
                    break;
                case 7:
                    minuteProchain = 10;
                    heureProchain = heureNow;
                    break;
                case 8:
                    minuteProchain = 10;
                    heureProchain = heureNow;
                    break;
                case 9:
                    minuteProchain = 10;
                    heureProchain = heureNow;
                    break;
                case 10:
                    minuteProchain = 15;
                    heureProchain = heureNow;
                    break;
                case 11:
                    minuteProchain = 15;
                    heureProchain = heureNow;
                    break;
                case 12:
                    minuteProchain = 15;
                    heureProchain = heureNow;
                    break;
                case 13:
                    minuteProchain = 15;
                    heureProchain = heureNow;
                    break;
                case 14:
                    minuteProchain = 15;
                    heureProchain = heureNow;
                    break;
                case 15:
                    minuteProchain = 20;
                    heureProchain = heureNow;
                    break;
                case 16:
                    minuteProchain = 20;
                    heureProchain = heureNow;
                    break;
                case 17:
                    minuteProchain = 20;
                    heureProchain = heureNow;
                    break;
                case 18:
                    minuteProchain = 20;
                    heureProchain = heureNow;
                    break;
                case 19:
                    minuteProchain = 20;
                    heureProchain = heureNow;
                    break;
                case 20:
                    minuteProchain = 25;
                    heureProchain = heureNow;
                    break;
                case 21:
                    minuteProchain = 25;
                    heureProchain = heureNow;
                    break;
                case 22:
                    minuteProchain = 25;
                    heureProchain = heureNow;
                    break;
                case 23:
                    minuteProchain = 25;
                    heureProchain = heureNow;
                    break;
                case 24:
                    minuteProchain = 25;
                    heureProchain = heureNow;
                    break;
                case 25:
                    minuteProchain = 30;
                    heureProchain = heureNow;
                    break;
                case 26:
                    minuteProchain = 30;
                    heureProchain = heureNow;
                    break;
                case 27:
                    minuteProchain = 30;
                    heureProchain = heureNow;
                    break;
                case 28:
                    minuteProchain = 30;
                    heureProchain = heureNow;
                    break;
                case 29:
                    minuteProchain = 30;
                    heureProchain = heureNow;
                    break;
                case 30:
                    minuteProchain = 35;
                    heureProchain = heureNow;
                    break;
                case 31:
                    minuteProchain = 35;
                    heureProchain = heureNow;
                    break;
                case 32:
                    minuteProchain = 35;
                    heureProchain = heureNow;
                    break;
                case 33:
                    minuteProchain = 35;
                    heureProchain = heureNow;
                    break;
                case 34:
                    minuteProchain = 35;
                    heureProchain = heureNow;
                    break;
                case 35:
                    minuteProchain = 40;
                    heureProchain = heureNow;
                    break;
                case 36:
                    minuteProchain = 40;
                    heureProchain = heureNow;
                    break;
                case 37:
                    minuteProchain = 40;
                    heureProchain = heureNow;
                    break;
                case 38:
                    minuteProchain = 40;
                    heureProchain = heureNow;
                    break;
                case 39:
                    minuteProchain = 40;
                    heureProchain = heureNow;
                    break;
                case 40:
                    minuteProchain = 45;
                    heureProchain = heureNow;
                    break;
                case 41:
                    minuteProchain = 45;
                    heureProchain = heureNow;
                    break;
                case 42:
                    minuteProchain = 45;
                    heureProchain = heureNow;
                    break;
                case 43:
                    minuteProchain = 45;
                    heureProchain = heureNow;
                    break;
                case 44:
                    minuteProchain = 45;
                    heureProchain = heureNow;
                    break;
                case 45:
                    minuteProchain = 50;
                    heureProchain = heureNow;
                    break;
                case 46:
                    minuteProchain = 50;
                    heureProchain = heureNow;
                    break;
                case 47:
                    minuteProchain = 50;
                    heureProchain = heureNow;
                    break;
                case 48:
                    minuteProchain = 50;
                    heureProchain = heureNow;
                    break;
                case 49:
                    minuteProchain = 50;
                    heureProchain = heureNow;
                    break;
                case 50:
                    minuteProchain = 55;
                    heureProchain = heureNow;
                    break;
                case 51:
                    minuteProchain = 55;
                    heureProchain = heureNow;
                    break;
                case 52:
                    minuteProchain = 55;
                    heureProchain = heureNow;
                    break;
                case 53:
                    minuteProchain = 55;
                    heureProchain = heureNow;
                    break;
                case 54:
                    minuteProchain = 55;
                    heureProchain = heureNow;
                    break;
                case 55:
                    minuteProchain = 0;
                    heureProchain = heureNow + 1;
                    break;
                case 56:
                    minuteProchain = 0;
                    heureProchain = heureNow + 1;
                    break;
                case 57:
                    minuteProchain = 0;
                    heureProchain = heureNow + 1;
                    break;
                case 58:
                    minuteProchain = 0;
                    heureProchain = heureNow + 1;
                    break;
                case 59:
                    minuteProchain = 0;
                    heureProchain = heureNow + 1;
                    break;
            }
            
            heureBateau1.Text = (Convert.ToString(DateTime.Now.Hour)) + ':' + (Convert.ToString(DateTime.Now.Minute));

            prochainBateau.Text = (Convert.ToString(heureProchain)) + ':' + (Convert.ToString(minuteProchain));       
            
        }
    }
}

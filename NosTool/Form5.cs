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
    public partial class simulateurPointSP : Form
    {
        public simulateurPointSP()
        {
            InitializeComponent();
            //axShockwaveFlash2.Movie = @"C:\Users\Charly\source\repos\NosTool\NosTool\Resources\build.swf";
            axShockwaveFlash2.Movie = @"http://sd-1.archive-host.com/membres/up/52135865560745204/build.swf";
            //axShockwaveFlash2.Movie = Properties.Resources.build;

            //axShockwaveFlash2.Movie = Properties.Resources.build.swf;
            
        }

        //int minutes = [4, 10, 16, 22, 28, 34, 40, 46, 52, 58];
       // int minuteNow = DateTime.Now.Minute;
        //int heureNow = DateTime.Now.Hour;
        //int minuteProchain;

       /* private int nextBateau(int minuteNow)
        {
            int minuteARetourner=0;
            int compteur;
            int[] minutes2 = new int[] { 4, 10, 16, 22, 28, 34, 40, 46, 52, 58 };
            for (compteur = 0;compteur < 10;compteur++)
            {
                if (minuteNow < minutes2[compteur])
                {
                    minuteARetourner = minutes2[compteur];
                    return minuteARetourner;
                }
            }

            return minuteARetourner;
        }

       /* private void timerBateau_Tick(object sender, EventArgs e)
        {
            minuteProchain = nextBateau(minuteNow) ;

            heureBateau1.Text = (Convert.ToString(DateTime.Now.Hour))+':'+(Convert.ToString(DateTime.Now.Minute));
            prochainBateau.Text = (Convert.ToString(heureNow)) + ':' + (Convert.ToString(minuteProchain));
        }

        private void prochainBateau_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void axShockwaveFlash2_Enter(object sender, EventArgs e)
        {

        }
    }
}

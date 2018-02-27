using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;



namespace NosTool
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void parfum_Click(object sender, EventArgs e)
        {
            parfum p1 = new parfum();

            p1.Show();
            //this.Cursor = new Cursor(GetType(), "dague.cur");
        }

      
        //son CI        
        System.Media.SoundPlayer ciMoins5 = new SoundPlayer(Properties.Resources.combatinstant);

        //son CALIGOR
        System.Media.SoundPlayer caligor = new SoundPlayer(Properties.Resources.caligor);

        private void rappelCi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_ci_Tick_1(object sender, EventArgs e)
        {
            
            DateTime ci0000 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 55, 0);
            DateTime ci0200 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 01, 55, 0);
            DateTime ci0400 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 03, 55, 0);
            DateTime ci0600 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 05, 55, 0);
            DateTime ci0800 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 07, 55, 0);
            DateTime ci1000 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 09, 55, 0);
            DateTime ci1200 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 55, 0);
            DateTime ci1400 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 55, 0);
            DateTime ci1600 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 55, 0);
            DateTime ci1800 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 55, 0);
            DateTime ci2000 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 55, 0);
            DateTime ci2200 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 21, 55, 0);

            //rappel ci minuit
            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci0000.Hour && DateTime.Now.Minute == ci0000.Minute && DateTime.Now.Second == ci0000.Second)
                {
                    
                    ciMoins5.Play();

                }
            }

            //rappel ci 02H00
            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci0200.Hour && DateTime.Now.Minute == ci0200.Minute && DateTime.Now.Second == ci0200.Second)
                {
                    ciMoins5.Play();
                    
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci0400.Hour && DateTime.Now.Minute == ci0400.Minute && DateTime.Now.Second == ci0400.Second)
                {
                    ciMoins5.Play();
                }
            }



            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci0800.Hour && DateTime.Now.Minute == ci0800.Minute && DateTime.Now.Second == ci0800.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci0800.Hour && DateTime.Now.Minute == ci0800.Minute && DateTime.Now.Second == ci0800.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci1000.Hour && DateTime.Now.Minute == ci1000.Minute && DateTime.Now.Second == ci1000.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci1200.Hour && DateTime.Now.Minute == ci1200.Minute && DateTime.Now.Second == ci1200.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci1400.Hour && DateTime.Now.Minute == ci1400.Minute && DateTime.Now.Second == ci1400.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci1600.Hour && DateTime.Now.Minute == ci1600.Minute && DateTime.Now.Second == ci1600.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci1800.Hour && DateTime.Now.Minute == ci1800.Minute && DateTime.Now.Second == ci1800.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci2000.Hour && DateTime.Now.Minute == ci2000.Minute && DateTime.Now.Second == ci1000.Second)
                {
                    ciMoins5.Play();
                }
            }

            if (check_rappelCI.Checked == true)
            {
                if (DateTime.Now.Hour == ci2200.Hour && DateTime.Now.Minute == ci2200.Minute && DateTime.Now.Second == ci2200.Second)
                {
                    ciMoins5.Play();
                }
            }


            //rappel CALIGOR
            DateTime heureCali1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 50, 0);
            DateTime heureCali2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 50, 0);
            int jourSemaine = (Int32)DateTime.Now.DayOfWeek;
            if (rappelCali.Checked == true)
            {
                if (jourSemaine == 0 || jourSemaine == 6)
                {
                    if (heureCali1.Hour == DateTime.Now.Hour && heureCali1.Minute == DateTime.Now.Minute && heureCali1.Second == DateTime.Now.Second)
                    {
                        caligor.Play();
                    }

                    if (heureCali2.Hour == DateTime.Now.Hour && heureCali2.Minute == DateTime.Now.Minute && heureCali1.Second == DateTime.Now.Second)
                    {
                        caligor.Play();
                    }

                }
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void orateur_Click(object sender, EventArgs e)
        {
            orateur orateur1 = new orateur();
            orateur1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            benefCalc benef1 = new benefCalc();
            benef1.Show();
        }

        private void bateau_Click(object sender, EventArgs e)
        {
            bateau bateau1 = new bateau();
            bateau1.Show();
        }

        private void rappelCali_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void upsp2_Click(object sender, EventArgs e)
        {
            upsp2 upsp = new upsp2();
            upsp.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.DISCRIMINACION_DE_FORMAS
{
    public partial class GoodorBad_Job : Form
    {
        int good = 0;
        SoundPlayer sonido;
        public GoodorBad_Job(int good)
        {
            InitializeComponent();
            this.good = good;
            timer.Start();
            
       
        }

        private void GoodorBad_Job_Load(object sender, EventArgs e)
        {
            if (good == 1)
            {
                Gif.Image = Image.FromFile(Application.StartupPath + @"\Gifs\good_job.gif");
                sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\yeii.wav");
                sonido.Play();
            }
                
            else
                Gif.Image = Image.FromFile(Application.StartupPath + @"\Gifs\bad.gif");
            //sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\dia_noche.wav");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

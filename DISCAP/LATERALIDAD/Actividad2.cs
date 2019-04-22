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

namespace DISCAP.LATERALIDAD
{
    public partial class Actividad2 : Form
    {
        Actividad3 form3 = new Actividad3();
        SoundPlayer correcto = new SoundPlayer(Application.StartupPath + @"\sonidos\si.wav");
        SoundPlayer incorrecto = new SoundPlayer(Application.StartupPath + @"\sonidos\no.wav");
        public Actividad2()
        {
            InitializeComponent();
            correcto.Load();
            incorrecto.Load();
        }

        private void Actividad2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Show();
            label4.Show();
            correcto.Play();
            timer1.Start();

            timer1.Tick += (s, en) =>
            {
                label5.Hide();
                label4.Hide();
                timer1.Stop();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Show();
            label2.Show();
            incorrecto.Play();
            timer1.Tick += (s, en) =>
            {
                label3.Hide();
                label2.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}

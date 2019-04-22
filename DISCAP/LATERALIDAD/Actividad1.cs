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
    public partial class Actividad1 : Form
    {
        SoundPlayer correcto = new SoundPlayer(Application.StartupPath + @"\sonidos\si.wav");
        SoundPlayer incorrecto = new SoundPlayer(Application.StartupPath + @"\sonidos\no.wav");
        Actividad2 form2 = new Actividad2();
        public Actividad1()
        {
            InitializeComponent();
            correcto.Load();
            incorrecto.Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actividad1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            incorrecto.Play();
            label3.Show();
            label2.Show();
            timer1.Tick += (s, en) =>
            {
                label3.Hide();
                label2.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correcto.Play();
            label5.Show();
            label4.Show();

            timer1.Tick += (s, en) =>
            {
                label5.Hide();
                label4.Hide();
                timer1.Stop();
            };
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}

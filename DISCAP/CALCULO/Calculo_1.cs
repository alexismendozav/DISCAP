using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.CALCULO
{
    public partial class Calculo_1 : Form
    {
        SoundPlayer play = new SoundPlayer();//OBJETO DE TIPO SOUNDPLAYER PARA REPRODUCIR AUDIOS
        public Calculo_1()
        {
            InitializeComponent();
            string audioPath = Path.Combine(Application.StartupPath, "Inicio.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Stop();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Stop();
        }

        private void introduccion_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "Inicio.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void uno_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "1.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void dos_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "2.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void tres_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "3.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "4.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "5.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void seis_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "6.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void siete_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "7.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "8.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "9.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void diez_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "10.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void sigVentana_Click(object sender, EventArgs e)
        {
            CalculoSig ventana = new CalculoSig();
            ventana.Show();
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Stop();

        }

        private void Calculo_1_Load(object sender, EventArgs e)
        {

        }
    }
}

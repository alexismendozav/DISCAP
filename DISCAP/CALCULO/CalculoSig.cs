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
    public partial class CalculoSig : Form
    {
        SoundPlayer play = new SoundPlayer();//OBJETO DE TIPO SOUNDPLAYER PARA REPRODUCIR AUDIOS
        public CalculoSig()
        {
            InitializeComponent();
        }

        private void btnOnce_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "11.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnDoce_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "12.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnTrece_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "13.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnCatorce_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "14.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnQuince_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "15.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnDieciseis_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "16.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnDiecisiete_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "17.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnDieciocho_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "18.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnDiecinueve_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "19.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void btnVeinte_Click(object sender, EventArgs e)
        {
            string audioPath = Path.Combine(Application.StartupPath, "20.wav");
            SoundPlayer simpleSound = new SoundPlayer(audioPath);
            simpleSound.Play();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retroceder_Click(object sender, EventArgs e)
        {
            Calculo_1 calculo =new  Calculo_1();
            calculo.Show();
            this.Close();
        }

        private void sigVentana_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}

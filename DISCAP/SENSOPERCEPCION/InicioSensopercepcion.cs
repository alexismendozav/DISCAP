using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.SENSOPERCEPCION
{
    public partial class InicioSensopercepcion : Form
    {
        public InicioSensopercepcion()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAmarrillo_Click(object sender, EventArgs e)
        {
            IntroduccionAmarillo amarillo = new IntroduccionAmarillo();
            amarillo.ShowDialog();
        }

        private void buttonAzul_Click(object sender, EventArgs e)
        {
            IntroduccionAzul azul = new IntroduccionAzul();
            azul.ShowDialog();
        }

        private void buttonBlanco_Click(object sender, EventArgs e)
        {
            IntroduccionBlanco blanco = new IntroduccionBlanco();
            blanco.ShowDialog();
        }

        private void buttonNegro_Click(object sender, EventArgs e)
        {
            IntroduccionNegro negro = new IntroduccionNegro();
            negro.ShowDialog();
        }

        private void buttonNaranja_Click(object sender, EventArgs e)
        {
            IntroduccionNaranja naranja = new IntroduccionNaranja();
            naranja.ShowDialog();
        }

        private void buttonVerde_Click(object sender, EventArgs e)
        {
            IntroduccionVerde verde = new IntroduccionVerde();
            verde.ShowDialog();
        }

        private void buttonHomigaRojo_Click(object sender, EventArgs e)
        {
            IntroduccionRojo rojo = new IntroduccionRojo();
            rojo.ShowDialog();
        }

        private void buttonRosa_Click(object sender, EventArgs e)
        {
            IntroduccionRosa rosa = new IntroduccionRosa();
            rosa.ShowDialog();
        }

        private void buttonCafe_Click(object sender, EventArgs e)
        {
            IntroduccionCafe cafe = new IntroduccionCafe();
            cafe.ShowDialog();
        }

        private void buttonMorado_Click(object sender, EventArgs e)
        {
            IntroduccionMorado morado = new IntroduccionMorado();
            morado.ShowDialog();
        }
    }
}

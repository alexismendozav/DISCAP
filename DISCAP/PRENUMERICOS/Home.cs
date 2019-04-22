using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.PRENUMERICOS
{
    public partial class Home : Form
    {
        public Home()
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

        private void btnTamaño_Click(object sender, EventArgs e)
        {
            Tamaño tamaño = new Tamaño();
            tamaño.ShowDialog();
        }

        private void btnDimensiones_Click(object sender, EventArgs e)
        {
            Dimensiones dimensiones = new Dimensiones();
            dimensiones.ShowDialog();
        }

        private void btnLlenoVacio_Click(object sender, EventArgs e)
        {
            LlenoVacio llenoVacio = new LlenoVacio();
            llenoVacio.ShowDialog();
        }
    }
}

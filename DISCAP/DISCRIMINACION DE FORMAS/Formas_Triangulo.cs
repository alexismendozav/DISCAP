using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.DISCRIMINACION_DE_FORMAS
{
    public partial class Formas_Triangulo : Form
    {
        public Formas_Triangulo()
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

        private void Advertencia_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Advertencia");
            mi.ShowDialog();
        }

        private void Escuadras_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Escuadras");
            mi.ShowDialog();
        }

        private void Señalamiento_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Señalamiento");
            mi.ShowDialog();
        }

        private void Rebanada_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Rebanada");
            mi.ShowDialog();
        }

        private void Pañuelo_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Pañuelo");
            mi.ShowDialog();
        }

        private void Cruce_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Cruce");
            mi.ShowDialog();
        }

        private void Formas_Triangulo_Load(object sender, EventArgs e)
        {

        }
    }
}

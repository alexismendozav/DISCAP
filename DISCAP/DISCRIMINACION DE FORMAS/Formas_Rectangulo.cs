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
    public partial class Formas_Rectangulo : Form
    {
        public Formas_Rectangulo()
        {
            InitializeComponent();
        }

      

        private void Repisa_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Repisa");
            mi.ShowDialog();
        }

        private void Celular_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Celular");
            mi.ShowDialog();
        }

        private void Caja_Zapatos_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Caja_Zapatos");
            mi.ShowDialog();
        }

        private void Colchon_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Colchon");
            mi.ShowDialog();
        }

        private void Libreta_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Libreta");
            mi.ShowDialog();
        }

        private void Trailer_Click(object sender, EventArgs e)
        {
            Mostrar_Imagenes mi = new Mostrar_Imagenes("Trailer");
            mi.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formas_Rectangulo_Load(object sender, EventArgs e)
        {

        }
    }
}

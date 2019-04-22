using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.ESCRITURA
{
    public partial class Escritura : Form
    {
        public Escritura()
        {
            InitializeComponent();
        }

        private void buttonModuloVocales_Click(object sender, EventArgs e)
        {
            EscrituraVocales vocales = new EscrituraVocales();
            vocales.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModuloNombre_Click(object sender, EventArgs e)
        {
            ReconocerNombre reconocerNombre = new ReconocerNombre();
            reconocerNombre.ShowDialog();
        }
    }
}

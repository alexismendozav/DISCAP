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
    public partial class ReconocerNombre : Form
    {
        public ReconocerNombre()
        {
            InitializeComponent();
        }

        private void ReconocerNombre_Load(object sender, EventArgs e)
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

        private void buttonIngresarNombre_Click(object sender, EventArgs e)
        {
            buttonTextoVocal.Text = textBoxNombre.Text;
            textBoxNombre.Text = null;
        }
    }
}

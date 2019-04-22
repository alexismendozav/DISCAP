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
    public partial class EscrituraVocales : Form
    {
        public EscrituraVocales()
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

        private void buttonIngresarVocal_Click(object sender, EventArgs e)
        {
            String cadenaVocal = textBoxVocal.Text;
            if (cadenaVocal != "")
            {
                char[] vectorVocal = cadenaVocal.ToCharArray();
                //char vocal = ' ';
                char vocal;
                vocal = vectorVocal[0];
                //vectorVocal[0] = vocal;
                switch (vocal)
                {
                    case 'A':
                        buttonImagenVocal.Image = Image.FromFile("vocalMayusculaA.jpg");
                        textBoxVocal.Text = "";
                        cadenaVocal = null;
                        break;
                    case 'E':
                        buttonImagenVocal.Image = Image.FromFile("vocalMayusculaE.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'I':
                        buttonImagenVocal.Image = Image.FromFile("vocalMayusculaI.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'O':
                        buttonImagenVocal.Image = Image.FromFile("vocalMayusculaO.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'U':
                        buttonImagenVocal.Image = Image.FromFile("vocalMayusculaU.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'a':
                        buttonImagenVocal.Image = Image.FromFile("vocalMinusculaa.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'e':
                        buttonImagenVocal.Image = Image.FromFile("vocalMinusculae.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'i':
                        buttonImagenVocal.Image = Image.FromFile("vocalMinusculai.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'o':
                        buttonImagenVocal.Image = Image.FromFile("vocalMinusculao.jpg");
                        textBoxVocal.Text = "";
                        break;
                    case 'u':
                        buttonImagenVocal.Image = Image.FromFile("vocalMinusculau.jpg");
                        textBoxVocal.Text = "";
                        break;
                }
            }
            
        }
    }
}

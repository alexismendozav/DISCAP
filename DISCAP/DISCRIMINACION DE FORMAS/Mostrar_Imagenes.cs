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

namespace DISCAP.DISCRIMINACION_DE_FORMAS
{
    public partial class Mostrar_Imagenes : Form
    {
        SoundPlayer sonido;
        public Mostrar_Imagenes(string name)
        {
            InitializeComponent();
            pb_imagen.Image = (Image)GetImageByName(name);
            if (name == "Reloj2")
                label1.Text = "RELOJ";
            else
                label1.Text = name;
     
        }
        public Mostrar_Imagenes(string name,int from)
        {
            InitializeComponent();
            pb_imagen.Image = (Image)GetImageByName(name);
            label1.Text = name;
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\"+name+".wav");
            sonido.Play();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            sonido.Stop();
        }

        private void Mostrar_Imagenes_Load(object sender, EventArgs e)
        {

        }
        public static Bitmap GetImageByName(string imageName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imageName);

        }
    }
}

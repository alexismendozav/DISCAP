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

namespace DISCAP.MEMORIA_AUDITIVA
{
    public partial class Ejercicio1 : Form
    {
        SoundPlayer sonido;
        int numeroSonido;
        int numeroImagen = 0;
        int aux = 0;
        Random rnd = new Random();
        List<string> sonidos = new List<string> {
            "perro","patrulla","Iglesia"
        };
        List<string> imagenes = new List<string> {
            "perro","patrulla","Iglesia","Urban","Peatonal","Licuadora"
        };
        public Ejercicio1()
        {
            InitializeComponent();
           
            numeroSonido = rnd.Next(3);
            Load_Images();
            sonido = new SoundPlayer(Application.StartupPath + @"\sonidos\" + sonidos[numeroSonido] + ".wav");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonido.Play();
        }

        public static Bitmap GetImageByName(string imageName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imageName);

        }
        //CARGAR IMAGENES
        public void Load_Images()
        {
            numeroImagen = rnd.Next(2);
            if (numeroImagen == 0)
            {
                numeroImagen = rnd.Next(6);
                Uno.Image = (Image)GetImageByName(imagenes[numeroImagen]);
                numeroImagen = rnd.Next(6);
                Dos.Image = (Image)GetImageByName(imagenes[numeroImagen]);
                Tres.Image = (Image)GetImageByName(sonidos[numeroSonido]);                            
                //VARIABLE QUE NOS INDICARÁ COMO SE ACOMODARON LAS IMAGENES
                aux = 1;
            }
            else if (numeroImagen == 1)
            {
                Uno.Image = (Image)GetImageByName(sonidos[numeroSonido]);
                numeroImagen = rnd.Next(6);
                Dos.Image = (Image)GetImageByName(imagenes[numeroImagen]);
                numeroImagen = rnd.Next(6);
                Tres.Image = (Image)GetImageByName(imagenes[numeroImagen]);
                aux = 2;
            }
            else if (numeroImagen == 2)
            {
                numeroImagen = rnd.Next(6);
                Uno.Image = (Image)GetImageByName(imagenes[numeroImagen]);
                Dos.Image = (Image)GetImageByName(sonidos[numeroSonido]);
                numeroImagen = rnd.Next(6);
                Tres.Image = (Image)GetImageByName(imagenes[numeroImagen]);           
                aux = 3;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uno_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1: DISCRIMINACION_DE_FORMAS.GoodorBad_Job good = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(0); good.ShowDialog(); break;
                case 2: DISCRIMINACION_DE_FORMAS.GoodorBad_Job bad = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(1); bad.ShowDialog();  break;
                case 3: DISCRIMINACION_DE_FORMAS.GoodorBad_Job bad1 = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(0); bad1.ShowDialog(); break;
            }
        }

        private void Dos_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1: DISCRIMINACION_DE_FORMAS.GoodorBad_Job good = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(0); good.ShowDialog(); break;
                case 2: DISCRIMINACION_DE_FORMAS.GoodorBad_Job bad = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(0); bad.ShowDialog(); break;
                case 3: DISCRIMINACION_DE_FORMAS.GoodorBad_Job bad1 = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(1); bad1.ShowDialog(); break;
            }
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1: DISCRIMINACION_DE_FORMAS.GoodorBad_Job good = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(1); good.ShowDialog(); break;
                case 2: DISCRIMINACION_DE_FORMAS.GoodorBad_Job bad = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(0); bad.ShowDialog(); break;
                case 3: DISCRIMINACION_DE_FORMAS.GoodorBad_Job bad1 = new DISCRIMINACION_DE_FORMAS.GoodorBad_Job(0); bad1.ShowDialog(); break;
            }
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}

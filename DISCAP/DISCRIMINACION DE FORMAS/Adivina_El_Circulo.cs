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
   
    public partial class Adivina_El_Circulo : Form
    {
        
        Random rnd = new Random();
        int numero=0;
        int aux = 0;
        //SE CREAN LISTAS CON LOS DIFERENTES NOMBRES DE LAS IMAGENES
        #region LISTAS 
        //LISTA QUE TIENE EL NOMBRE DE LOS RECURSOS DE LOS CIRCULOS
        List<string> circulos = new List<string>()
        {
            "cd","pizza","llanta","Reloj2","moneda","luna"
        };
        //LISTA QUE TIENE EL NOMBRE DE LOS RECURSOS DE LOS CUADRADOS
        List<string> cuadrados = new List<string>()
        {
            "cuadro","almohada","caja","pantalla","servilleta","ventana"
        };
        //LISTA QUE TIENE EL NOMBRE DE LOS RECURSOS DE LOS RECTANGULOS
        List<string> rectangulos = new List<string>()
        {
            "Trailer","Colchon","Libreta","Celular","Caja_Zapatos","Repisa"
        };
        List<string> triangulos = new List<string>()
        {
            "Rebanada","Advertencia","Señalamiento","Escuadras","Cruce","Pañuelo"
        };
        List<string> posciociones = new List<string>()
        {
            "Uno","Dos","Tres","Cuatro","Cinco"
        };
        #endregion

        public Adivina_El_Circulo()
        {
            InitializeComponent();
            //LLAMA AL METODO QUE CARGA LAS IMAGENES
            Load_Images();
        }
           
        //CIERRA APP
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CIERRA APP
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adivina_El_Circulo_Load(object sender, EventArgs e)
        {
         
        }
        //MANDA A TRAER UNA IMAGEN DE LOS RECURSOS
        public static Bitmap GetImageByName(string imageName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imageName);

        }

        private void Uno_Click(object sender, EventArgs e)
        {
            //HACE UNA FUNCION DE ACUERDO A COMO SE HAYAN ACOMODADO LAS IMAGENES, SABEMOS COMO ESTAN POR LA VARIABLE AUX
            switch (aux)
            {
                case 1: GoodorBad_Job good = new GoodorBad_Job(1);  good.ShowDialog(); Load_Images(); break;
                case 2: GoodorBad_Job bad = new GoodorBad_Job(0); bad.ShowDialog(); break;
                case 3: GoodorBad_Job bad1 = new GoodorBad_Job(0); bad1.ShowDialog(); break;
            }
    
        }

        private void Dos_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1: GoodorBad_Job bad = new GoodorBad_Job(0); bad.ShowDialog();  break;
                case 2: GoodorBad_Job good = new GoodorBad_Job(1); good.ShowDialog(); Load_Images();break;
                case 3: GoodorBad_Job bad1 = new GoodorBad_Job(0); bad1.ShowDialog();  break;           
            }

        }

        private void Tres_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1: GoodorBad_Job bad = new GoodorBad_Job(0); bad.ShowDialog(); break;
                case 2: GoodorBad_Job bad1 = new GoodorBad_Job(0); bad1.ShowDialog(); break;
                case 3: GoodorBad_Job good = new GoodorBad_Job(1); good.ShowDialog(); Load_Images();  break;
            }
        }

        private void Cuatro_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1: GoodorBad_Job bad = new GoodorBad_Job(0); bad.ShowDialog(); break;
                case 2: GoodorBad_Job good = new GoodorBad_Job(1); good.ShowDialog(); Load_Images(); break;
                case 3: GoodorBad_Job bad1 = new GoodorBad_Job(0); bad1.ShowDialog();  break;
            }
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1: GoodorBad_Job good = new GoodorBad_Job(1); good.ShowDialog(); Load_Images();  break;
                case 2: GoodorBad_Job bad = new GoodorBad_Job(0); bad.ShowDialog();  break;
                case 3: GoodorBad_Job bad1 = new GoodorBad_Job(0); bad1.ShowDialog();  break;
            }
        }

        //CARGAR IMAGENES
        public void Load_Images()
        {
            numero = rnd.Next(6);
            if (numero <= 2)
            {
                numero = rnd.Next(6);
                Uno.Image = (Image)GetImageByName(circulos[numero]);
                Dos.Image = (Image)GetImageByName(cuadrados[numero]);
                Tres.Image = (Image)GetImageByName(triangulos[numero]);
                Cuatro.Image = (Image)GetImageByName(rectangulos[numero]);
                numero = rnd.Next(6);
                Cinco.Image = (Image)GetImageByName(circulos[numero]);
                //VARIABLE QUE NOS INDICARÁ COMO SE ACOMODARON LAS IMAGENES
                aux = 1;
            }
            else if (numero > 2 && numero <= 4)
            {
                numero = rnd.Next(6);
                Uno.Image = (Image)GetImageByName(cuadrados[numero]);
                Dos.Image = (Image)GetImageByName(circulos[numero]);
                Tres.Image = (Image)GetImageByName(triangulos[numero]);
                numero = rnd.Next(6);
                Cuatro.Image = (Image)GetImageByName(circulos[numero]);
                Cinco.Image = (Image)GetImageByName(cuadrados[numero]);
                aux = 2;
            }
            else if (numero >= 5)
            {
                numero = rnd.Next(6);
                Uno.Image = (Image)GetImageByName(rectangulos[numero]);
                Dos.Image = (Image)GetImageByName(cuadrados[numero]);
                Tres.Image = (Image)GetImageByName(circulos[numero]);
                numero = rnd.Next(6);
                Cuatro.Image = (Image)GetImageByName(rectangulos[numero]);
                numero = rnd.Next(6);
                Cinco.Image = (Image)GetImageByName(cuadrados[numero]);
                aux = 3;
            }
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP
{
    public partial class Categorias : Form
    {
        private int posX;
        private int posY;
        Inicio formPrincipal;

        public Categorias()
        {
            InitializeComponent();
       
        }

        private void Categorias_Load(object sender, EventArgs e)
        {

        }
        //CIERRA LA APLICACION
        private void btnClose_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }
        //EVENTO QUE MUEVE EL FORM DE POSISCION 
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        //MAXIMIZAR FORM
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
                //btnSensopercepcion.Font = new Font(new FontFamily("Montserrat"), 20);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
              
            }
        }

        //OBTIENE EL FORM PRINCIPAL ->
        public void setForm (Inicio formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();

        }

        #region Mensajes en los botones 
        private void btnSensopercepcion_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnSensopercepcion, "Ayuda al niño a discriminar colores");
        }
        private void btnFormas_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnFormas, "Ayuda al niño a discriminar formas geométricas básicas:\nCírculo, cuadrado,triángulo y rectángulo");
        }
    
        private void btnEspacio_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnEspacio, "Ayuda al niño a identificar:\nDia y noche ,ayer,hoy,Mañana,dias y meses");
        }

       private void btnLateralidad_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnLateralidad, "Ayuda al niño a identificar:\nIzquierda y derecha");
        }

        private void btnAuditiva_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnAuditiva, "Ayuda al niño a recordar sonidos y secuencias de sonidos");
        }

        private void btnVisual_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnVisual, "Ayuda al niño a recordar estimulos visuales y secuencias de estimulos visuales");
        }

        private void btnPrenumericos_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnPrenumericos, "Ayuda al niño a tener conceptos de alto, bajo, chico, grande,...");
        }
      
        private void btnEsquema_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnEsquema, "Ayuda al niño a identificar partes del cuerpo como:\n Orejas, nariz, cejas, ...");
        }

        private void btnEscritura_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnEscritura, "Ayuda al niño a reconocer vocales, consonantes,\nletras mayusculas y minusculas, ...\n");
        }

        private void btnLectura_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnLectura, "Ayuda al niño a leer silabas, palabras, frases, ...");
        }

        private void btnCalculo_MouseHover(object sender, EventArgs e)
        {
            message.IsBalloon = true;
            message.SetToolTip(btnCalculo, "Ayuda al niño a realizar conteos, reconocer números anteriores y posteriores,\nTiene concepto de unidad, decena, centena, ...");
        }
        #endregion

        private void btnAuditiva_Click(object sender, EventArgs e)
        {
           MEMORIA_AUDITIVA.Sonidos ne=new MEMORIA_AUDITIVA.Sonidos();
            ne.ShowDialog();
        }

        private void btnFormas_Click(object sender, EventArgs e)
        {
            Elegir_ejercicio ddf =new Elegir_ejercicio();
            ddf.WindowState = FormWindowState.Maximized;
            ddf.ShowDialog();
        }

        private void btnSensopercepcion_Click(object sender, EventArgs e)
        {
            SENSOPERCEPCION.InicioSensopercepcion inicio = new SENSOPERCEPCION.InicioSensopercepcion();
            inicio.ShowDialog();
        }

        private void btnEspacio_Click(object sender, EventArgs e)
        {
            NOCIONES_TEMPORALES.Ejercicios_Neuroespaciales ejercicios = new NOCIONES_TEMPORALES.Ejercicios_Neuroespaciales();
            ejercicios.ShowDialog();

        }

        private void btnLateralidad_Click(object sender, EventArgs e)
        {
            LATERALIDAD.Actividad1 actividad = new LATERALIDAD.Actividad1();
            actividad.ShowDialog();
        }

        private void btnEscritura_Click(object sender, EventArgs e)
        {
            ESCRITURA.Escritura escritura = new ESCRITURA.Escritura();
            escritura.ShowDialog();
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            Building building = new Building();
            building.ShowDialog();
        }

        private void btnPrenumericos_Click(object sender, EventArgs e)
        {
            PRENUMERICOS.Home home = new PRENUMERICOS.Home();
            home.ShowDialog();
        }

        private void btnEsquema_Click(object sender, EventArgs e)
        {
            ESQUEMA_CORPORAL.EsquemaCorporal home = new ESQUEMA_CORPORAL.EsquemaCorporal();
            home.ShowDialog();
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            LECTURA.Lectura lectura = new LECTURA.Lectura();
            lectura.ShowDialog();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            CALCULO.Calculo_1 menu = new CALCULO.Calculo_1();
            menu.ShowDialog();
        }
    }
}

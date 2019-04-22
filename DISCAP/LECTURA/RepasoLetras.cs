using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISCAP.LECTURA
{
    public partial class RepasoLetras : Form
    {
        private int widthDefault = 25;
        private int heightDefault = 35;
        //efecto hover de los iconos
        private int width_Hover = 35;
        private int height_Hover = 45;
        public RepasoLetras()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            this.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_A.mp4");
        }
        private void reproduceVideo(String ruta)
        {
            try
            {
                axWindowsMediaPlayer1.URL = ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception)
            {
                //lblRuta.Text = "Hubo un error al intentar reproducir el video!...";
            }
        }
        #region METODOS DE MAUSE LEAVE Y MAUSE ENTER PARA QUE EL BOTON TENGA EL EFECTO DE HOVER
        private void btnA_MouseEnter(object sender, EventArgs e)
        {
            btnA.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnA_MouseLeave(object sender, EventArgs e)
        {
            btnA.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnB_MouseEnter(object sender, EventArgs e)
        {
            btnB.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnB_MouseLeave(object sender, EventArgs e)
        {
            btnB.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnC_MouseEnter(object sender, EventArgs e)
        {
            btnC.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnC_MouseLeave(object sender, EventArgs e)
        {
            btnC.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnD_MouseEnter(object sender, EventArgs e)
        {
            btnD.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnD_MouseLeave(object sender, EventArgs e)
        {
            btnD.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnE_MouseEnter(object sender, EventArgs e)
        {
            btnE.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnE_MouseLeave(object sender, EventArgs e)
        {
            btnE.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnF_MouseEnter(object sender, EventArgs e)
        {
            btnF.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnF_MouseLeave(object sender, EventArgs e)
        {
            btnF.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnG_MouseEnter(object sender, EventArgs e)
        {
            btnG.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnG_MouseLeave(object sender, EventArgs e)
        {
            btnG.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnH_MouseEnter(object sender, EventArgs e)
        {
            btnH.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnH_MouseLeave(object sender, EventArgs e)
        {
            btnH.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnI_MouseEnter(object sender, EventArgs e)
        {
            btnI.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnI_MouseLeave(object sender, EventArgs e)
        {
            btnI.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnJ_MouseEnter(object sender, EventArgs e)
        {
            btnJ.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnJ_MouseLeave(object sender, EventArgs e)
        {
            btnJ.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnK_MouseEnter(object sender, EventArgs e)
        {
            btnK.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnK_MouseLeave(object sender, EventArgs e)
        {
            btnK.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnL_MouseEnter(object sender, EventArgs e)
        {
            btnL.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnL_MouseLeave(object sender, EventArgs e)
        {
            btnL.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnM_MouseEnter(object sender, EventArgs e)
        {
            btnM.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnM_MouseLeave(object sender, EventArgs e)
        {
            btnM.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnN_MouseEnter(object sender, EventArgs e)
        {
            btnN.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnN_MouseLeave(object sender, EventArgs e)
        {
            btnN.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnÑ_MouseEnter(object sender, EventArgs e)
        {
            btnÑ.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnÑ_MouseLeave(object sender, EventArgs e)
        {
            btnÑ.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnO_MouseEnter(object sender, EventArgs e)
        {
            btnO.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnO_MouseLeave(object sender, EventArgs e)
        {
            btnO.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnP_MouseEnter(object sender, EventArgs e)
        {
            btnP.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnP_MouseLeave(object sender, EventArgs e)
        {
            btnP.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnQ_MouseEnter(object sender, EventArgs e)
        {
            btnQ.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnQ_MouseLeave(object sender, EventArgs e)
        {
            btnQ.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnR_MouseEnter(object sender, EventArgs e)
        {
            btnR.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnR_MouseLeave(object sender, EventArgs e)
        {
            btnR.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnS_MouseEnter(object sender, EventArgs e)
        {
            btnS.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnS_MouseLeave(object sender, EventArgs e)
        {
            btnS.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnT_MouseEnter(object sender, EventArgs e)
        {
            btnT.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnT_MouseLeave(object sender, EventArgs e)
        {
            btnT.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnU_MouseEnter(object sender, EventArgs e)
        {
            btnU.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnU_MouseLeave(object sender, EventArgs e)
        {
            btnU.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnV_MouseEnter(object sender, EventArgs e)
        {
            btnV.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnV_MouseLeave(object sender, EventArgs e)
        {
            btnV.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnW_MouseEnter(object sender, EventArgs e)
        {
            btnW.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnW_MouseLeave(object sender, EventArgs e)
        {
            btnW.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnX_MouseEnter(object sender, EventArgs e)
        {
            btnX.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnX_MouseLeave(object sender, EventArgs e)
        {
            btnX.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnY_MouseEnter(object sender, EventArgs e)
        {
            btnY.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnY_MouseLeave(object sender, EventArgs e)
        {
            btnY.Size = new Size(width: widthDefault, height: heightDefault);
        }

        private void btnZ_MouseEnter(object sender, EventArgs e)
        {
            btnZ.Size = new Size(width: width_Hover, height: height_Hover);
        }

        private void btnZ_MouseLeave(object sender, EventArgs e)
        {
            btnZ.Size = new Size(width: widthDefault, height: heightDefault);
        }
        #endregion
        #region Reproduce el video de cada letra cuando se le da clic
        private void btnB_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_B.mp4");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_C.mp4");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_D.mp4");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_E.mp4");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_F.mp4");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_G.mp4");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_H.mp4");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_I.mp4");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_J.mp4");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_K.mp4");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_L.mp4");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_M.mp4");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_N.mp4");
        }

        private void btnÑ_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_Ñ.mp4");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_O.mp4");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnP_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_P.mp4");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_Q.mp4");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_R.mp4");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_S.mp4");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_T.mp4");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_U.mp4");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_V.mp4");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_W.mp4");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_X.mp4");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_Y.mp4");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            reproduceVideo(Application.StartupPath + @"\videos\Letra_Z.mp4");
        }
        #endregion
    }
}

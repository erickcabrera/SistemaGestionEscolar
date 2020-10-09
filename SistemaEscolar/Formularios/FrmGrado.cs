using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaEscolar.Formularios
{
    public partial class FrmGrado : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );

        public FrmGrado()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {

        }

        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;

            //if para validar camppos vacíos en el formulario de Profesor

            if (txtGrado.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtGrado, "Debe ingresar una materia");
            }

            return validado;
        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtGrado, "");
        }


        private void picBSalir_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin f = new FrmMenuAdmin();
            f.Show();
            this.Hide();
        }

        private void FrmGrado_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarGrado_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (validarCampos())
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

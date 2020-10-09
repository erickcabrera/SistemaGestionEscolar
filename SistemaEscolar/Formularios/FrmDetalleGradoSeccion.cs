using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace SistemaEscolar.Formularios
{
    public partial class FrmDetalleGradoSeccion : Form
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

        public FrmDetalleGradoSeccion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin f = new FrmMenuAdmin();
            f.Show();
            this.Hide();
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;

            //if para validar camppos vacíos en el formulario de Profesor

            if (cmbGrado.SelectedIndex==-1)
            {
                validado = false;
                errorProvider1.SetError(cmbGrado, "Debe elegir un grado");
            }
            if (cmbProfesor.SelectedIndex == -1)
            {
                validado = false;
                errorProvider1.SetError(cmbProfesor, "Debe elegir un profesor");
            }
            if (cmbSeccion.SelectedIndex == -1)
            {
                validado = false;
                errorProvider1.SetError(cmbSeccion, "Debe elegir una seccion");
            }

            int anio = DateTime.Now.Year;
            if(anio>dtpAnio.Value.Year)
            {
                errorProvider1.SetError(dtpAnio, "Debe elegir un ano no mayor al actual");
            }
            

            return validado;
        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(cmbGrado, "");
            errorProvider1.SetError(cmbProfesor, "");
            errorProvider1.SetError(cmbSeccion, "");
        }
       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (validarCampos())
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

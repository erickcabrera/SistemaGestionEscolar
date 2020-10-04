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
using SistemaEscolar.Formularios;

namespace SistemaEscolar.Formularios
{
    public partial class FrmAlumno : Form
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
        public FrmAlumno()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            
        }

        //validar que la fecha de nacimiento no sea mayor a la fecha del sistema
        private bool ValidarFechaySexo()

        {
            DateTime FechaNacimiento= dtpFechanacimiento.Value;
            bool validarF = true;


            if (FechaNacimiento > System.DateTime.Now.Date )
            {
                validarF = false;
                errorProvider1.SetError(dtpFechanacimiento, "La fecha no puede ser mayor a la fecha de este día");
                
            }
            if(cmbSexoA.SelectedIndex==-1)
            {
                validarF = false;
                errorProvider1.SetError(cmbSexoA, "Este campo no puede estar vacío");
            }
            return validarF;
        }
        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAdmin frmMP = new FrmMenuAdmin();
            frmMP.Show();
            this.Hide();
        }

        private void txtNombreA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombreA, "En este campo sólo se permiten letras");
            }
        }

        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;
            //if para validar camppos vacíos en el formulario de Alumno
            if(txtApellidoA.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtApellidoA, "Ingresar los apellidos del alumno");
            }
           

            if(mtxtNIEA.MaskFull){ }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNIEA, "Ingresar el número de NIE del alumno");
            }

            if(txtPadre.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtPadre, "Ingresar el nombre del padre");
            }
            if(txtMadre.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtMadre, "Ingresar el nombre de la madre");
            }
            if(txtEncargado.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtEncargado, "Ingresar el nombre del encargado");
            }
            if (txtNombreA.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtNombreA, "Ingresar el nombre del alumno");
            }
            if(mtxtNumPartidaA.MaskFull){ }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNumPartidaA, "Ingresar el número de partida de nacimiento");
            }

            if (mtxtTelefonoA.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtTelefonoA, "Ingresar el número de teléfono del alumno");
            }
            if(rtbDireccionA.Text=="")
            {
                validado = false;
                errorProvider1.SetError(rtbDireccionA, "Proporcione una dirección de vivienda");
            }
            return validado;

        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtApellidoA, "");
            errorProvider1.SetError(txtPadre, "");
            errorProvider1.SetError(mtxtNIEA, "");
            errorProvider1.SetError(txtMadre, "");
            errorProvider1.SetError(txtNombreA, "");
            errorProvider1.SetError(mtxtNumPartidaA, "");
            errorProvider1.SetError(mtxtTelefonoA, "");
            errorProvider1.SetError(txtEncargado, "");
            errorProvider1.SetError(rtbDireccionA, "");
        }

        private void txtApellidoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtApellidoA, "En este campo sólo se permiten letras");
            }
        }

        private void btnGuardarA_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();

            if (validarCampos() || ValidarFechaySexo())
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtPadre, "En este campo sólo se permiten letras");
            }
        }

        private void txtMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtMadre, "En este campo sólo se permiten letras");
            }
        }

        private void txtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtEncargado, "En este campo sólo se permiten letras");
            }
        }
    }
}

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
using System.Text.RegularExpressions;

namespace SistemaEscolar.Formularios
{
    public partial class FrmProfesor : Form
    {
        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );*/
        public FrmProfesor()
        {
            InitializeComponent();
            /*this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));*/
        }
        
       
        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;

           //if para validar camppos vacíos en el formulario de Profesor
            
            if(txtApellidoP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtApellidoP, "Ingresar los apellidos del docente");
            }

            if (mtxtDUIP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtDUIP, "Ingresar el número de DUI");
            }

            if (mtxtNITP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNITP, "Ingresar el número de NIT del docente");
            }

            if(txtNombreP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtNombreP, "Ingresar el nombre del docente");
            }

            if (mtxtNumEscalafonP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNumEscalafonP, "Ingresar el número de escalafón");
            }

            if (mtxtTelefonoP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtTelefonoP, "Ingresar el número de teléfono del docente");
            }

            if(txtEmailP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtEmailP, "Ingresar el correo electrónico del docente");
            }

            if(rtbDireccionP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(rtbDireccionP, "Proporcione una dirección de vivienda");
            }

            return validado;
        }


        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtApellidoP, "");
            errorProvider1.SetError(mtxtDUIP, "");
            errorProvider1.SetError(mtxtNITP, "");
            errorProvider1.SetError(txtNombreP, "");
            errorProvider1.SetError(mtxtNumEscalafonP, "");
            errorProvider1.SetError(mtxtTelefonoP, "");
            errorProvider1.SetError(txtEmailP, "");
            errorProvider1.SetError(dtpFechaP, "");
            errorProvider1.SetError(rtbDireccionP, "");
        }

        private bool ValidarFechaySexo()

        {
            DateTime FechaNacimiento = dtpFechaP.Value;
            bool validarF = true;


            if (FechaNacimiento > System.DateTime.Now.Date )
            {
                validarF = false;
                errorProvider1.SetError(dtpFechaP, "La fecha no puede ser mayor a la fecha de este día");

            }
            if (cmbSexoP.SelectedIndex == -1)
            {
                validarF = false;
                errorProvider1.SetError(cmbSexoP, "Este campo no puede estar vacío");
            }
            return validarF;
        }

        private bool validarCorreo(string correo)
        {
            string cadena = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, cadena))
            {
                if (Regex.Replace(correo, cadena, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validarCampos() || ValidarFechaySexo())
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAdmin f = new FrmMenuAdmin();
            f.Show();
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {

        }

       

        private void txtEmailP_TextChanged(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (validarCorreo(txtEmailP.Text))
            {

            }
            else
            {
                errorProvider1.SetError(txtEmailP, "El formato del correo no es válido");
            }
        }

        private void txtNombreP_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(txtNombreP, "En este campo sólo se permiten letras");
            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(txtApellidoP, "En este campo sólo se permiten letras");
            }
        }

        private void picBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /* private void picBMinimizar_Click(object sender, EventArgs e)
         {
             this.WindowState = FormWindowState.Minimized;
         }*/
    }
}

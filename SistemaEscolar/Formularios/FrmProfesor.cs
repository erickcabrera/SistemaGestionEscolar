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
    public partial class FrmProfesor : Form
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
        public FrmProfesor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;

            //if para validar camppos vacíos en el formulario de Profesor
            if (txtApellidoP.Text == "" || txtDUIP.Text == "" ||  txtNITP.Text == "" ||
                txtNombreP.Text == "" || txtNumEscalafonP.Text == "" || txtTelefonoP.Text == ""||txtEmailP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtApellidoP, "Ingresar los apellidos del docente");
                errorProvider1.SetError(txtDUIP, "Ingresar el número de DUI");
                errorProvider1.SetError(txtNITP, "Ingresar el número de NIT del docente");
                errorProvider1.SetError(txtNombreP, "Ingresar el nombre del docente");
                errorProvider1.SetError(txtNumEscalafonP, "Ingresar el número de escalafón");
                errorProvider1.SetError(txtTelefonoP, "Ingresar el número de teléfono del docente");
                errorProvider1.SetError(txtNombreP, "Ingresar el correo electrónico del docente");
                errorProvider1.SetError(txtEmailP, "Ingresar el correo electrónico del docente");


            }
            return validado;
        
        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtApellidoP, "");
            errorProvider1.SetError(txtDUIP, "");
            errorProvider1.SetError(txtNITP, "");
            errorProvider1.SetError(txtNombreP, "");
            errorProvider1.SetError(txtNumEscalafonP, "");
            errorProvider1.SetError(txtTelefonoP, "");
            errorProvider1.SetError(txtEmailP, "");
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if(validarCampos())
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

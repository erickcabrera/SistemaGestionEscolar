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
using SistemaEscolar.Clases;

namespace SistemaEscolar.Formularios
{
    public partial class materia : Form
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

        public materia()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAdmin formMP = new FrmMenuAdmin();
            formMP.Show();
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

            if (txtMateria.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtMateria, "Debe ingresar una materia");
            }

            return validado;
        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtMateria, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*BorrarMensaje();
            if(validarCampos())
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

            if(txtMateria.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingresar todos los datos");
            }
            else
            {
                try
                {
                    Materia materia = new Materia();
                    materia.NombreMateria = txtMateria.Text.ToUpper();

                    if(materia.Agregar(materia.NombreMateria) == true)
                    {
                        MessageBox.Show("La materia ha sido agregada correctamente");
                        btnEliminarMateria.Enabled = false;
                        btnAgregarMateria.Enabled = true;
                        btnModificarMateria.Enabled = false;
                        ActualizarDataGrid();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar materia");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
             
        }

        public void Limpiar()
        {
            txtMateria.Clear();
        }

        public void ActualizarDataGrid()
        {
            Materia materia = new Materia();
            dgvMaterias.DataSource = null;
            dgvMaterias.DataSource = materia.Mostrar();
            dgvMaterias.ClearSelection();
            
        }

        private void materia_Load(object sender, EventArgs e)
        {
            materia  materia = new materia();
            try
            {
                ActualizarDataGrid();
                btnModificarMateria.Enabled = false;
                btnEliminarMateria.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message);
            }
        }
    }
}

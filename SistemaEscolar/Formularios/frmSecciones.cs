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
    public partial class frmSecciones : Form
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

        public frmSecciones()
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

            if (txtSeccion.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtSeccion, "Debe ingresar una materia");
            }

            return validado;
        }
        private void ActualizarDataGrid()
        {
            Seccion seccion = new Seccion();
            dgvSecciones.DataSource = null;
            dgvSecciones.DataSource = seccion.Mostrar();
            dgvSecciones.ClearSelection();
        }
        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtSeccion, "");
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin frmMA = new FrmMenuAdmin();
            frmMA.Show();
            this.Hide();
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Limpiar()
        {
            txtSeccion.Clear();
            txtSeccion.Focus();
            lblseccion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtSeccion.Text == String.Empty)
            {
                MessageBox.Show("Por favor ingresar todos los datos");
            }
            else
            {
                try
                {
                    Seccion seccion = new Seccion();
                    seccion.NombreSeccion = txtSeccion.Text.ToUpper();

                    if (seccion.Agregar(seccion.NombreSeccion) == true)
                    {
                        MessageBox.Show("La sección ha sido agregada correctamente");
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la sección");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void frmSecciones_Load(object sender, EventArgs e)
        {
            Seccion seccion = new Seccion();
            try
            {
                ActualizarDataGrid();
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtSeccion.Text == String.Empty && lblseccion.Text == String.Empty)
            {
                MessageBox.Show("Por favor ingresar todos los datos");
            }
            else
            {
                try
                {
                    Seccion seccion = new Seccion();
                    seccion.NombreSeccion = txtSeccion.Text.ToUpper();

                    if (seccion.Modificar(seccion.NombreSeccion, int.Parse(lblseccion.Text)) == true)
                    {
                        MessageBox.Show("La seccion ha sido modificada correctamente");
                        ActualizarDataGrid();
                        Limpiar();
                        lblseccion.Text = "";
                        btnModificar.Enabled = false;
                        btnAgregar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el grado");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSecciones.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro numero " + lblseccion.Text + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Seccion seccion = new Seccion();

                    if (seccion.Eliminar(int.Parse(lblseccion.Text)) == true)
                    {
                        MessageBox.Show("La sección se ha eliminado correctamente");
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al eliminar la sección");
                        txtSeccion.Text = "";
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    btnEliminar.Enabled = false;
                    dgvSecciones.ClearSelection();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

       

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Seccion seccion = new Seccion();

                dgvSecciones.DataSource = null;
                dgvSecciones.DataSource = seccion.Buscar(txtBuscar.Text);
                dgvSecciones.ClearSelection();
                txtBuscar.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}

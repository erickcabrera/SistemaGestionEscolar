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
    public partial class FrmSecciones : Form
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

        public FrmSecciones()
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
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Seccion seccion = new Seccion();
                    seccion.NombreSeccion = txtSeccion.Text.ToUpper();

                    if (seccion.Agregar(seccion.NombreSeccion) == true)
                    {
                        MessageBox.Show("La sección ha sido agregada correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar sección", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al agregar sección " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                lblseccion.Visible = false;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtSeccion.Text == String.Empty && lblseccion.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Seccion seccion = new Seccion();
                    seccion.NombreSeccion = txtSeccion.Text.ToUpper();

                    if (seccion.Modificar(seccion.NombreSeccion, int.Parse(lblseccion.Text)) == true)
                    {
                        MessageBox.Show("La sección ha sido modificado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarDataGrid();
                        Limpiar();
                        lblseccion.Text = "";
                        btnModificar.Enabled = false;
                        btnAgregar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar sección", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al modificar sección " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("La sección ha sido eliminada correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar sección", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvSecciones_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSecciones.SelectedRows.Count > 0)
            {
                txtSeccion.Text = dgvSecciones.CurrentRow.Cells["Seccion"].Value.ToString();
                lblseccion.Text = dgvSecciones.CurrentRow.Cells["Num"].Value.ToString();

                btnModificar.Enabled = true;
                btnEliminar.Enabled = false;
                btnAgregar.Enabled = false;
                txtSeccion.Focus();
                dgvSecciones.CurrentCell.Selected = false;
                dgvSecciones.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSecciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSecciones.SelectedRows.Count > 0)
            {
                try
                {
                    Limpiar();
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = true;
                    lblseccion.Text = dgvSecciones.CurrentRow.Cells["Num"].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void dgvSecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
            Grado grado = new Grado();
            try
            {
                ActualizarDataGrid();
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarGrado_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (validarCampos())
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpiar()
        {
            txtGrado.Clear();
            txtGrado.Focus();
            lblIdGrado.Text = "";
        }

        private void ActualizarDataGrid()
        {
            Grado grado = new Grado();
            dgvGrados.DataSource = null;
            dgvGrados.DataSource = grado.Mostrar();
            dgvGrados.ClearSelection();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtGrado.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Grado grado = new Grado();
                    grado.NombreGrado = txtGrado.Text.ToUpper();

                    if (grado.Agregar(grado.NombreGrado) == true)
                    {
                        MessageBox.Show("El grado ha sido agregado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el grado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al agregar el grado " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvGrados_DoubleClick(object sender, EventArgs e)
        {
            if (dgvGrados.SelectedRows.Count > 0)
            {
                txtGrado.Text = dgvGrados.CurrentRow.Cells["Grado"].Value.ToString();
                lblIdGrado.Text = dgvGrados.CurrentRow.Cells["Num"].Value.ToString();

                btnModificar.Enabled = true;
                btnEliminar.Enabled = false;
                btnAgregar.Enabled = false;
                txtGrado.Focus();
                dgvGrados.CurrentCell.Selected = false;
                dgvGrados.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtGrado.Text == String.Empty && lblIdGrado.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Grado grado = new Grado();
                    grado.NombreGrado = txtGrado.Text.ToUpper();
                    
                    if (grado.Modificar(grado.NombreGrado,int.Parse(lblIdGrado.Text)) == true)
                    {
                        MessageBox.Show("El grado ha sido modificado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        lblIdGrado.Text = "";
                        btnModificar.Enabled = false;
                        btnAgregar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el grado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al modificar el grado " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrados.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro numero " + lblIdGrado.Text  + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Grado grado = new Grado();

                    if (grado.Eliminar(int.Parse(lblIdGrado.Text)) == true)
                    {
                        MessageBox.Show("El grado ha sido eliminado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminar.Enabled = false;
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el grado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtGrado.Text = "";
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    btnEliminar.Enabled = false;
                    dgvGrados.ClearSelection();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvGrados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrados.SelectedRows.Count > 0)
            {
                try
                {
                    Limpiar();
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = true;
                    lblIdGrado.Text = dgvGrados.CurrentRow.Cells["Num"].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Grado grado = new Grado();

                dgvGrados.DataSource = null;
                dgvGrados.DataSource = grado.Buscar(txtBuscar.Text);
                dgvGrados.ClearSelection();
                txtBuscar.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dgvGrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

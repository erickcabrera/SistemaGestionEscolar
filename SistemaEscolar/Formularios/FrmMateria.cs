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
    public partial class FrmMateria : Form
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

        public FrmMateria()
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
            if(txtMateria.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Materia materia = new Materia();
                    materia.NombreMateria = txtMateria.Text.ToUpper();

                    if(materia.Agregar(materia.NombreMateria) == true)
                    {
                        MessageBox.Show("ELa materia ha sido agregada correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnEliminarMateria.Enabled = false;
                        btnAgregarMateria.Enabled = true;
                        btnModificarMateria.Enabled = false;
                        ActualizarDataGrid();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar materia", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Error al agregar materia " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            Materia  materia = new Materia();
            try
            {
                ActualizarDataGrid();
                btnModificarMateria.Enabled = false;
                btnEliminarMateria.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text == String.Empty && lblIdMateria.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Materia materia = new Materia();
                    materia.NombreMateria = txtMateria.Text.ToUpper();

                    if (materia.Modificar(materia.NombreMateria, int.Parse(lblIdMateria.Text)) == true)
                    {
                        MessageBox.Show("La materia ha sido modificada correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarDataGrid();
                        Limpiar();
                        lblIdMateria.Text = "";
                        btnModificarMateria.Enabled = false;
                        btnAgregarMateria.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar materia", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al modificar materia " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMaterias_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                txtMateria.Text = dgvMaterias.CurrentRow.Cells["Materia"].Value.ToString();
                lblIdMateria.Text = dgvMaterias.CurrentRow.Cells["Num"].Value.ToString();

                btnModificarMateria.Enabled = true;
                btnEliminarMateria.Enabled = false;
                btnAgregarMateria.Enabled = false;
                txtMateria.Focus();
                dgvMaterias.CurrentCell.Selected = false;
                dgvMaterias.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                try
                {
                    Limpiar();
                    btnModificarMateria.Enabled = false;
                    btnEliminarMateria.Enabled = true;
                    btnAgregarMateria.Enabled = true;
                    lblIdMateria.Text = dgvMaterias.CurrentRow.Cells["Num"].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro numero " + lblIdMateria.Text + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Materia materia = new Materia();

                    if (materia.Eliminar(int.Parse(lblIdMateria.Text)) == true)
                    {
                        MessageBox.Show("El grado ha sido eliminado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminarMateria.Enabled = false;
                        btnAgregarMateria.Enabled = true;
                        btnModificarMateria.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el grado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMateria.Text = "";
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    btnEliminarMateria.Enabled = false;
                    dgvMaterias.ClearSelection();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Materia materia = new Materia();

                dgvMaterias.DataSource = null;
                dgvMaterias.DataSource = materia.Buscar(txtBuscar.Text);
                dgvMaterias.ClearSelection();
                txtBuscar.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}

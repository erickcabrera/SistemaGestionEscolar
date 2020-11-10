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
using SistemaEscolar.Clases;

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
                DetalleGrupo detalle = new DetalleGrupo();
                if(detalle.AgregarGrupo(int.Parse(lblIdGrado.Text), int.Parse(lblIdSeccion.Text), int.Parse(lblIdProfesor.Text), int.Parse(dtpAnio.Text)) == true)
                {
                    MessageBox.Show("Los datos se han ingresado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al registrar grupo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void ActualizarDataGrid()
        {
            DetalleGrupo detalle = new DetalleGrupo();
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = detalle.Mostrar();
            dgvDetalles.ClearSelection();
        }

        private void FrmDetalleGradoSeccion_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarDataGrid();
                DetalleGrupo detalle = new DetalleGrupo();
                detalle.llenarComboGrado(cmbGrado);
                detalle.llenarComboSeccion(cmbSeccion);
                detalle.llenarComboMaestros(cmbProfesor);
                lblIdDetalle.Text = "";
                lblIdGrado.Text = "";
                lblIdProfesor.Text = "";
                lblIdSeccion.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
        }

        private void cmbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = cmbProfesor.SelectedItem.ToString();
            char delimitador = ' ';
            string[] trozos = cadena.Split(delimitador);

            DetalleGrupo detalle = new DetalleGrupo();
            detalle.obtenerCodigoProfesor(lblIdProfesor, trozos[0], trozos[1]);
        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seccion = cmbSeccion.SelectedItem.ToString();
            DetalleGrupo detalle = new DetalleGrupo();
            detalle.obtenerCodigoSeccion(lblIdSeccion, seccion);
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grado = cmbGrado.SelectedItem.ToString();
            DetalleGrupo detalle = new DetalleGrupo();
            detalle.obtenerCodigoGrado(lblIdGrado, grado);
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {                
                lblIdDetalle.Text = dgvDetalles.CurrentRow.Cells["Codigo_Grupo"].Value.ToString();
                cmbGrado.Text = dgvDetalles.CurrentRow.Cells["Grado"].Value.ToString();
                cmbProfesor.Text = dgvDetalles.CurrentRow.Cells["Profesor_Encargado"].Value.ToString();
                cmbSeccion.Text = dgvDetalles.CurrentRow.Cells["Seccion"].Value.ToString();                
                dgvDetalles.CurrentCell.Selected = false;
                dgvDetalles.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblIdDetalle.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro numero " + lblIdDetalle.Text + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    DetalleGrupo detalle = new DetalleGrupo();

                    if (detalle.EliminarGrupo(int.Parse(lblIdDetalle.Text)) == true)
                    {
                        MessageBox.Show("El grupo ha sido eliminado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarDataGrid();
                        lblIdDetalle.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar registro", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (resultado == DialogResult.No)
                {
                   
                    dgvDetalles.ClearSelection();
                    lblIdDetalle.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblIdSeccion_Click(object sender, EventArgs e)
        {

        }

        private void lblIdDetalle_Click(object sender, EventArgs e)
        {

        }

        private void lblIdProfesor_Click(object sender, EventArgs e)
        {

        }

        private void lblIdGrado_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lblIdDetalle.Text != "")
            {
                if (lblIdGrado.Text != "")
                {
                    if (lblIdProfesor.Text != "")
                    {
                        if (lblIdSeccion.Text != "")
                        {
                            try
                            {
                                DetalleGrupo detalle = new DetalleGrupo();
                                if (detalle.ModificarCurso(int.Parse(lblIdDetalle.Text), int.Parse(lblIdGrado.Text), int.Parse(lblIdSeccion.Text), int.Parse(lblIdProfesor.Text), int.Parse(dtpAnio.Text)) == true)
                                {
                                    ActualizarDataGrid();
                                    lblIdDetalle.Text = "";
                                    MessageBox.Show("Grupo actualizado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar el grupo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al actualizar el grupo " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe de seleccionar sección", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe de seleccionar profesor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar un grado", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro para modificar", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

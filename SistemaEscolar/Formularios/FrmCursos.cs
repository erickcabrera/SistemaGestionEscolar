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
    public partial class FrmCursos : Form
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

        public FrmCursos()
        {            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin frmMA = new FrmMenuAdmin();
            frmMA.Show();
            this.Hide();
        }
        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;

            //if para validar camppos vacíos en el formulario de Profesor

            if (cmbMaterias.SelectedIndex == -1)
            {
                validado = false;
                errorProvider1.SetError(cmbMaterias, "Debe elegir una materia");
            }
            if (cmbProfesor.SelectedIndex == -1)
            {
                validado = false;
                errorProvider1.SetError(cmbProfesor, "Debe elegir un profesor");
            }


            return validado;
        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(cmbMaterias, "");
            errorProvider1.SetError(cmbProfesor, "");
            
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(lblIdMateria.Text != "")
            {
                if(lblDetalle.Text != "")
                {
                    if(lblIdProfesor.Text != "")
                    {
                        try
                        {
                            Curso curso = new Curso();
                            curso.Id_Detalle_Grado = int.Parse(lblDetalle.Text);
                            curso.Id_Materia = int.Parse(lblIdMateria.Text);
                            curso.Id_Profesor = int.Parse(lblIdProfesor.Text);

                            if(curso.agregarCurso(curso.Id_Detalle_Grado, curso.Id_Materia, curso.Id_Profesor) == true)
                            {
                                MessageBox.Show("El curso ha sido registrado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ActualizarDataGridCurso();
                                ActualizarDataGrid();
                                lblDetalle.Text = "";
                                lblIdMateria.Text = "";
                                lblIdProfesor.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar curso", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        catch(Exception Ex)
                        {
                            MessageBox.Show("Error al agregar curso " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe de seleccionar profesor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar un grupo", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una materia", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            try
            {
                Materia objMateria = new Materia();
                objMateria.llenarComboMaterias(cmbMaterias);

                Profesor objProfesor = new Profesor();
                objProfesor.llenarComboMaestros(cmbProfesor);

                ActualizarDataGrid();

                lblDetalle.Text = "";
                lblIdMateria.Text = "";
                lblIdProfesor.Text = "";
                lblIdCurso.Text = "";
                ActualizarDataGridCurso();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error cargar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
            
        }

        private void ActualizarDataGrid()
        {
            Curso curso = new Curso();
            dgvDetalleGrado.DataSource = null;
            dgvDetalleGrado.DataSource = curso.Mostrar();
            dgvDetalleGrado.ClearSelection();
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            string nombreM = cmbMaterias.SelectedItem.ToString();
            curso.obtenerCodigoMateria(lblIdMateria, nombreM);
        }

        private void cmbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string cadena = cmbProfesor.SelectedItem.ToString();
            char delimitador = ' ';
            string[] trozos = cadena.Split(delimitador);
            
            Curso curso = new Curso();
            curso.obtenerCodigoProfesor(lblIdProfesor, trozos[0], trozos[1]);
        }

        private void dgvDetalleGrado_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDetalleGrado.SelectedRows.Count > 0)
            {
                lblDetalle.Text = dgvDetalleGrado.CurrentRow.Cells["Codigo"].Value.ToString();
                                
                dgvDetalleGrado.CurrentCell.Selected = false;
                dgvDetalleGrado.ClearSelection();
            }
            else
            {
              //  MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDetalleGrado_SelectionChanged(object sender, EventArgs e)
        {
            /*if (dgvDetalleGrado.SelectedRows.Count > 0)
            {
                try
                {                                       
                    lblDetalle.Text = dgvDetalleGrado.CurrentRow.Cells["Codigo"].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }*/
        }

        private void ActualizarDataGridCurso()
        {
            Curso curso = new Curso();
            dgvCurso.DataSource = null;
            dgvCurso.DataSource = curso.MostrarCursos();
            dgvCurso.ClearSelection();
        }

        private void dgvCurso_DoubleClick(object sender, EventArgs e)
        {
            /*if (dgvCurso.SelectedRows.Count > 0)
            {                
                lblIdCurso.Text = dgvCurso.CurrentRow.Cells["Codigo_Curso"].Value.ToString();
                cmbProfesor.Text = dgvCurso.CurrentRow.Cells["Profesor"].Value.ToString();
                cmbMaterias.Text = dgvCurso.CurrentRow.Cells["Materia"].Value.ToString();
                dgvCurso.CurrentCell.Selected = false;
                dgvCurso.ClearSelection();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }*/
        }

        private void dgvCurso_SelectionChanged(object sender, EventArgs e)
        {
            /*if (dgvCurso.SelectedRows.Count > 0)
            {
                try
                {                   
                    //lblIdCurso.Text = dgvCurso.CurrentRow.Cells["Codigo_Curso"].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }*
            }*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblIdCurso.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el curso con código " + lblIdCurso.Text + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Curso curso = new Curso();

                    if (curso.EliminarCurso(int.Parse(lblIdCurso.Text)) == true)
                    {
                        MessageBox.Show("El curso ha sido eliminado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lblIdCurso.Text = "";
                        ActualizarDataGridCurso();                                              
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el grado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblIdCurso.Text = "";
                    }
                }
                else if (resultado == DialogResult.No)
                {                    
                    dgvCurso.ClearSelection();                  
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lblIdMateria.Text == "" || lblIdProfesor.Text == "" || lblIdCurso.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Curso curso = new Curso();

                    if (curso.ModificarCurso(int.Parse(lblIdMateria.Text), int.Parse(lblIdProfesor.Text), int.Parse(lblIdCurso.Text)) == true)
                    {
                        MessageBox.Show("El curso ha sido modificado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarDataGridCurso();
                        /* cmbMaterias.SelectedIndex = -1;
                        cmbProfesor.SelectedIndex = -1;
                        
                         lblIdCurso.Text = "";
                         lblIdMateria.Text = "";
                         lblIdCurso.Text = "";
                         lblIdProfesor.Text = "";*/

                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el curso", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al modificar el curso " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (dgvCurso.SelectedRows.Count > 0)
            {
                lblIdCurso.Text = dgvCurso.CurrentRow.Cells["Codigo_Curso"].Value.ToString();
                cmbProfesor.Text = dgvCurso.CurrentRow.Cells["Profesor"].Value.ToString();
                cmbMaterias.Text = dgvCurso.CurrentRow.Cells["Materia"].Value.ToString();
                dgvCurso.CurrentCell.Selected = false;
                dgvCurso.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void dgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurso.SelectedRows.Count > 0)
            {
                lblIdCurso.Text = dgvCurso.CurrentRow.Cells["Codigo_Curso"].Value.ToString();
                cmbProfesor.Text = dgvCurso.CurrentRow.Cells["Profesor"].Value.ToString();
                cmbMaterias.Text = dgvCurso.CurrentRow.Cells["Materia"].Value.ToString();
                dgvCurso.CurrentCell.Selected = false;
                dgvCurso.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDetalleGrado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurso.SelectedRows.Count > 0)
            {
                lblIdCurso.Text = dgvCurso.CurrentRow.Cells["Codigo_Curso"].Value.ToString();
                cmbProfesor.Text = dgvCurso.CurrentRow.Cells["Profesor"].Value.ToString();
                cmbMaterias.Text = dgvCurso.CurrentRow.Cells["Materia"].Value.ToString();
                dgvCurso.CurrentCell.Selected = false;
                dgvCurso.ClearSelection();
            }
            else
            {
               // MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDetalleGrado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgvCurso.SelectedRows.Count > 0)
            {
                lblIdCurso.Text = dgvCurso.CurrentRow.Cells["Codigo_Curso"].Value.ToString();
                cmbProfesor.Text = dgvCurso.CurrentRow.Cells["Profesor"].Value.ToString();
                cmbMaterias.Text = dgvCurso.CurrentRow.Cells["Materia"].Value.ToString();
                dgvCurso.CurrentCell.Selected = false;
                dgvCurso.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void dgvDetalleGrado_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

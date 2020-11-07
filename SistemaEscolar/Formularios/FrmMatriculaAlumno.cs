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
    public partial class FrmMatriculaAlumno : Form
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

        public FrmMatriculaAlumno()
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

          /*  if (cmbGrado.SelectedIndex==-1)
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

            int anio = DateTime.Now.Year;
            if(anio>dtpAnio.Value.Year)
            {
                errorProvider1.SetError(dtpAnio, "Debe elegir un ano no mayor al actual");
            }*/
            

            return validado;
        }

        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
          /*  errorProvider1.SetError(cmbGrado, "");
            errorProvider1.SetError(cmbProfesor, "");
            errorProvider1.SetError(cmbSeccion, "");*/
        }
       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbGrupos.SelectedIndex > -1)
            {
                if(lblIdDetalle.Text != "")
                {
                    if(lblIAlumno.Text != "")
                    {
                        try
                        {
                            Matricula matricula = new Matricula();
                            if(matricula.Matricular(int.Parse(lblIdDetalle.Text), int.Parse(lblIAlumno.Text)) == true)
                            {
                                if(matricula.actualizarEstadoMatricula(int.Parse(lblIAlumno.Text)) == true)
                                {
                                    MessageBox.Show("Alumno matriculado con éxito");
                                    lblApellidoA.Text = "";
                                    lblNombreA.Text = "";
                                    ActualizarDataGrid();
                                }
                                else
                                {
                                    MessageBox.Show("ERROR AL MATRICULAR");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("ERROR AL MATRICULAR");
                            }
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un alumno");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un grupo");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grupo");
            }
        }

        
        private void FrmMatriculaAlumno_Load(object sender, EventArgs e)
        {
            //BorrarMensaje();
            try
            {
                /* ActualizarDataGrid();
                 btnModificar.Enabled = false;
                 btnEliminar.Enabled = false;*/
                DateTime fecha = DateTime.Now.Date;
                int anio = fecha.Year;               
                ActualizarDataGrid();
                Matricula matricula = new Matricula();
                matricula.llenarComboGrupos(cmbGrupos, anio);
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message);
            }
        }

        private void ActualizarDataGrid()
        {
            Matricula objMatricula = new Matricula();            
            dgvMatriculaAlumnos.DataSource = null;
            dgvMatriculaAlumnos.DataSource = objMatricula.mostrarAlumnosSinMatricular();
            dgvMatriculaAlumnos.ClearSelection();
        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Matricula objMatricula = new Matricula();
            string cadena = cmbGrupos.SelectedItem.ToString();
            char delimitador = ' ';
            string[] trozos = cadena.Split(delimitador);
            objMatricula.obtenerIdGrupo(lblIdDetalle, trozos[0], trozos[1]);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvMatriculaAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvMatriculaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombreA.Text = dgvMatriculaAlumnos.CurrentRow.Cells["Nombres"].Value.ToString();
            lblApellidoA.Text = dgvMatriculaAlumnos.CurrentRow.Cells["Apellidos"].Value.ToString();
            lblIAlumno.Text = dgvMatriculaAlumnos.CurrentRow.Cells["Num"].Value.ToString();
        }
    }
}

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
    public partial class FrmVisualizarCursos : Form

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

        public FrmVisualizarCursos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuProfesor frmMP = new MenuProfesor();
            frmMP.Show();
            this.Hide();
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmVisualizarCursos_Load(object sender, EventArgs e)
        {
            string cadena = FrmLogin.nombreProfesor;
            lblidProfesor.Text = FrmLogin.idProfesor.ToString();


            Curso curso = new Curso();
            curso.obtenerCodigoProfesor(lblidProfesor,cadena);

            lblidProfesor.Visible = false;
        }
        private void ActualizarDataGrid(int idProfesor, string anio)
        {
            //int anio = dateTimePicker1.Value.Year;
            Curso curso = new Curso();
            dgvCursos.DataSource = null;
            dgvCursos.DataSource = curso.mostrarCursos_Profesor(int.Parse(lblidProfesor.Text), anio);
            dgvCursos.ClearSelection();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                Grado grado = new Grado();

                dgvCursos.DataSource = null;
                dgvCursos.DataSource = grado.Buscar_curso(txtBuscar.Text, int.Parse(lblidProfesor.Text) );
                dgvCursos.ClearSelection();
                txtBuscar.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string anio = Convert.ToString(dateTimePicker1.Value.Year);

                string idProfesor = lblidProfesor.Text;
                if (lblidProfesor.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Curso curso = new Curso();
                    // grupo.Id_Detale = int.Parse(lblidDetalle.Text);
                    //curso.mostrarCursos_Profesor(int.Parse(lblidProfesor.Text), anio);
                    ActualizarDataGrid(int.Parse(lblidProfesor.Text), anio);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex.Message);
            }
            
        }
    }
}

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
            char delimitador = ' ';
            string[] trozos = cadena.Split(delimitador);

            Curso curso = new Curso();
            curso.obtenerCodigoProfesor(lblidProfesor,trozos[0] , trozos[1] );

            lblidProfesor.Visible = false;

        }
        private void ActualizarDataGrid()
        {
            Curso curso = new Curso();
            dgvCursos.DataSource = null;
            dgvCursos.DataSource = curso.mostrarCursos_Profesor(int.Parse(lblidProfesor.Text));
            dgvCursos.ClearSelection();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string idProfesor = lblidProfesor.Text;
            if (lblidProfesor.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todos los campos");

            }
            else
            {

                Curso curso = new Curso();
                // grupo.Id_Detale = int.Parse(lblidDetalle.Text);
                curso.mostrarCursos_Profesor(int.Parse(lblidProfesor.Text));
                ActualizarDataGrid();



            }
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
                dgvCursos.DataSource = grado.Buscar_curso(txtBuscar.Text, int.Parse(lblidProfesor.Text));
                dgvCursos.ClearSelection();
                txtBuscar.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}

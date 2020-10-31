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
    public partial class FrmVisualizarAlumnos : Form
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

        public FrmVisualizarAlumnos()
        {
            InitializeComponent();            
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            MenuProfesor frmMP = new MenuProfesor();
            frmMP.Show();
            this.Hide();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           

        }

        private void FrmVisualizarAlumnos_Load(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.llenarComboGrupos(cmbCurso, FrmLogin.idProfesor.ToString());
            //MessageBox.Show(FrmLogin.idProfesor.ToString());
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.llenarComboGrupos(cmbCurso, FrmLogin.idProfesor);
        }*/
    }
}

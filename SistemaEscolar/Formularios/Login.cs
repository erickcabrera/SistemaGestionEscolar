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
using SistemaEscolar.Formularios;

namespace SistemaEscolar
{

    public partial class FrmLogin : Form
    {   
        //VARIABLES GLOBALES
        internal static int idProfesor = 0;
        internal static String nombreProfesor = String.Empty;

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

        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            //texto
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar(object sender, EventArgs e)
        {
            try
            {
                Sesion sesion = new Sesion();
                if (sesion.Iniciar(txtUsuario.Text, txtContra.Text) == 1)
                {
                    idProfesor = sesion.ExtraerID(txtUsuario.Text, txtContra.Text);
                    nombreProfesor = sesion.ExtraerNombre(txtUsuario.Text, txtContra.Text);
                    FormMenuPrueba formMenuPrueba = new FormMenuPrueba();
                    formMenuPrueba.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ó contraseña incorrecta");
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error: " + Ex);
            }
            
        }
    }
}

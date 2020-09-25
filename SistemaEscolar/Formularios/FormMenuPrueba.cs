using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Formularios;

namespace SistemaEscolar.Formularios
{
    public partial class FormMenuPrueba : Form
    {
        public FormMenuPrueba()
        {
            InitializeComponent();
        }

        private void FormMenuPrueba_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido " + FrmLogin.nombreProfesor.ToString() + " con codigo "+ FrmLogin.idProfesor.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
